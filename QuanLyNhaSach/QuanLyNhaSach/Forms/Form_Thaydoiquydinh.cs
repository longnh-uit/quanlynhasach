using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Form_Thaydoiquydinh : Form
    {
        public Form_Thaydoiquydinh()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSotienphaitra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblSotienthua_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxGiamgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSotiennhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Thaydoiquydinh_Load(object sender, EventArgs e)
        {

        }

        private void logo2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void txtSlmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongtonmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxNomin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxTonbanmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isEmpty()
        {
            if (cbNomin.Checked && txtBoxNomin.TextLength==0)
            {
                return false;
            }
            if (cbSlmin.Checked && txtSlmin.TextLength == 0)
            {
                return false;
            }
            if (cbLuongtonmax.Checked && txtLuongtonmax.TextLength==0)
            {
                return false;
            }
            if (cbTonbanmin.Checked && txtBoxTonbanmin.TextLength==0)
            {
                return false;
            }
            if (txtBoxDongia.TextLength == 0)
                return false;
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                MessageBox.Show("Nhập tất cả các mục còn trống");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Ghi vào DATABASE;
                    this.Dispose();
                }

            }
        }

        private void cbSlmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSlmin.Checked)
            {
                Color cl = Color.FromArgb(0, 71, 160);
                txtSlmin.ReadOnly = false;
                cbSlmin.ForeColor = cl;
            }
            else
            {
                Color cl = Color.FromName("Red");
                txtSlmin.ReadOnly = true;
                cbSlmin.ForeColor = cl;
            }
        }

        private void cbLuongtonmax_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLuongtonmax.Checked)
            {
                txtLuongtonmax.ReadOnly = false;
                Color cl = Color.FromArgb(0, 71, 160);
                cbLuongtonmax.ForeColor = cl;

            }
            else
            {
                Color cl = Color.FromName("Red");
                txtLuongtonmax.ReadOnly = true;
                cbLuongtonmax.ForeColor = cl;
            }
        }

        private void cbNomin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNomin.Checked)
            {
                txtBoxNomin.ReadOnly = false;
                Color cl = Color.FromArgb(0, 71, 160);
                cbNomin.ForeColor = cl;
            }
            else
            {
                txtBoxNomin.ReadOnly = true;
                Color cl = Color.FromName("Red");
                cbNomin.ForeColor = cl;
            }
        }

        private void cbTonbanmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTonbanmin.Checked)
            {
                txtBoxTonbanmin.ReadOnly = false;
                Color cl = Color.FromArgb(0, 71, 160);
                cbTonbanmin.ForeColor = cl;
            }
            else
            {
                txtBoxTonbanmin.ReadOnly = true;
                Color cl = Color.FromName("Red");
                cbTonbanmin.ForeColor = cl;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
