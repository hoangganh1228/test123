﻿using Manager_Hotel.ClassLoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public static string tenTK = ""
;        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenTK = txtUserName.Text;
            string matKhau = txtPass.Text;
            if(tenTK.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string squery = "select * from TaiKhoan where TenDangNhap= '" + tenTK + "' and MatKhau = '"+matKhau+"'";
                if(modify.TaiKhoans(squery).Count > 0 )
                {
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            txtPass.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau mk = new QuenMatKhau();
            mk.ShowDialog();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender,e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
