using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaTien.Text = "22000";
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaTien.Text = "21000";
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaTien.Text = "20000";
        }

        private void butTinhTien_Click(object sender, EventArgs e)
        {
            int tienSum = int.Parse(txtGiaTien.Text) * int.Parse(txtSoLuong.Text);
            txtSum.Text = tienSum.ToString();
        }
    }
}
