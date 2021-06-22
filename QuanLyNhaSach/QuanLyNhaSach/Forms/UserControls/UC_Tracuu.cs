using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QuanLyNhaSach.Forms.UserControls
{

    public partial class UC_Tracuu : UserControl
    {
        SqlDataAdapter sda;
        DataSet sach;
        SqlCommandBuilder scb;
        public UC_Tracuu()
        {
            InitializeComponent();
        }

        public void LoadSach()
        {
            Globals.sqlcon.Open();
            string query = "select MaSach, TenSach, TheLoai, TacGia, SoLuong from SACH where SoLuong > 0";
            SqlCommand com = new SqlCommand(query, Globals.sqlcon);
            com.CommandType = CommandType.Text;
            sda = new SqlDataAdapter(com);
            sach = new DataSet();
            sda.Fill(sach, "Sach_Details");
            Globals.sqlcon.Close();
            dgvSach.DataSource = sach.Tables[0];
            dgvSach.Columns["MaSach"].Visible = false;
        }

        private void UC_Tracuu_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnNhapsach_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                Excel.Range row1_TieuDe_DanhSachSach = ws.get_Range("A1", "E1");
                row1_TieuDe_DanhSachSach.Merge();
                row1_TieuDe_DanhSachSach.Font.Size = fontSizeTieuDe;
                row1_TieuDe_DanhSachSach.Font.Name = fontName;
                row1_TieuDe_DanhSachSach.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_DanhSachSach.Value2 = "Danh sách sách";

                //Tạo Ô Số Thứ Tự (STT)
                Excel.Range row2_STT = ws.get_Range("A2", "A2");//Cột A dòng 2
                row2_STT.Font.Size = fontSizeTenTruong;
                row2_STT.Font.Name = fontName;
                row2_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_STT.Value2 = "STT";

                //Tạo Ô Tên sách
                Excel.Range row2_TenSach = ws.get_Range("B2", "B2");//Cột B dòng 2
                row2_TenSach.Font.Size = fontSizeTenTruong;
                row2_TenSach.Font.Name = fontName;
                row2_TenSach.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TenSach.Value2 = "Tên sách";

                //Tạo Ô Thể loại
                Excel.Range row2_TheLoai = ws.get_Range("C2", "C2");//Cột C dòng 2
                row2_TheLoai.Font.Size = fontSizeTenTruong;
                row2_TheLoai.Font.Name = fontName;
                row2_TheLoai.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TheLoai.Value2 = "Thể loại";

                //Tạo Ô Tác giả
                Excel.Range row2_TacGia = ws.get_Range("D2", "D2");//Cột D dòng 2
                row2_TacGia.Font.Size = fontSizeTenTruong;
                row2_TacGia.Font.Name = fontName;
                row2_TacGia.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TacGia.Value2 = "Tác giả";

                //Tạo Ô Số lượng
                Excel.Range row2_SL = ws.get_Range("E2", "E2");//Cột E dòng 2
                row2_SL.Font.Size = fontSizeTenTruong;
                row2_SL.Font.Name = fontName;
                row2_SL.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_SL.Value2 = "Số lượng";

                //Tô nền vàng các cột tiêu đề:
                Excel.Range row2_CotTieuDe = ws.get_Range("A2", "E2");
                //nền vàng
                row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row2_CotTieuDe.Font.Bold = true;
                //chữ đen
                row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 2; // dữ liệu bắt đầu từ dòng số 3 trong file Excel
                foreach(DataRow sach in sach.Tables[0].Rows)
                {
                    stt++;
                    row++;
                    dynamic[] arr = {stt, sach[1], sach[2], sach[3], sach[4] };
                    Excel.Range rowData = ws.get_Range("A" + row, "E" + row); // Lấy dòng thứ row để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;

                }

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "E" + row));
                ws.get_Range("A1","E" + row).Columns.AutoFit();

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e) {
            try
            {
                Globals.sqlcon.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(sach, "Sach_Details");
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.sqlcon.Close();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            //Xuât kết quả tra cứu ra DATAGRIDVIEW
            int nhonhat;
            int lonnhat;
            try
            {
                nhonhat = int.Parse(txtBoxNhonhat.Text);
            }
            catch
            {
                nhonhat = 1;
            }
            try
            {
                lonnhat = int.Parse(txtBoxLonnhat.Text);
            }
            catch
            {
                //SQL
                lonnhat = 99999999; // SỐ LƯỢNG LỚN NHẤT CỦA SÁCH CÓ TRONG CƠ SỞ DỮ LIỆu;
            }

            if (nhonhat > lonnhat)
            {
                MessageBox.Show("Lỗi: Mục 'nhỏ nhất' phải bé hơn hoặc bằng mục 'lớn nhất' ");
            }
            else
            {
                string searchStr = "";
                if (txtBoxTensach.TextLength != 0) searchStr += "TenSach LIKE '%" + txtBoxTensach.Text + "%' AND ";
                if (txtBoxTacgia.TextLength != 0) searchStr += "TacGia LIKE '%" + txtBoxTacgia.Text + "%' AND ";
                if (txtBoxTheloai.TextLength != 0) searchStr += "TheLoai LIKE '%" + txtBoxTheloai.Text + "%' AND ";
                if (txtBoxLonnhat.TextLength != 0) searchStr += "SoLuong <= " + txtBoxLonnhat.Text + " AND ";
                if (txtBoxNhonhat.TextLength != 0) searchStr += "SoLuong >= " + txtBoxNhonhat.Text + " AND ";
                if (searchStr.Length != 0) searchStr = searchStr.Substring(0, searchStr.Length - 5);
                sach.Tables[0].DefaultView.RowFilter = searchStr;

            }

        }

        private void txtBoxNhonhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxLonnhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLonnhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSach.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); 
        }

        private void btnHoantac_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            using (Form_Nhapsach ns = new Form_Nhapsach())
            {
                ns.ShowDialog();
            }
        }
    }
}
