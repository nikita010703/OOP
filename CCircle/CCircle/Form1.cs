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
    public partial class FormCircles : Form {
        int circleSize = 25;
        bool isPressedCtrl = false;
        int selectedCircles = 1;
        List<CCircle> circles = new List<CCircle>();

        public FormCircles() {
            InitializeComponent();
        }

        private void pnlPaint_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            circles.ForEach(circle => circle.Paint(g));
        }

        private void ProcessingCircleWithCtrl(CCircle circle) {
            if (circle.isSelect() && selectedCircles > 1) {
                circle.Unselect();
                selectedCircles--;
            }
            else if (circle.isSelect() && selectedCircles == 1) {
            }
            else if (!circle.isSelect()) {
                circle.Select();
                selectedCircles++;
            }
        }

        private void ProcessingCircles(MouseEventArgs e) {
            bool isOnCircle = false;

            if (isPressedCtrl && isWorkingWithCtrl.Checked) {
                for (int i = circles.Count - 1; i > -1; i--) {
                    if (isMultipleSelection.Checked) {
                        if (circles[i].isLiesOn(e.X, e.Y)) {
                            isOnCircle = true;
                            ProcessingCircleWithCtrl(circles[i]);
                        }
                    }
                    else if (circles[i].isLiesOn(e.X, e.Y)) {
                        isOnCircle = true;
                        ProcessingCircleWithCtrl(circles[i]);
                        break;
                    }
                }
            }
            else {
                selectedCircles = 0;
                for (int i = circles.Count - 1; i > -1; i--) {
                    if (isMultipleSelection.Checked) {
                        if (circles[i].isLiesOn(e.X, e.Y) && true) {
                            isOnCircle = true;
                            circles[i].Select();
                            selectedCircles++;
                        }
                        else
                            circles[i].Unselect();
                    }
                    else {
                        if (circles[i].isLiesOn(e.X, e.Y) && !isOnCircle) {
                            isOnCircle = true;
                            circles[i].Select();
                            selectedCircles++;
                        }
                        else
                            circles[i].Unselect();
                    }
                }
            }

            if (!isOnCircle) {
                circles.Add(new CCircle(e.X, e.Y, circleSize));
                circles[circles.Count - 1].Select();

                if (isPressedCtrl && isWorkingWithCtrl.Checked) selectedCircles++;
                else selectedCircles = 1;
            }
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e) {
            ProcessingCircles(e);

            NumOfSelectedCircles.Text = selectedCircles.ToString();

            pnlPaint.Invalidate();
        }

        private void FormCircles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = true;

            if (e.KeyCode == Keys.Delete) {
                for (int i = 0; i < circles.Count; i++)
                    if (circles[i].isSelect())
                        circles.RemoveAt(i--);

                if (circles.Count > 0) {
                    circles[circles.Count - 1].Select();
                    selectedCircles = 1;
                }
                else
                    selectedCircles = 0;
                NumOfSelectedCircles.Text = selectedCircles.ToString();

                pnlPaint.Invalidate();
            }
        }

        private void FormCircles_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey)
                isPressedCtrl = false;
        }

        private void newCircleRadius_ValueChanged(object sender, EventArgs e) {
            circleSize = (int)newCircleRadius.Value;
        }
    }
}
