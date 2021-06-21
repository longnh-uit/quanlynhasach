
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tenSach = new System.Windows.Forms.ColumnHeader();
            this.soLuong = new System.Windows.Forms.ColumnHeader();
            this.gia = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxSoluong = new System.Windows.Forms.TextBox();
            this.txtBoxTheloai = new System.Windows.Forms.TextBox();
            this.txtBoxTensach = new System.Windows.Forms.TextBox();
            this.txtBoxNgay = new System.Windows.Forms.TextBox();
            this.txtBoxSodienthoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxSotientra = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            btnKiemTra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKiemTra
            // 
            btnKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnKiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            btnKiemTra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnKiemTra.ForeColor = System.Drawing.Color.White;
            btnKiemTra.Location = new System.Drawing.Point(253, 119);
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
            this.panel6.Location = new System.Drawing.Point(10, 503);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 8);
            this.panel6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 511);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenSach,
            this.soLuong,
            this.gia});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(345, 368);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tenSach
            // 
            this.tenSach.Text = "Tên sách";
            this.tenSach.Width = 200;
            // 
            // soLuong
            // 
            this.soLuong.Text = "SL";
            this.soLuong.Width = 55;
            // 
            // gia
            // 
            this.gia.Text = "Giá";
            this.gia.Width = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 8);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnXacNhan);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 376);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 127);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(122, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "Xóa tất cả";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 34);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(345, 8);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(345, 34);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(52, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(102, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(355, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 511);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 511);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtBoxHoten
            // 
            this.txtBoxHoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxHoten.Location = new System.Drawing.Point(253, 47);
            this.txtBoxHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxHoten.Name = "txtBoxHoten";
            this.txtBoxHoten.Size = new System.Drawing.Size(132, 23);
            this.txtBoxHoten.TabIndex = 1;
            this.txtBoxHoten.ModifiedChanged += new System.EventHandler(this.txtBoxHoten_ModifiedChanged);
            this.txtBoxHoten.TextChanged += new System.EventHandler(this.txtBoxHoten_TextChanged);
            this.txtBoxHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHoten_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(253, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "    Thêm vào giỏ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(120, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số tiền trả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(121, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(120, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thể loại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(121, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên sách";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(120, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtBoxSoluong
            // 
            this.txtBoxSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSoluong.Location = new System.Drawing.Point(253, 326);
            this.txtBoxSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSoluong.Name = "txtBoxSoluong";
            this.txtBoxSoluong.ReadOnly = true;
            this.txtBoxSoluong.Size = new System.Drawing.Size(132, 23);
            this.txtBoxSoluong.TabIndex = 7;
            this.txtBoxSoluong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBoxSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoluong_KeyPress);
            // 
            // txtBoxTheloai
            // 
            this.txtBoxTheloai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTheloai.Location = new System.Drawing.Point(253, 284);
            this.txtBoxTheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTheloai.Name = "txtBoxTheloai";
            this.txtBoxTheloai.ReadOnly = true;
            this.txtBoxTheloai.Size = new System.Drawing.Size(132, 23);
            this.txtBoxTheloai.TabIndex = 6;
            this.txtBoxTheloai.TextChanged += new System.EventHandler(this.txtBoxTheloai_TextChanged);
            // 
            // txtBoxTensach
            // 
            this.txtBoxTensach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTensach.Location = new System.Drawing.Point(253, 239);
            this.txtBoxTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTensach.Name = "txtBoxTensach";
            this.txtBoxTensach.ReadOnly = true;
            this.txtBoxTensach.Size = new System.Drawing.Size(132, 23);
            this.txtBoxTensach.TabIndex = 5;
            this.txtBoxTensach.TextChanged += new System.EventHandler(this.txtBoxTensach_TextChanged);
            // 
            // txtBoxNgay
            // 
            this.txtBoxNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNgay.Location = new System.Drawing.Point(253, 197);
            this.txtBoxNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNgay.Name = "txtBoxNgay";
            this.txtBoxNgay.ReadOnly = true;
            this.txtBoxNgay.Size = new System.Drawing.Size(132, 23);
            this.txtBoxNgay.TabIndex = 4;
            this.txtBoxNgay.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtBoxSodienthoai
            // 
            this.txtBoxSodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSodienthoai.Location = new System.Drawing.Point(253, 85);
            this.txtBoxSodienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSodienthoai.Name = "txtBoxSodienthoai";
            this.txtBoxSodienthoai.Size = new System.Drawing.Size(132, 23);
            this.txtBoxSodienthoai.TabIndex = 2;
            this.txtBoxSodienthoai.TextChanged += new System.EventHandler(this.txtBoxSodienthoai_TextChanged);
            this.txtBoxSodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(120, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số điện thoại";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtBoxSotientra
            // 
            this.txtBoxSotientra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSotientra.Location = new System.Drawing.Point(253, 365);
            this.txtBoxSotientra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSotientra.Name = "txtBoxSotientra";
            this.txtBoxSotientra.ReadOnly = true;
            this.txtBoxSotientra.Size = new System.Drawing.Size(132, 23);
            this.txtBoxSotientra.TabIndex = 8;
            this.txtBoxSotientra.TextChanged += new System.EventHandler(this.txtBoxSotientra_TextChanged);
            this.txtBoxSotientra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSotientra_KeyPress);
            // 
            // lblCheck
            // 
            this.lblCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(120, 166);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(256, 15);
            this.lblCheck.TabIndex = 26;
            this.lblCheck.Text = "* Khách hàng không đủ điều kiện để mua hàng";
            this.lblCheck.Visible = false;
            this.lblCheck.Click += new System.EventHandler(this.lblCheck_Click);
            // 
            // UC_Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(btnKiemTra);
            this.Controls.Add(this.txtBoxSotientra);
            this.Controls.Add(this.txtBoxSodienthoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxNgay);
            this.Controls.Add(this.txtBoxTensach);
            this.Controls.Add(this.txtBoxTheloai);
            this.Controls.Add(this.txtBoxSoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxHoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Hoadon";
            this.Size = new System.Drawing.Size(969, 511);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tenSach;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxSoluong;
        private System.Windows.Forms.TextBox txtBoxTheloai;
        private System.Windows.Forms.TextBox txtBoxTensach;
        private System.Windows.Forms.TextBox txtBoxNgay;
        private System.Windows.Forms.TextBox txtBoxSodienthoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxSotientra;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel panel3;
    }
}
