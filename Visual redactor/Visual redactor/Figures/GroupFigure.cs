using Container;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    public class GroupFigure : Figure {
        private Container<Figure> figures;
        private Iterator<Figure> iter;

        public GroupFigure() {
            figures = new Container<Figure>();
            iter = figures.createIterator();
        }

        public GroupFigure(Container<Figure> container) {
            figures = container;
            iter = figures.createIterator();
            isSelected = true;
        }

        public Container<Figure> getFigures() {
            return figures;
        }

        public override bool Move(int x, int y, int rightBorder, int bottomBorder) {
            bool success = true;
            int numOfCorrect = 0;
            for (iter.first(); !iter.isEOL(); iter.next())
                if (!iter.getCurrentObject().Move(x, y, rightBorder, bottomBorder)) {
                    success = false;
                    numOfCorrect = iter.getPosition();
                    break;
                }

            iter.first();
            if (!success)
                while (numOfCorrect > 0) {
                    iter.getCurrentObject().Move(-x, -y, rightBorder, bottomBorder);
                    iter.next();
                    --numOfCorrect;
                }
            return success;
        }

        public override bool isLiesOn(int _x, int _y) {
            for (iter.first(); !iter.isEOL(); iter.next())
                if (iter.getCurrentObject().isLiesOn(_x, _y))
                    return true;
            return false;
        }

        public override void Select() {
            isSelected = true;
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().Select();
        }

        public override void Unselect() {
            isSelected = false;
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().Unselect();
        }

        public override bool ChangeSize(int dSize, int rightBorder, int bottomBorder) {
            bool success = true;
            int numOfCorrect = 0;
            for (iter.first(); !iter.isEOL(); iter.next())
                if (!iter.getCurrentObject().ChangeSize(dSize, rightBorder, bottomBorder)) {
                    success = false;
                    numOfCorrect = iter.getPosition();
                    break;
                }

            iter.first();
            if (!success)
                while (numOfCorrect > 0) {
                    iter.getCurrentObject().ChangeSize(-dSize, rightBorder, bottomBorder);
                    iter.next();
                    --numOfCorrect;
                }
            return success;
        }

        public override void ChangeColor(Color color) {
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().ChangeColor(color);
        }

        public override void Paint(Graphics g) {
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().Paint(g);

            base.Paint(g);
        }

        public override void Save(StreamWriter file) {
            file.WriteLine("GroupFigure");
            file.WriteLine(isSelected.ToString());
            file.WriteLine(figures.Count.ToString());
            for (iter.first(); !iter.isEOL(); iter.next())
                iter.getCurrentObject().Save(file);
        }

        public override void Load(StreamReader file) {
            isSelected = Convert.ToBoolean(file.ReadLine());
            int numOfFigures = Int32.Parse(file.ReadLine());
            FigureFactory<Figure> factory = new FigureFactory<Figure>();
            for (int i = 0; i < numOfFigures; ++i) {
                Figure fig = factory.CreateObject(file.ReadLine());
                fig.Load(file);
                figures.pushBack(fig);
            }
        }

        public override Point GetCenter() {
            int x = 0, y = 0;

            for (iter.first(); !iter.isEOL(); iter.next()) {
                x += iter.getCurrentObject().GetCenter().X;
                y += iter.getCurrentObject().GetCenter().Y;
            }

            x /= figures.Count; y /= figures.Count;
            return new Point(x, y);
        }
    }
}