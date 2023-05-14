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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNewSircleRadius = new System.Windows.Forms.Label();
            this.newFirureSize = new System.Windows.Forms.NumericUpDown();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.cdChooseColor = new System.Windows.Forms.ColorDialog();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.cbChooseFigure = new System.Windows.Forms.ComboBox();
            this.lbCurrentFigure = new System.Windows.Forms.Label();
            this.lbCurrentColor = new System.Windows.Forms.Label();
            this.btnSetColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newFirureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewSircleRadius
            // 
            this.lblNewSircleRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewSircleRadius.AutoSize = true;
            this.lblNewSircleRadius.Location = new System.Drawing.Point(590, 11);
            this.lblNewSircleRadius.Name = "lblNewSircleRadius";
            this.lblNewSircleRadius.Size = new System.Drawing.Size(161, 13);
            this.lblNewSircleRadius.TabIndex = 11;
            this.lblNewSircleRadius.Text = "Размер добавляемой фигуры:";
            // 
            // newFirureSize
            // 
            this.newFirureSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newFirureSize.Location = new System.Drawing.Point(754, 8);
            this.newFirureSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.newFirureSize.Name = "newFirureSize";
            this.newFirureSize.Size = new System.Drawing.Size(37, 20);
            this.newFirureSize.TabIndex = 10;
            this.newFirureSize.TabStop = false;
            this.newFirureSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.newFirureSize.ValueChanged += new System.EventHandler(this.newFirureSize_ValueChanged);
            // 
            // pnlPaint
            // 
            this.pnlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPaint.Location = new System.Drawing.Point(0, 42);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(804, 419);
            this.pnlPaint.TabIndex = 7;
            this.pnlPaint.TabStop = true;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pnlPaint_PreviewKeyDown);
            this.pnlPaint.Resize += new System.EventHandler(this.pnlPaint_Resize);
            // 
            // cdChooseColor
            // 
            this.cdChooseColor.FullOpen = true;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChooseColor.Location = new System.Drawing.Point(283, 7);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(25, 25);
            this.btnChooseColor.TabIndex = 14;
            this.btnChooseColor.TabStop = false;
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
            this.cbChooseFigure.Location = new System.Drawing.Point(141, 8);
            this.cbChooseFigure.Name = "cbChooseFigure";
            this.cbChooseFigure.Size = new System.Drawing.Size(95, 21);
            this.cbChooseFigure.TabIndex = 15;
            this.cbChooseFigure.TabStop = false;
            // 
            // lbCurrentFigure
            // 
            this.lbCurrentFigure.AutoSize = true;
            this.lbCurrentFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentFigure.Location = new System.Drawing.Point(5, 10);
            this.lbCurrentFigure.Name = "lbCurrentFigure";
            this.lbCurrentFigure.Size = new System.Drawing.Size(134, 15);
            this.lbCurrentFigure.TabIndex = 16;
            this.lbCurrentFigure.Text = "Создаваемая фигура:";
            // 
            // lbCurrentColor
            // 
            this.lbCurrentColor.AutoSize = true;
            this.lbCurrentColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentColor.Location = new System.Drawing.Point(242, 10);
            this.lbCurrentColor.Name = "lbCurrentColor";
            this.lbCurrentColor.Size = new System.Drawing.Size(40, 15);
            this.lbCurrentColor.TabIndex = 17;
            this.lbCurrentColor.Text = "Цвет:";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(314, 8);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(76, 24);
            this.btnSetColor.TabIndex = 18;
            this.btnSetColor.TabStop = false;
            this.btnSetColor.Text = "Применить цвет к выделенным фигурам";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.lbCurrentColor);
            this.Controls.Add(this.lbCurrentFigure);
            this.Controls.Add(this.cbChooseFigure);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.lblNewSircleRadius);
            this.Controls.Add(this.newFirureSize);
            this.Controls.Add(this.pnlPaint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "Визуальный редактор";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.newFirureSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewSircleRadius;
        private System.Windows.Forms.NumericUpDown newFirureSize;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.ColorDialog cdChooseColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ComboBox cbChooseFigure;
        private System.Windows.Forms.Label lbCurrentFigure;
        private System.Windows.Forms.Label lbCurrentColor;
        private System.Windows.Forms.Button btnSetColor;
    }
}

