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
    public partial class ClientOrdersWindow : Form
    {

        DataBase dataBase = new DataBase();

        public ClientOrdersWindow()
        {
            InitializeComponent();
        }


        private void OrdersNotConfirmByClientButton_MouseEnter(object sender, EventArgs e)
        {
            var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
            tooltip.SetToolTip(OrdersNotConfirmByClientButton, "В этом списке заказов вы можете подтвердить изменённый администратором заказ\nили же удалить в случае несогласия на меньшее кол-во товара.\nЕсли вы не подтвердите заказ, то товар не будет отправлен"); //Вывод текста в подсказке 
        
        }

        private void ActiveOrdersButton_MouseEnter(object sender, EventArgs e)
        {
            var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
            tooltip.SetToolTip(ActiveOrdersButton, "Вы можете просто просматривать список заказов,\nкоторые исполняются работниками интернет магазина"); //Вывод текста в подсказке 

        }

        private void OrdersNotConfirmedByAdminButton_MouseEnter(object sender, EventArgs e)
        {
            var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
            tooltip.SetToolTip(OrdersNotConfirmedByAdminButton, "В этом списке заказов вы можете изменить\nкол-во заказываемого товара либо вовсе удалить заказ"); //Вывод текста в подсказке 

        }

        private void OrdersNotConfirmByClientButton_Click(object sender, EventArgs e)
        {
            var myForm = new OrdersNotConfirmByClientWindow();
            myForm.Show();
        }

        private void OrdersNotConfirmedByAdminButton_Click(object sender, EventArgs e)
        {
            var myForm = new OrdersNotConfirmedByAdminWindow();
            myForm.Show();
        }

        private void ActiveOrdersButton_Click(object sender, EventArgs e)
        {
            var myForm = new ActiveOrdersWindow();
            myForm.Show();
        }
    }
}
