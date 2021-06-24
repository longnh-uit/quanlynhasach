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
    public partial class Form_FinishOrder : Form
    {
        int tongTien, thanhToan, tienTra;
        string hoTen, sodienthoai;
        DateTime ngay;
        public Form_FinishOrder(int uc_tongTien, string uc_hoten, string uc_sodienthoai, DateTime date)
        {
            InitializeComponent();
            tongTien = uc_tongTien;
            thanhToan = uc_tongTien;
            hoTen = uc_hoten;
            sodienthoai = uc_sodienthoai;
            ngay = date;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form_FinishOrder_Load(object sender, EventArgs e)
        {
            txtBoxTongtien.Text = tongTien.ToString();
            txtBoxSotienphaitra.Text = tongTien.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ghi vào CSDL
            using (SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString))
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "insert into HOADON values(@hoten, @sdt, @ngay, @tongtien, @sotientra)";
                command.Parameters.AddWithValue("@hoten", hoTen);
                command.Parameters.AddWithValue("@sdt", sodienthoai);
                command.Parameters.AddWithValue("@ngay", ngay);
                command.Parameters.AddWithValue("@tongtien", tongTien);
                command.Parameters.AddWithValue("@sotientra", tienTra);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Ghi hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBoxSotientra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_FinishOrder_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxSotiennhan_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSotiennhan.Text != "") tienTra = int.Parse(txtBoxSotiennhan.Text);
            else tienTra = 0;
            lblGiatritienthua.Text = (tienTra - thanhToan).ToString();

        }

        private void txtBoxSotiennhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxGiamgia_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxGiamgia.Text != "")
                thanhToan = (int)(tongTien - tongTien * 0.01 * int.Parse(txtBoxGiamgia.Text));
            else thanhToan = tongTien;
            txtBoxSotienphaitra.Text = thanhToan.ToString();
        }
    }
}
