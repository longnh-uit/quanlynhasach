﻿using System;
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
            txtBoxTensach.LostFocus += txtBoxTensach_LostFocus;
        }

        private void txtBoxTensach_LostFocus(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "select * from SACH where TenSach = N'" + txtBoxTensach.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtBoxTheloai.Text = dr["TheLoai"].ToString();
                    txtBoxTacgia.Text = dr["TacGia"].ToString();
                    txtBoxDongianhap.Text = dr["DonGiaNhap"].ToString();
                }
            }
            Globals.sqlcon.Close();

        }

        private void Form_Nhapsach_Load(object sender, EventArgs e)
        {
            // Tu dong dien ngay hien tai
            dtpNgay.Value = System.DateTime.Now;
            dtpNgay.MaxDate = System.DateTime.Now;

            // Autofill Tensach
            AutoCompleteStringCollection ascs = new AutoCompleteStringCollection();
            Globals.sqlcon.Open();
            using (SqlCommand command = Globals.sqlcon.CreateCommand())
            {
                command.CommandText = "select * from SACH";
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ascs.Add(dr["TenSach"].ToString());
                }
            }
            txtBoxTensach.AutoCompleteCustomSource = ascs;
            Globals.sqlcon.Close();
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
                    // Ghi vào CSDL
                    Globals.sqlcon.Open();
                    using (SqlCommand command = new SqlCommand("dbo.InsertNhapSach", Globals.sqlcon))
                    {
                        command.Parameters.AddWithValue("@NgayNhap", dtpNgay.Value);
                        command.Parameters.Add("@TenSach", SqlDbType.NVarChar);
                        command.Parameters.Add("@TheLoai", SqlDbType.NVarChar);
                        command.Parameters.Add("@TacGia", SqlDbType.NVarChar);
                        command.Parameters.Add("@SoLuong", SqlDbType.Int);
                        command.Parameters.Add("@DonGiaNhap", SqlDbType.Int);

                        foreach (ListViewItem item in lv_nhapSach.Items)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters["@TenSach"].Value = item.SubItems[0].Text;
                            command.Parameters["@TheLoai"].Value = item.SubItems[1].Text;
                            command.Parameters["@TacGia"].Value = item.SubItems[2].Text;
                            command.Parameters["@SoLuong"].Value = int.Parse(item.SubItems[3].Text);
                            command.Parameters["@DonGiaNhap"].Value = int.Parse(item.SubItems[4].Text);
                            command.ExecuteNonQuery();
                        }   
                        

                    }
                    if (cboxXuat.Checked)
                    {
                        
                    }
                    Globals.sqlcon.Close();

                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lv_nhapSach.Items.Clear();
            }
            else
            {
                MessageBox.Show("Danh sách nhập sách trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtBoxTensach.TextLength > 0 && txtBoxTheloai.TextLength > 0 && txtBoxTacgia.TextLength > 0 && txtBoxSoluong.TextLength > 0 && txtBoxDongianhap.TextLength > 0)
            {
                string[] arr = new string[5];
                ListViewItem itm;
                int soLuongTon;

                Globals.sqlcon.Open();
                using (SqlCommand command = Globals.sqlcon.CreateCommand())
                {
                    command.CommandText = "Select SoLuong from SACH " +
                        "where TenSach = @tensach and TheLoai = @theloai and TacGia = @tacgia";
                    command.Parameters.AddWithValue("@tensach", txtBoxTensach.Text);
                    command.Parameters.AddWithValue("@theloai", txtBoxTheloai.Text);
                    command.Parameters.AddWithValue("@tacgia", txtBoxTacgia.Text);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soLuongTon = Convert.ToInt32(reader[0]);
                        }
                        else soLuongTon = 0;
                    }
                }
                Globals.sqlcon.Close();

                // Kiểm tra số lượng tồn có đạt tiêu chuẩn
                if (soLuongTon > Globals.Luongtonmax)
                {
                    MessageBox.Show("Không thể nhập sách có lượng tồn trên " + Globals.Luongtonmax.ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra số lượng nhập có đạt tiêu chuẩn
                if (int.Parse(txtBoxSoluong.Text) < Globals.Slmin)
                {
                    MessageBox.Show("Số lượng sách nhập phải lớn hơn hoặc bằng " + Globals.Slmin.ToString(), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

