
namespace QuanLyNhaSach.Forms.UserControls
{
    partial class UC_Tracuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Tracuu));
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxLonnhat = new System.Windows.Forms.TextBox();
            this.txtBoxNhonhat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTheloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTensach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Sach,
            this.Theloai,
            this.Tacgia,
            this.Soluong});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(10, 203);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 29;
            this.dgvSach.Size = new System.Drawing.Size(1144, 468);
            this.dgvSach.TabIndex = 10;
            this.dgvSach.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSach_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Sach
            // 
            this.Sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sach.DataPropertyName = "TenSach";
            this.Sach.HeaderText = "Sách";
            this.Sach.MinimumWidth = 6;
            this.Sach.Name = "Sach";
            // 
            // Theloai
            // 
            this.Theloai.DataPropertyName = "TheLoai";
            this.Theloai.HeaderText = "Thể loại";
            this.Theloai.MinimumWidth = 6;
            this.Theloai.Name = "Theloai";
            this.Theloai.Width = 200;
            // 
            // Tacgia
            // 
            this.Tacgia.DataPropertyName = "TacGia";
            this.Tacgia.HeaderText = "Tác giả";
            this.Tacgia.MinimumWidth = 6;
            this.Tacgia.Name = "Tacgia";
            this.Tacgia.Width = 250;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SoLuong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 165;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.btnNhapSach);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnXuat);
            this.panel2.Controls.Add(this.btnHoanTac);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnTracuu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxLonnhat);
            this.panel2.Controls.Add(this.txtBoxNhonhat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBoxTheloai);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBoxTacgia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxTensach);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 193);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnNhapSach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhapSach.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.Image")));
            this.btnNhapSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapSach.Location = new System.Drawing.Point(29, 108);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(141, 58);
            this.btnNhapSach.TabIndex = 41;
            this.btnNhapSach.Text = "Nhập sách";
            this.btnNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapSach.UseVisualStyleBackColor = false;
            this.btnNhapSach.Click += new System.EventHandler(this.btnNhapSach_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(521, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "lớn nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(766, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 39;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(741, 88);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(225, 53);
            this.btnXuat.TabIndex = 38;
            this.btnXuat.Text = "         Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoanTac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnHoanTac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoanTac.ForeColor = System.Drawing.Color.White;
            this.btnHoanTac.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.Image")));
            this.btnHoanTac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoanTac.Location = new System.Drawing.Point(988, 85);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(141, 58);
            this.btnHoanTac.TabIndex = 6;
            this.btnHoanTac.Text = "       Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoantac_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(988, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 58);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTracuu
            // 
            this.btnTracuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTracuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTracuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTracuu.ForeColor = System.Drawing.Color.White;
            this.btnTracuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTracuu.Image")));
            this.btnTracuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTracuu.Location = new System.Drawing.Point(741, 12);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(225, 58);
            this.btnTracuu.TabIndex = 6;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = false;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "nhỏ nhất";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxLonnhat
            // 
            this.txtBoxLonnhat.Location = new System.Drawing.Point(629, 104);
            this.txtBoxLonnhat.Name = "txtBoxLonnhat";
            this.txtBoxLonnhat.Size = new System.Drawing.Size(77, 29);
            this.txtBoxLonnhat.TabIndex = 5;
            this.txtBoxLonnhat.TextChanged += new System.EventHandler(this.txtBoxLonnhat_TextChanged);
            this.txtBoxLonnhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLonnhat_KeyPress);
            // 
            // txtBoxNhonhat
            // 
            this.txtBoxNhonhat.Location = new System.Drawing.Point(629, 62);
            this.txtBoxNhonhat.Name = "txtBoxNhonhat";
            this.txtBoxNhonhat.Size = new System.Drawing.Size(77, 29);
            this.txtBoxNhonhat.TabIndex = 4;
            this.txtBoxNhonhat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtBoxNhonhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNhonhat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(413, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxTheloai
            // 
            this.txtBoxTheloai.Location = new System.Drawing.Point(521, 12);
            this.txtBoxTheloai.Name = "txtBoxTheloai";
            this.txtBoxTheloai.Size = new System.Drawing.Size(196, 29);
            this.txtBoxTheloai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thể loại:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxTacgia
            // 
            this.txtBoxTacgia.Location = new System.Drawing.Point(120, 62);
            this.txtBoxTacgia.Name = "txtBoxTacgia";
            this.txtBoxTacgia.Size = new System.Drawing.Size(196, 29);
            this.txtBoxTacgia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tác giả:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxTensach
            // 
            this.txtBoxTensach.Location = new System.Drawing.Point(120, 12);
            this.txtBoxTensach.Name = "txtBoxTensach";
            this.txtBoxTensach.Size = new System.Drawing.Size(196, 29);
            this.txtBoxTensach.TabIndex = 1;
            this.txtBoxTensach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sách:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 671);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1144, 10);
            this.panel5.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1144, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 681);
            this.panel1.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.DefaultExt = "xlsx";
            this.Save.FileName = "Danhsachsach";
            // 
            // UC_Tracuu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Tracuu";
            this.Size = new System.Drawing.Size(1164, 681);
            this.Load += new System.EventHandler(this.UC_Tracuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTensach;
        private System.Windows.Forms.TextBox txtBoxNhonhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTheloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLonnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.SaveFileDialog Save;
    }
}
