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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void smiBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frm = new frmBai2();
            frm.ShowDialog();
        }

        private void smiBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frm = new frmBai1();
            frm.ShowDialog();
        }

        private void smiBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frm = new frmBai3();
            frm.ShowDialog();
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 frm = new frmBai4();
            frm.ShowDialog();
        }
    }
}
