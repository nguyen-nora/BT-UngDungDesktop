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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butChon_Click(object sender, EventArgs e)
        {
            var item = listDS.SelectedItem;
            listKhach.Items.Add(item);
        }

        private void listKhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butBo_Click(object sender, EventArgs e)
        {
            listKhach.Items.Remove(listKhach.SelectedItems);
        }

        private void butTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (string hang in listKhach.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
            }
            txtTien.Text = soTien.ToString();
        }
    }
}
