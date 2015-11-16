namespace TaskPaneAddIn
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.button1 = new System.Windows.Forms.Button();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPrinter = new System.Windows.Forms.PictureBox();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(0, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picComputer
            // 
            this.picComputer.Image = ((System.Drawing.Image)(resources.GetObject("picComputer.Image")));
            this.picComputer.Location = new System.Drawing.Point(51, 115);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(16, 16);
            this.picComputer.TabIndex = 2;
            this.picComputer.TabStop = false;
            // 
            // picPrinter
            // 
            this.picPrinter.Image = ((System.Drawing.Image)(resources.GetObject("picPrinter.Image")));
            this.picPrinter.Location = new System.Drawing.Point(87, 115);
            this.picPrinter.Name = "picPrinter";
            this.picPrinter.Size = new System.Drawing.Size(16, 16);
            this.picPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPrinter.TabIndex = 3;
            this.picPrinter.TabStop = false;
            // 
            // picSetting
            // 
            this.picSetting.Image = ((System.Drawing.Image)(resources.GetObject("picSetting.Image")));
            this.picSetting.Location = new System.Drawing.Point(119, 115);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(16, 16);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSetting.TabIndex = 4;
            this.picSetting.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.picSetting);
            this.Controls.Add(this.picPrinter);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(326, 485);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picPrinter;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
