﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_FISU
{
    //Создание формы
    public partial class AccountChooseWindow : Form
    {

        DataBase dataBase = new DataBase();

        public AccountChooseWindow()
        {
            InitializeComponent();
        }

        //Функция открытия окна ClientWindow
        private void ClientButton_Click(object sender, EventArgs e)
        {
            var myForm = new ClientWindow();
            myForm.Show();
        }

        //Функция открытия окна AdminWindow
        private void AdminButton_Click(object sender, EventArgs e)
        {
            var myForm = new AdminWindow();
            myForm.Show();
        }
    }
}
