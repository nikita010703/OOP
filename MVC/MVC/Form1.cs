using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC {
    public partial class Form : System.Windows.Forms.Form {
        ModelABC model;
        public Form() {
            InitializeComponent();
            model = new ModelABC();
            model.observers += new EventHandler(UpdateFromModel);
        }

        private void Form_Load(object sender, EventArgs e) {
            UpdateFromModel(sender, e);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        public void UpdateFromModel(object sender, EventArgs e) {
            txtBxA.Text = model.A.ToString();
            txtBxB.Text = model.B.ToString();
            txtBxC.Text = model.C.ToString();
            numUDA.Value = model.A;
            numUDB.Value = model.B;
            numUDC.Value = model.C;
            trckBrA.Value = model.A;
            trckBrB.Value = model.B;
            trckBrC.Value = model.C;
        }

        private void txtBx_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                model.ValueChanged(sender);
        }

        private void numUD_ValueChanged(object sender, EventArgs e) {
            model.ValueChanged(sender);
        }

        private void trckBr_ValueChanged(object sender, EventArgs e) {
            model.ValueChanged(sender);
        }
    }
}
