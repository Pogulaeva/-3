﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_FISU
{
    public partial class AccountChooseWindow : Form
    {
        public AccountChooseWindow()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            var myForm = new ClientWindow();
            myForm.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            var myForm = new AdminWindow();
            myForm.Show();
        }
    }
}