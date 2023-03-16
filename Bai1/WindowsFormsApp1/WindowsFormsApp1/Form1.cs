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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            var tendanhap = txtTen.Text;
            MessageBox.Show($"Hello {tendanhap}.");
        }

        private void textCopy_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void butCopy_Click(object sender, EventArgs e)
        {
            txtCopy.Text = txtTen.Text;
        }
    }
}
