
namespace QuanLyNhaSach.Forms
{
    partial class frmDSHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCTHD = new System.Windows.Forms.ListView();
            this.stt = new System.Windows.Forms.ColumnHeader();
            this.tenSach = new System.Windows.Forms.ColumnHeader();
            this.theLoai = new System.Windows.Forms.ColumnHeader();
            this.tacGia = new System.Windows.Forms.ColumnHeader();
            this.soLuong = new System.Windows.Forms.ColumnHeader();
            this.donGia = new System.Windows.Forms.ColumnHeader();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.MaHD = new System.Windows.Forms.ColumnHeader();
            this.TenKH = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.NgayHoaDon = new System.Windows.Forms.ColumnHeader();
            this.TongTien = new System.Windows.Forms.ColumnHeader();
            this.SoTienTra = new System.Windows.Forms.ColumnHeader();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(9, 451);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 8);
            this.panel4.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1091, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 451);
            this.panel3.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(9, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 8);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 459);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(457, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // lvCTHD
            // 
            this.lvCTHD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tenSach,
            this.theLoai,
            this.tacGia,
            this.soLuong,
            this.donGia});
            this.lvCTHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvCTHD.FullRowSelect = true;
            this.lvCTHD.GridLines = true;
            this.lvCTHD.HideSelection = false;
            this.lvCTHD.Location = new System.Drawing.Point(560, 64);
            this.lvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCTHD.Name = "lvCTHD";
            this.lvCTHD.Size = new System.Drawing.Size(514, 358);
            this.lvCTHD.TabIndex = 81;
            this.lvCTHD.UseCompatibleStateImageBehavior = false;
            this.lvCTHD.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 30;
            // 
            // tenSach
            // 
            this.tenSach.Text = "Tên sách";
            this.tenSach.Width = 130;
            // 
            // theLoai
            // 
            this.theLoai.Text = "Thể loại";
            this.theLoai.Width = 80;
            // 
            // tacGia
            // 
            this.tacGia.Text = "Tác giả";
            this.tacGia.Width = 130;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            this.soLuong.Width = 80;
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá";
            this.donGia.Width = 100;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHD,
            this.TenKH,
            this.DienThoai,
            this.NgayHoaDon,
            this.TongTien,
            this.SoTienTra});
            this.lvHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(25, 64);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvHoaDon.MultiSelect = false;
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(517, 358);
            this.lvHoaDon.TabIndex = 82;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvHoaDon_SelectedIndexChanged);
            // 
            // MaHD
            // 
            this.MaHD.Text = "Mã HD";
            this.MaHD.Width = 50;
            // 
            // TenKH
            // 
            this.TenKH.Text = "Tên khách hàng";
            this.TenKH.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.Width = 100;
            // 
            // NgayHoaDon
            // 
            this.NgayHoaDon.Text = "Ngày viết";
            this.NgayHoaDon.Width = 80;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.Width = 80;
            // 
            // SoTienTra
            // 
            this.SoTienTra.Text = "Số tiền nhận";
            this.SoTienTra.Width = 80;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(1037, 8);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 40);
            this.button8.TabIndex = 101;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 459);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.lvCTHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromDSHoaDon";
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCTHD;
        private System.Windows.Forms.ColumnHeader tenSach;
        private System.Windows.Forms.ColumnHeader theLoai;
        private System.Windows.Forms.ColumnHeader tacGia;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColumnHeader MaHD;
        private System.Windows.Forms.ColumnHeader TenKH;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader NgayHoaDon;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.ColumnHeader SoTienTra;
        private System.Windows.Forms.ColumnHeader stt;
    }
}