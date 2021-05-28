
namespace QuanLyNhaSach.Forms
{
    partial class frmDash_board
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDash_board));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnThutien = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnNhapsach = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.btnBaocao);
            this.panelLeft.Controls.Add(this.btnThutien);
            this.panelLeft.Controls.Add(this.btnTracuu);
            this.panelLeft.Controls.Add(this.btnHoadon);
            this.panelLeft.Controls.Add(this.btnNhapsach);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(248, 806);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // btnBaocao
            // 
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaocao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocao.Image")));
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(14, 407);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(234, 63);
            this.btnBaocao.TabIndex = 7;
            this.btnBaocao.Text = "    Báo cáo tháng";
            this.btnBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnThutien
            // 
            this.btnThutien.FlatAppearance.BorderSize = 0;
            this.btnThutien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThutien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThutien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThutien.Image = ((System.Drawing.Image)(resources.GetObject("btnThutien.Image")));
            this.btnThutien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThutien.Location = new System.Drawing.Point(14, 338);
            this.btnThutien.Name = "btnThutien";
            this.btnThutien.Size = new System.Drawing.Size(234, 63);
            this.btnThutien.TabIndex = 6;
            this.btnThutien.Text = "    Phiếu thu tiền";
            this.btnThutien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThutien.UseVisualStyleBackColor = true;
            this.btnThutien.Click += new System.EventHandler(this.btnThutien_Click);
            // 
            // btnTracuu
            // 
            this.btnTracuu.FlatAppearance.BorderSize = 0;
            this.btnTracuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTracuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTracuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTracuu.Image")));
            this.btnTracuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTracuu.Location = new System.Drawing.Point(14, 269);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(234, 63);
            this.btnTracuu.TabIndex = 5;
            this.btnTracuu.Text = "    Tra cứu sách";
            this.btnTracuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoadon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadon.Image")));
            this.btnHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.Location = new System.Drawing.Point(14, 200);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(234, 63);
            this.btnHoadon.TabIndex = 4;
            this.btnHoadon.Text = "    Hóa đơn";
            this.btnHoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnNhapsach
            // 
            this.btnNhapsach.FlatAppearance.BorderSize = 0;
            this.btnNhapsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapsach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhapsach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapsach.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapsach.Image")));
            this.btnNhapsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapsach.Location = new System.Drawing.Point(14, 131);
            this.btnNhapsach.Name = "btnNhapsach";
            this.btnNhapsach.Size = new System.Drawing.Size(234, 63);
            this.btnNhapsach.TabIndex = 3;
            this.btnNhapsach.Text = "    Phiếu nhập sách";
            this.btnNhapsach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapsach.UseVisualStyleBackColor = true;
            this.btnNhapsach.Click += new System.EventHandler(this.btnNhapsach_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 131);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 63);
            this.panelSide.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 125);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(248, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1164, 44);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1102, -6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 53);
            this.button8.TabIndex = 4;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Shop Management System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(248, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1164, 81);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTime.Location = new System.Drawing.Point(970, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(63, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(63, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(248, 125);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1164, 681);
            this.panelControl.TabIndex = 2;
            // 
            // frmDash_board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 806);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDash_board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash_board";
            this.Load += new System.EventHandler(this.Dash_board_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnThutien;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnNhapsach;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelControl;
    }
}