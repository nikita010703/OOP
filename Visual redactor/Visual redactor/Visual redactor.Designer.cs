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
            this.lblNumOfSelectedCircles = new System.Windows.Forms.Label();
            this.NumOfSelectedCircles = new System.Windows.Forms.Label();
            this.lblNewSircleRadius = new System.Windows.Forms.Label();
            this.newCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.isMultipleSelection = new System.Windows.Forms.CheckBox();
            this.isWorkingWithCtrl = new System.Windows.Forms.CheckBox();
            this.pnlPaint = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.newCircleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumOfSelectedCircles
            // 
            this.lblNumOfSelectedCircles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumOfSelectedCircles.AutoSize = true;
            this.lblNumOfSelectedCircles.Location = new System.Drawing.Point(388, 10);
            this.lblNumOfSelectedCircles.Name = "lblNumOfSelectedCircles";
            this.lblNumOfSelectedCircles.Size = new System.Drawing.Size(166, 13);
            this.lblNumOfSelectedCircles.TabIndex = 13;
            this.lblNumOfSelectedCircles.Text = "Количество выбранных кругов:";
            // 
            // NumOfSelectedCircles
            // 
            this.NumOfSelectedCircles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumOfSelectedCircles.AutoSize = true;
            this.NumOfSelectedCircles.Location = new System.Drawing.Point(552, 11);
            this.NumOfSelectedCircles.Name = "NumOfSelectedCircles";
            this.NumOfSelectedCircles.Size = new System.Drawing.Size(13, 13);
            this.NumOfSelectedCircles.TabIndex = 12;
            this.NumOfSelectedCircles.Text = "0";
            // 
            // lblNewSircleRadius
            // 
            this.lblNewSircleRadius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewSircleRadius.AutoSize = true;
            this.lblNewSircleRadius.Location = new System.Drawing.Point(601, 10);
            this.lblNewSircleRadius.Name = "lblNewSircleRadius";
            this.lblNewSircleRadius.Size = new System.Drawing.Size(153, 13);
            this.lblNewSircleRadius.TabIndex = 11;
            this.lblNewSircleRadius.Text = "Радиус добавляемого круга:";
            // 
            // newCircleRadius
            // 
            this.newCircleRadius.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // isMultipleSelection
            // 
            this.isMultipleSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isMultipleSelection.AutoSize = true;
            this.isMultipleSelection.Location = new System.Drawing.Point(150, 9);
            this.isMultipleSelection.Name = "isMultipleSelection";
            this.isMultipleSelection.Size = new System.Drawing.Size(216, 17);
            this.isMultipleSelection.TabIndex = 9;
            this.isMultipleSelection.Text = "Выделяются сразу несколько кругов";
            this.isMultipleSelection.UseVisualStyleBackColor = true;
            // 
            // isWorkingWithCtrl
            // 
            this.isWorkingWithCtrl.AutoSize = true;
            this.isWorkingWithCtrl.Location = new System.Drawing.Point(7, 9);
            this.isWorkingWithCtrl.Name = "isWorkingWithCtrl";
            this.isWorkingWithCtrl.Size = new System.Drawing.Size(138, 17);
            this.isWorkingWithCtrl.TabIndex = 8;
            this.isWorkingWithCtrl.Text = "Клавиша Ctrl работает";
            this.isWorkingWithCtrl.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.lblNumOfSelectedCircles);
            this.Controls.Add(this.NumOfSelectedCircles);
            this.Controls.Add(this.lblNewSircleRadius);
            this.Controls.Add(this.newCircleRadius);
            this.Controls.Add(this.isMultipleSelection);
            this.Controls.Add(this.isWorkingWithCtrl);
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

        private System.Windows.Forms.Label lblNumOfSelectedCircles;
        private System.Windows.Forms.Label NumOfSelectedCircles;
        private System.Windows.Forms.Label lblNewSircleRadius;
        private System.Windows.Forms.NumericUpDown newCircleRadius;
        private System.Windows.Forms.CheckBox isMultipleSelection;
        private System.Windows.Forms.CheckBox isWorkingWithCtrl;
        private System.Windows.Forms.Panel pnlPaint;
    }
}

