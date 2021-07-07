using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Forms.UserControls
{
    public partial class UC_Phieutratien : UserControl
    {
        SqlDataAdapter sda;
        DataSet kh;
        SqlCommandBuilder scb;
        public UC_Phieutratien()
        {
            InitializeComponent();
        }

        private void LoadKH()
        {
            Globals.sqlcon.Open();
            string query = "select MaKH, TenKH, DiaChi, DienThoai, Email, SoTienNo from KHACHHANG";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(com);
            kh = new DataSet();
            sda.Fill(kh, "KhachHang_Details");
            Globals.sqlcon.Close();
            dgvKhachHang.DataSource = kh.Tables[0];
            dgvKhachHang.Columns["MaKH"].Visible = false;
        }

        private void UC_Phieutratien_Load(object sender, EventArgs e)
        {
            LoadKH();
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
            // Thực hiện nếu có item được chọn ở bảng khách hàng
            if (dgvKhachHang.SelectedCells.Count > 0)
            {
                DataGridViewRow row_no = dgvKhachHang.Rows[dgvKhachHang.SelectedCells[0].RowIndex];
                int no = int.Parse(row_no.Cells[5].Value.ToString());
                if (no > 0)
                {
                    using (Form_Thutien uf = new Form_Thutien(dgvKhachHang.Rows[dgvKhachHang.SelectedCells[0].RowIndex]))
                    {
                        uf.ShowDialog();
                        LoadKH();
                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng không nợ", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            //SQL
            //LỌC THEO TEXTBOX RỒI CHO VÀO DATAGRID

            string searchStr = "";
            if (txtBoxHoten.Text != "") searchStr += "TenKH LIKE '%" + txtBoxHoten.Text + "%' AND ";
            if (txtBoxDiachi.Text != "") searchStr += "DiaChi LIKE '%" + txtBoxDiachi.Text + "%' AND ";
            if (txtBoxSDT.Text != "") searchStr += "DienThoai LIKE '%" + txtBoxSDT.Text + "%' AND ";
            if (txtBoxEmail.Text != "") searchStr += "Email LIKE '%" + txtBoxEmail.Text + "%' AND ";
            if (searchStr.Length != 0) searchStr = searchStr.Substring(0, searchStr.Length - 5);
            kh.Tables[0].DefaultView.RowFilter = searchStr;

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
            txtBoxHoten.Text = "";
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.sqlcon.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(kh, "Khachhang_Details");
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (chonDuongDan.ShowDialog() == DialogResult.OK)
            {
                string saveLocation = chonDuongDan.FileName;

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Không thể sử dụng thư viện Excel", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Excel.Range row1_TieuDe_DanhSachSach = ws.get_Range("A1", "F1");
                row1_TieuDe_DanhSachSach.Merge();
                row1_TieuDe_DanhSachSach.Font.Size = fontSizeTieuDe;
                row1_TieuDe_DanhSachSach.Font.Name = fontName;
                row1_TieuDe_DanhSachSach.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_DanhSachSach.Value2 = "Thông tin khách hàng";

                //Tạo Ô Số Thứ Tự (STT)
                Excel.Range row2_STT = ws.get_Range("A2", "A2");//Cột A dòng 2
                row2_STT.Font.Size = fontSizeTenTruong;
                row2_STT.Font.Name = fontName;
                row2_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_STT.Value2 = "STT";

                //Tạo Ô Tên sách
                Excel.Range row2_HoTen = ws.get_Range("B2", "B2");//Cột B dòng 2
                row2_HoTen.Font.Size = fontSizeTenTruong;
                row2_HoTen.Font.Name = fontName;
                row2_HoTen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_HoTen.Value2 = "Họ tên";

                //Tạo Ô Thể loại
                Excel.Range row2_DiaChi = ws.get_Range("C2", "C2");//Cột C dòng 2
                row2_DiaChi.Font.Size = fontSizeTenTruong;
                row2_DiaChi.Font.Name = fontName;
                row2_DiaChi.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_DiaChi.Value2 = "Địa chỉ";

                //Tạo Ô Tác giả
                Excel.Range row2_SDT = ws.get_Range("D2", "D2");//Cột D dòng 2
                row2_SDT.Font.Size = fontSizeTenTruong;
                row2_SDT.Font.Name = fontName;
                row2_SDT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_SDT.Value2 = "Số điện thoại";

                //Tạo Ô Số lượng
                Excel.Range row2_Email = ws.get_Range("E2", "E2");//Cột E dòng 2
                row2_Email.Font.Size = fontSizeTenTruong;
                row2_Email.Font.Name = fontName;
                row2_Email.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_Email.Value2 = "Email";

                Excel.Range row2_TienNo = ws.get_Range("F2", "F2");//Cột F dòng 2
                row2_TienNo.Font.Size = fontSizeTenTruong;
                row2_TienNo.Font.Name = fontName;
                row2_TienNo.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TienNo.Value2 = "Số tiền nợ";


                //Tô nền vàng các cột tiêu đề:
                Excel.Range row2_CotTieuDe = ws.get_Range("A2", "F2");
                //nền vàng
                row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row2_CotTieuDe.Font.Bold = true;
                //chữ đen
                row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2; // dữ liệu bắt đầu từ dòng số 3 trong file Excel
                foreach (DataRow sach in kh.Tables[0].Rows)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, sach[1], sach[2], sach[3], sach[4], sach[5] };
                    Excel.Range rowData = ws.get_Range("A" + row, "F" + row); // Lấy dòng thứ row để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;

                }

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "F" + row));
                ws.get_Range("A1", "F" + row).Columns.AutoFit();

                //Lưu file
                wb.SaveAs(saveLocation);

                //Đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BorderAround(Excel.Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvKhachHang.SelectedRows)
            {
                if (Convert.ToInt32(item.Cells[5].Value) > 0)
                {
                    if (MessageBox.Show("Khách hàng này vẫn còn nợ, bạn có chắc muốn xoá khách hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        dgvKhachHang.Rows.RemoveAt(item.Index);
                    return;
                }
                else dgvKhachHang.Rows.RemoveAt(item.Index);
            }
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                using frmPhieuthu frm = new frmPhieuthu(Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells["MaKH"].Value));
                frm.ShowDialog();
            }
        }
    }
}
