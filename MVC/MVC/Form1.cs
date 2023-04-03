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
                txtBox_Input(sender);
        }

        private void txtBx_Leave(object sender, EventArgs e) {
            txtBox_Input(sender);
        }

        private void txtBox_Input(object sender) {
            TextBox send = (TextBox)sender;
            int num;
            bool success = int.TryParse(send.Text, out num);
            if (success) {
                switch (send.Name.Last()) {
                    case 'A': model.A = num; break;
                    case 'B': model.B = num; break;
                    case 'C': model.C = num; break;
                    default: break;
                }
            }
            else
                model.Update();
        }

        private void numUD_ValueChanged(object sender, EventArgs e) {
            NumericUpDown send = (NumericUpDown)sender;
            switch (send.Name.Last()) {
                case 'A': model.A = (int)send.Value; break;
                case 'B': model.B = (int)send.Value; break;
                case 'C': model.C = (int)send.Value; break;
                default: break;
            }
        }

        private void trckBr_ValueChanged(object sender, EventArgs e) {
            TrackBar send = (TrackBar)sender;
            switch (send.Name.Last()) {
                case 'A': model.A = send.Value; break;
                case 'B': model.B = send.Value; break;
                case 'C': model.C = send.Value; break;
                default: break;
            }
        }
    }
}
