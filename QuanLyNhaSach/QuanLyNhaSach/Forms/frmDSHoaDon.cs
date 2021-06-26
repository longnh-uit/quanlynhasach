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
    public partial class frmDSHoaDon : Form
    {
        DataTable hoadon, cthd;
        public frmDSHoaDon()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 0) return;
            lvCTHD.Items.Clear();
            Globals.sqlcon.Open();
            string query = "select TenSach, TheLoai, TacGia, CTHD.SoLuongBan, CTHD.DonGiaBan " +
                "from CTHD inner join SACH on CTHD.MaSach = SACH.MaSach " +
                "where CTHD.MaHD = " + lvHoaDon.SelectedItems[0].SubItems[0].Text;
 
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            cthd = new DataTable();
            sda.Fill(cthd);
            Globals.sqlcon.Close();

            int stt = 0;
            foreach (DataRow dr in cthd.Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(dr["TenSach"].ToString());
                item.SubItems.Add(dr["TheLoai"].ToString());
                item.SubItems.Add(dr["TacGia"].ToString());
                item.SubItems.Add(dr["SoLuongBan"].ToString());
                item.SubItems.Add(dr["DonGiaBan"].ToString());
                lvCTHD.Items.Add(item);
            }

        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "select MaHD, TenKH, DienThoai, NgayHoaDon, TongTien, SoTienTra from HOADON";
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            hoadon = new DataTable();
            sda.Fill(hoadon);
            Globals.sqlcon.Close();

            foreach (DataRow dr in hoadon.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaHD"].ToString());
                item.SubItems.Add(dr["TenKH"].ToString());
                item.SubItems.Add(dr["DienThoai"].ToString());
                item.SubItems.Add(dr["NgayHoaDon"].ToString());
                item.SubItems.Add(dr["TongTien"].ToString());
                item.SubItems.Add(dr["SoTienTra"].ToString());
                lvHoaDon.Items.Add(item);
            }
        }
    }
}
