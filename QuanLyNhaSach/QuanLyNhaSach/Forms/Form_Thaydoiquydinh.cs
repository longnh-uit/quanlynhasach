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
            txtBoxSlmin.Text = Globals.Slmin.ToString();
            txtLuongtonmax.Text = Globals.Luongtonmax.ToString();
            txtBoxNomax.Text = Globals.Nomax.ToString();
            txtBoxTonbanmin.Text = Globals.Tonbanmin.ToString();
            if (Globals.tienthuvuottienno) cbVuotTienNo.CheckState = CheckState.Checked;
            else cbVuotTienNo.CheckState = CheckState.Unchecked;
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
            if (txtBoxNomax.TextLength==0)
            {
                return false;
            }
            if (txtBoxSlmin.TextLength == 0)
            {
                return false;
            }
            if (txtLuongtonmax.TextLength==0)
            {
                return false;
            }
            if (txtBoxTonbanmin.TextLength==0)
            {
                return false;
            }
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
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Globals.Slmin = int.Parse(txtBoxSlmin.Text);
                    Globals.Luongtonmax = int.Parse(txtLuongtonmax.Text);
                    Globals.Nomax = int.Parse(txtBoxNomax.Text);
                    Globals.Tonbanmin = int.Parse(txtBoxTonbanmin.Text);
                    if (cbVuotTienNo.CheckState == CheckState.Checked) Globals.tienthuvuottienno = true;
                    else Globals.tienthuvuottienno = false;

                    //Ghi vào DATABASE;
                    using (SqlConnection con = new SqlConnection(Globals.sqlcon.ConnectionString))
                        using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "update THAMSO " +
                            "set LuongNhapItNhat = @Slmin, LuongTonToiDa = @Luongtonmax, NoToiDa = @Nomax, LuongTonToiThieu = @Tonbanmin, KiemTraSoTienThu = @Vuottienthu";
                        command.Parameters.AddWithValue("@Slmin", Globals.Slmin.ToString());
                        command.Parameters.AddWithValue("@Luongtonmax", Globals.Luongtonmax.ToString());
                        command.Parameters.AddWithValue("@Nomax", Globals.Nomax.ToString());
                        command.Parameters.AddWithValue("@Tonbanmin", Globals.Tonbanmin.ToString());
                        if (Globals.tienthuvuottienno) command.Parameters.AddWithValue("@Vuottienthu", "1");
                        else command.Parameters.AddWithValue("@Vuottienthu", "0");

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }

                    this.Dispose();
                }

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
