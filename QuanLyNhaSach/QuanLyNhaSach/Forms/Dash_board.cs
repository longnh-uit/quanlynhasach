using QuanLyNhaSach.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class frmDash_board : Form
    {
        int PanelWidth;
        bool isColapsed;
        public frmDash_board()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isColapsed = false;
            timerTime.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dash_board_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                panelLeft.Width = panelLeft.Width + 3;
                if (panelLeft.Width>=PanelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 3;
                if (panelLeft.Width <= 63)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }


        private void btnNhapsach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhapsach);
            UC_Nhapsach ucns = new UC_Nhapsach();
            AddControltoPanel(ucns);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoadon);
            UC_Hoadon uchd = new UC_Hoadon();
            AddControltoPanel(uchd);
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTracuu);
            UC_Tracuu uctc = new UC_Tracuu();
            AddControltoPanel(uctc);
        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThutien);
            UC_Phieutratien utptt = new UC_Phieutratien();
            AddControltoPanel(utptt);
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBaocao);
        }
        private void AddControltoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThaydoiquydinh_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThaydoiquydinh);
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
