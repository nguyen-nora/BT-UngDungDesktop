namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.butChon = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(311, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gioi tinh";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(18, 21);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(18, 67);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 0;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nu";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butChon);
            this.groupBox2.Controls.Add(this.rdBlue);
            this.groupBox2.Controls.Add(this.rdRed);
            this.groupBox2.Location = new System.Drawing.Point(311, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chon mau";
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(18, 71);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(55, 20);
            this.rdBlue.TabIndex = 0;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Location = new System.Drawing.Point(18, 32);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(54, 20);
            this.rdRed.TabIndex = 0;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            // 
            // butChon
            // 
            this.butChon.Location = new System.Drawing.Point(99, 52);
            this.butChon.Name = "butChon";
            this.butChon.Size = new System.Drawing.Size(75, 23);
            this.butChon.TabIndex = 1;
            this.butChon.Text = "Chon";
            this.butChon.UseVisualStyleBackColor = true;
            this.butChon.Click += new System.EventHandler(this.butChon_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(556, 238);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(176, 94);
            this.txtColor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butChon;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.TextBox txtColor;
    }
}

