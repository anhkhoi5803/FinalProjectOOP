﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeFactory.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            mainmenu.ShowDialog() ;

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            var mainmenu = new MainMenu();
            mainmenu.ShowDialog();
        }
    }
}
