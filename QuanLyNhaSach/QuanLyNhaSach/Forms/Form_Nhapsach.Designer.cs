
namespace QuanLyNhaSach.Forms
{
    partial class Form_Nhapsach
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTheloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNgaynhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxDongianhap = new System.Windows.Forms.TextBox();
            this.txtBoxTensach = new System.Windows.Forms.TextBox();
            this.txtBoxTacgia = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lv_nhapSach = new System.Windows.Forms.ListView();
            this.tenSach = new System.Windows.Forms.ColumnHeader();
            this.theLoai = new System.Windows.Forms.ColumnHeader();
            this.tacGia = new System.Windows.Forms.ColumnHeader();
            this.soLuong = new System.Windows.Forms.ColumnHeader();
            this.donGia = new System.Windows.Forms.ColumnHeader();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(544, 355);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 40);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXong
            // 
            this.btnXong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXong.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXong.ForeColor = System.Drawing.Color.White;
            this.btnXong.Location = new System.Drawing.Point(735, 355);
            this.btnXong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(148, 40);
            this.btnXong.TabIndex = 54;
            this.btnXong.Text = "Hoàn tất";
            this.btnXong.UseVisualStyleBackColor = false;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(360, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(9, 399);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 8);
            this.panel4.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(893, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 399);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(9, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 8);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 407);
            this.panel1.TabIndex = 38;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(614, 330);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 23);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.Text = "Xuất phiếu nhập sách";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(52, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Đơn giá nhập";
            // 
            // txtBoxSoluong
            // 
            this.txtBoxSoluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSoluong.Location = new System.Drawing.Point(186, 256);
            this.txtBoxSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSoluong.Name = "txtBoxSoluong";
            this.txtBoxSoluong.Size = new System.Drawing.Size(205, 23);
            this.txtBoxSoluong.TabIndex = 73;
            this.txtBoxSoluong.TextChanged += new System.EventHandler(this.txtBoxSoluong_TextChanged);
            this.txtBoxSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoluong_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(52, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(52, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tác giả";
            // 
            // txtBoxTheloai
            // 
            this.txtBoxTheloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTheloai.Location = new System.Drawing.Point(186, 176);
            this.txtBoxTheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTheloai.Name = "txtBoxTheloai";
            this.txtBoxTheloai.Size = new System.Drawing.Size(205, 23);
            this.txtBoxTheloai.TabIndex = 71;
            this.txtBoxTheloai.TextChanged += new System.EventHandler(this.txtBoxTheloai_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(53, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(52, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Thể loại";
            // 
            // txtBoxNgaynhap
            // 
            this.txtBoxNgaynhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNgaynhap.Location = new System.Drawing.Point(186, 69);
            this.txtBoxNgaynhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNgaynhap.Name = "txtBoxNgaynhap";
            this.txtBoxNgaynhap.Size = new System.Drawing.Size(205, 23);
            this.txtBoxNgaynhap.TabIndex = 69;
            this.txtBoxNgaynhap.TextChanged += new System.EventHandler(this.txtBoxNgaynhap_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(52, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 68;
            this.label8.Tag = "";
            this.label8.Text = "Ngày nhập";
            // 
            // txtBoxDongianhap
            // 
            this.txtBoxDongianhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDongianhap.Location = new System.Drawing.Point(186, 296);
            this.txtBoxDongianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDongianhap.Name = "txtBoxDongianhap";
            this.txtBoxDongianhap.Size = new System.Drawing.Size(205, 23);
            this.txtBoxDongianhap.TabIndex = 74;
            this.txtBoxDongianhap.TextChanged += new System.EventHandler(this.txtBoxDongianhap_TextChanged);
            this.txtBoxDongianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDongianhap_KeyPress);
            // 
            // txtBoxTensach
            // 
            this.txtBoxTensach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTensach.Location = new System.Drawing.Point(186, 136);
            this.txtBoxTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTensach.Name = "txtBoxTensach";
            this.txtBoxTensach.Size = new System.Drawing.Size(205, 23);
            this.txtBoxTensach.TabIndex = 70;
            // 
            // txtBoxTacgia
            // 
            this.txtBoxTacgia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTacgia.Location = new System.Drawing.Point(186, 216);
            this.txtBoxTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTacgia.Name = "txtBoxTacgia";
            this.txtBoxTacgia.Size = new System.Drawing.Size(205, 23);
            this.txtBoxTacgia.TabIndex = 72;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Location = new System.Drawing.Point(396, 175);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(40, 39);
            this.btnNhap.TabIndex = 75;
            this.btnNhap.Text = "=>";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lv_nhapSach
            // 
            this.lv_nhapSach.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lv_nhapSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenSach,
            this.theLoai,
            this.tacGia,
            this.soLuong,
            this.donGia});
            this.lv_nhapSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_nhapSach.FullRowSelect = true;
            this.lv_nhapSach.GridLines = true;
            this.lv_nhapSach.HideSelection = false;
            this.lv_nhapSach.Location = new System.Drawing.Point(442, 69);
            this.lv_nhapSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_nhapSach.Name = "lv_nhapSach";
            this.lv_nhapSach.Size = new System.Drawing.Size(441, 258);
            this.lv_nhapSach.TabIndex = 80;
            this.lv_nhapSach.UseCompatibleStateImageBehavior = false;
            this.lv_nhapSach.View = System.Windows.Forms.View.Details;
            this.lv_nhapSach.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // tenSach
            // 
            this.tenSach.Text = "Tên sách";
            this.tenSach.Width = 220;
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
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá nhập";
            this.donGia.Width = 100;
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
            this.button8.Location = new System.Drawing.Point(839, 8);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 40);
            this.button8.TabIndex = 100;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form_Nhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 407);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lv_nhapSach);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtBoxTacgia);
            this.Controls.Add(this.txtBoxTensach);
            this.Controls.Add(this.txtBoxDongianhap);
            this.Controls.Add(this.txtBoxNgaynhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSoluong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTheloai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Nhapsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Nhapsach";
            this.Load += new System.EventHandler(this.Form_Nhapsach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNgaynhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxDongianhap;
        private System.Windows.Forms.TextBox txtBoxTensach;
        private System.Windows.Forms.TextBox txtBoxTacgia;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListView lv_nhapSach;
        private System.Windows.Forms.ColumnHeader tenSach;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColumnHeader theLoai;
        private System.Windows.Forms.ColumnHeader tacGia;
        private System.Windows.Forms.ColumnHeader donGia;
    }
}