using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms {
    public partial class Form1 : Form {
    #region Initializing
        public Form1() {
            InitializeComponent();
        }

        static Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e) {
            Width = rand.Next(500, 1201);
            Height = rand.Next(400, 901);
            cbColor.SelectedIndex = 0;

            btn0.Left = Size.Width / 2 - btn0.Size.Width / 2;
            btn0.Top = Size.Height / 2 - btn0.Size.Height;
            maxBtnNum = (int)nupMaxBtn.Value;

            pnRun.Left = rand.Next(Width / 3, 2 * Width / 3);
            pnRun.Top = rand.Next(Height / 3, 2 * Height / 3);
            accX = pnRun.Left;
            accY = pnRun.Top;

            rbHidePnRun.Checked = true;

            mtbDelay.ValidatingType = typeof(Int32);

            scPbLoad.SplitterDistance = 0;

            ttObjects.SetToolTip(btn0, "Кнопка");
            ttObjects.SetToolTip(nupMaxBtn, "Максимальное количество кнопок");
            ttObjects.SetToolTip(lbColor, "Выбрать цвет");
            ttObjects.SetToolTip(cbColor, "Выбрать цвет");
            ttObjects.SetToolTip(lbX, "Позиция курсора на форме");
            ttObjects.SetToolTip(lbXPos, "Позиция курсора на форме");
            ttObjects.SetToolTip(lbY, "Позиция курсора на форме");
            ttObjects.SetToolTip(lbYPos, "Позиция курсора на форме");
            ttObjects.SetToolTip(rbHidePnRun, "Программма закроется при достижении панелью границ окна");
            ttObjects.SetToolTip(rbShowPnRun, "Программма закроется при достижении панелью границ окна");
            ttObjects.SetToolTip(mtbDelay, "Введите время заполнения индикаторов выполнения");
        }
        #endregion

    #region Buttons
        private void Form1_SizeChanged(object sender, EventArgs e) {
            int counter = 0;
            while (counter <= btnCounter) {
                Control btn = Controls.Find("btn" + counter.ToString(), true)[0];
                if (Size.Width < btn.Left + btn.Size.Width + 15)
                    btn.Left = Size.Width - btn.Size.Width - 15;
                if (Size.Height < btn.Top + btn.Size.Height + 37)
                    btn.Top = Size.Height - btn.Size.Height - 37;

                counter++;
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            if (cbIsJumping.Checked) {
                Button btn = sender as Button;
                btn.Left = rand.Next(Size.Width - btn.Width);
                btn.Top = rand.Next(Size.Height - btn.Height * 2);
            }
        }

        private void cbIsJumping_CheckedChanged(object sender, EventArgs e) {
            if (cbIsJumping.Checked)
                tsmiBtnIsJumping.Checked = true;
            else
                tsmiBtnIsJumping.Checked = false;

            int counter = 0;
            while (counter <= btnCounter) {
                Control btn = Controls.Find("btn" + counter.ToString(), true)[0];
                Button btn1 = btn as Button;
                btn1.PerformClick();

                counter++;
            }
        }

        private void tsmiBtnIsJumping_Click(object sender, EventArgs e) {
            tsmiBtnIsJumping.Checked = !tsmiBtnIsJumping.Checked;
            cbIsJumping.Checked = tsmiBtnIsJumping.Checked;
        }

        int btnCounter = 0;
        int maxBtnNum;
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            btnCounter++;

            if (btnCounter == maxBtnNum) {
                btnCounter = 0;
                for (int i = 0; i < maxBtnNum; i++) {
                    Control btnC = Controls.Find("btn" + i.ToString(), false)[0];
                    Button btn = btnC as Button;
                    btn.Click -= new EventHandler(btn_Click);
                    Controls.Remove(btn);
                    btn.Dispose();
                }
            }

            Button newBtn = new System.Windows.Forms.Button();
            newBtn.Size = new System.Drawing.Size(140, 40);
            newBtn.Location = new System.Drawing.Point(e.X - newBtn.Width / 2, e.Y - newBtn.Height / 2);
            newBtn.Name = "btn" + btnCounter.ToString();
            newBtn.Text = "Нажми меня";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += new System.EventHandler(this.btn_Click);
            Controls.Add(newBtn);

            ttObjects.SetToolTip(newBtn, "Кнопка");
        }

        private void nupMaxBtn_ValueChanged(object sender, EventArgs e) {
            maxBtnNum = (int)nupMaxBtn.Value;

            while (maxBtnNum <= btnCounter) {
                Control btn = Controls.Find("btn" + (btnCounter--).ToString(), true)[0];
                btn.Click -= new EventHandler(btn_Click);
                Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void tsmiSetMaxBtnNum_Click(object sender, EventArgs e) {
            nupMaxBtn.Value = nupMaxBtn.Maximum;
        }

        private void tsmiSetMinBtnNum_Click(object sender, EventArgs e) {
            nupMaxBtn.Value = nupMaxBtn.Minimum;
        }

        private void tsmiIncBtnNum_Click(object sender, EventArgs e) {
            if (nupMaxBtn.Value != nupMaxBtn.Maximum)
                nupMaxBtn.Value++;
        }

        private void tsmiDecBtnNum_Click(object sender, EventArgs e) {
            if (nupMaxBtn.Value != nupMaxBtn.Minimum)
                nupMaxBtn.Value--;
        }
        #endregion

    #region Other Form methods
        private void Form1_Paint(object sender, PaintEventArgs e) {
            tbRun.Text = BackColor.Name;
        }

        private void tsmiWindowClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void Form1_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsmiClearWindow_Click(object sender, EventArgs e) {
            Controls.Clear();
            this.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Click += new System.EventHandler(this.Form1_Click);
            ttObjects.SetToolTip(this, "Окно закроется по нажатию мыши");
        }
        #endregion

    #region Panel
        int posX, posY;
        float accX;
        float accY;
        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            posX = e.X;
            posY = e.Y;
            lbXPos.Text = posX.ToString();
            lbYPos.Text = posY.ToString();

            if (pnRun.Visible) {
                float distX = pnRun.Left + pnRun.Width / 2 - posX;
                float distY = pnRun.Top + pnRun.Height / 2 - posY;
                float distance = (float)Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));
                float coefX = distX / distance;
                float coefY = distY / distance;

                accX += 50f * coefX / distance;
                accY += 50f * coefY / distance;
                pnRun.Left = (int)accX;
                pnRun.Top = (int)accY;
                if (pnRun.Left < 0 || pnRun.Top < 0 || pnRun.Right > Width - 15 || pnRun.Bottom > Height - 37)
                    Close();
            }
        }

        private void rbHidePnRun_CheckedChanged(object sender, EventArgs e) {
            if (sender.Equals(tsmiPnRunIsShowing))
                rbHidePnRun.Checked = true;

            pnRun.Visible = false;
            tsmiPnRunIsShowing.Checked = false;
        }

        private void rbShowPnRun_CheckedChanged(object sender, EventArgs e) {
            if (sender.Equals(tsmiPnRunIsShowing))
                rbShowPnRun.Checked = true;

            pnRun.Visible = true;
            tsmiPnRunIsShowing.Checked = true;
        }

        private void tsmiPnRunIsShowing_Click(object sender, EventArgs e) {
            if (tsmiPnRunIsShowing.Checked)
                rbHidePnRun_CheckedChanged(sender, e);
            else
                rbShowPnRun_CheckedChanged(sender, e);
            /*
            tsmiPnRunIsShowing.Checked = !tsmiPnRunIsShowing.Checked;
            if (tsmiPnRunIsShowing.Checked)
                rbShowPnRun.Checked = true;
            else
                rbHidePnRun.Checked = true;
            */
        }

        private void IncreaseToolStripMenuItem_Click(object sender, EventArgs e) {
            pnRun.Width += 10;
            pnRun.Height += 10;
            tbRun.Left = (pnRun.Width - tbRun.Width) / 2;
            tbRun.Top = (pnRun.Height - tbRun.Height) / 2;
        }

        private void DecreaseToolStripMenuItem_Click(object sender, EventArgs e) {
            pnRun.Width -= 10;
            pnRun.Height -= 10;
            tbRun.Left = (pnRun.Width - tbRun.Width) / 2;
            tbRun.Top = (pnRun.Height - tbRun.Height) / 2;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            Controls.Remove(tbRun);
            tbRun.Dispose();
            pnRun.ContextMenuStrip = null;
            Controls.Remove(pnRun);
            pnRun.Dispose();
        }
        #endregion

    #region Change color
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbColor.SelectedIndex) {
                case 0: {
                    BackColor = Color.White;
                    lbColor.SelectedItem = "Белый";
                    tscbSelectedColor.SelectedIndex = 0; break;
                }
                case 1: {
                    BackColor = Color.DimGray;
                    lbColor.SelectedItem = "Серый";
                    tscbSelectedColor.SelectedIndex = 1; break;
                }
                case 2: {
                    BackColor = Color.LightCoral;
                    lbColor.SelectedItem = "Красный";
                    tscbSelectedColor.SelectedIndex = 2; break;
                }
                case 3: {
                    BackColor = Color.LightGreen;
                    lbColor.SelectedItem = "Зеленый";
                    tscbSelectedColor.SelectedIndex = 3; break;
                }
                case 4: {
                    BackColor = Color.LightBlue;
                    lbColor.SelectedItem = "Синий";
                    tscbSelectedColor.SelectedIndex = 4; break;
                }
            }
        }

        private void lbColor_SelectedIndexChanged(object sender, EventArgs e) {
            switch (lbColor.SelectedIndex) {
                case 0: {
                    //BackColor = Color.White;
                    cbColor.SelectedIndex = 0; break;
                }
                case 1: {
                    //BackColor = Color.DimGray;
                    cbColor.SelectedIndex = 1; break;
                }
                case 2: {
                    //BackColor = Color.LightCoral;
                    cbColor.SelectedIndex = 2; break;
                }
                case 3: {
                    //BackColor = Color.LightGreen;
                    cbColor.SelectedIndex = 3; break;
                }
                case 4: {
                    //BackColor = Color.LightBlue;
                    cbColor.SelectedIndex = 4; break;
                }
            }
        }

        private void tscbSelectedColor_SelectedIndexChanged(object sender, EventArgs e) {
            switch (tscbSelectedColor.SelectedIndex) {
                case 0: {
                    cbColor.SelectedIndex = 0; break;
                }
                case 1: {
                    cbColor.SelectedIndex = 1; break;
                }
                case 2: {
                    cbColor.SelectedIndex = 2; break;
                }
                case 3: {
                    cbColor.SelectedIndex = 3; break;
                }
                case 4: {
                    cbColor.SelectedIndex = 4; break;
                }
            }
        }
        #endregion

    #region ProgressBar
        private void mtbDelay_TextChanged(object sender, EventArgs e) {
            if (mtbDelay.MaskCompleted) {
                pbClose.Value = 0;
                pbClose.Maximum = 10 * (int)(mtbDelay.Text[0] - '0') + (int)(mtbDelay.Text[1] - '0') + 1;

                scPbLoad.SplitterDistance = 0;
                lbScProgress.Text = "0%";

                tmPbClose.Start();
            }
        }

        private void tmPbClose_Tick(object sender, EventArgs e) {
            pbClose.Value++;

            float percent = (float)pbClose.Value / pbClose.Maximum;
            scPbLoad.SplitterDistance = (int)(scPbLoad.Width * percent);
            lbScProgress.Text = ((int)(percent * 100)).ToString() + "%";

            if (pbClose.Value == pbClose.Maximum) {
                tmPbClose.Stop();
                ttObjects.Show("Загрузка завершена", pbClose);
            }
        }
    #endregion
    }
}
