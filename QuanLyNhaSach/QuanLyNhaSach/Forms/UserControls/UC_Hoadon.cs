using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Hoadon : UserControl
    {
        DataSet sach;
        DataView dv;
        bool dontHandle = false;
        int tongTien, maHD;
        DateTime fromDateValue;

        public class cSach
        {
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TheLoai { get; set; }
            public string TacGia { get; set; }
            public int SoLuong { get; set; }
            public int DonGiaNhap { get; set; }
        }

        public List<cSach> CSachList(DataTable dt)
        {
            List<cSach> sachList = new List<cSach>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cSach csach = new cSach();
                csach.MaSach = dt.Rows[i]["MaSach"].ToString();
                csach.TenSach = dt.Rows[i]["TenSach"].ToString();
                csach.TheLoai = dt.Rows[i]["TheLoai"].ToString();
                csach.TacGia = dt.Rows[i]["TacGia"].ToString();
                csach.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"]);
                csach.DonGiaNhap = Convert.ToInt32(dt.Rows[i]["DonGiaNhap"]);
                sachList.Add(csach);
            }
            return sachList;
        }

        public UC_Hoadon()
        {
            InitializeComponent();
            txtBoxNgay.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            txtBoxHoten.Font = new Font("Segoe UI", 10);
            txtBoxSodienthoai.Font = new Font("Segoe UI", 10);
            txtBoxNgay.Font = new Font("Segoe UI", 10);
            cbTenSach.Font = new Font("Segoe UI", 10);
            cbTacGia.Font = new Font("Segoe UI", 10);
            cbTheLoai.Font = new Font("Segoe UI", 10);
            txtBoxSoluong.Font = new Font("Segoe UI", 10);
            txtBoxSotientra.Font = new Font("Segoe UI", 10);

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
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
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

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            bool isEligible = true; // Biến kiểm tra điều kiện khách hàng
            Globals.sqlcon.Open();
            // Kiểm tra nợ của khách hàng

            string query = "select * from KHACHHANG where TenKH = N'" + txtBoxHoten.Text + "' and DienThoai = '" + txtBoxSodienthoai.Text + "' and SoTienNo > " + Globals.Nomax.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable kh = new DataTable();
            sda.Fill(kh);
            Globals.sqlcon.Close();

            if (kh.Rows.Count != 0)
                isEligible = false;
            if (isEligible)
            {
                txtBoxNgay.ReadOnly = false;
                cbTenSach.Enabled = true;
                cbTheLoai.Enabled = true;
                cbTacGia.Enabled = true;
                txtBoxSoluong.ReadOnly = false;
                lblCheck.Visible = false;
                btnDoiThongTin.Enabled = true;
                txtBoxHoten.ReadOnly = true;
                txtBoxSodienthoai.ReadOnly = true;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            int soLuongBan, soLuongTon;
            if (txtBoxNgay.TextLength > 0 && cbTenSach.SelectedItem != null && cbTheLoai.SelectedItem != null && txtBoxHoten.TextLength > 0 && txtBoxSoluong.TextLength > 0 && txtBoxSotientra.TextLength > 0 && txtBoxSodienthoai.TextLength > 0)
            {
                if (IsDate(txtBoxNgay.Text))
                {
                    // Nếu đã có sách trong list view thì tăng số lượng
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[5].Text == cbTenSach.SelectedValue.ToString())
                        {
                            soLuongBan = int.Parse(item.SubItems[3].Text) + int.Parse(txtBoxSoluong.Text);
                            soLuongTon = sach.Tables[0].Select("MaSach = " + item.SubItems[5].Text)[0].Field<int>("SoLuong");
                            if (soLuongTon - soLuongBan < Globals.Tonbanmin)
                            {
                                MessageBox.Show("Lượng tồn sau khi bán của đầu sách không thể bé hơn 20", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                                return;
                            }
                            item.SubItems[3].Text = soLuong.ToString();
                            dontHandle = true;
                            txtBoxSoluong.Text = "";
                            txtBoxSotientra.Text = "";
                            cbTheLoai.SelectedItem = null;
                            cbTacGia.SelectedItem = null;
                            dontHandle = false;
                            cbTenSach.DataSource = CSachList(sach.Tables[0]);
                            cbTenSach.SelectedItem = null;
                            return;
                        }
                    }

                    // Nếu k có sách trong list view thì thêm
                    soLuongBan = int.Parse(txtBoxSoluong.Text);
                    soLuongTon = sach.Tables[0].Select("MaSach = " + cbTenSach.SelectedValue.ToString())[0].Field<int>("SoLuong");
                    if (soLuongTon - soLuongBan < Globals.Tonbanmin)
                    {
                        MessageBox.Show("Lượng tồn sau khi bán của đầu sách không thể bé hơn 20", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        return;
                    }

                    string[] arr = new string[6];
                    arr[0] = cbTenSach.Text;
                    arr[1] = cbTheLoai.Text;
                    arr[2] = cbTacGia.Text;
                    arr[3] = txtBoxSoluong.Text;
                    arr[4] = txtBoxSotientra.Text;
                    arr[5] = cbTenSach.SelectedValue.ToString();
                    ListViewItem lst = new ListViewItem(arr);
                    listView1.Items.Add(lst);
                    dontHandle = true;
                    txtBoxSoluong.Text = "";
                    txtBoxSotientra.Text = "";
                    cbTheLoai.SelectedItem = null;
                    cbTacGia.SelectedItem = null;
                    dontHandle = false;
                    cbTenSach.DataSource = CSachList(sach.Tables[0]);
                    cbTenSach.SelectedItem = null;

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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tongTien = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                tongTien += int.Parse(item.SubItems[4].Text) * int.Parse(item.SubItems[3].Text);
            }
            using (Form_FinishOrder uf = new Form_FinishOrder(tongTien, txtBoxHoten.Text, txtBoxSodienthoai.Text, fromDateValue))
            {
                uf.ShowDialog();
                maHD = uf.maHD;
                if (maHD != -1) VietCTHD();
            }
        }

        private void VietCTHD()
        {
            using (SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString))
            using (SqlCommand command = con.CreateCommand())
            {
                string insert = "insert into CTHD values(@mahd, @masach, @sl, @dongia)",
                    modify = "update SACH " +
                    "set SoLuong = SoLuong - @sl where MaSach = @masach";

                // định nghĩa các tham số trước
                command.Parameters.Add("@mahd", SqlDbType.Int);
                command.Parameters.Add("@masach", SqlDbType.Int);
                command.Parameters.Add("@sl", SqlDbType.Int);
                command.Parameters.Add("@dongia", SqlDbType.Int);

                con.Open();
                foreach (ListViewItem item in listView1.Items)
                {
                    command.CommandText = insert;
                    command.Parameters["@mahd"].Value = maHD;
                    command.Parameters["@masach"].Value = int.Parse(item.SubItems[5].Text);
                    command.Parameters["@sl"].Value = int.Parse(item.SubItems[3].Text);
                    command.Parameters["@dongia"].Value = int.Parse(item.SubItems[4].Text);

                    command.ExecuteNonQuery();

                    command.CommandText = modify;
                    command.ExecuteNonQuery();

                }
                con.Close();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Hoadon_Load(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            string query = "select MaSach, TenSach, TheLoai, TacGia, SoLuong, DonGiaNhap from SACH where SoLuong > 0";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sach = new DataSet();
            sda.Fill(sach, "Sach_Details");
            Globals.sqlcon.Close();

            cbTenSach.DataSource = CSachList(sach.Tables[0]);
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.SelectedIndex = -1;

            cbTheLoai.Items.Add("Tất cả");
            cbTacGia.Items.Add("Tất cả");
            for (int i = 0; i < sach.Tables[0].Rows.Count; ++i)
            {
                var val = sach.Tables[0].Rows[i]["TheLoai"].ToString();

                if (!cbTheLoai.Items.Contains(val))
                    cbTheLoai.Items.Add(val);
            }

            for (int i = 0; i < sach.Tables[0].Rows.Count; ++i)
            {
                var val = sach.Tables[0].Rows[i]["TacGia"].ToString();

                if (!cbTacGia.Items.Contains(val))
                    cbTacGia.Items.Add(val);
            }

        }

        private void cbTenSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strDonGiaNhap = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["DonGiaNhap"].ToString();
            int DonGiaBan = (int)(int.Parse(strDonGiaNhap) * 1.05f);
            dontHandle = true;
            if (cbTheLoai.SelectedIndex == -1)
                cbTheLoai.Text = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["TheLoai"].ToString();
            if (cbTacGia.SelectedIndex == -1)
                cbTacGia.Text = sach.Tables[0].Select("MaSach = '" + cbTenSach.SelectedValue.ToString() + "'")[0]["TacGia"].ToString();
            txtBoxSotientra.Text = DonGiaBan.ToString();
            dontHandle = false;
        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontHandle) return;
            string expr = "";
            if (cbTheLoai.SelectedItem.ToString() != "Tất cả")
                expr += "TheLoai = '" + cbTheLoai.SelectedItem.ToString() + "' AND ";
            if (cbTacGia.SelectedItem != null && cbTacGia.SelectedItem.ToString() != "Tất cả")
                expr += "TacGia = '" + cbTacGia.SelectedItem.ToString() + "' AND ";
            if (expr.Length != 0)
                expr = expr.Substring(0, expr.Length - 5);
            cbTenSach.SelectedItem = null;

            dv = new DataView(sach.Tables[0])
            {
                RowFilter = expr
            };
            cbTenSach.DataSource = dv.ToTable().Rows.Cast<DataRow>().Select(r => new cSach {
                MaSach = r["MaSach"].ToString(),
                TenSach = r["TenSach"].ToString(),
                TheLoai = r["TheLoai"].ToString(),
                TacGia = r["TacGia"].ToString(),
                SoLuong = r.Field<int>("SoLuong"),
                DonGiaNhap = r.Field<int>("DonGiaNhap")
            })
            .ToList<cSach>();
            cbTenSach.SelectedIndex = -1;
            txtBoxSotientra.Text = null;
        }

        private void cbTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontHandle) return;
            string expr = "";
            if (cbTheLoai.SelectedItem != null && cbTheLoai.SelectedItem.ToString() != "Tất cả")
                expr += "TheLoai = '" + cbTheLoai.SelectedItem.ToString() + "' AND ";
            if (cbTacGia.SelectedItem.ToString() != "Tất cả")
                expr += "TacGia = '" + cbTacGia.SelectedItem.ToString() + "' AND ";
            if (expr.Length != 0)
                expr = expr.Substring(0, expr.Length - 5);
            cbTenSach.SelectedItem = null;

            dv = new DataView(sach.Tables[0])
            {
                RowFilter = expr
            };
            cbTenSach.DataSource = dv.ToTable().Rows.Cast<DataRow>().Select(r => new cSach {
                MaSach = r["MaSach"].ToString(),
                TenSach = r["TenSach"].ToString(),
                TheLoai = r["TheLoai"].ToString(),
                TacGia = r["TacGia"].ToString(),
                SoLuong = r.Field<int>("SoLuong"),
                DonGiaNhap = r.Field<int>("DonGiaNhap")
            })
            .ToList<cSach>();
            cbTenSach.SelectedIndex = -1;
            txtBoxSotientra.Text = null;
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            dontHandle = true;
            txtBoxNgay.ReadOnly = true;
            cbTenSach.Enabled = false;
            cbTheLoai.Enabled = false;
            cbTacGia.Enabled = false;
            txtBoxSoluong.ReadOnly = true;
            cbTenSach.SelectedItem = null;
            txtBoxSoluong.Text = "";
            txtBoxSotientra.Text = "";
            cbTheLoai.SelectedItem = null;
            cbTacGia.SelectedItem = null;
            listView1.Items.Clear();
            dontHandle = false;

            txtBoxHoten.ReadOnly = false;
            txtBoxSodienthoai.ReadOnly = false;
            btnDoiThongTin.Enabled = false;
        }
    }
}
