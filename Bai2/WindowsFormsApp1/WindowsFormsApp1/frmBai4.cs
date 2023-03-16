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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void lbKQ_Click(object sender, EventArgs e)
        {
           
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            foreach (int so in listBox1.Items)
            {
                if (so == soCanTim)
                {
                    lbKQ.Text = "Tìm thấy";
                    break;
                }
                else
                {
                    lbKQ.Text = "Không tìm thấy";
                }
            }
        }
    }
}
