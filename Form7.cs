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
    public partial class ClientOrdersWindow : Form
    {

        DataBase dataBase = new DataBase();

        public ClientOrdersWindow()
        {
            InitializeComponent();
        }
    }
}
