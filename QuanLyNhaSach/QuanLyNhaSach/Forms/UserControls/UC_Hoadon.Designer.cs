
namespace QuanLyNhaSach.Forms.UserControls
{
    partial class UC_Hoadon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnKiemTra;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Hoadon));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvGio = new System.Windows.Forms.ListView();
            this.tenSach = new System.Windows.Forms.ColumnHeader();
            this.theloai = new System.Windows.Forms.ColumnHeader();
            this.tacgia = new System.Windows.Forms.ColumnHeader();
            this.soLuong = new System.Windows.Forms.ColumnHeader();
            this.gia = new System.Windows.Forms.ColumnHeader();
            this.maSach = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbltongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoatat = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtBoxHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxSoluong = new System.Windows.Forms.TextBox();
            this.txtBoxSodienthoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxDongia = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.btnDoiThongTin = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnLichsu = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            btnKiemTra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKiemTra
            // 
            btnKiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            btnKiemTra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnKiemTra.ForeColor = System.Drawing.Color.White;
            btnKiemTra.Location = new System.Drawing.Point(225, 209);
            btnKiemTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new System.Drawing.Size(105, 37);
            btnKiemTra.TabIndex = 3;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = false;
            btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 673);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(563, 8);
            this.panel6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lvGio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(581, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 681);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvGio
            // 
            this.lvGio.BackColor = System.Drawing.Color.White;
            this.lvGio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenSach,
            this.theloai,
            this.tacgia,
            this.soLuong,
            this.gia,
            this.maSach});
            this.lvGio.FullRowSelect = true;
            this.lvGio.GridLines = true;
            this.lvGio.HideSelection = false;
            this.lvGio.Location = new System.Drawing.Point(10, 10);
            this.lvGio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvGio.Name = "lvGio";
            this.lvGio.Size = new System.Drawing.Size(563, 532);
            this.lvGio.TabIndex = 7;
            this.lvGio.UseCompatibleStateImageBehavior = false;
            this.lvGio.View = System.Windows.Forms.View.Details;
            this.lvGio.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tenSach
            // 
            this.tenSach.Text = "Tên sách";
            this.tenSach.Width = 200;
            // 
            // theloai
            // 
            this.theloai.Text = "Thể loại";
            this.theloai.Width = 100;
            // 
            // tacgia
            // 
            this.tacgia.Text = "Tác giả";
            this.tacgia.Width = 126;
            // 
            // soLuong
            // 
            this.soLuong.Text = "SL";
            this.soLuong.Width = 55;
            // 
            // gia
            // 
            this.gia.Text = "Giá";
            this.gia.Width = 90;
            // 
            // maSach
            // 
            this.maSach.Width = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 538);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 8);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbltongTien);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnXacNhan);
            this.panel5.Controls.Add(this.btnXoatat);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 546);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 127);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lbltongTien
            // 
            this.lbltongTien.AutoSize = true;
            this.lbltongTien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbltongTien.Location = new System.Drawing.Point(122, 62);
            this.lbltongTien.Name = "lbltongTien";
            this.lbltongTien.Size = new System.Drawing.Size(27, 19);
            this.lbltongTien.TabIndex = 20;
            this.lbltongTien.Text = "00";
            this.lbltongTien.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng tiền:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(109, 90);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(101, 38);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoatat
            // 
            this.btnXoatat.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoatat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoatat.ForeColor = System.Drawing.Color.White;
            this.btnXoatat.Location = new System.Drawing.Point(0, 90);
            this.btnXoatat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoatat.Name = "btnXoatat";
            this.btnXoatat.Size = new System.Drawing.Size(116, 38);
            this.btnXoatat.TabIndex = 17;
            this.btnXoatat.Text = "Xóa tất cả";
            this.btnXoatat.UseVisualStyleBackColor = false;
            this.btnXoatat.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 34);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(563, 8);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnTru);
            this.panel7.Controls.Add(this.btnXoa);
            this.panel7.Controls.Add(this.btnCong);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 34);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTru.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTru.ForeColor = System.Drawing.Color.White;
            this.btnTru.Location = new System.Drawing.Point(52, 0);
            this.btnTru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(54, 34);
            this.btnTru.TabIndex = 17;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(102, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCong.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCong.ForeColor = System.Drawing.Color.White;
            this.btnCong.Location = new System.Drawing.Point(0, 0);
            this.btnCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(54, 34);
            this.btnCong.TabIndex = 15;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(573, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 681);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 681);
            this.panel12.TabIndex = 0;
            // 
            // txtBoxHoten
            // 
            this.txtBoxHoten.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxHoten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxHoten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxHoten.Location = new System.Drawing.Point(225, 129);
            this.txtBoxHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxHoten.Name = "txtBoxHoten";
            this.txtBoxHoten.Size = new System.Drawing.Size(173, 23);
            this.txtBoxHoten.TabIndex = 1;
            this.txtBoxHoten.ModifiedChanged += new System.EventHandler(this.txtBoxHoten_ModifiedChanged);
            this.txtBoxHoten.TextChanged += new System.EventHandler(this.txtBoxHoten_TextChanged);
            this.txtBoxHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHoten_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(92, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(225, 543);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(173, 37);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "    Thêm vào giỏ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(92, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đơn giá";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(92, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(92, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thể loại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(92, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên sách";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(92, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtBoxSoluong
            // 
            this.txtBoxSoluong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxSoluong.Location = new System.Drawing.Point(225, 453);
            this.txtBoxSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSoluong.Name = "txtBoxSoluong";
            this.txtBoxSoluong.ReadOnly = true;
            this.txtBoxSoluong.Size = new System.Drawing.Size(173, 23);
            this.txtBoxSoluong.TabIndex = 8;
            this.txtBoxSoluong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBoxSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoluong_KeyPress);
            // 
            // txtBoxSodienthoai
            // 
            this.txtBoxSodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxSodienthoai.Location = new System.Drawing.Point(225, 167);
            this.txtBoxSodienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSodienthoai.Name = "txtBoxSodienthoai";
            this.txtBoxSodienthoai.Size = new System.Drawing.Size(173, 23);
            this.txtBoxSodienthoai.TabIndex = 2;
            this.txtBoxSodienthoai.TextChanged += new System.EventHandler(this.txtBoxSodienthoai_TextChanged);
            this.txtBoxSodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(92, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số điện thoại";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtBoxDongia
            // 
            this.txtBoxDongia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxDongia.Location = new System.Drawing.Point(225, 495);
            this.txtBoxDongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDongia.Name = "txtBoxDongia";
            this.txtBoxDongia.ReadOnly = true;
            this.txtBoxDongia.Size = new System.Drawing.Size(173, 23);
            this.txtBoxDongia.TabIndex = 8;
            this.txtBoxDongia.TabStop = false;
            this.txtBoxDongia.TextChanged += new System.EventHandler(this.txtBoxSotientra_TextChanged);
            this.txtBoxDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSotientra_KeyPress);
            // 
            // lblCheck
            // 
            this.lblCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(92, 254);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(256, 15);
            this.lblCheck.TabIndex = 26;
            this.lblCheck.Text = "* Khách hàng không đủ điều kiện để mua hàng";
            this.lblCheck.Visible = false;
            this.lblCheck.Click += new System.EventHandler(this.lblCheck_Click);
            // 
            // cbTenSach
            // 
            this.cbTenSach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTenSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenSach.Enabled = false;
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(225, 327);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(173, 23);
            this.cbTenSach.TabIndex = 5;
            this.cbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbTenSach_SelectedIndexChanged);
            this.cbTenSach.SelectionChangeCommitted += new System.EventHandler(this.cbTenSach_SelectionChangeCommitted);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTheLoai.Enabled = false;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(225, 369);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(173, 23);
            this.cbTheLoai.TabIndex = 6;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // cbTacGia
            // 
            this.cbTacGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTacGia.Enabled = false;
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(225, 411);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(173, 23);
            this.cbTacGia.TabIndex = 27;
            this.cbTacGia.SelectedIndexChanged += new System.EventHandler(this.cbTacGia_SelectedIndexChanged);
            // 
            // lblTacGia
            // 
            this.lblTacGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblTacGia.Location = new System.Drawing.Point(92, 415);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(65, 19);
            this.lblTacGia.TabIndex = 28;
            this.lblTacGia.Text = "Tác giả";
            // 
            // btnDoiThongTin
            // 
            this.btnDoiThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDoiThongTin.Enabled = false;
            this.btnDoiThongTin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoiThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoiThongTin.Location = new System.Drawing.Point(361, 209);
            this.btnDoiThongTin.Name = "btnDoiThongTin";
            this.btnDoiThongTin.Size = new System.Drawing.Size(131, 37);
            this.btnDoiThongTin.TabIndex = 29;
            this.btnDoiThongTin.Text = "Đổi thông tin";
            this.btnDoiThongTin.UseVisualStyleBackColor = false;
            this.btnDoiThongTin.Click += new System.EventHandler(this.btnDoiThongTin_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel9.Controls.Add(this.btnLichsu);
            this.panel9.Location = new System.Drawing.Point(3, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(579, 79);
            this.panel9.TabIndex = 30;
            // 
            // btnLichsu
            // 
            this.btnLichsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLichsu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLichsu.ForeColor = System.Drawing.Color.White;
            this.btnLichsu.Location = new System.Drawing.Point(45, 15);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(155, 44);
            this.btnLichsu.TabIndex = 0;
            this.btnLichsu.Text = "Lịch sử hoá đơn";
            this.btnLichsu.UseVisualStyleBackColor = false;
            this.btnLichsu.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1164, 10);
            this.panel10.TabIndex = 30;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 681);
            this.panel11.TabIndex = 30;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Enabled = false;
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(225, 285);
            this.dtpNgay.MaxDate = new System.DateTime(2028, 11, 30, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(173, 25);
            this.dtpNgay.TabIndex = 31;
            this.dtpNgay.Value = new System.DateTime(2021, 6, 26, 0, 0, 0, 0);
            // 
            // UC_Hoadon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnDoiThongTin);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.cbTacGia);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.cbTenSach);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(btnKiemTra);
            this.Controls.Add(this.txtBoxDongia);
            this.Controls.Add(this.txtBoxSodienthoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxSoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxHoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Name = "UC_Hoadon";
            this.Size = new System.Drawing.Size(1164, 681);
            this.Load += new System.EventHandler(this.UC_Hoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBoxHoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnXoatat;
        private System.Windows.Forms.Label lbltongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvGio;
        private System.Windows.Forms.ColumnHeader tenSach;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxSoluong;
        private System.Windows.Forms.TextBox txtBoxSodienthoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxDongia;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader theloai;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.ColumnHeader tacgia;
        private System.Windows.Forms.ColumnHeader maSach;
        private System.Windows.Forms.Button btnDoiThongTin;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnLichsu;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}
