﻿using System;
using System.Drawing;

namespace DXApplication1
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        FormRegister frmRegister = new FormRegister();

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            frmRegister.Show();
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void svgImageBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            txtUsername_Login.Clear();

            picUsername.Image = Properties.Resources.userlogo_before;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername_Login.ForeColor = Color.FromArgb(78, 184, 206);

            if (txtPassword_Login.Text == "" || txtPassword_Login.Text == "Password")
            {
                txtPassword_Login.Text = "Password";
                picPassword.Image = Properties.Resources.private_icon1;
                panel2.ForeColor = Color.WhiteSmoke;
                txtPassword_Login.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                picPassword.Image = Properties.Resources.private_icon_before;
                panel2.ForeColor = Color.FromArgb(78, 184, 206);
                txtPassword_Login.ForeColor = Color.FromArgb(78, 184, 206);

            }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword_Login.Clear();

            picPassword.Image = Properties.Resources.private_icon_before;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword_Login.ForeColor = Color.FromArgb(78, 184, 206);

            if (txtUsername_Login.Text == "" || txtUsername_Login.Text == "Username")
            {
                txtUsername_Login.Text = "Username";
                picUsername.Image = Properties.Resources.userlogo;
                panel1.ForeColor = Color.WhiteSmoke;
                txtUsername_Login.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                picPassword.Image = Properties.Resources.private_icon_before;
                panel1.ForeColor = Color.FromArgb(78, 184, 206);
                txtUsername_Login.ForeColor = Color.FromArgb(78, 184, 206);

            }

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmRegister.Left += 10;
            label3.Text = frmRegister.Size.ToString();
            if (frmRegister.Left >= 1000)
            {
                timer1.Stop();
                this.TopMost = false;
                frmRegister.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frmRegister.Left -= 10;
            if (frmRegister.Left <= 700)
            {
                timer2.Stop();
            }
        }
    }
}
