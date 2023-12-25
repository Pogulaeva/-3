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
    //Создание формы
    public partial class ClientWindow : Form
    {

        DataBase dataBase = new DataBase();
        String ID;
        private DateTime orderdate;
        int amounttestproduct;

        public ClientWindow()
        {
            InitializeComponent();
            LoadData();
        }

        //Функция открытия окна ClientOrdersWindow
        private void ClientOrderListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ClientOrdersWindow();
            myForm.Show();
        }

        //Функция возврата к выбору аккаунта
        private void ChangeAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Загрузка данных из БД в элемент формы DataBaseClient
        private void LoadData()
        {
            string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
            MySqlConnection connection = new MySqlConnection(connectString);
            connection.Open();
            string query = "SELECT * FROM Products WHERE amount_products > 0 ORDER BY id";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();
            connection.Close();
            foreach (string[] s in data)
                DataBaseClient.Rows.Add(s);
        }

        //Функция переноса выбранных из DataBaseClient данных в удобный просмотр и редактирование заказа
        private void DataBaseClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Загрузка данных каждой ячейки из выбранной строки в элементы для редактирования
                if (DataBaseClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataBaseClient.CurrentRow.Selected = true;
                    ID = DataBaseClient.Rows[e.RowIndex].Cells["idd"].FormattedValue.ToString();
                    NameOutput.Text = DataBaseClient.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                    PriceOutput.Text = DataBaseClient.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                    string amounttest = DataBaseClient.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                    amounttestproduct = Int32.Parse(amounttest);
                    MakeOfFinalPrice();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите одну запись, а не шапку таблицы", "");
            }
        }

        //Функция проверки в случае того, если клиент вдруг захочет поменять значение в ChangeAmountBox, не выбрав товар
        private void ChangeAmountBox_ValueChanged(object sender, EventArgs e)
        {
            if (ID != null)
            {
                MakeOfFinalPrice();
            }
            else
            {
                MessageBox.Show("Сначала выберите товар из списка", "");
            }
        }
        //Функция подсчёта итоговой суммы заказа
        private void MakeOfFinalPrice()
        {
            // Обновление текста в ForPaymentOutput при изменении значения в ChangeAmountBox
            int amount = (int)ChangeAmountBox.Value;
            int price = Int32.Parse(PriceOutput.Text);
            int finalprice = amount * price;
            String changingprice = finalprice.ToString();
            ForPaymentOutput.Text = changingprice;
        }
        //Функция формирования заказа и запись в БД
        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            if (ID != null) //Проверка выбранности товара из списка
            {
                if (((int)ChangeAmountBox.Value > 0) && ((int)ChangeAmountBox.Value <= amounttestproduct)) //Проверка указанного кол-ва товара(не должно быть меньше 1 и больше, чем есть на складе)
                {
                    if (MessageBox.Show("Сделать заказ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Проверка возможного случайного нажатия клиентом кнопки
                    {
                        // Запись текущей даты и времени при нажатии на кнопку
                        orderdate = DateTime.Now;

                        //Отправка информации о заказе в БД
                        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
                        MySqlConnection connection = new MySqlConnection(connectString);
                        connection.Open();

                        string idproduct = ID;
                        string price = ForPaymentOutput.Text;
                        string amount = ChangeAmountBox.Text;
                        int orderagreement = 0;
                        int changesconfirm = 0;
                        int orderwasedited = 0;
                        string MakeOrderSQL = $"insert into Orders(id_product, amount_product, order_price, order_date, order_agreement, changes_confirm, order_was_edited) values ('{idproduct}', '{amount}', '{price}', '{orderdate}', '{orderagreement}', '{changesconfirm}', '{orderwasedited}')";
                        MySqlCommand command = new MySqlCommand(MakeOrderSQL, connection);
                        command.ExecuteReader();
                        connection.Close();

                        MessageBox.Show("Заказ сформирован, ждите одобрения заказа от администратора", "");
                    }
                }
                else
                {
                    MessageBox.Show("Такого количества товара нет на складе!", "");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите товар для совершения заказа!", "");
            }

        }

       
    }
}
