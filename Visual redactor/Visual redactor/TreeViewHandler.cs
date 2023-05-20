using Container;
using Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_redactor.Figures;

namespace Visual_redactor {
    public class TreeViewHandler {
        internal TreeView tree;
        internal List<FigureContainer<Figure>> observers;

        public TreeViewHandler(TreeView tree) {
            this.tree = tree;
            observers = new List<FigureContainer<Figure>>();
        }

        public void AddObserver(FigureContainer<Figure> observer) {
            observers.Add(observer);
        }

        public void RemoveObserver(FigureContainer<Figure> observer) {
            observers.Remove(observer);
        }

        public void Notify() {
            foreach (FigureContainer<Figure> handler in observers)
                handler.onTreeViewChange(this);
        }

        public void onObservableChange(FigureContainer<Figure> container) {
            tree.Nodes.Clear();

            Iterator<Figure> it = container.createIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                TreeNode newNode = CreateNewNode(it.getCurrentObject());
                tree.Nodes.Add(newNode);
            }

            tree.ExpandAll();
        }

        private void ProcessNode(TreeNode tr, Figure figure) {
            if (figure as GroupFigure == null)
                return;

            Container<Figure> tmp = (figure as GroupFigure).getFigures();
            Iterator<Figure> it = tmp.createIterator();
            for (it.first(); !it.isEOL(); it.next()) {
                TreeNode newNode = CreateNewNode(it.getCurrentObject());
                tr.Nodes.Add(newNode);
            }
        }

        public TreeNode CreateNewNode(Figure fig) {
            TreeNode newNode = new TreeNode();
            switch (fig.GetType().Name) {
                case "Circle":
                    newNode.Text = "Круг";
                    newNode.ImageIndex = 0;
                    newNode.SelectedImageIndex = 0; break;
                case "Square":
                    newNode.Text = "Квадрат";
                    newNode.ImageIndex = 1;
                    newNode.SelectedImageIndex = 1; break;
                case "Triangle":
                    newNode.Text = "Треугольник";
                    newNode.ImageIndex = 2;
                    newNode.SelectedImageIndex = 2; break;
                case "GroupFigure":
                    newNode.Text = "Группа";
                    newNode.ImageIndex = 3;
                    newNode.SelectedImageIndex = 3; break;
                default: break;
            }
            ProcessNode(newNode, fig);

            if (fig.IsSelected) {
                newNode.Checked = true;
                newNode.BackColor = Color.SkyBlue;
            }
            return newNode;
        }

        public void Reset() {
            foreach (TreeNode node in tree.Nodes)
                ResetNodes(node);
        }

        private void ResetNodes(TreeNode node) {
            foreach (TreeNode child in node.Nodes)
                ResetNodes(child);

            node.Checked = false;
        }
    }
}
