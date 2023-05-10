namespace Visual_redactor {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.lblNewSircleRadius = new System.Windows.Forms.Label();
            this.newCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.cdChooseColor = new System.Windows.Forms.ColorDialog();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.cbChooseFigure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.newCircleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewSircleRadius
            // 
            this.lblNewSircleRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewSircleRadius.AutoSize = true;
            this.lblNewSircleRadius.Location = new System.Drawing.Point(601, 10);
            this.lblNewSircleRadius.Name = "lblNewSircleRadius";
            this.lblNewSircleRadius.Size = new System.Drawing.Size(153, 13);
            this.lblNewSircleRadius.TabIndex = 11;
            this.lblNewSircleRadius.Text = "Радиус добавляемого круга:";
            // 
            // newCircleRadius
            // 
            this.newCircleRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newCircleRadius.Location = new System.Drawing.Point(754, 8);
            this.newCircleRadius.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.newCircleRadius.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.newCircleRadius.Name = "newCircleRadius";
            this.newCircleRadius.Size = new System.Drawing.Size(37, 20);
            this.newCircleRadius.TabIndex = 10;
            this.newCircleRadius.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.newCircleRadius.ValueChanged += new System.EventHandler(this.newCircleRadius_ValueChanged);
            // 
            // pnlPaint
            // 
            this.pnlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPaint.Location = new System.Drawing.Point(8, 35);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(791, 419);
            this.pnlPaint.TabIndex = 7;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            // 
            // cdChooseColor
            // 
            this.cdChooseColor.FullOpen = true;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChooseColor.Location = new System.Drawing.Point(8, 8);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(25, 25);
            this.btnChooseColor.TabIndex = 14;
            this.btnChooseColor.UseVisualStyleBackColor = false;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // cbChooseFigure
            // 
            this.cbChooseFigure.FormattingEnabled = true;
            this.cbChooseFigure.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Треугольник"});
            this.cbChooseFigure.Location = new System.Drawing.Point(39, 10);
            this.cbChooseFigure.Name = "cbChooseFigure";
            this.cbChooseFigure.Size = new System.Drawing.Size(121, 21);
            this.cbChooseFigure.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.cbChooseFigure);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.lblNewSircleRadius);
            this.Controls.Add(this.newCircleRadius);
            this.Controls.Add(this.pnlPaint);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.newCircleRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewSircleRadius;
        private System.Windows.Forms.NumericUpDown newCircleRadius;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.ColorDialog cdChooseColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ComboBox cbChooseFigure;
    }
}

