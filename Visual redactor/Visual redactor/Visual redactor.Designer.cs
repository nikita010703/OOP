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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNewSircleRadius = new System.Windows.Forms.Label();
            this.newFirureSize = new System.Windows.Forms.NumericUpDown();
            this.cdChooseColor = new System.Windows.Forms.ColorDialog();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.cbChooseFigure = new System.Windows.Forms.ComboBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnDecompose = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlPaint = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSetGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newFirureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewSircleRadius
            // 
            this.lblNewSircleRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewSircleRadius.AutoSize = true;
            this.lblNewSircleRadius.Location = new System.Drawing.Point(14, 48);
            this.lblNewSircleRadius.Name = "lblNewSircleRadius";
            this.lblNewSircleRadius.Size = new System.Drawing.Size(49, 13);
            this.lblNewSircleRadius.TabIndex = 11;
            this.lblNewSircleRadius.Text = "Размер:";
            // 
            // newFirureSize
            // 
            this.newFirureSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newFirureSize.Location = new System.Drawing.Point(64, 46);
            this.newFirureSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.newFirureSize.Name = "newFirureSize";
            this.newFirureSize.Size = new System.Drawing.Size(37, 20);
            this.newFirureSize.TabIndex = 1;
            this.toolTip.SetToolTip(this.newFirureSize, "Размер создаваемой фигуры");
            this.newFirureSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.newFirureSize.ValueChanged += new System.EventHandler(this.newFirureSize_ValueChanged);
            // 
            // cdChooseColor
            // 
            this.cdChooseColor.FullOpen = true;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChooseColor.Location = new System.Drawing.Point(6, 19);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(39, 39);
            this.btnChooseColor.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnChooseColor, "Цвет создаваемой фигры");
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
            this.cbChooseFigure.Location = new System.Drawing.Point(6, 19);
            this.cbChooseFigure.Name = "cbChooseFigure";
            this.cbChooseFigure.Size = new System.Drawing.Size(95, 21);
            this.cbChooseFigure.TabIndex = 0;
            this.toolTip.SetToolTip(this.cbChooseFigure, "Создаваемая фигура");
            // 
            // btnSetColor
            // 
            this.btnSetColor.Image = ((System.Drawing.Image)(resources.GetObject("btnSetColor.Image")));
            this.btnSetColor.Location = new System.Drawing.Point(51, 19);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(39, 39);
            this.btnSetColor.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSetColor, "Применить цвет к выбранным фигурам");
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnDecompose
            // 
            this.btnDecompose.Image = ((System.Drawing.Image)(resources.GetObject("btnDecompose.Image")));
            this.btnDecompose.Location = new System.Drawing.Point(51, 19);
            this.btnDecompose.Name = "btnDecompose";
            this.btnDecompose.Size = new System.Drawing.Size(39, 39);
            this.btnDecompose.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnDecompose, "Разгруппировать фигуры");
            this.btnDecompose.UseVisualStyleBackColor = true;
            this.btnDecompose.Click += new System.EventHandler(this.btnDecompose_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "(*.txt)|*.txt";
            this.openFileDialog.FileName = "openFile";
            this.openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.DefaultExt = "(*.txt)|*.txt";
            this.saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaint.Location = new System.Drawing.Point(0, 87);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(804, 374);
            this.pnlPaint.TabIndex = 23;
            this.pnlPaint.TabStop = false;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pnlPaint_PreviewKeyDown);
            this.pnlPaint.Resize += new System.EventHandler(this.pnlPaint_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbChooseFigure);
            this.groupBox1.Controls.Add(this.newFirureSize);
            this.groupBox1.Controls.Add(this.lblNewSircleRadius);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фигура";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnChooseColor);
            this.groupBox2.Controls.Add(this.btnSetColor);
            this.groupBox2.Location = new System.Drawing.Point(124, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвет";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnSetGroup);
            this.groupBox3.Controls.Add(this.btnDecompose);
            this.groupBox3.Location = new System.Drawing.Point(228, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Группировка";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Location = new System.Drawing.Point(332, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Файл";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 39);
            this.btnSave.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSave, "Сохранить фигуры в файл");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(51, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(39, 39);
            this.btnLoad.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnLoad, "Загрузить фигуры из файла сохранения");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSetGroup
            // 
            this.btnSetGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetGroup.Image")));
            this.btnSetGroup.Location = new System.Drawing.Point(6, 19);
            this.btnSetGroup.Name = "btnSetGroup";
            this.btnSetGroup.Size = new System.Drawing.Size(39, 39);
            this.btnSetGroup.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnSetGroup, "Сгруппировать фигуры");
            this.btnSetGroup.UseVisualStyleBackColor = true;
            this.btnSetGroup.Click += new System.EventHandler(this.btnSetGroup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPaint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "Визуальный редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCircles_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.newFirureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNewSircleRadius;
        private System.Windows.Forms.NumericUpDown newFirureSize;
        private System.Windows.Forms.ColorDialog cdChooseColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ComboBox cbChooseFigure;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnDecompose;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pnlPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSetGroup;
    }
}

