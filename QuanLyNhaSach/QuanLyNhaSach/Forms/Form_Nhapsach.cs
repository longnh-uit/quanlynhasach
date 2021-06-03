using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Form_Nhapsach : Form
    {
        public Form_Nhapsach()
        {
            InitializeComponent();
        }

        private void Form_Nhapsach_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxNgaynhap.TextLength > 0 && txtBoxTensach.TextLength > 0 && txtBoxTheloai.TextLength > 0 && txtBoxTacgia.TextLength > 0 && txtBoxSoluong.TextLength > 0 && txtBoxDongianhap.TextLength > 0)
            {
                if (IsDate(txtBoxNgaynhap.Text))
                {


                    string[] arr = new string[2];
                    arr[1] = txtBoxSoluong.Text;
                    arr[0] = txtBoxTensach.Text;
                    ListViewItem lst = new ListViewItem(arr);
                    listView1.Items.Add(lst);
                    txtBoxTensach.Text = "";
                    txtBoxSoluong.Text = "";
                    txtBoxTacgia.Text = "";
                    txtBoxTheloai.Text = "";
                    txtBoxDongianhap.Text = "";
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ !");
                }
            }
            else
            {
                MessageBox.Show("Cần phải nhập tất cả các mục !");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBoxNgaynhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSoluong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtBoxDongianhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            { listView1.Items.RemoveAt(listView1.SelectedIndices[0]); }
            catch
            {
                MessageBox.Show("Chọn Item muốn xóa!");
            }
        }
    }

}

