using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Container;
using Figures;
using Save_and_Load;

namespace Visual_redactor.Figures {
    public class FigureContainer<T> : Container<T> where T : Figure {
        List<TreeViewHandler> handlers;
        public FigureContainer() : base() {
            handlers = new List<TreeViewHandler>();
        }

        public void AddObserver(TreeViewHandler handler) {
            handlers.Add(handler);
        }

        public void RemoveObserver(TreeViewHandler handler) {
            handlers.Remove(handler);
        }

        public void Notify() {
            foreach (TreeViewHandler handler in handlers)
                handler.onObservableChange(this as FigureContainer<Figure>);
        }

        public void onTreeViewChange(TreeViewHandler tree) {
            Iterator<Figure> it = this.createIterator() as Iterator<Figure>;
            int j = 0;
            for (it.first(); !it.isEOL(); it.next(), j++) {
                if (tree.tree.Nodes[j].Checked || isAnyChildChecked(tree.tree.Nodes[j]))
                    it.getCurrentObject().Select();
                else
                    it.getCurrentObject().Unselect();
            }
            Notify();
        }

        private bool isAnyChildChecked(TreeNode tr) {
            if (tr.Checked)
                return true;

            foreach (TreeNode child in tr.Nodes)
                if (isAnyChildChecked(child))
                    return true;

            return false;
        }

        public override void pushBack(T data) {
            base.pushBack(data);
            Notify();
        }

        public override void pushFront(T data) {
            base.pushFront(data);
            Notify();
        }

        public override void insertAfter(T value, int index) {
            base.insertAfter(value, index);
            Notify();
        }

        public override T popBack() {
            T tmp = base.popBack();
            Notify();
            return tmp;
        }

        public override T popFront() {
            T tmp = base.popFront();
            Notify();
            return tmp;
        }

        public override void removeAt(int index) {
            base.removeAt(index);
            Notify();
        }

        public override void Clear() {
            base.Clear();
            Notify();
        }
    }
}
