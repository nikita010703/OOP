using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC {
    internal class ModelABC {
        private int a, b, c;
        public EventHandler observers;

        public ModelABC() {
            Load();
        }

        public int A {
            get {
                return a;
            }
            set {
                a = value;
                if (a < 0) a = 0;
                if (a > 100) a = 100;
                if (a > b) b = a;
                if (a > c) c = a;
                Update();
            }
        }
        public int B {
            get {
                return b;
            }
            set {
                b = value;
                if (b < a) b = a;
                if (b > c) b = c;
                Update();
            }
        }
        public int C {
            get {
                return c;
            }
            set {
                c = value;
                if (c < 0) c = 0;
                if (c > 100) c = 100;
                if (b > c) b = c;
                if (a > c) a = c;
                Update();
            }
        }

        public void Load() {
            a = Properties.Settings.Default.a;
            b = Properties.Settings.Default.b;
            c = Properties.Settings.Default.c;
        }

        public void Update() {
            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            observers.Invoke(this, null);
        }
        /*
        public void ValueChanged(object sender) {
            if (sender is TextBox) {
                TextBox send = (TextBox)sender;
                int num;
                bool success = int.TryParse(send.Text, out num);
                if (success) {
                    switch (send.Name.Last()) {
                        case 'A': A = num; break;
                        case 'B': B = num; break;
                        case 'C': C = num; break;
                        default: break;
                    }
                }
            }
            else if (sender is NumericUpDown) {
                NumericUpDown send = (NumericUpDown)sender;
                switch (send.Name.Last()) {
                    case 'A': A = (int)send.Value; break;
                    case 'B': B = (int)send.Value; break;
                    case 'C': C = (int)send.Value; break;
                    default: break;
                }
            }
            else if (sender is TrackBar) {
                TrackBar send = (TrackBar)sender;
                switch (send.Name.Last()) {
                    case 'A': A = send.Value; break;
                    case 'B': B = send.Value; break;
                    case 'C': C = send.Value; break;
                    default: break;
                }
            }
            Update();
        }
        
        public void Sync(int num, Variable var) {
            switch (var) {
                case Variable.A: A = num; break;
                case Variable.B: B = num; break;
                case Variable.C: C = num; break;
            }
            Update();
        }

        public enum Variable {
            A = 0,
            B = 1,
            C = 2
        }
        */
    }
}
