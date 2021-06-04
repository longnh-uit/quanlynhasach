using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Baocao : UserControl
    {
        public UC_Baocao()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvCongno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "MM/yyyy", "M/yyyy" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnBaocaoton_Click(object sender, EventArgs e)
        {
            if (IsDate(txtBoxThangnam.Text))
            {
                //Báo cáo tồn thì bảng Công nợ ẩn đi
                dgvTon.Visible = true;
                dgvCongno.Visible = false;
                //Dùng SQL đưa vô Datagrid dgvTon
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng định dạng [Tháng]/[Năm]");
            }
        }

        private void btnCongno_Click(object sender, EventArgs e)
        {
            if (IsDate(txtBoxThangnam.Text))
            {
                //Báo cáo công nợ thì bảng Báo cáo tồn ẩn đi
                dgvTon.Visible = false;
                dgvCongno.Visible = true;
                //Dùng SQL đưa dữ liệu vào Datagrid dgvCongno
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng định dạng [Tháng]/[Năm]");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
