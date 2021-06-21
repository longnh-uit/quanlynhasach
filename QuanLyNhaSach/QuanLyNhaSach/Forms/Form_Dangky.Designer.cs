
namespace QuanLyNhaSach.Forms
{
    partial class Form_Dangky
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
 //           System.Windows.Forms.ComboBox cbBoxChucVu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dangky));
            this.button4 = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMatkhau = new System.Windows.Forms.TextBox();
            this.txtBoxNhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.txtBoxTentk = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbBoxChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBoxChucVu
            // 
            this.cbBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBoxChucVu.FormattingEnabled = true;
            this.cbBoxChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên bán hàng",
            "Thủ kho"});
            this.cbBoxChucVu.Location = new System.Drawing.Point(383, 285);
            this.cbBoxChucVu.Name = "cbBoxChucVu";
            this.cbBoxChucVu.Size = new System.Drawing.Size(205, 29);
            this.cbBoxChucVu.TabIndex = 5;
            this.cbBoxChucVu.SelectedIndexChanged += new System.EventHandler(this.cbBoxChucvu_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(33, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 53);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(597, 368);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(169, 53);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Hoàn tất";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.White;
            this.logo2.ErrorImage = null;
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(33, 16);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(124, 111);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 77;
            this.logo2.TabStop = false;
            this.logo2.Click += new System.EventHandler(this.logo2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(307, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 76;
            this.label1.Text = "ĐĂNG KÍ TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 10);
            this.panel4.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(790, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 440);
            this.panel3.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 10);
            this.panel2.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Tên tài khoản:";
            // 
            // txtBoxMatkhau
            // 
            this.txtBoxMatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMatkhau.Location = new System.Drawing.Point(383, 187);
            this.txtBoxMatkhau.Name = "txtBoxMatkhau";
            this.txtBoxMatkhau.Size = new System.Drawing.Size(205, 29);
            this.txtBoxMatkhau.TabIndex = 3;
            this.txtBoxMatkhau.UseSystemPasswordChar = true;
            this.txtBoxMatkhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxNhaplaimatkhau
            // 
            this.txtBoxNhaplaimatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNhaplaimatkhau.Location = new System.Drawing.Point(383, 236);
            this.txtBoxNhaplaimatkhau.Name = "txtBoxNhaplaimatkhau";
            this.txtBoxNhaplaimatkhau.Size = new System.Drawing.Size(205, 29);
            this.txtBoxNhaplaimatkhau.TabIndex = 4;
            this.txtBoxNhaplaimatkhau.UseSystemPasswordChar = true;
            this.txtBoxNhaplaimatkhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxTentk
            // 
            this.txtBoxTentk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTentk.Location = new System.Drawing.Point(383, 138);
            this.txtBoxTentk.Name = "txtBoxTentk";
            this.txtBoxTentk.Size = new System.Drawing.Size(205, 29);
            this.txtBoxTentk.TabIndex = 2;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(188, 91);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(86, 19);
            this.lblHoten.TabIndex = 87;
            this.lblHoten.Text = "Họ và tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoten.Location = new System.Drawing.Point(383, 87);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(205, 29);
            this.txtHoten.TabIndex = 1;
            // 
            // Form_Dangky
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtBoxTentk);
            this.Controls.Add(this.txtBoxNhaplaimatkhau);
            this.Controls.Add(this.txtBoxMatkhau);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBoxChucVu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dangky";
            this.Load += new System.EventHandler(this.Form_Dangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBoxChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMatkhau;
        private System.Windows.Forms.TextBox txtBoxNhaplaimatkhau;
        private System.Windows.Forms.TextBox txtBoxTentk;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtHoten;
    }
}