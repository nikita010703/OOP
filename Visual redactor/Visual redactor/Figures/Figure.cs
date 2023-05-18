using Save_and_Load;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}