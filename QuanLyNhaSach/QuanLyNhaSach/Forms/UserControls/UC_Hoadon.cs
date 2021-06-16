using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Hoadon : UserControl
    {
        public UC_Hoadon()
        {
            InitializeComponent();
            txtBoxNgay.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void UC_Hoadon_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            { listView1.Items.RemoveAt(listView1.SelectedIndices[0]); }
            catch
            {
                MessageBox.Show("Chọn Item muốn xóa!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try{
                string soluong = listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
                int sl = int.Parse(soluong);
                sl++;
                soluong = sl.ToString();
                listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = soluong;
            }
            catch {  }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool isEligible = true; // Nếu khách đủ điều kiện thì biến này true, ko thì false (SQL)
            if (isEligible)
            {
                txtBoxNgay.ReadOnly = false;
                txtBoxTensach.ReadOnly = false;
                txtBoxTheloai.ReadOnly = false;
                txtBoxSotientra.ReadOnly = false;
                txtBoxSoluong.ReadOnly = false;
                lblCheck.Visible = false;
            }
            else
            {
                lblCheck.Visible = true; // Hiện "khách ko đủ đk"
            }
        }

        private void txtBoxTensach_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "dd/M/yyyy","d/M/yyyy","d/MM/yyyy" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBoxNgay.TextLength > 0 && txtBoxTensach.TextLength > 0 && txtBoxTheloai.TextLength > 0 && txtBoxHoten.TextLength > 0 && txtBoxSoluong.TextLength > 0 && txtBoxSotientra.TextLength > 0 && txtBoxSodienthoai.TextLength > 0)
            {
                if (IsDate(txtBoxNgay.Text))
                {


                    string[] arr = new string[3];
                    arr[1] = txtBoxSoluong.Text;
                    arr[0] = txtBoxTensach.Text;
                    arr[2] = ""; //Cần lấy giá tiền từ CSDL;
                    ListViewItem lst = new ListViewItem(arr);
                    listView1.Items.Add(lst);
                    txtBoxTensach.Text = "";
                    txtBoxSoluong.Text = "";
                    txtBoxSotientra.Text = "";
                    txtBoxTheloai.Text = "";
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Form_FinishOrder uf = new Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }

        private void lblCheck_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            txtBoxNgay.ReadOnly = true;
            txtBoxTensach.ReadOnly = true;
            txtBoxTheloai.ReadOnly = true;
            txtBoxSotientra.ReadOnly = true;
            txtBoxSoluong.ReadOnly = true;
            txtBoxTensach.Text = "";
            txtBoxSoluong.Text = "";
            txtBoxSotientra.Text = "";
            txtBoxTheloai.Text = "";
            txtBoxNgay.Text = "";

        }

        private void txtBoxSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxSotientra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxSotientra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxHoten_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxNgay.ReadOnly = true;
            txtBoxTensach.ReadOnly = true;
            txtBoxTheloai.ReadOnly = true;
            txtBoxSotientra.ReadOnly = true;
            txtBoxSoluong.ReadOnly = true;
            txtBoxTensach.Text = "";
            txtBoxSoluong.Text = "";
            txtBoxSotientra.Text = "";
            txtBoxTheloai.Text = "";
            txtBoxNgay.Text = "";
        }

        private void txtBoxHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            try
            {
                string soluong = listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
                int sl = int.Parse(soluong);
                sl--;
                if (sl >= 1)
                {
                    soluong = sl.ToString();
                    listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text = soluong;
                }
            }
            catch { }
        }

        private void txtBoxSodienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxTheloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
