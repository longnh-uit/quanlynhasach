using QuanLyNhaSach.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Forms
{
    public partial class frmDash_board : Form
    {
        public bool logOut = true;
        int mov, movX, movY;

        public frmDash_board()
        {
            InitializeComponent();
            timerTime.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            Globals.status = 1;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Unable_button(Button b)
        {
            b.Enabled = false;
            Color cl = Color.FromName("Gray");
            b.ForeColor = cl;
        }
        private void Dash_board_Load(object sender, EventArgs e)
        {
            Globals.status = 0;
            logOut = false;
            lblWelcome.Text += Globals.name;
            lblRole.Text += Globals.role;

            // Kiểm tra các quy định
            Globals.sqlcon.Open();
            string query = "select * from THAMSO";
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable thamso = new DataTable();
            sda.Fill(thamso);
            Globals.sqlcon.Close();

            Globals.Slmin = thamso.Rows[0].Field<int>("LuongNhapItNhat");
            Globals.Tonbanmin = thamso.Rows[0].Field<int>("LuongTonToiThieu");
            Globals.Luongtonmax = thamso.Rows[0].Field<int>("LuongTonToiDa");
            Globals.Nomax = thamso.Rows[0].Field<int>("NoToiDa");
            Globals.tienthuvuottienno = thamso.Rows[0].Field<bool>("KiemTraSoTienThu");

            //Khi mới bật thì ở mục tra cứu
            UC_Tracuu uctc = new UC_Tracuu();
            AddControltoPanel(uctc);
            moveSidePanel(btnTracuu);

            string Chucvu = Globals.role; // Cần kiểm tra tài khoản login chức vụ gì rồi gán vô đây
            if (Chucvu=="Nhân viên bán hàng")
            {
                Unable_button(btnBaocao);
                Unable_button(btnNhansu);
                Unable_button(btnThaydoiquydinh);
            }
            else if (Chucvu=="Thủ kho")
            {
                Unable_button(btnBaocao);
                Unable_button(btnNhansu);
                Unable_button(btnThaydoiquydinh);
                Unable_button(btnThutien);
                Unable_button(btnHoadon);
            }    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

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
            UC_Baocao ucbc = new UC_Baocao();
            AddControltoPanel(ucbc);
        }
        private void AddControltoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            lblDoiThongTin.Controls.Clear();
            lblDoiThongTin.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm:ss");
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
            //moveSidePanel(btnThaydoiquydinh);
            Form_Thaydoiquydinh tdqd = new Form_Thaydoiquydinh();
            tdqd.ShowDialog();
        }

        private void btnNhansu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhansu);
            UC_Nhansu ucns = new UC_Nhansu();
            AddControltoPanel(ucns);

        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmDoiThongTin dmk = new frmDoiThongTin();
            dmk.ShowDialog();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
