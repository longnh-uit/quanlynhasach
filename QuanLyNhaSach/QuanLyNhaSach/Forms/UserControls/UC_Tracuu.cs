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

    public partial class UC_Tracuu : UserControl
    {
        SqlDataAdapter sda;
        DataSet sach;
        SqlCommandBuilder scb;
        public UC_Tracuu()
        {
            InitializeComponent();
        }

        public void LoadSach()
        {
            Globals.sqlcon.Open();
            string query = "select MaSach, TenSach, TheLoai, TacGia, SoLuong from SACH where SoLuong > 0";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(com);
            sach = new DataSet();
            sda.Fill(sach, "Sach_Details");
            Globals.sqlcon.Close();
            dgvSach.DataSource = sach.Tables[0];
            dgvSach.Columns["MaSach"].Visible = false;
        }

        private void UC_Tracuu_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnNhapsach_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e) {
            try
            {
                Globals.sqlcon.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(sach, "Sach_Details");
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.sqlcon.Close();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            //Xuât kết quả tra cứu ra DATAGRIDVIEW
            int nhonhat;
            int lonnhat;
            try
            {
                nhonhat = int.Parse(txtBoxNhonhat.Text);
            }
            catch
            {
                nhonhat = 1;
            }
            try
            {
                lonnhat = int.Parse(txtBoxLonnhat.Text);
            }
            catch
            {
                //SQL
                lonnhat = 99999999; // SỐ LƯỢNG LỚN NHẤT CỦA SÁCH CÓ TRONG CƠ SỞ DỮ LIỆu;
            }

            if (nhonhat > lonnhat)
            {
                MessageBox.Show("Lỗi: Mục 'nhỏ nhất' phải bé hơn hoặc bằng mục 'lớn nhất' ");
            }
            else
            {
                string searchStr = "";
                if (txtBoxTensach.TextLength != 0) searchStr += "TenSach LIKE '%" + txtBoxTensach.Text + "%' AND ";
                if (txtBoxTacgia.TextLength != 0) searchStr += "TacGia LIKE '%" + txtBoxTacgia.Text + "%' AND ";
                if (txtBoxTheloai.TextLength != 0) searchStr += "TheLoai LIKE '%" + txtBoxTheloai.Text + "%' AND ";
                if (txtBoxLonnhat.TextLength != 0) searchStr += "SoLuong <= " + txtBoxLonnhat.Text + " AND ";
                if (txtBoxNhonhat.TextLength != 0) searchStr += "SoLuong >= " + txtBoxNhonhat.Text + " AND ";
                if (searchStr.Length != 0) searchStr = searchStr.Substring(0, searchStr.Length - 5);
                sach.Tables[0].DefaultView.RowFilter = searchStr;

            }

        }

        private void txtBoxNhonhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxLonnhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLonnhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSach.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); 
        }

        private void btnHoantac_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            using (Form_Nhapsach ns = new Form_Nhapsach())
            {
                ns.ShowDialog();
            }
        }
    }
}
