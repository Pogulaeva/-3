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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ToStuffListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new StuffStorageWindow();
            myForm.Show();
        }

        private void ToOrderListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ChooseOrderListWindow();
            myForm.Show(); 
        }

        private void ChangeAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new AccountChooseWindow();
            myForm.Show();
        }
    }
}
