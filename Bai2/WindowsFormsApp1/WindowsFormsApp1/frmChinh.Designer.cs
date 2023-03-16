namespace WindowsFormsApp1
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyenHuyHieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyenHuyHieuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyenHuyHieuToolStripMenuItem
            // 
            this.nguyenHuyHieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBai1,
            this.smiBai2,
            this.smiBai3,
            this.bai4ToolStripMenuItem});
            this.nguyenHuyHieuToolStripMenuItem.Name = "nguyenHuyHieuToolStripMenuItem";
            this.nguyenHuyHieuToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.nguyenHuyHieuToolStripMenuItem.Text = "Nguyen Huy Hieu";
            // 
            // smiBai1
            // 
            this.smiBai1.Image = ((System.Drawing.Image)(resources.GetObject("smiBai1.Image")));
            this.smiBai1.Name = "smiBai1";
            this.smiBai1.Size = new System.Drawing.Size(224, 26);
            this.smiBai1.Text = "Bai 1";
            this.smiBai1.Click += new System.EventHandler(this.smiBai1_Click);
            // 
            // smiBai2
            // 
            this.smiBai2.Image = ((System.Drawing.Image)(resources.GetObject("smiBai2.Image")));
            this.smiBai2.Name = "smiBai2";
            this.smiBai2.Size = new System.Drawing.Size(224, 26);
            this.smiBai2.Text = "Bai 2";
            this.smiBai2.Click += new System.EventHandler(this.smiBai2_Click);
            // 
            // smiBai3
            // 
            this.smiBai3.Image = ((System.Drawing.Image)(resources.GetObject("smiBai3.Image")));
            this.smiBai3.Name = "smiBai3";
            this.smiBai3.Size = new System.Drawing.Size(224, 26);
            this.smiBai3.Text = "Bai 3";
            this.smiBai3.Click += new System.EventHandler(this.smiBai3_Click);
            // 
            // bai4ToolStripMenuItem
            // 
            this.bai4ToolStripMenuItem.Name = "bai4ToolStripMenuItem";
            this.bai4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai4ToolStripMenuItem.Text = "Bai 4";
            this.bai4ToolStripMenuItem.Click += new System.EventHandler(this.bai4ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChinh";
            this.Text = "Chương Trình Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyenHuyHieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiBai1;
        private System.Windows.Forms.ToolStripMenuItem smiBai2;
        private System.Windows.Forms.ToolStripMenuItem smiBai3;
        private System.Windows.Forms.ToolStripMenuItem bai4ToolStripMenuItem;
    }
}

