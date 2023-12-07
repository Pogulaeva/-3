using System;
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
    public partial class ChooseOrderListWindow : Form
    {
        public ChooseOrderListWindow()
        {
            InitializeComponent();
        }

        private void UnapprovedOrdersButton_Click(object sender, EventArgs e)
        {
            var myForm = new OrderListWindow();
            myForm.Show(); 
        }
    }
}
