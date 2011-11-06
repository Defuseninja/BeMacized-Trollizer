﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeMacized_Trollizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "BeMacized Trollizer - " + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPwdGen_Click(object sender, EventArgs e)
        {
            try
            {
                txtPwd.Text = Wouter.Main.GenPassword(Convert.ToInt32(txtPwdLgth.Text));
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void btnMD5gen_Click(object sender, EventArgs e)
        {
            txtMD5output.Text = Wouter.Main.GenMD5(txtMD5input.Text, MD5useweb.Checked);
        }
    }
}
