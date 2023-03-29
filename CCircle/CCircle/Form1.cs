using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCircle {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        CCircle circle = new CCircle(100, 200);

        private void panel1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            circle.Paint(g);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            if(circle.isLiesOn(e.X, e.Y))
                circle.Select();
            else
                circle.Unselect();
            checkBox1.Checked = circle.isSelect();
            panel1.Invalidate();
        }
    }
}
