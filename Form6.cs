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
    public partial class NewProductWindow : Form
    {

        DataBase dataBase = new DataBase();

        public NewProductWindow()
        {
            InitializeComponent();
        }

        private void NameInputBox_TextChanged(object sender, EventArgs e)
        {
            AddProductButton.Visible = NameInputBox.Text.Length > 0;
        }

        private void PriceStandardInfo_Click(object sender, EventArgs e)
        {
           var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
           tooltip.SetToolTip(PriceStandardInfo, "Писать в поле цены товара нужно только цифры, ничего более"); //Вывод текста в подсказке 
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {

            DataBase dataBase = new DataBase();

            var name = NameInputBox.Text;
            var price = PriceInput.Value;
            var amount = AmountInput.Value;
            var supplydate = DateInput.Text;

            string AddingProduct = $"insert into Products(name_product, price_product, amount_product, supply_date) values ('{name}', '{price}', '{amount}', '{supplydate}')";

            MySqlCommand command = new MySqlCommand(AddingProduct, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар успешно добавлен!", "");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Товар не добавлен", "");
            }
            dataBase.closeConnection();
        }
    }
}
