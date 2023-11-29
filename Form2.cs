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
    public partial class ClientWindow : Form
    {

        DataBase dataBase = new DataBase();

        public ClientWindow()
        {
            InitializeComponent();
        }

        private void ClientOrderListButton_Click(object sender, EventArgs e)
        {
            var myForm = new ClientOrdersWindow();
            myForm.Show();
        }
    }
}
