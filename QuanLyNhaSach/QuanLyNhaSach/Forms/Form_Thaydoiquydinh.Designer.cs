
namespace QuanLyNhaSach.Forms
{
    partial class Form_Thaydoiquydinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Thaydoiquydinh));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnHoantat = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuongtonmax = new System.Windows.Forms.TextBox();
            this.txtBoxSlmin = new System.Windows.Forms.TextBox();
            this.txtBoxNomax = new System.Windows.Forms.TextBox();
            this.txtBoxTonbanmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVuotTienNo = new System.Windows.Forms.CheckBox();
            this.lblSlmin = new System.Windows.Forms.Label();
            this.lblLuongtonmax = new System.Windows.Forms.Label();
            this.lblNomax = new System.Windows.Forms.Label();
            this.lblTonbanmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Firebrick;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(40, 353);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 40);
            this.btnHuy.TabIndex = 55;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHoantat
            // 
            this.btnHoantat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoantat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHoantat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoantat.ForeColor = System.Drawing.Color.White;
            this.btnHoantat.Location = new System.Drawing.Point(506, 353);
            this.btnHoantat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoantat.Name = "btnHoantat";
            this.btnHoantat.Size = new System.Drawing.Size(148, 40);
            this.btnHoantat.TabIndex = 54;
            this.btnHoantat.Text = "Hoàn tất";
            this.btnHoantat.UseVisualStyleBackColor = false;
            this.btnHoantat.Click += new System.EventHandler(this.button3_Click);
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.White;
            this.logo2.ErrorImage = null;
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(25, 29);
            this.logo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(108, 83);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 45;
            this.logo2.TabStop = false;
            this.logo2.Click += new System.EventHandler(this.logo2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(9, 408);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 8);
            this.panel4.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(681, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 408);
            this.panel3.TabIndex = 41;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(9, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 8);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 416);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(242, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "THAY ĐỔI QUY ĐỊNH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(168, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "1. Nhập sách:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLuongtonmax
            // 
            this.txtLuongtonmax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLuongtonmax.Location = new System.Drawing.Point(522, 130);
            this.txtLuongtonmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongtonmax.Name = "txtLuongtonmax";
            this.txtLuongtonmax.Size = new System.Drawing.Size(72, 23);
            this.txtLuongtonmax.TabIndex = 2;
            this.txtLuongtonmax.TextChanged += new System.EventHandler(this.txtBoxSoluong_TextChanged);
            this.txtLuongtonmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongtonmax_KeyPress);
            // 
            // txtBoxSlmin
            // 
            this.txtBoxSlmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSlmin.Location = new System.Drawing.Point(522, 98);
            this.txtBoxSlmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSlmin.Name = "txtBoxSlmin";
            this.txtBoxSlmin.Size = new System.Drawing.Size(72, 23);
            this.txtBoxSlmin.TabIndex = 1;
            this.txtBoxSlmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlmin_KeyPress);
            // 
            // txtBoxNomax
            // 
            this.txtBoxNomax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNomax.Location = new System.Drawing.Point(522, 199);
            this.txtBoxNomax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNomax.Name = "txtBoxNomax";
            this.txtBoxNomax.Size = new System.Drawing.Size(72, 23);
            this.txtBoxNomax.TabIndex = 3;
            this.txtBoxNomax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNomin_KeyPress);
            // 
            // txtBoxTonbanmin
            // 
            this.txtBoxTonbanmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTonbanmin.Location = new System.Drawing.Point(522, 231);
            this.txtBoxTonbanmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTonbanmin.Name = "txtBoxTonbanmin";
            this.txtBoxTonbanmin.Size = new System.Drawing.Size(72, 23);
            this.txtBoxTonbanmin.TabIndex = 4;
            this.txtBoxTonbanmin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtBoxTonbanmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTonbanmin_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(168, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "2. Bán sách:";
            // 
            // cbVuotTienNo
            // 
            this.cbVuotTienNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVuotTienNo.AutoSize = true;
            this.cbVuotTienNo.Checked = true;
            this.cbVuotTienNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVuotTienNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVuotTienNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.cbVuotTienNo.Location = new System.Drawing.Point(168, 275);
            this.cbVuotTienNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVuotTienNo.Name = "cbVuotTienNo";
            this.cbVuotTienNo.Size = new System.Drawing.Size(414, 25);
            this.cbVuotTienNo.TabIndex = 64;
            this.cbVuotTienNo.Text = "Số tiền thu không vượt quá số tiền khách hàng đang nợ";
            this.cbVuotTienNo.UseVisualStyleBackColor = true;
            // 
            // lblSlmin
            // 
            this.lblSlmin.AutoSize = true;
            this.lblSlmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblSlmin.Location = new System.Drawing.Point(164, 98);
            this.lblSlmin.Name = "lblSlmin";
            this.lblSlmin.Size = new System.Drawing.Size(160, 21);
            this.lblSlmin.TabIndex = 65;
            this.lblSlmin.Text = "Số lượng nhập ít nhất";
            // 
            // lblLuongtonmax
            // 
            this.lblLuongtonmax.AutoSize = true;
            this.lblLuongtonmax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLuongtonmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblLuongtonmax.Location = new System.Drawing.Point(164, 130);
            this.lblLuongtonmax.Name = "lblLuongtonmax";
            this.lblLuongtonmax.Size = new System.Drawing.Size(270, 21);
            this.lblLuongtonmax.TabIndex = 65;
            this.lblLuongtonmax.Text = "Chỉ nhập các sách có lượng tồn ít hơn";
            // 
            // lblNomax
            // 
            this.lblNomax.AutoSize = true;
            this.lblNomax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblNomax.Location = new System.Drawing.Point(164, 199);
            this.lblNomax.Name = "lblNomax";
            this.lblNomax.Size = new System.Drawing.Size(192, 21);
            this.lblNomax.TabIndex = 65;
            this.lblNomax.Text = "Khách hàng nợ không quá";
            // 
            // lblTonbanmin
            // 
            this.lblTonbanmin.AutoSize = true;
            this.lblTonbanmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTonbanmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblTonbanmin.Location = new System.Drawing.Point(164, 231);
            this.lblTonbanmin.Name = "lblTonbanmin";
            this.lblTonbanmin.Size = new System.Drawing.Size(213, 21);
            this.lblTonbanmin.TabIndex = 65;
            this.lblTonbanmin.Text = "Lượng tồn sau khi bán ít nhất";
            // 
            // Form_Thaydoiquydinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.lblTonbanmin);
            this.Controls.Add(this.lblNomax);
            this.Controls.Add(this.lblLuongtonmax);
            this.Controls.Add(this.lblSlmin);
            this.Controls.Add(this.txtBoxNomax);
            this.Controls.Add(this.cbVuotTienNo);
            this.Controls.Add(this.txtBoxTonbanmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSlmin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnHoantat);
            this.Controls.Add(this.txtLuongtonmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Thaydoiquydinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Thaydoiquydinh";
            this.Load += new System.EventHandler(this.Form_Thaydoiquydinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoantat;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLuongtonmax;
        private System.Windows.Forms.TextBox txtBoxSlmin;
        private System.Windows.Forms.TextBox txtBoxNomax;
        private System.Windows.Forms.TextBox txtBoxTonbanmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVuotTienNo;
        private System.Windows.Forms.Label lblSlmin;
        private System.Windows.Forms.Label lblLuongtonmax;
        private System.Windows.Forms.Label lblNomax;
        private System.Windows.Forms.Label lblTonbanmin;
    }
}