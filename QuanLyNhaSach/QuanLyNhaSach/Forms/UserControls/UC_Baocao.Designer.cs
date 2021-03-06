
namespace QuanLyNhaSach.Forms.UserControls
{
    partial class UC_Baocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Baocao));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCongno = new System.Windows.Forms.Button();
            this.btnBaocaoton = new System.Windows.Forms.Button();
            this.dgvTon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCongno = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chonDuongDan = new System.Windows.Forms.OpenFileDialog();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1154, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 671);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 671);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1154, 10);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 661);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.dtpThangNam);
            this.panel4.Controls.Add(this.btnXuat);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnCongno);
            this.panel4.Controls.Add(this.btnBaocaoton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 94);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(598, 32);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(167, 27);
            this.dtpThangNam.TabIndex = 40;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(865, 22);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(210, 50);
            this.btnXuat.TabIndex = 39;
            this.btnXuat.Text = "      Xuất báo cáo";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tháng/Năm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCongno
            // 
            this.btnCongno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCongno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCongno.FlatAppearance.BorderSize = 0;
            this.btnCongno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCongno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCongno.Image = ((System.Drawing.Image)(resources.GetObject("btnCongno.Image")));
            this.btnCongno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongno.Location = new System.Drawing.Point(209, 0);
            this.btnCongno.Name = "btnCongno";
            this.btnCongno.Size = new System.Drawing.Size(235, 94);
            this.btnCongno.TabIndex = 1;
            this.btnCongno.Text = "        Báo cáo công nợ";
            this.btnCongno.UseVisualStyleBackColor = false;
            this.btnCongno.Click += new System.EventHandler(this.btnCongno_Click);
            // 
            // btnBaocaoton
            // 
            this.btnBaocaoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnBaocaoton.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBaocaoton.FlatAppearance.BorderSize = 0;
            this.btnBaocaoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaocaoton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaocaoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocaoton.Image")));
            this.btnBaocaoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocaoton.Location = new System.Drawing.Point(0, 0);
            this.btnBaocaoton.Name = "btnBaocaoton";
            this.btnBaocaoton.Size = new System.Drawing.Size(209, 94);
            this.btnBaocaoton.TabIndex = 0;
            this.btnBaocaoton.Text = "     Báo cáo tồn";
            this.btnBaocaoton.UseVisualStyleBackColor = false;
            this.btnBaocaoton.Click += new System.EventHandler(this.btnBaocaoton_Click);
            // 
            // dgvTon
            // 
            this.dgvTon.AllowUserToAddRows = false;
            this.dgvTon.AllowUserToDeleteRows = false;
            this.dgvTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTon.Location = new System.Drawing.Point(10, 104);
            this.dgvTon.Name = "dgvTon";
            this.dgvTon.RowHeadersWidth = 51;
            this.dgvTon.RowTemplate.Height = 29;
            this.dgvTon.Size = new System.Drawing.Size(1144, 567);
            this.dgvTon.TabIndex = 7;
            this.dgvTon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTon_CellContentClick);
            this.dgvTon.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTon_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TonDau";
            this.Column3.HeaderText = "Tồn đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 205;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TonPhatSinh";
            this.Column4.HeaderText = "Phát sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TonCuoi";
            this.Column5.HeaderText = "Tồn cuối";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 210;
            // 
            // dgvCongno
            // 
            this.dgvCongno.AllowUserToAddRows = false;
            this.dgvCongno.AllowUserToDeleteRows = false;
            this.dgvCongno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.dgvCongno.Location = new System.Drawing.Point(10, 104);
            this.dgvCongno.Name = "dgvCongno";
            this.dgvCongno.RowHeadersWidth = 51;
            this.dgvCongno.RowTemplate.Height = 29;
            this.dgvCongno.Size = new System.Drawing.Size(1144, 567);
            this.dgvCongno.TabIndex = 8;
            this.dgvCongno.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCongno_RowPostPaint);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenKH";
            this.Column7.HeaderText = "Khách hàng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 350;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NoDau";
            this.Column8.HeaderText = "Nợ đầu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 205;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PhatSinh";
            this.Column9.HeaderText = "Phát sinh";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NoCuoi";
            this.Column11.HeaderText = "Nợ cuối";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 210;
            // 
            // chonDuongDan
            // 
            this.chonDuongDan.CheckFileExists = false;
            this.chonDuongDan.CheckPathExists = false;
            this.chonDuongDan.DefaultExt = "xlsx";
            this.chonDuongDan.FileName = "bao cao";
            this.chonDuongDan.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            this.chonDuongDan.InitialDirectory = "D:\\";
            this.chonDuongDan.Title = "Chọn vị trí lưu";
            // 
            // UC_Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvCongno);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Baocao";
            this.Size = new System.Drawing.Size(1164, 681);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCongno;
        private System.Windows.Forms.Button btnBaocaoton;
        private System.Windows.Forms.DataGridView dgvTon;
        private System.Windows.Forms.DataGridView dgvCongno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.OpenFileDialog chonDuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
    }
}
