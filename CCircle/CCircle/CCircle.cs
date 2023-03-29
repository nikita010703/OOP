using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCircle {
    internal class CCircle {
        private int x, y;
        private int rad;
        private bool isSelected = false;
        
        public CCircle() {
            x = y = 0;
            rad = 25;
        }
        public CCircle(int _x, int _y, int _rad = 25) {
            x = _x;
            y = _y;
            rad = _rad;
        }
        public CCircle(CCircle existingCircle) {
            x = existingCircle.x;
            y = existingCircle.y;
            rad = existingCircle.rad;
        }

        public bool isLiesOn(float _x, float _y) {
            return Math.Sqrt(Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2)) < rad;
        }

        public void Select() {
            isSelected = true;
        }

        public void Unselect() {
            isSelected = false;
        }

        public bool isSelect() {
            return isSelected;
        }

        public void Paint(Graphics g) {
            g.FillEllipse(Brushes.SkyBlue, x - rad, y - rad, 2 * rad, 2 * rad);

            Pen p = new Pen(Color.SkyBlue);
            p.Width = 2;
            if (isSelected)
                p.Color = Color.DeepSkyBlue;
            g.DrawEllipse(p, x - rad, y - rad, 2 * rad, 2 * rad);
        }
    }
}
