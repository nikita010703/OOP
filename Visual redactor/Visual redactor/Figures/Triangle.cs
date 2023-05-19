using Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    public class Triangle : SingleFigure {
        Point[] points = new Point[3];

        public Triangle() {
            x = y = 25;
            size = 25;
            calculatePoints();

            isSelected = false;
        }
        public Triangle(int _x, int _y, int _size, bool select, Color _color) {
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

            base.Paint(g);
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
}