﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form message = new Form();
            MessageBox.Show("Ваш логин:" + tbLogin.Text + "\nВаш пароль:" + tbPassword.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbLogin.Text);
        }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbPassword.Text);
        }
        private void KeysComb(KeyEventArgs e, String tb)
        {
            if (e.KeyCode == Keys.F10)
            {
                MessageBox.Show(tb);
            }
        }
    }
}
