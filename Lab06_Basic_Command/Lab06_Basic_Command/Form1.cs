﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string connectionString = "server=PC340\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			string query = "SELECT ID, Name, Type FROM Category";
			sqlCommand.CommandText = query;
			sqlConnection.Open();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			this.DisplayCategory(sqlDataReader);
			sqlConnection.Close();
		}

		private void DisplayCategory(SqlDataReader reder)
		{
			lvCategory.Items.Clear();
			while (reder.Read())
			{
				// Tạo một dòng mới trong ListView
				ListViewItem item = new ListViewItem(reder["ID"].ToString());

				//Bổ sung các thông tin khác cho ListViewItem
				item.SubItems.Add(reder["Name"].ToString());
				item.SubItems.Add(Check(reder["Type"].ToString()));

				//Thêm dòng mới vào ListView
				lvCategory.Items.Add(item);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string connectionString = "server= PC340\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true ;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtName.Text + "', " + ConvertType(txtType.Text) + ")";
			sqlConnection.Open();
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			if (numOfRowsEffected == 1)
			{
				if (txtType.Text == "Đồ ăn" || txtType.Text == "Nước uống")
				{
					MessageBox.Show("Thêm món ăn thành công.");
					btnLoad.PerformClick();
				}
				else MessageBox.Show("Nhập sai loại món ăn, vui lòng nhập lại!");
			}
			else
				MessageBox.Show("Đã xảy ra lỗi. Vui lòng nhập lại!");
		}

		private string ConvertType(string n)
        {
			if (n == "Đồ ăn") return "1";
			else return "0";
        }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
				// Tạo đối tượng kết nối
				string connectionString = "server= PC340\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true ;";
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
			if (sqlCommand != null)
			{
				sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "', [Type] = " + txtType.Text + " WHERE ID = " + ConvertType(txtID.Text);
				sqlConnection.Open();
				int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();

				if (numOfRowsEffected == 1)
				{
					if (txtType.Text == "Đồ ăn" || txtType.Text == "Nước uống")
					{
						// Cập nhật lại dữ liệu trên ListView
						ListViewItem item = lvCategory.SelectedItems[0];
						item.SubItems[1].Text = txtName.Text;
						item.SubItems[2].Text = Check(txtType.Text);

						// Xóa các ô nhập
						txtID.Text = "";
						txtName.Text = "";
						txtType.Text = "";

						//Disable các nút xóa và cập nhật
						btnUpdate.Enabled = false;
						btnDetele.Enabled = false;

						MessageBox.Show("Cập nhật nhóm món ăn thành công.");
					}
					else
						MessageBox.Show("Nhập sai loại món ăn, vui lòng nhập lại!");
				}
				else
					MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
			}
		}

		private void btnDetele_Click(object sender, EventArgs e)
		{
			string connectionString = "server= PC340\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true ;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

			sqlConnection.Open();
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				ListViewItem item = lvCategory.SelectedItems[0];
				lvCategory.Items.Remove(item);

				// Xóa các ô nhập
				txtID.Text = "";
				txtName.Text = "";
				txtType.Text = "";

				// Disable các nút cập nhật và xóa
				btnUpdate.Enabled = false;
				btnDetele.Enabled = false;

				MessageBox.Show("Xóa nhóm món ăn thành công.");
			}
			else
				MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			// Lấy dòng được chọn trong ListView
			ListViewItem item = lvCategory.SelectedItems[0];
			
			// Hiển thị dữ liệu lên TextBox
			txtID.Text = item.Text;
			txtName.Text = item.SubItems[1].Text;
			txtType.Text = Check(item.SubItems[2].Text);

			// Hiển thị nút cập nhật và xóa
			btnUpdate.Enabled = true;
			btnDetele.Enabled = true;
		}

		private string Check(string n)
        {
			if (n == "1") return "Đồ ăn";
			else return "Nước uống";
        }

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
				btnDetele.PerformClick();
			
		}

		private void tsmiViewFood_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "")
			{
			frmFood foodForm = new frmFood();
			foodForm.Show(this);
				foodForm.LoadFood(Convert.ToInt32(txtID.Text));
			}
		}
	}
}
