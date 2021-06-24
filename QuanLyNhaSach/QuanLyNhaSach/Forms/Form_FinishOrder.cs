using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace QuanLyNhaSach.Forms
{
    public partial class Form_FinishOrder : Form
    {
        public int maHD;
        private int tongTien, thanhToan, tienTra;
        private string hoTen, sodienthoai, diaChi, email;
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
            if (tienTra - thanhToan < 0)
            {
                Globals.sqlcon.Open();

                // Kiểm tra khách hàng có trong CSDL
                string query = "select * from KHACHHANG where TenKH = N'" + hoTen + "' and DienThoai = '" + sodienthoai + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Nếu có thông tin khách hàng trong CSDL
                if (dt.Rows.Count != 0)
                {
                    using SqlCommand command = Globals.sqlcon.CreateCommand();
                    command.CommandText = "update KHACHHANG " +
                        "set SoTienNo = SoTienNo + " + (thanhToan - tienTra).ToString();
                    command.ExecuteNonQuery();
                }
                else
                {
                    using (frmThongTinThem form = new frmThongTinThem())
                    {
                        form.ShowDialog();
                        if (form.cancel == true) return;
                        diaChi = form.diaChi;
                        email = form.email;
                    }
                    using SqlCommand command = Globals.sqlcon.CreateCommand();
                    command.CommandText = "insert into KHACHHANG values(@ten, @diachi, @sodt, @email, @tienno)";
                    command.Parameters.AddWithValue("@ten", hoTen);
                    command.Parameters.AddWithValue("@diachi", diaChi);
                    command.Parameters.AddWithValue("@sodt", sodienthoai);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@tienno", thanhToan - tienTra);
                    command.ExecuteNonQuery();
                }
                Globals.sqlcon.Close();
                


            }

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

                command.CommandText = "select max(MaHD) from HOADON";
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                maHD = dr.GetInt32(0);
                con.Close();
            }

            
            MessageBox.Show("Ghi hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maHD = -1;
            Dispose();
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
