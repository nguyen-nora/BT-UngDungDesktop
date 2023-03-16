using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            MessageBox.Show($"Ban chon gioi tinh nam");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            MessageBox.Show($"Ban chon gioi tinh nu");
        }

        private void butChon_Click(object sender, EventArgs e)
        {
            if (rdRed.Checked)
                txtColor.BackColor = Color.Red;
            if (rdBlue.Checked)
                txtColor.BackColor = Color.Blue;
        }
    }
}
