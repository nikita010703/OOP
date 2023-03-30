namespace CCircle {
    partial class FormCircles {
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
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.isWorkingWithCtrl = new System.Windows.Forms.CheckBox();
            this.isMultipleSelection = new System.Windows.Forms.CheckBox();
            this.newCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.lblNewSircleRadius = new System.Windows.Forms.Label();
            this.NumOfSelectedCircles = new System.Windows.Forms.Label();
            this.lblNumOfSelectedCircles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newCircleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPaint.Location = new System.Drawing.Point(5, 6);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(787, 427);
            this.pnlPaint.TabIndex = 0;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            // 
            // isWorkingWithCtrl
            // 
            this.isWorkingWithCtrl.AutoSize = true;
            this.isWorkingWithCtrl.Location = new System.Drawing.Point(5, 439);
            this.isWorkingWithCtrl.Name = "isWorkingWithCtrl";
            this.isWorkingWithCtrl.Size = new System.Drawing.Size(138, 17);
            this.isWorkingWithCtrl.TabIndex = 1;
            this.isWorkingWithCtrl.Text = "Клавиша Ctrl работает";
            this.isWorkingWithCtrl.UseVisualStyleBackColor = true;
            // 
            // isMultipleSelection
            // 
            this.isMultipleSelection.AutoSize = true;
            this.isMultipleSelection.Location = new System.Drawing.Point(148, 439);
            this.isMultipleSelection.Name = "isMultipleSelection";
            this.isMultipleSelection.Size = new System.Drawing.Size(216, 17);
            this.isMultipleSelection.TabIndex = 2;
            this.isMultipleSelection.Text = "Выделяются сразу несколько кругов";
            this.isMultipleSelection.UseVisualStyleBackColor = true;
            // 
            // newCircleRadius
            // 
            this.newCircleRadius.Location = new System.Drawing.Point(755, 438);
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
            this.newCircleRadius.TabIndex = 3;
            this.newCircleRadius.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.newCircleRadius.ValueChanged += new System.EventHandler(this.newCircleRadius_ValueChanged);
            // 
            // lblNewSircleRadius
            // 
            this.lblNewSircleRadius.AutoSize = true;
            this.lblNewSircleRadius.Location = new System.Drawing.Point(602, 440);
            this.lblNewSircleRadius.Name = "lblNewSircleRadius";
            this.lblNewSircleRadius.Size = new System.Drawing.Size(153, 13);
            this.lblNewSircleRadius.TabIndex = 4;
            this.lblNewSircleRadius.Text = "Радиус добавляемого круга:";
            // 
            // NumOfSelectedCircles
            // 
            this.NumOfSelectedCircles.AutoSize = true;
            this.NumOfSelectedCircles.Location = new System.Drawing.Point(551, 441);
            this.NumOfSelectedCircles.Name = "NumOfSelectedCircles";
            this.NumOfSelectedCircles.Size = new System.Drawing.Size(13, 13);
            this.NumOfSelectedCircles.TabIndex = 5;
            this.NumOfSelectedCircles.Text = "0";
            // 
            // lblNumOfSelectedCircles
            // 
            this.lblNumOfSelectedCircles.AutoSize = true;
            this.lblNumOfSelectedCircles.Location = new System.Drawing.Point(387, 440);
            this.lblNumOfSelectedCircles.Name = "lblNumOfSelectedCircles";
            this.lblNumOfSelectedCircles.Size = new System.Drawing.Size(166, 13);
            this.lblNumOfSelectedCircles.TabIndex = 6;
            this.lblNumOfSelectedCircles.Text = "Количество выбранных кругов:";
            // 
            // FormCircles
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
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "FormCircles";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.newCircleRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.CheckBox isWorkingWithCtrl;
        private System.Windows.Forms.CheckBox isMultipleSelection;
        private System.Windows.Forms.NumericUpDown newCircleRadius;
        private System.Windows.Forms.Label lblNewSircleRadius;
        private System.Windows.Forms.Label NumOfSelectedCircles;
        private System.Windows.Forms.Label lblNumOfSelectedCircles;
    }
}

