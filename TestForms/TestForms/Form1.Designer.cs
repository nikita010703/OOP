using System;

namespace TestForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn0 = new System.Windows.Forms.Button();
            this.cbIsJumping = new System.Windows.Forms.CheckBox();
            this.ttObjects = new System.Windows.Forms.ToolTip(this.components);
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbXPos = new System.Windows.Forms.Label();
            this.lbYPos = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.ListBox();
            this.nupMaxBtn = new System.Windows.Forms.NumericUpDown();
            this.tbRun = new System.Windows.Forms.TextBox();
            this.cmsPnRun = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IncreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnRun = new System.Windows.Forms.Panel();
            this.rbShowPnRun = new System.Windows.Forms.RadioButton();
            this.rbHidePnRun = new System.Windows.Forms.RadioButton();
            this.mtbDelay = new System.Windows.Forms.MaskedTextBox();
            this.pbClose = new System.Windows.Forms.ProgressBar();
            this.tmPbClose = new System.Windows.Forms.Timer(this.components);
            this.scPbLoad = new System.Windows.Forms.SplitContainer();
            this.lbScProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBtnIsJumping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBtnNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetMaxBtnNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetMinBtnNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncBtnNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecBtnNum = new System.Windows.Forms.ToolStripMenuItem();
            this.панельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPnRunIsShowing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSelectedColor = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiClearWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindowClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxBtn)).BeginInit();
            this.cmsPnRun.SuspendLayout();
            this.pnRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPbLoad)).BeginInit();
            this.scPbLoad.Panel1.SuspendLayout();
            this.scPbLoad.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Location = new System.Drawing.Point(12, 59);
            this.btn0.MaximumSize = new System.Drawing.Size(140, 40);
            this.btn0.MinimumSize = new System.Drawing.Size(140, 40);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(140, 40);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "Нажми меня";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // cbIsJumping
            // 
            this.cbIsJumping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIsJumping.AutoSize = true;
            this.cbIsJumping.Location = new System.Drawing.Point(12, 430);
            this.cbIsJumping.Name = "cbIsJumping";
            this.cbIsJumping.Size = new System.Drawing.Size(188, 17);
            this.cbIsJumping.TabIndex = 1;
            this.cbIsJumping.Text = "Хотите, чтобы кнопки прыгали?";
            this.cbIsJumping.UseVisualStyleBackColor = true;
            this.cbIsJumping.CheckedChanged += new System.EventHandler(this.cbIsJumping_CheckedChanged);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(9, 30);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 13);
            this.lbX.TabIndex = 2;
            this.lbX.Text = "X: ";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(9, 43);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 13);
            this.lbY.TabIndex = 3;
            this.lbY.Text = "Y: ";
            // 
            // lbXPos
            // 
            this.lbXPos.AutoSize = true;
            this.lbXPos.Location = new System.Drawing.Point(25, 30);
            this.lbXPos.Name = "lbXPos";
            this.lbXPos.Size = new System.Drawing.Size(39, 13);
            this.lbXPos.TabIndex = 4;
            this.lbXPos.Text = "lbXpos";
            // 
            // lbYPos
            // 
            this.lbYPos.AutoSize = true;
            this.lbYPos.Location = new System.Drawing.Point(25, 43);
            this.lbYPos.Name = "lbYPos";
            this.lbYPos.Size = new System.Drawing.Size(40, 13);
            this.lbYPos.TabIndex = 5;
            this.lbYPos.Text = "lbYPos";
            // 
            // cbColor
            // 
            this.cbColor.DisplayMember = "0";
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Белый",
            "Серый",
            "Красный",
            "Зеленый",
            "Синий"});
            this.cbColor.Location = new System.Drawing.Point(70, 30);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(90, 21);
            this.cbColor.TabIndex = 6;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // lbColor
            // 
            this.lbColor.FormattingEnabled = true;
            this.lbColor.Items.AddRange(new object[] {
            "Белый",
            "Серый",
            "Красный",
            "Зеленый",
            "Синий"});
            this.lbColor.Location = new System.Drawing.Point(166, 30);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(57, 69);
            this.lbColor.TabIndex = 7;
            this.lbColor.SelectedIndexChanged += new System.EventHandler(this.lbColor_SelectedIndexChanged);
            // 
            // nupMaxBtn
            // 
            this.nupMaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nupMaxBtn.Location = new System.Drawing.Point(12, 404);
            this.nupMaxBtn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupMaxBtn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMaxBtn.Name = "nupMaxBtn";
            this.nupMaxBtn.Size = new System.Drawing.Size(56, 20);
            this.nupMaxBtn.TabIndex = 8;
            this.nupMaxBtn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupMaxBtn.ValueChanged += new System.EventHandler(this.nupMaxBtn_ValueChanged);
            // 
            // tbRun
            // 
            this.tbRun.BackColor = System.Drawing.SystemColors.Window;
            this.tbRun.ContextMenuStrip = this.cmsPnRun;
            this.tbRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRun.Location = new System.Drawing.Point(5, 20);
            this.tbRun.MaximumSize = new System.Drawing.Size(50, 50);
            this.tbRun.Name = "tbRun";
            this.tbRun.Size = new System.Drawing.Size(50, 20);
            this.tbRun.TabIndex = 9;
            // 
            // cmsPnRun
            // 
            this.cmsPnRun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncreaseToolStripMenuItem,
            this.DecreaseToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.cmsPnRun.Name = "cmsPnRun";
            this.cmsPnRun.Size = new System.Drawing.Size(139, 70);
            // 
            // IncreaseToolStripMenuItem
            // 
            this.IncreaseToolStripMenuItem.Name = "IncreaseToolStripMenuItem";
            this.IncreaseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.IncreaseToolStripMenuItem.Text = "Увеличить";
            this.IncreaseToolStripMenuItem.Click += new System.EventHandler(this.IncreaseToolStripMenuItem_Click);
            // 
            // DecreaseToolStripMenuItem
            // 
            this.DecreaseToolStripMenuItem.Name = "DecreaseToolStripMenuItem";
            this.DecreaseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.DecreaseToolStripMenuItem.Text = "Уменьшить";
            this.DecreaseToolStripMenuItem.Click += new System.EventHandler(this.DecreaseToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // pnRun
            // 
            this.pnRun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnRun.ContextMenuStrip = this.cmsPnRun;
            this.pnRun.Controls.Add(this.tbRun);
            this.pnRun.Location = new System.Drawing.Point(12, 105);
            this.pnRun.MinimumSize = new System.Drawing.Size(60, 60);
            this.pnRun.Name = "pnRun";
            this.pnRun.Size = new System.Drawing.Size(60, 60);
            this.pnRun.TabIndex = 10;
            this.pnRun.Visible = false;
            // 
            // rbShowPnRun
            // 
            this.rbShowPnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbShowPnRun.AutoSize = true;
            this.rbShowPnRun.Location = new System.Drawing.Point(12, 364);
            this.rbShowPnRun.Name = "rbShowPnRun";
            this.rbShowPnRun.Size = new System.Drawing.Size(113, 17);
            this.rbShowPnRun.TabIndex = 11;
            this.rbShowPnRun.TabStop = true;
            this.rbShowPnRun.Text = "Показать панель";
            this.rbShowPnRun.UseVisualStyleBackColor = true;
            this.rbShowPnRun.CheckedChanged += new System.EventHandler(this.rbShowPnRun_CheckedChanged);
            // 
            // rbHidePnRun
            // 
            this.rbHidePnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbHidePnRun.AutoSize = true;
            this.rbHidePnRun.Location = new System.Drawing.Point(12, 381);
            this.rbHidePnRun.Name = "rbHidePnRun";
            this.rbHidePnRun.Size = new System.Drawing.Size(102, 17);
            this.rbHidePnRun.TabIndex = 12;
            this.rbHidePnRun.TabStop = true;
            this.rbHidePnRun.Text = "Скрыть панель";
            this.rbHidePnRun.UseVisualStyleBackColor = true;
            this.rbHidePnRun.CheckedChanged += new System.EventHandler(this.rbHidePnRun_CheckedChanged);
            // 
            // mtbDelay
            // 
            this.mtbDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbDelay.Location = new System.Drawing.Point(636, 368);
            this.mtbDelay.Mask = "00";
            this.mtbDelay.Name = "mtbDelay";
            this.mtbDelay.Size = new System.Drawing.Size(22, 20);
            this.mtbDelay.TabIndex = 13;
            this.mtbDelay.ValidatingType = typeof(int);
            this.mtbDelay.TextChanged += new System.EventHandler(this.mtbDelay_TextChanged);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Location = new System.Drawing.Point(558, 424);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(100, 23);
            this.pbClose.TabIndex = 14;
            // 
            // tmPbClose
            // 
            this.tmPbClose.Tick += new System.EventHandler(this.tmPbClose_Tick);
            // 
            // scPbLoad
            // 
            this.scPbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scPbLoad.IsSplitterFixed = true;
            this.scPbLoad.Location = new System.Drawing.Point(558, 394);
            this.scPbLoad.Name = "scPbLoad";
            // 
            // scPbLoad.Panel1
            // 
            this.scPbLoad.Panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.scPbLoad.Panel1.Controls.Add(this.lbScProgress);
            this.scPbLoad.Panel1MinSize = 0;
            // 
            // scPbLoad.Panel2
            // 
            this.scPbLoad.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.scPbLoad.Panel2MinSize = 0;
            this.scPbLoad.Size = new System.Drawing.Size(101, 24);
            this.scPbLoad.SplitterDistance = 36;
            this.scPbLoad.SplitterWidth = 1;
            this.scPbLoad.TabIndex = 15;
            // 
            // lbScProgress
            // 
            this.lbScProgress.AutoSize = true;
            this.lbScProgress.Location = new System.Drawing.Point(3, 4);
            this.lbScProgress.Name = "lbScProgress";
            this.lbScProgress.Size = new System.Drawing.Size(27, 13);
            this.lbScProgress.TabIndex = 0;
            this.lbScProgress.Text = "10%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBtn,
            this.панельToolStripMenuItem,
            this.tsmiWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBtn
            // 
            this.tsmiBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBtnIsJumping,
            this.tsmiBtnNum});
            this.tsmiBtn.Name = "tsmiBtn";
            this.tsmiBtn.Size = new System.Drawing.Size(60, 20);
            this.tsmiBtn.Text = "Кнопки";
            // 
            // tsmiBtnIsJumping
            // 
            this.tsmiBtnIsJumping.Name = "tsmiBtnIsJumping";
            this.tsmiBtnIsJumping.Size = new System.Drawing.Size(225, 22);
            this.tsmiBtnIsJumping.Text = "Прыгают";
            this.tsmiBtnIsJumping.Click += new System.EventHandler(this.tsmiBtnIsJumping_Click);
            // 
            // tsmiBtnNum
            // 
            this.tsmiBtnNum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetMaxBtnNum,
            this.tsmiSetMinBtnNum,
            this.tsmiIncBtnNum,
            this.tsmiDecBtnNum});
            this.tsmiBtnNum.Name = "tsmiBtnNum";
            this.tsmiBtnNum.Size = new System.Drawing.Size(225, 22);
            this.tsmiBtnNum.Text = "Максимальное количество";
            // 
            // tsmiSetMaxBtnNum
            // 
            this.tsmiSetMaxBtnNum.Name = "tsmiSetMaxBtnNum";
            this.tsmiSetMaxBtnNum.Size = new System.Drawing.Size(163, 22);
            this.tsmiSetMaxBtnNum.Text = "Максимум";
            this.tsmiSetMaxBtnNum.Click += new System.EventHandler(this.tsmiSetMaxBtnNum_Click);
            // 
            // tsmiSetMinBtnNum
            // 
            this.tsmiSetMinBtnNum.Name = "tsmiSetMinBtnNum";
            this.tsmiSetMinBtnNum.Size = new System.Drawing.Size(163, 22);
            this.tsmiSetMinBtnNum.Text = "Минимум";
            this.tsmiSetMinBtnNum.Click += new System.EventHandler(this.tsmiSetMinBtnNum_Click);
            // 
            // tsmiIncBtnNum
            // 
            this.tsmiIncBtnNum.Name = "tsmiIncBtnNum";
            this.tsmiIncBtnNum.Size = new System.Drawing.Size(163, 22);
            this.tsmiIncBtnNum.Text = "Увеличить на 1";
            this.tsmiIncBtnNum.Click += new System.EventHandler(this.tsmiIncBtnNum_Click);
            // 
            // tsmiDecBtnNum
            // 
            this.tsmiDecBtnNum.Name = "tsmiDecBtnNum";
            this.tsmiDecBtnNum.Size = new System.Drawing.Size(163, 22);
            this.tsmiDecBtnNum.Text = "Уменьшить на 1";
            this.tsmiDecBtnNum.Click += new System.EventHandler(this.tsmiDecBtnNum_Click);
            // 
            // панельToolStripMenuItem
            // 
            this.панельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPnRunIsShowing});
            this.панельToolStripMenuItem.Name = "панельToolStripMenuItem";
            this.панельToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.панельToolStripMenuItem.Text = "Панель";
            // 
            // tsmiPnRunIsShowing
            // 
            this.tsmiPnRunIsShowing.Name = "tsmiPnRunIsShowing";
            this.tsmiPnRunIsShowing.Size = new System.Drawing.Size(126, 22);
            this.tsmiPnRunIsShowing.Text = "Показана";
            this.tsmiPnRunIsShowing.Click += new System.EventHandler(this.tsmiPnRunIsShowing_Click);
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackgroundColor,
            this.tsmiClearWindow,
            this.tsmiWindowClose});
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(48, 20);
            this.tsmiWindow.Text = "Окно";
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSelectedColor});
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiBackgroundColor.Text = "Цвет";
            // 
            // tscbSelectedColor
            // 
            this.tscbSelectedColor.Items.AddRange(new object[] {
            "Белый",
            "Серый",
            "Красный",
            "Зеленый",
            "Синий"});
            this.tscbSelectedColor.Name = "tscbSelectedColor";
            this.tscbSelectedColor.Size = new System.Drawing.Size(121, 23);
            this.tscbSelectedColor.SelectedIndexChanged += new System.EventHandler(this.tscbSelectedColor_SelectedIndexChanged);
            // 
            // tsmiClearWindow
            // 
            this.tsmiClearWindow.Name = "tsmiClearWindow";
            this.tsmiClearWindow.Size = new System.Drawing.Size(180, 22);
            this.tsmiClearWindow.Text = "Очистить";
            this.tsmiClearWindow.Click += new System.EventHandler(this.tsmiClearWindow_Click);
            // 
            // tsmiWindowClose
            // 
            this.tsmiWindowClose.Name = "tsmiWindowClose";
            this.tsmiWindowClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiWindowClose.Text = "Закрыть";
            this.tsmiWindowClose.Click += new System.EventHandler(this.tsmiWindowClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(670, 454);
            this.Controls.Add(this.scPbLoad);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.cbIsJumping);
            this.Controls.Add(this.nupMaxBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.mtbDelay);
            this.Controls.Add(this.rbHidePnRun);
            this.Controls.Add(this.rbShowPnRun);
            this.Controls.Add(this.pnRun);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbYPos);
            this.Controls.Add(this.lbXPos);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxBtn)).EndInit();
            this.cmsPnRun.ResumeLayout(false);
            this.pnRun.ResumeLayout(false);
            this.pnRun.PerformLayout();
            this.scPbLoad.Panel1.ResumeLayout(false);
            this.scPbLoad.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPbLoad)).EndInit();
            this.scPbLoad.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.CheckBox cbIsJumping;
        private System.Windows.Forms.ToolTip ttObjects;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbXPos;
        private System.Windows.Forms.Label lbYPos;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ListBox lbColor;
        private System.Windows.Forms.NumericUpDown nupMaxBtn;
        private System.Windows.Forms.TextBox tbRun;
        private System.Windows.Forms.Panel pnRun;
        private System.Windows.Forms.RadioButton rbShowPnRun;
        private System.Windows.Forms.RadioButton rbHidePnRun;
        private System.Windows.Forms.MaskedTextBox mtbDelay;
        private System.Windows.Forms.ProgressBar pbClose;
        private System.Windows.Forms.Timer tmPbClose;
        private System.Windows.Forms.ContextMenuStrip cmsPnRun;
        private System.Windows.Forms.ToolStripMenuItem IncreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scPbLoad;
        private System.Windows.Forms.Label lbScProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBtn;
        private System.Windows.Forms.ToolStripMenuItem tsmiBtnIsJumping;
        private System.Windows.Forms.ToolStripMenuItem tsmiBtnNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetMaxBtnNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetMinBtnNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncBtnNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecBtnNum;
        private System.Windows.Forms.ToolStripMenuItem панельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPnRunIsShowing;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripComboBox tscbSelectedColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindowClose;
    }
}