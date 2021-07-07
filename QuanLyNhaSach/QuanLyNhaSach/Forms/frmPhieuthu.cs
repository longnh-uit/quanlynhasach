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
    public partial class frmPhieuthu : Form
    {
        private int makh;
        public frmPhieuthu(int imakh)
        {
            makh = imakh;
            InitializeComponent();
        }

        private void frmPhieuthu_Load(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "select P.MaPhieuThu, K.TenKH, K.DienThoai, P.NgayThuTien, P.SoTienThu from PHIEUTHUTIEN P inner join KHACHHANG K on P.MaKH = K.MaKH where K.MaKH = " + makh.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable phieuthu = new DataTable();
            sda.Fill(phieuthu);
            Globals.sqlcon.Close();

            foreach (DataRow dr in phieuthu.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaPhieuThu"].ToString());
                item.SubItems.Add(dr["TenKH"].ToString());
                item.SubItems.Add(dr["DienThoai"].ToString());
                item.SubItems.Add(dr["NgayThuTien"].ToString());
                item.SubItems.Add(dr["SoTienThu"].ToString());
                lvPhieuThu.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
