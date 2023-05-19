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
        internal Observer observers;
        internal Observable observable;
   
        public bool IsSelected { get { return isSelected; } }

        public Figure() {
            observers = new Observer();
            observable = new Observable();
        }
        public abstract bool Move(int x, int y, int rightBorder, int bottomBorder);
        public abstract bool isLiesOn(int _x, int _y);
        public abstract void Select();
        public abstract void Unselect();
        public abstract bool ChangeSize(int dSize, int rightBorder, int bottomBorder);
        public abstract void ChangeColor(Color color);
        public virtual void Paint(Graphics g) {
            observers.DrawArrows(GetCenter().X, GetCenter().Y, g);
            observable.Reset();
        }

        public abstract void Save(StreamWriter file);
        public abstract void Load(StreamReader file);

        public abstract Point GetCenter();
    }

}