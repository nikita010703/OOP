using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Container;
using Figures;

namespace Visual_redactor {
    public partial class Form1 : Form {
        int figureSize = 25;
        bool isPressedCtrl = false;
        int selectedFigures = 1;
        Container<Figure> figures = new Container<Figure>();

        public Form1() {
            InitializeComponent();

            cbChooseFigure.SelectedIndex = 0;
            cdChooseColor= new ColorDialog();
            cdChooseColor.Color = Color.SkyBlue;
        }

        private void pnlPaint_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next())
                it.getCurrentObject().Paint(g);
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
                    case 0: newFigure = new CCircle(e.X, e.Y, figureSize, cdChooseColor.Color); break;
                    case 1: newFigure = new Square(e.X, e.Y, figureSize, cdChooseColor.Color); break;
                    default: newFigure = new Triangle(e.X, e.Y, figureSize, cdChooseColor.Color); break;
                };
                newFigure.Select();
                figures.pushBack(newFigure);

                if (isPressedCtrl) selectedFigures++;
                else selectedFigures = 1;
            }
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e) {
            Processingfigures(e);

            pnlPaint.Focus();
            pnlPaint.Invalidate();
        }

        private void FormCircles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = true;
        }

        private void FormCircles_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = false;
        }

        private void newCircleRadius_ValueChanged(object sender, EventArgs e) {
            figureSize = (int)newCircleRadius.Value;
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
            pnlPaint.Invalidate();
        }

        private void pnlPaint_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            /*
            if (e.KeyCode == Keys.Delete) {
                Iterator<Figure> it = figures.createIterator();
                for (it.first(); !it.isEOL(); it.next())
                    if (it.getCurrentObject().IsSelected) {
                        int tmp = it.getPosition();
                        it.previous();
                        figures.removeAt(tmp);
                    }

                if (figures.Count > 0) {
                    it.last();
                    it.getCurrentObject().Select();
                    selectedFigures = 1;
                }
                else
                    selectedFigures = 0;

                pnlPaint.Invalidate();
            }

            if (e.KeyCode == Keys.Oemplus) {
                Iterator<Figure> it = figures.createIterator();
                for (it.first(); !it.isEOL(); it.next()) {
                    Figure fig = it.getCurrentObject();
                    if (fig.IsSelected)
                        fig.ChangeSize(5);
                }
                pnlPaint.Invalidate();
            }

            if (e.KeyCode == Keys.OemMinus) {
                Iterator<Figure> it = figures.createIterator();
                for (it.first(); !it.isEOL(); it.next()) {
                    Figure fig = it.getCurrentObject();
                    if (fig.IsSelected)
                        fig.ChangeSize(-5);
                }
                pnlPaint.Invalidate();
            }

            if (e.KeyCode == Keys.Left) {
                Iterator<Figure> it = figures.createIterator();
                for (it.first(); !it.isEOL(); it.next()) {
                    Figure fig = it.getCurrentObject();
                    if (fig.IsSelected)
                        fig.Move(-5, 0);
                }
                pnlPaint.Invalidate();
            }*/

            Iterator<Figure> it = figures.createIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                Figure fig = it.getCurrentObject();
                if (fig.IsSelected)
                    switch (e.KeyCode) {
                        case Keys.Delete: {
                                int tmp = it.getPosition();
                                it.previous();
                                figures.removeAt(tmp);
                            }
                            break;

                        case Keys.OemMinus:
                            fig.ChangeSize(-5); break;
                        case Keys.Oemplus:
                            fig.ChangeSize(5); break;

                        case Keys.Left:
                            fig.Move(-5, 0); break;
                        case Keys.Right:
                            fig.Move(5, 0); break;
                        case Keys.Up:
                            fig.Move(0, -5); break;
                        case Keys.Down:
                            fig.Move(0, 5); break;
                    }
            }
            pnlPaint.Invalidate();
            pnlPaint.BringToFront();
        }
    }
}
