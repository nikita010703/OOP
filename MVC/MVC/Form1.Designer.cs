namespace MVC {
    partial class Form {
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
            this.trckBrC = new System.Windows.Forms.TrackBar();
            this.txtBxC = new System.Windows.Forms.TextBox();
            this.numUDC = new System.Windows.Forms.NumericUpDown();
            this.lblMain = new System.Windows.Forms.Label();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.txtBxB = new System.Windows.Forms.TextBox();
            this.trckBrB = new System.Windows.Forms.TrackBar();
            this.numUDA = new System.Windows.Forms.NumericUpDown();
            this.txtBxA = new System.Windows.Forms.TextBox();
            this.trckBrA = new System.Windows.Forms.TrackBar();
            this.modelABCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trckBrC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelABCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trckBrC
            // 
            this.trckBrC.Location = new System.Drawing.Point(315, 117);
            this.trckBrC.Maximum = 100;
            this.trckBrC.Name = "trckBrC";
            this.trckBrC.Size = new System.Drawing.Size(118, 45);
            this.trckBrC.TabIndex = 2;
            this.trckBrC.ValueChanged += new System.EventHandler(this.trckBr_ValueChanged);
            // 
            // txtBxC
            // 
            this.txtBxC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelABCBindingSource, "C", true));
            this.txtBxC.Location = new System.Drawing.Point(325, 65);
            this.txtBxC.Name = "txtBxC";
            this.txtBxC.Size = new System.Drawing.Size(100, 20);
            this.txtBxC.TabIndex = 5;
            this.txtBxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_KeyDown);
            this.txtBxC.Leave += new System.EventHandler(this.txtBx_Leave);
            // 
            // numUDC
            // 
            this.numUDC.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.modelABCBindingSource, "C", true));
            this.numUDC.Location = new System.Drawing.Point(325, 91);
            this.numUDC.Name = "numUDC";
            this.numUDC.Size = new System.Drawing.Size(100, 20);
            this.numUDC.TabIndex = 7;
            this.numUDC.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(63, 19);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(335, 39);
            this.lblMain.TabIndex = 9;
            this.lblMain.Text = "A    <=    B    <=    C";
            // 
            // numUDB
            // 
            this.numUDB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.modelABCBindingSource, "B", true));
            this.numUDB.Location = new System.Drawing.Point(179, 91);
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(100, 20);
            this.numUDB.TabIndex = 12;
            this.numUDB.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // txtBxB
            // 
            this.txtBxB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelABCBindingSource, "B", true));
            this.txtBxB.Location = new System.Drawing.Point(179, 65);
            this.txtBxB.Name = "txtBxB";
            this.txtBxB.Size = new System.Drawing.Size(100, 20);
            this.txtBxB.TabIndex = 11;
            this.txtBxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_KeyDown);
            this.txtBxB.Leave += new System.EventHandler(this.txtBx_Leave);
            // 
            // trckBrB
            // 
            this.trckBrB.Location = new System.Drawing.Point(169, 117);
            this.trckBrB.Maximum = 100;
            this.trckBrB.Name = "trckBrB";
            this.trckBrB.Size = new System.Drawing.Size(118, 45);
            this.trckBrB.TabIndex = 10;
            this.trckBrB.ValueChanged += new System.EventHandler(this.trckBr_ValueChanged);
            // 
            // numUDA
            // 
            this.numUDA.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.modelABCBindingSource, "A", true));
            this.numUDA.Location = new System.Drawing.Point(33, 91);
            this.numUDA.Name = "numUDA";
            this.numUDA.Size = new System.Drawing.Size(100, 20);
            this.numUDA.TabIndex = 15;
            this.numUDA.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // txtBxA
            // 
            this.txtBxA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelABCBindingSource, "A", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBxA.Location = new System.Drawing.Point(33, 65);
            this.txtBxA.Name = "txtBxA";
            this.txtBxA.Size = new System.Drawing.Size(100, 20);
            this.txtBxA.TabIndex = 14;
            this.txtBxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_KeyDown);
            this.txtBxA.Leave += new System.EventHandler(this.txtBx_Leave);
            // 
            // trckBrA
            // 
            this.trckBrA.Location = new System.Drawing.Point(23, 117);
            this.trckBrA.Maximum = 100;
            this.trckBrA.Name = "trckBrA";
            this.trckBrA.Size = new System.Drawing.Size(118, 45);
            this.trckBrA.TabIndex = 13;
            this.trckBrA.ValueChanged += new System.EventHandler(this.trckBr_ValueChanged);
            // 
            // modelABCBindingSource
            // 
            this.modelABCBindingSource.DataSource = typeof(MVC.ModelABC);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 183);
            this.Controls.Add(this.numUDA);
            this.Controls.Add(this.txtBxA);
            this.Controls.Add(this.trckBrA);
            this.Controls.Add(this.numUDB);
            this.Controls.Add(this.txtBxB);
            this.Controls.Add(this.trckBrB);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.numUDC);
            this.Controls.Add(this.txtBxC);
            this.Controls.Add(this.trckBrC);
            this.Name = "Form";
            this.Text = "MVC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckBrC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelABCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trckBrC;
        private System.Windows.Forms.TextBox txtBxC;
        private System.Windows.Forms.NumericUpDown numUDC;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.TextBox txtBxB;
        private System.Windows.Forms.TrackBar trckBrB;
        private System.Windows.Forms.NumericUpDown numUDA;
        private System.Windows.Forms.TextBox txtBxA;
        private System.Windows.Forms.TrackBar trckBrA;
        private System.Windows.Forms.BindingSource modelABCBindingSource;
    }
}

