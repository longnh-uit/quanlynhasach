using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class frmThongTinThem : Form
    {
        public string diaChi, email;
        public bool cancel = false;

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            diaChi = txtBoxDiachi.Text;
            email = txtBoxEmail.Text;
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancel = true;
            Dispose();
        }

        public frmThongTinThem()
        {
            InitializeComponent();
        }
    }
}
