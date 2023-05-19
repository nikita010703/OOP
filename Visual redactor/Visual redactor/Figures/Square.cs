using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
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

            base.Paint(g);
        }

        public override void Save(StreamWriter file) {
            file.WriteLine("Square");
            base.Save(file);
        }
    }
}