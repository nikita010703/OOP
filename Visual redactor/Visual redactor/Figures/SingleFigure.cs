using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
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

            observable.Notify(_x, _y, rightBorder, bottomBorder);
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

        public override Point GetCenter() {
            return new Point(x, y);
        }
    }
}