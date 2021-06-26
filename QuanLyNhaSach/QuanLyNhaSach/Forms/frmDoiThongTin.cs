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
    public partial class frmDoiThongTin : Form
    {
        public frmDoiThongTin()
        {
            InitializeComponent();
        }

        private void frmDoiThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtBoxMKCu.Text == "" || txtBoxMatkhau.Text == "" || txtBoxNhaplaimatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (txtBoxMatkhau.Text != txtBoxNhaplaimatkhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "update ADMINISTRATORS " +
                    "set PASSWORD = '" + txtBoxMatkhau.Text + "' where USERNAME = '" + Globals.username + "'";
                command.ExecuteNonQuery();
            }
            Globals.sqlcon.Close();
            MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
