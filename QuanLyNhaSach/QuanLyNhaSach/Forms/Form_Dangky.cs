﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Form_Dangky : Form
    {
        ComboBox cur;
        public Form_Dangky()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form_Dangky_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selected = ""; //Chức vụ
            if (cur!=null)
            {
                selected = cur.Text;
            }
            if (txtBoxMatkhau.TextLength != 0 && txtBoxNhaplaimatkhau.TextLength != 0 && txtBoxTentk.TextLength != 0 && selected!="")
            {
                bool isExist = false; //Cần kiểm tra tên tài khoản có trong database chưa, tồn tại rồi thì true, không thì false
                
                if (!isExist && txtBoxMatkhau.Text == txtBoxNhaplaimatkhau.Text)
                {
                    MessageBox.Show("Đăng kí tài khoản thành công!");
                    //Thêm vào DATABASE
                    this.Dispose();
                }
                else
                {
                    if (isExist)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu đã nhập không khớp với nhau!");
                    }
                }
            }
            else {
                MessageBox.Show("Cần nhập tất các các mục!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void logo2_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur = sender as ComboBox;
        }
    }
}
