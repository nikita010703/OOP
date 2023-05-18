using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
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
}