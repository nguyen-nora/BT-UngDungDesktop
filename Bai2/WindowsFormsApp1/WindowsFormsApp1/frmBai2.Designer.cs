namespace WindowsFormsApp1
{
    partial class frmBai2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listDS = new System.Windows.Forms.ListBox();
            this.butChon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butBo = new System.Windows.Forms.Button();
            this.listKhach = new System.Windows.Forms.ListBox();
            this.butTinhTien = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butChon);
            this.groupBox1.Controls.Add(this.listDS);
            this.groupBox1.Location = new System.Drawing.Point(45, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Hóa";
            // 
            // listDS
            // 
            this.listDS.FormattingEnabled = true;
            this.listDS.ItemHeight = 16;
            this.listDS.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listDS.Location = new System.Drawing.Point(21, 51);
            this.listDS.Name = "listDS";
            this.listDS.Size = new System.Drawing.Size(205, 132);
            this.listDS.TabIndex = 0;
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // butChon
            // 
            this.butChon.Location = new System.Drawing.Point(243, 67);
            this.butChon.Name = "butChon";
            this.butChon.Size = new System.Drawing.Size(85, 23);
            this.butChon.TabIndex = 1;
            this.butChon.Text = "Chọn hàng";
            this.butChon.UseVisualStyleBackColor = true;
            this.butChon.Click += new System.EventHandler(this.butChon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTien);
            this.groupBox2.Controls.Add(this.butTinhTien);
            this.groupBox2.Controls.Add(this.butBo);
            this.groupBox2.Controls.Add(this.listKhach);
            this.groupBox2.Location = new System.Drawing.Point(424, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 333);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các mặt hàng khách mua";
            // 
            // butBo
            // 
            this.butBo.Location = new System.Drawing.Point(17, 67);
            this.butBo.Name = "butBo";
            this.butBo.Size = new System.Drawing.Size(75, 23);
            this.butBo.TabIndex = 1;
            this.butBo.Text = "Bỏ hàng";
            this.butBo.UseVisualStyleBackColor = true;
            this.butBo.Click += new System.EventHandler(this.butBo_Click);
            // 
            // listKhach
            // 
            this.listKhach.FormattingEnabled = true;
            this.listKhach.ItemHeight = 16;
            this.listKhach.Location = new System.Drawing.Point(98, 51);
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(205, 132);
            this.listKhach.TabIndex = 0;
            this.listKhach.SelectedIndexChanged += new System.EventHandler(this.listKhach_SelectedIndexChanged);
            // 
            // butTinhTien
            // 
            this.butTinhTien.Location = new System.Drawing.Point(131, 208);
            this.butTinhTien.Name = "butTinhTien";
            this.butTinhTien.Size = new System.Drawing.Size(75, 23);
            this.butTinhTien.TabIndex = 1;
            this.butTinhTien.Text = "Tính tiền";
            this.butTinhTien.UseVisualStyleBackColor = true;
            this.butTinhTien.Click += new System.EventHandler(this.butTinhTien_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(190, 280);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(73, 22);
            this.txtTien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền phải trả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butChon;
        private System.Windows.Forms.ListBox listDS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butBo;
        private System.Windows.Forms.ListBox listKhach;
        private System.Windows.Forms.Button butTinhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTien;
    }
}