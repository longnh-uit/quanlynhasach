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
    public partial class Form_Thutien : Form
    {
        private string hoTen, diaChi, dienThoai, email;
        private int soTienNo;
        private readonly int maKH;

        public Form_Thutien(DataGridViewRow kh)
        {
            InitializeComponent();
            hoTen = kh.Cells["TenKH"].Value.ToString();
            diaChi = kh.Cells["DiaChi"].Value.ToString();
            dienThoai = kh.Cells["DienThoai"].Value.ToString();
            email = kh.Cells["Email"].Value.ToString();
            soTienNo = Convert.ToInt32(kh.Cells["SoTienNo"].Value);
            maKH = Convert.ToInt32(kh.Cells["MaKH"].Value);
        }

        private void Form_Thutien_Load(object sender, EventArgs e)
        {
            txtBoxHoten.Text = hoTen;
            txtBoxDiachi.Text = diaChi;
            txtBoxDienthoai.Text = dienThoai;
            txtBoxEmail.Text = email;
            txtBoxTienno.Text = soTienNo.ToString();
        }

        private void txtBoxTienthu_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTienthu.Text == "") txtBoxTiennomoi.Text = txtBoxTienno.Text;
            else txtBoxTiennomoi.Text = (soTienNo - int.Parse(txtBoxTienthu.Text)).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (txtBoxTienthu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Globals.tienthuvuottienno && int.Parse(txtBoxTienthu.Text) > soTienNo)
            {
                MessageBox.Show("Số tiền thu không thể vượt số tiền nợ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Cập nhật CSDl
            Globals.sqlcon.Open();
            using SqlCommand command = Globals.sqlcon.CreateCommand();
            command.CommandText = "update KHACHHANG " +
                "set SoTienNo = SoTienNo - " + txtBoxTienthu.Text;
            command.ExecuteNonQuery();
            Globals.sqlcon.Close();
            MessageBox.Show("Thu tiền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

    }
}
