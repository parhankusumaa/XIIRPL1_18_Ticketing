﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL1_18_Ticketing.MasterForm;

namespace XIIRPL1_18_Ticketing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
