using System;
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
    public partial class AccountChooseWindow : Form
    {

        DataBase dataBase = new DataBase();

        public AccountChooseWindow()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ClientWindow();
            myForm.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new AdminWindow();
            myForm.Show();
        }
    }
}
