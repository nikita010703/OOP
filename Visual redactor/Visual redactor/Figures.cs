using Container;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Save_and_Load;
using Factory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;

namespace Figures {
    public abstract class Figure : ISaveable {
        internal bool isSelected;
        public bool IsSelected { get { return isSelected; } }

        public abstract bool Move(int x, int y, int rightBorder, int bottomBorder);
        public abstract bool isLiesOn(int _x, int _y);
        public abstract void Select();
        public abstract void Unselect();
        public abstract bool ChangeSize(int dSize, int rightBorder, int bottomBorder);
        public abstract void ChangeColor(Color color);
        public abstract void Paint(Graphics g);

        public abstract void Save(StreamWriter file);
        public abstract void Load(StreamReader file);
    }

    public abstract class SingleFigure : Figure {
        internal int x, y;
        internal int size;
        internal Color color;

        public bool CorrectPosition(int rightBorder, int bottomBorder) {
            bool isUncorrect = false;
            isUncorrect = x + size > rightBorder ? true
                : x - size < 0 ? true : isUncorrect;
            isUncorrect = y + size > bottomBorder ? true
                : y - size < 0 ? true : isUncorrect;

            x = x + size > rightBorder ? rightBorder - size
                : x - size < 0 ? size : x;

            y = y + size > bottomBorder ? bottomBorder - size
                : y - size < 0 ? size : y;

            return isUncorrect;
        }

        public override bool Move(int _x, int _y, int rightBorder, int bottomBorder) {
            x += _x; y += _y;

            if (CorrectPosition(rightBorder, bottomBorder))
                return false;
            return true;
        }

        public override bool ChangeSize(int dSize, int rightBorder, int bottomBorder) {
            size += dSize;

            bool isTooLarge = false;
            isTooLarge = size < 5 ? true
                : size * 2 > rightBorder ? true
                : size * 2 > bottomBorder ? true : isTooLarge;

            bool isUncorrect = false;
            isUncorrect = x + size > rightBorder ? true
                : x - size < 0 ? true : isUncorrect;
            isUncorrect = y + size > bottomBorder ? true
                : y - size < 0 ? true : isUncorrect;

            if (isTooLarge || isUncorrect) {
                ChangeSize(-dSize, rightBorder, bottomBorder);
                return false;
            }
            return true;
        }

        public override void Select() {
            isSelected = true;
        }

        public override void Unselect() {
            isSelected = false;
        }

        public override void ChangeColor(Color _color) {
            color = _color;
        }

        public override void Save(StreamWriter file) {
            file.WriteLine(x.ToString() + " " + y.ToString() + " " + size.ToString() + " " + isSelected.ToString() + " "
                + color.R.ToString() + " " + color.G.ToString() + " " + color.B.ToString());
        }

        public override void Load(StreamReader file) {
            string[] args = file.ReadLine().Split(' ');
            x = Int32.Parse(args[0]);
            y = Int32.Parse(args[1]);
            size = Int32.Parse(args[2]);
            isSelected = Convert.ToBoolean(args[3]);
            int red = Int32.Parse(args[4]);
            int green = Int32.Parse(args[5]);
            int blue = Int32.Parse(args[6]);
            color = Color.FromArgb(255, red, green, blue);
        }
    }

    public class CCircle : SingleFigure {
        public CCircle() {
            x = y = 0;
            size = 25;
            isSelected = false;
        }
        public CCircle(int _x, int _y, int _size, bool select, Color _color) {
            x = _x;
            y = _y;
            size = _size;
            isSelected = select;
            color = _color;
        }
        public CCircle(CCircle existingCircle) {
            x = existingCircle.x;
            y = existingCircle.y;
            size = existingCircle.size;
            isSelected = existingCircle.isSelected;
        }

        public override bool isLiesOn(int _x, int _y) {
            return Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2) < Math.Pow(size, 2);
        }

        public override void Paint(Graphics g) {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x - size, y - size, 2 * size, 2 * size);

            Pen p = new Pen(color);
            p.Width = 3;
            if (isSelected) {
                p.Color = Color.RoyalBlue;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            g.DrawEllipse(p, x - size, y - size, 2 * size, 2 * size);
        }

        public override void Save(StreamWriter file) {
            file.WriteLine("Circle");
            base.Save(file);
        }
    }

    public class Square : SingleFigure {
        public Square() {
            x = y = 0;
            size = 25;
            isSelected = false;
        }
        public Square(int _x, int _y, int _size, bool select, Color _color) {
            x = _x;
            y = _y;
            size = _size;
            isSelected = select;
            color = _color;
        }
        public Square(Square existingSquare) {
            x = existingSquare.x;
            y = existingSquare.y;
            size = existingSquare.size;
            isSelected = existingSquare.isSelected;
        }

        public override bool isLiesOn(int _x, int _y) {
            return Math.Abs(x - _x) < size && Math.Abs(y - _y) < size;
        }

        public override void Paint(Graphics g) {
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, x - size, y - size, 2 * size, 2 * size);

            Pen p = new Pen(color);
            p.Width = 3;
            if (isSelected) {
                p.Color = Color.RoyalBlue;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            g.DrawRectangle(p, x - size, y - size, 2 * size, 2 * size);
        }

        public override void Save(StreamWriter file) {
            file.WriteLine("Square");
            base.Save(file);
        }
    }

    public class Triangle : SingleFigure {
        Point[] points = new Point[3];

        public Triangle() {
            x = y = 25;
            size = 25;
            calculatePoints();

            isSelected = false;
        }
        public Triangle(int _x, int _y, int _size ,bool select, Color _color) {
            x = _x;
            y = _y;
            size = _size;
            calculatePoints();

            isSelected = select;
            color = _color;
        }
        /*
        public Triangle(Triangle existingTriangle) {
            x = existingTriangle.x;
            y = existingTriangle.y;
            points[0] = new Point(existingTriangle.points[0]);
            size = existingTriangle.size;
            isSelected = existingTriangle.isSelected;
        }
        */
        private void calculatePoints() {
            points[0].X = x;
            points[0].Y = y - size;
            points[1].X = x + size;
            points[1].Y = y + size;
            points[2].X = x - size;
            points[2].Y = y + size;
        }

        public override bool Move(int _x, int _y, int rightBorder, int bottomBorder) {
            bool result = base.Move(_x, _y, rightBorder, bottomBorder);
            calculatePoints();
            return result;
        }

        public override bool ChangeSize(int dSize, int rightBorder, int bottomBorder) {
            bool result = base.ChangeSize(dSize, rightBorder, bottomBorder);
            calculatePoints();
            return result;
        }

        public override bool isLiesOn(int _x, int _y) {
            int a = (points[0].X - _x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - _y);
            int b = (points[1].X - _x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - _y);
            int c = (points[2].X - _x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - _y);
            return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
        }

        public override void Paint(Graphics g) {
            SolidBrush brush = new SolidBrush(color);
            g.FillPolygon(brush, points);

            Pen p = new Pen(color);
            p.Width = 3;
            if (isSelected) {
                p.Color = Color.RoyalBlue;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            g.DrawPolygon(p, points);
        }

        public override void Save(StreamWriter file) {
            file.WriteLine("Triangle");
            base.Save(file);
        }
        public override void Load(StreamReader file) {
            base.Load(file);
            calculatePoints();
        }
    }

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
    }

    public class FigureFactory<T> : Factory<T> where T : Figure {
        public override T CreateObject(string name) {
            Figure newFig;
            switch (name) {
                case "Circle":
                    newFig = new CCircle(); break;
                case "Square":
                    newFig = new Square(); break;
                case "Triangle":
                    newFig = new Triangle(); break;
                case "GroupFigure":
                    newFig = new GroupFigure(); break;
                default:
                    newFig = null; break;
            }
            return newFig as T;
        }

        public override string CreatedObjectsType() {
            return "Figures";
        }
    }
}
