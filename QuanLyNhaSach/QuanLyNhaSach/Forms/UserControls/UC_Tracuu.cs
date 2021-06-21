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
        public UC_Tracuu()
        {
            InitializeComponent();
        }

        private void UC_Tracuu_Load(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "select TenSach, TheLoai, TacGia, SoLuong from SACH where SoLuong > 0";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable sach = new DataTable();
            sda.Fill(sach);
            Globals.sqlcon.Close();
            dgvSach.DataSource = sach;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (txtBoxLonnhat.TextLength == 0 && txtBoxNhonhat.TextLength == 0 && txtBoxTacgia.TextLength == 0 && txtBoxTensach.TextLength == 0 && txtBoxTheloai.TextLength == 0)
            {
                if (nhonhat <= lonnhat)
                {
                    MessageBox.Show("Lỗi:\n- Cần nhập ít nhất một mục để tra cứu");
                }
                else
                {
                    MessageBox.Show("Lỗi:\n- Cần nhập ít nhất một mục để tra cứu\n- Mục 'nhỏ nhất' phải bé hơn hoặc bằng mục 'lớn nhất' ");
                }
            }
            else
            {
                if (nhonhat <= lonnhat)
                {
                    //SQL
                    // TRA CỨU TRONG CSDL RỒI CHO VÔ DATAGRID Ở ĐÂY
                    // XONG RỒI HIỆN MESSAGEBOX
                    MessageBox.Show("✓ Tra cứu thành công !");
                }
                else
                {
                    MessageBox.Show("Lỗi:\n- Mục 'nhỏ nhất' phải bé hơn hoặc bằng mục 'lớn nhất' ");
                }
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
    }
}
