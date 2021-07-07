using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Forms
{
    public partial class Form_Dangky : Form
    {
        ComboBox cur;
        public Form_Dangky()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form_Dangky_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string selected = ""; //Chức vụ
            if (cur!=null)
            {
                selected = cur.Text;
            }
            if (txtBoxHoten.TextLength != 0 && txtBoxMatkhau.TextLength != 0 && txtBoxNhaplaimatkhau.TextLength != 0 && txtBoxTentk.TextLength != 0 && selected!="")
            {
                bool isExist = false; //Cần kiểm tra tên tài khoản có trong database chưa, tồn tại rồi thì true, không thì false

                Globals.sqlcon.Open();
                string query = "select * from ADMINISTRATORS where username = '" + txtBoxTentk.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Globals.sqlcon.Close();

                if (dt.Rows.Count != 0) isExist = true;
                if (!isExist && txtBoxMatkhau.Text == txtBoxNhaplaimatkhau.Text)
                {
                    //Thêm vào DATABASE
                    string transact = @"insert into ADMINISTRATORS values(@hoten, @username, @password, @role)";
                    SqlCommand cmd = new SqlCommand(transact, Globals.sqlcon);
                    cmd.Parameters.AddWithValue("@hoten", txtBoxHoten.Text);
                    cmd.Parameters.AddWithValue("@username", txtBoxTentk.Text);
                    cmd.Parameters.AddWithValue("@password", txtBoxMatkhau.Text);
                    cmd.Parameters.AddWithValue("@role", cbBoxChucVu.SelectedItem.ToString());
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();

                    MessageBox.Show("Đăng kí tài khoản thành công!");
                    this.Dispose();
                }
                else
                {
                    if (isExist)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu đã nhập không khớp với nhau!");
                    }
                }
            }
            else {
                MessageBox.Show("Cần nhập tất các các mục!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void logo2_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur = sender as ComboBox;
        }
    }
}
