using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Container;
using Factory;
using Figures;
using Visual_redactor.Figures;

namespace Visual_redactor {
    public partial class Form1 : Form {
        int figureSize = 25;
        bool isPressedCtrl = false;
        bool isArrowCreatingMode = false;
        int selectedFigures = 1;
        FigureContainer<Figure> figures;
        TreeViewHandler treeViewHandler;
        HashSet<Keys> existingCommands;

        public Form1() {
            InitializeComponent();
            figures = new FigureContainer<Figure>();
            treeViewHandler = new TreeViewHandler(treeView);
            existingCommands = new HashSet<Keys>();

            figures.AddObserver(treeViewHandler);
            treeViewHandler.AddObserver(figures);

            treeView.ImageList = figureImages;

            cbChooseFigure.SelectedIndex = 0;
            cdChooseColor= new ColorDialog();
            cdChooseColor.Color = Color.SkyBlue;

            existingCommands.Add(Keys.Delete);
            existingCommands.Add(Keys.W);
            existingCommands.Add(Keys.A);
            existingCommands.Add(Keys.S);
            existingCommands.Add(Keys.D);
            existingCommands.Add(Keys.Oemplus);
            existingCommands.Add(Keys.Add);
            existingCommands.Add(Keys.OemMinus);
            existingCommands.Add(Keys.Subtract);
        }

        private void FormCircles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = true;
        }

        private void FormCircles_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = false;
        }

        private void Processingfigures(MouseEventArgs e) {
            bool isOnCircle = false;

            if (isPressedCtrl) {
                Iterator<Figure> it = figures.createReverseIterator();
                for (it.first(); !it.isEOL(); it.next()) {
                    Figure circle = it.getCurrentObject();
                    if (circle.isLiesOn(e.X, e.Y)) {
                        isOnCircle = true;
                        if (circle.IsSelected && selectedFigures > 1) {
                            circle.Unselect();
                            selectedFigures--;
                        }
                        else if (!circle.IsSelected) {
                            circle.Select();
                            selectedFigures++;
                        }
                        break;
                    }
                }
            }
            else {
                selectedFigures = 0;
                Iterator<Figure> it = figures.createReverseIterator();
                for (it.first(); !it.isEOL(); it.next()) {
                    Figure circle = it.getCurrentObject();
                    if (circle.isLiesOn(e.X, e.Y) && !isOnCircle) {
                        isOnCircle = true;
                        circle.Select();
                        selectedFigures++;
                    }
                    else
                        circle.Unselect();
                }
            }

            if (!isOnCircle) {
                Figure newFigure;
                switch(cbChooseFigure.SelectedIndex) {
                    case 0: newFigure = new Circle(e.X, e.Y, figureSize, true, cdChooseColor.Color); break;
                    case 1: newFigure = new Square(e.X, e.Y, figureSize, true, cdChooseColor.Color); break;
                    default: newFigure = new Triangle(e.X, e.Y, figureSize, true, cdChooseColor.Color); break;
                };
                newFigure.Move(0, 0, pnlPaint.Width, pnlPaint.Height);
                figures.pushBack(newFigure);

                if (isPressedCtrl) selectedFigures++;
                else selectedFigures = 1;
            }
        }

        private void pnlPaint_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next())
                it.getCurrentObject().Paint(g);
        }

        Figure selectedFigure;
        private void pnlPaint_MouseDown(object sender, MouseEventArgs e) {
            if (!isArrowCreatingMode) {
                Processingfigures(e);
                figures.Notify();
            }

            if (isArrowCreatingMode) {
                Iterator<Figure> it = figures.createReverseIterator();
                for (it.first(); !it.isEOL(); it.next())
                    if (it.getCurrentObject().isLiesOn(e.X, e.Y)) {
                        selectedFigure = it.getCurrentObject();
                        break;
                    }
            }
            pnlPaint.Focus();
            pnlPaint.Refresh();
        }

        private void pnlPaint_MouseUp(object sender, MouseEventArgs e) {
            if (!isArrowCreatingMode)
                return;

            Iterator<Figure> it = figures.createReverseIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                Figure fig = it.getCurrentObject();
                if (fig.isLiesOn(e.X, e.Y)) {
                    if (selectedFigure != fig) {
                        selectedFigure.observable.AddObserver(fig);
                        //fig.observable.AddObserver(selectedFigure);
                        fig.observers.AddObservable(selectedFigure);
                        //selectedFigure.observers.AddObservable(fig);
                    }

                }
            }
            pnlPaint.Refresh();

        }

        private void pnlPaint_Resize(object sender, EventArgs e) {
            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next())
                it.getCurrentObject().Move(0, 0, pnlPaint.Width, pnlPaint.Height);

            pnlPaint.Refresh();
        }

        private void pnlPaint_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (!existingCommands.Contains(e.KeyCode))
                return;

            int deletedIndex = 0;
            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                Figure fig = it.getCurrentObject();
                if (fig.IsSelected)
                    switch (e.KeyCode) {
                        case Keys.Delete:
                            deletedIndex = it.getPosition();
                            it.previous();
                            figures.removeAt(deletedIndex);

                            foreach (Figure obs in fig.observable.observers)
                                obs.observers.RemoveObservable(fig);
                            fig.observable.Clear();
                            break;

                        case Keys.Subtract:
                        case Keys.OemMinus:
                            fig.ChangeSize(-5, pnlPaint.Width, pnlPaint.Height); break;
                        case Keys.Add:
                        case Keys.Oemplus:
                            fig.ChangeSize(5, pnlPaint.Width, pnlPaint.Height); break;

                        case Keys.A:
                            fig.Move(-5, 0, pnlPaint.Width, pnlPaint.Height); break;
                        case Keys.D:
                            fig.Move(5, 0, pnlPaint.Width, pnlPaint.Height); break;
                        case Keys.W:
                            fig.Move(0, -5, pnlPaint.Width, pnlPaint.Height); break;
                        case Keys.S:
                            fig.Move(0, 5, pnlPaint.Width, pnlPaint.Height); break;
                    }
            }

            if (isPressedCtrl && e.KeyCode == Keys.A) {
                Iterator<Figure> i = figures.createIterator();
                for (i.first(); !i.isEOL(); i.next())
                    i.getCurrentObject().Select();
            }

            if (e.KeyCode == Keys.Delete) {
                if (figures.Count > 0) {
                    figures.getValueAt(deletedIndex).Select();
                    //it.getCurrentObject().Select();
                    selectedFigures = 1;
                }
                else
                    selectedFigures = 0;

                figures.Notify();
            }

            pnlPaint.Refresh();
        }

        private void newFirureSize_ValueChanged(object sender, EventArgs e) {
            figureSize = (int)newFirureSize.Value;
        }

        private void btnChooseColor_Click(object sender, EventArgs e) {
            if (cdChooseColor.ShowDialog() == DialogResult.OK)
                btnChooseColor.BackColor = cdChooseColor.Color;

            pnlPaint.Focus();
        }

        private void btnSetColor_Click(object sender, EventArgs e) {
            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                Figure fig = it.getCurrentObject();
                if (fig.IsSelected)
                    fig.ChangeColor(cdChooseColor.Color);
            }

            pnlPaint.Focus();
            pnlPaint.Refresh();
        }

        private void btnSetGroup_Click(object sender, EventArgs e) {
            Container<Figure> container = new Container<Figure>();
            Iterator<Figure> it = figures.createIterator();

            for (it.first(); !it.isEOL(); it.next())
                if (it.getCurrentObject().IsSelected)
                    container.pushBack(it.getCurrentObject());

            if (container.Count == 1)
                return;

            for (it.first(); !it.isEOL(); it.next())
                if (it.getCurrentObject().IsSelected) {
                    int tmp = it.getPosition();
                    it.previous();
                    figures.removeAt(tmp);
                }

            figures.pushBack(new GroupFigure(container));
            pnlPaint.Focus();
            pnlPaint.Refresh();
        }

        private void btnDecompose_Click(object sender, EventArgs e) {
            Iterator<Figure> i = figures.createIterator();
            Container<Figure> container = new Container<Figure>();

            for (i.first(); !i.isEOL(); i.next()) {
                GroupFigure fig = i.getCurrentObject() as GroupFigure;
                if (fig != null && fig.IsSelected) {
                    int tmp = i.getPosition();
                    i.previous();
                    figures.removeAt(tmp);

                    Container<Figure> figs = fig.getFigures();
                    Iterator<Figure> j = figs.createIterator();
                    for (j.first(); !j.isEOL(); j.next())
                        container.pushBack(j.getCurrentObject());
                }
            }

            Iterator<Figure> k = container.createIterator();
            for (k.first(); !k.isEOL(); k.next())
                figures.pushBack(k.getCurrentObject());
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            figures.SaveElements(filename);

            pnlPaint.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;

            Factory<Figure> factory = new FigureFactory<Figure>();
            if (!figures.LoadElements(filename, factory)) {
                MessageBox.Show("Некорректный файл сохранения.");
                return;
            }

            pnlPaint.Focus();
            pnlPaint.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pnlPaint.Focus();
        }

        private void btnCreateArrow_Click(object sender, EventArgs e) {
            isArrowCreatingMode = !isArrowCreatingMode;
            btnCreateArrow.BackColor = isArrowCreatingMode ? SystemColors.MenuHighlight : SystemColors.ControlLight;

            pnlPaint.Focus();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (!isPressedCtrl)
                treeViewHandler.Reset();
            e.Node.Checked = !e.Node.Checked;

            treeViewHandler.Notify();
            pnlPaint.Refresh();
        }

        private void treeView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            pnlPaint_PreviewKeyDown(sender, e);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            e.Node.TreeView.SelectedNode = null;
        }
    }
}
