using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
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
