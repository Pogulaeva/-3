using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_FISU
{
    public partial class StuffStorageWindow : Form
    {

        DataBase dataBase = new DataBase();

        public StuffStorageWindow()
        {
            InitializeComponent();
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            var myForm = new NewProductWindow();
            myForm.Show();
        }
    }
}
