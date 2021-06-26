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
    public partial class UC_Nhansu : UserControl
    {
        SqlDataAdapter sda;
        DataSet nhanvien;
        SqlCommandBuilder scb;

        public void LoadNV()
        {
            Globals.sqlcon.Open();
            string query = "select HOTEN, USERNAME, PASSWORD, CHUCVU from ADMINISTRATORS";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(com);
            nhanvien = new DataSet();
            sda.Fill(nhanvien, "NV_Details");
            Globals.sqlcon.Close();
            dgvNhanVien.DataSource = nhanvien.Tables[0];
        }


        public UC_Nhansu()
        {
            InitializeComponent();
        }

        private void UC_Nhansu_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.sqlcon.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(nhanvien, "NV_Details");
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Form_Dangky dk = new Form_Dangky();
            dk.ShowDialog();
            LoadNV();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count == 0) return;

            string role = dgvNhanVien.Rows[dgvNhanVien.SelectedCells[0].RowIndex].Cells["ChucVu"].Value.ToString();
            if (role == "Quản lý")
            {
                MessageBox.Show("Không thể xoá nhân viên này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = dgvNhanVien.Rows[dgvNhanVien.SelectedCells[0].RowIndex].Cells["TenTK"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá nhân viên đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Globals.sqlcon.Open();
                using (SqlCommand command = Globals.sqlcon.CreateCommand())
                {
                    command.CommandText = "delete from ADMINISTRATORS where USERNAME = '" + user + "'";
                    command.ExecuteNonQuery();
                }
                Globals.sqlcon.Close();
                LoadNV();
            }
        }
    }
}

