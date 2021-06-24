using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Phieutratien : UserControl
    {
        SqlDataAdapter sda;
        DataSet kh;
        SqlCommandBuilder scb;
        public UC_Phieutratien()
        {
            InitializeComponent();
        }

        private void LoadKH()
        {
            Globals.sqlcon.Open();
            string query = "select MaKH, TenKH, DiaChi, DienThoai, Email, SoTienNo from KHACHHANG";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(com);
            kh = new DataSet();
            sda.Fill(kh, "KhachHang_Details");
            Globals.sqlcon.Close();
            dgvKhachHang.DataSource = kh.Tables[0];
            dgvKhachHang.Columns["MaKH"].Visible = false;
        }

        private void UC_Phieutratien_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Thực hiện nếu có item được chọn ở bảng khách hàng
            if (dgvKhachHang.SelectedCells.Count > 0)
            {
                using (Form_Thutien uf = new Form_Thutien(dgvKhachHang.Rows[dgvKhachHang.SelectedCells[0].RowIndex]))
                {
                    uf.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn thu tiền");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTracuu_Click_1(object sender, EventArgs e)
        {
            //SQL
            //LỌC THEO TEXTBOX RỒI CHO VÀO DATAGRID

            string searchStr = "";
            if (txtBoxHoten.Text != "") searchStr += "TenKH LIKE '%" + txtBoxHoten.Text + "%' AND ";
            if (txtBoxDiachi.Text != "") searchStr += "DiaChi LIKE '%" + txtBoxDiachi.Text + "%' AND ";
            if (txtBoxSDT.Text != "") searchStr += "DienThoai LIKE '%" + txtBoxSDT.Text + "%' AND ";
            if (txtBoxEmail.Text != "") searchStr += "Email LIKE '%" + txtBoxEmail.Text + "%' AND ";
            if (searchStr.Length != 0) searchStr = searchStr.Substring(0, searchStr.Length - 5);
            kh.Tables[0].DefaultView.RowFilter = searchStr;

        }

        private void txtBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBoxEmail.Text = "";
            txtBoxHoten.Text = "";
            txtBoxDiachi.Text = "";
            txtBoxSDT.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Click chọn khách hàng ở bảng bên trái rồi click 'THU TIỀN' để thu tiền");
        }

        private void txBoxHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.sqlcon.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(kh, "Khachhang_Details");
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadKH();
        }
    }
}
