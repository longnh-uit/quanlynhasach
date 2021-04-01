using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Dash_board : Form
    {
        int PanelWidth;
        bool isColapsed;
        public Dash_board()
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnNhapsach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhapsach);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoadon);
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTracuu);
        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnThutien);
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBaocao);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
