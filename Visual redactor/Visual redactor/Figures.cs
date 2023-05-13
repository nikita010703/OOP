﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures {
    public abstract class Figure {
        internal bool isSelected;
        public bool IsSelected { get { return isSelected; } }
        public abstract void Move(int x, int y);
        public abstract bool isLiesOn(int _x, int _y);
        public void Select() {
            isSelected = true;
        }
        public void Unselect() {
            isSelected = false;
        }
        public abstract void ChangeSize(int dSize);
        public abstract void ChangeColor(Color color);
        public abstract void Paint(Graphics g);
    }

    public class CCircle : Figure {
        private int x, y;
        private int rad;
        Color color = Color.SkyBlue;

        public CCircle() {
            x = y = 0;
            rad = 25;
            isSelected = false;
        }
        public CCircle(int _x, int _y, int _rad, Color _color) {
            x = _x;
            y = _y;
            rad = _rad;
            isSelected = false;
            color = _color;
        }
        public CCircle(CCircle existingCircle) {
            x = existingCircle.x;
            y = existingCircle.y;
            rad = existingCircle.rad;
            isSelected = existingCircle.isSelected;
        }

        public override void Move(int _x, int _y) {
            x += _x; y += _y;
        }

        public override bool isLiesOn(int _x, int _y)  {
            return Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2) < Math.Pow(rad, 2);
        }

        public override void ChangeSize(int dSize) {
            rad += dSize;
            if (rad < 5)
                rad = 5;
        }

        public override void ChangeColor(Color _color) {
            color = _color;
        }

        public override void Paint(Graphics g) {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x - rad, y - rad, 2 * rad, 2 * rad);

            Pen p = new Pen(color);
            p.Width = 3;
            if (isSelected) {
                p.Color = Color.RoyalBlue;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            g.DrawEllipse(p, x - rad, y - rad, 2 * rad, 2 * rad);
        }
    }

    public class Square : Figure {
        int x, y;
        int size;
        Color color;

        public Square() {
            x = y = 0;
            size = 25;
            isSelected = false;
        }
        public Square(int _x, int _y, int _rad, Color _color) {
            x = _x;
            y = _y;
            size = _rad;
            isSelected = false;
            color = _color;
        }
        public Square(Square existingSquare) {
            x = existingSquare.x;
            y = existingSquare.y;
            size = existingSquare.size;
            isSelected = existingSquare.isSelected;
        }

        public override void Move(int _x, int _y) {
            x += _x; y += _y;
        }

        public override bool isLiesOn(int _x, int _y) {
            return Math.Abs(x - _x) < size && Math.Abs(y - _y) < size;
        }

        public override void ChangeSize(int dSize) {
            size += dSize;
            if (size < 5)
                size = 5;
        }

        public override void ChangeColor(Color _color) {
            color = _color;
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
    }

    public class Triangle : Figure {
        int x, y;
        int size;
        Color color;
        Point[] points = new Point[3];

        public Triangle() {
            x = y = 25;
            size = 25;
            calculatePoints();

            isSelected = false;
        }
        public Triangle(int _x, int _y, int _size, Color _color) {
            x = _x;
            y = _y;
            size = (int)(1.25f * _size);
            calculatePoints();

            isSelected = false;
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
            int dX = (int)Math.Sqrt(0.75f * size * size);
            points[0].X = x;
            points[0].Y = y - size;
            points[1].X = x + dX;
            points[1].Y = y + size / 2;
            points[2].X = x - dX;
            points[2].Y = y + size / 2;
        }

        public override void Move(int _x, int _y) {
            x += _x; y += _y;
            calculatePoints();
        }

        public override bool isLiesOn(int _x, int _y) {
            int a = (points[0].X - _x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - _y);
            int b = (points[1].X - _x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - _y);
            int c = (points[2].X - _x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - _y);
            return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
        }

        public override void ChangeSize(int dSize) {
            size = dSize;
            if (size < 5)
                size = 5;

            calculatePoints();
        }

        public override void ChangeColor(Color _color) {
            color = _color;
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
    }
}
