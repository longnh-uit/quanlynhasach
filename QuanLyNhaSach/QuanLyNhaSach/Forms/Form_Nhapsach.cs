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
    public partial class Form_Nhapsach : Form
    {
        public Form_Nhapsach()
        {
            InitializeComponent();
        }

        private void Form_Nhapsach_Load(object sender, EventArgs e)
        {
            // Tu dong dien ngay hien tai
            txtBoxNgaynhap.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
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

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (lv_nhapSach.Items.Count > 0)
            {
                if (IsDate(txtBoxNgaynhap.Text))
                {
 //                   ListViewItem item = lv_nhapSach.Items[0];

 //                   string transaction = "set  ";
 //                   SqlDataAdapter sda = new SqlDataAdapter(transaction, Globals.sqlcon);
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
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd", "d/M/yyyy", "d/MM/yyyy", "dd/M/yyyy" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtBoxNgaynhap.TextLength > 0 && txtBoxTensach.TextLength > 0 && txtBoxTheloai.TextLength > 0 && txtBoxTacgia.TextLength > 0 && txtBoxSoluong.TextLength > 0 && txtBoxDongianhap.TextLength > 0)
            {
                string[] arr = new string[5];
                ListViewItem itm;
                // them Item vao ListView
                arr[0] = txtBoxTensach.Text;
                arr[1] = txtBoxTheloai.Text;
                arr[2] = txtBoxTacgia.Text;
                arr[3] = txtBoxSoluong.Text;
                arr[4] = txtBoxDongianhap.Text;

                itm = new ListViewItem(arr);
                lv_nhapSach.Items.Add(itm);

                txtBoxTensach.Text = "";
                txtBoxSoluong.Text = "";
                txtBoxTacgia.Text = "";
                txtBoxTheloai.Text = "";
                txtBoxDongianhap.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            { lv_nhapSach.Items.RemoveAt(lv_nhapSach.SelectedIndices[0]); }
            catch
            {
                MessageBox.Show("Chọn Item muốn xóa!");
            }
        }

        private void txtBoxTheloai_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

