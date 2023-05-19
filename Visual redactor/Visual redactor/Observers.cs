using Figures;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Figures {
    public class Observer {
        public List<Figure> observables;

        public Observer() {
            observables = new List<Figure>();
        }

        public void AddObservable(Figure observable) {
            observables.Add(observable);
        }
        
        public void RemoveObservable(Figure observable) {
            observables.Remove(observable);
        }

        public void DrawArrows(float start_x, float start_y, Graphics g) {
            Pen pen = new Pen(Color.Black, 1.0f);
            pen.CustomStartCap = new AdjustableArrowCap(6, 6, true);
            foreach (Figure f in observables)
                g.DrawLine(pen, start_x, start_y, f.GetCenter().X, f.GetCenter().Y);
        }

        public void Clear() {
            observables.Clear();
        }
    }

    public class Observable {
        public List<Figure> observers;
        public List<bool> visited;

        public Observable() {
            observers = new List<Figure>();
            visited = new List<bool>();
        }

        public void AddObserver(Figure observer) {
            observers.Add(observer);
            visited.Add(false);
        }

        public void RemoveObserver(Figure observer) {
            observers.Remove(observer);
            visited.RemoveAt(0);
        }

        public void Notify(int dx, int dy, int rightBorder, int leftBorder) {
            for (int i = 0; i < observers.Count; ++i)
                if (!visited[i]) {
                    visited[i] = true;
                    observers[i].Move(dx, dy, rightBorder, leftBorder);
                }
        }

        public void DrawLines(float start_x, float start_y, Graphics g) {
            Pen pen = new Pen(Color.Black, 1.0f);
            pen.CustomEndCap = new AdjustableArrowCap(6, 6, true);
            foreach (Figure fig in observers) {
                g.DrawLine(pen, start_x, start_y, fig.GetCenter().X, fig.GetCenter().Y);
            }
        }

        internal void Reset() {
            for (int i = 0; i < visited.Count; i++)
                visited[i] = false;
        }

        public void Clear() {
            observers.Clear();
        }
    }
}
