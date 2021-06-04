using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Phieutratien : UserControl
    {
        public UC_Phieutratien()
        {
            InitializeComponent();
        }

        private void UC_Phieutratien_Load(object sender, EventArgs e)
        {

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
            bool isSelected = true; //Phải chọn ở bảng bên trái thì mới được thu tiền ko chọn thì -> false;
            //Thông tin khách hàng được chọn được đưa vào Form_Thutien sẵn, người dùng chỉ cần nhấn vào thêm tiền thu
            if (isSelected)
            {
                using (Form_Thutien uf = new Form_Thutien())
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
            if (txtBoxDiachi.TextLength == 0 && txBoxHoten.TextLength == 0 && txtBoxEmail.TextLength == 0 && txtBoxSDT.TextLength == 0)
            {
                MessageBox.Show("Cần điền ít nhất một mục");
            }
            else
            {
                //SQL
                //LỌC THEO TEXTBOX RỒI CHO VÀO DATAGRID
                MessageBox.Show("Thành công!");
            }
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
            txBoxHoten.Text = "";
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
    }
}
