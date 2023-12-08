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
    public partial class OrderListWindow : Form
    {

        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        int amounttestproduct;
        string priceproduct;
        public OrderListWindow()
        {
            InitializeComponent();
            LoadData(); // Вызов метода для загрузки данных в DataGridView при загрузке формы
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            o.id, 
                            p.name_product,
                            p.price_product, 
                            o.amount_product, 
                            p.amount_products,
                            o.order_price, 
                            o.order_date
                        FROM 
                            Orders o
                            INNER JOIN Products p ON o.id_product = p.id
                        WHERE
                             o.order_agreement = 0";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Загрузка данных в DataGridView
                        while (reader.Read())
                        {
                            DataBaseUnconfirmedOrders.Rows.Add(
                                reader["id"],
                                reader["name_product"],
                                reader["price_product"],
                                reader["amount_product"],
                                reader["amount_products"],
                                reader["order_price"],
                                reader["order_date"]

                            );
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DataBaseUnconfirmedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataBaseUnconfirmedOrders.CurrentRow.Selected = true;
                IDoutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                NameProductOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                AmountProductChange.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                OrderPriceOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["order_price"].FormattedValue.ToString();
                OrderDateOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["order_date"].FormattedValue.ToString();
                string amounttest = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                priceproduct = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                amounttestproduct = Int32.Parse(amounttest);
                MakeOfFinalPrice();

            }
        }
        private void ChangeAmountBox_ValueChanged(object sender, EventArgs e)
        {
            MakeOfFinalPrice();
        }
        private void MakeOfFinalPrice()
        {
            // Обновление текста в Label при изменении значения в NumericUpDown
            int amount = (int)AmountProductChange.Value;
            int price = Int32.Parse(priceproduct);
            int finalprice = amount * price;
            String changingprice = finalprice.ToString();
            OrderPriceOutput.Text = changingprice;
        }


        private void ApproveOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderApproveCheckBox.Checked)
            {
                if ((int)AmountProductChange.Value == amounttestproduct)
                {
                    MySqlConnection connection = new MySqlConnection(connectString);
                    connection.Open();

                    int orderagreement = 1;
                    string id = IDoutput.Text;
                    string ApproveOrderSQL = $"UPDATE Orders SET order_agreement = '" + orderagreement + "' WHERE id =" + id;
                    MySqlCommand command = new MySqlCommand(ApproveOrderSQL, connection);
                    command.ExecuteReader();
                    connection.Close();

                    MessageBox.Show("Заказ подтверждён!", "");
                    // Очистка данных в DataGridView перед обновлением
                    DataBaseUnconfirmedOrders.DataSource = null;
                    DataBaseUnconfirmedOrders.Rows.Clear();
                    DataBaseUnconfirmedOrders.Columns.Clear();

                    LoadData1();
                }
                else
                {
                    MessageBox.Show("При подтверждении заказа количество товара менять нельзя, верните изначальное количество товара в заказе", "");
                }
            }
            else
            {
                MessageBox.Show("Если вы хотите подтвердить заказ, установите галочку рядом с надписью «подтвердить заказ»", "");
            }
        }
        private void LoadData1()
        {
            using (MySqlConnection connection = new MySqlConnection(connectString))
            {
                string query = @"
                        SELECT 
                            o.id, 
                            p.name_product,
                            p.price_product, 
                            o.amount_product, 
                            p.amount_products,
                            o.order_price, 
                            o.order_date
                        FROM 
                            Orders o
                            INNER JOIN Products p ON o.id_product = p.id
                        WHERE
                             o.order_agreement = 0";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataBaseUnconfirmedOrders.DataSource = dataTable;
                }
            }
        }
        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            if ((int)AmountProductChange.Value != amounttestproduct)
            {
                if ((int)AmountProductChange.Value > 0)
                {
                    if ((int)AmountProductChange.Value <= amounttestproduct)
                    {
                        if (OrderApproveCheckBox.Checked)
                        {
                            MessageBox.Show("При внесении изменений в заказ нельзя ставить галочку рядом с надписью «подтвердить заказ»", "");
                        }
                        else
                        {
                            MySqlConnection connection = new MySqlConnection(connectString);
                            connection.Open();

                            string id = IDoutput.Text;
                            string amount = AmountProductChange.Text;
                            string SaveChangesSQL = $"UPDATE Orders SET amount_product = '" + amount + "' WHERE id =" + id;
                            MySqlCommand command = new MySqlCommand(SaveChangesSQL, connection);
                            command.ExecuteReader();
                            connection.Close();

                            MessageBox.Show("Заказ успешно изменён!", "");
                            // Очистка данных в DataGridView перед обновлением
                            DataBaseUnconfirmedOrders.DataSource = null;
                            DataBaseUnconfirmedOrders.Rows.Clear();
                            DataBaseUnconfirmedOrders.Columns.Clear();

                            LoadData1();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество товара не должно превышать количество заказанного товара клиентом!", "");
                    }
                }
                else
                {
                    MessageBox.Show("Такого количества товара нет на складе", "");
                }
            }
            else
            {
                MessageBox.Show("Вы не внесли никаких изменений в поле количества товара, внесите изменения, если хотите изменить заказ", "");
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить заказ клиента? (Если вы нажмёте «да», запись о заказе автоматически удалится)", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection(connectString);
                connection.Open();
                string id = IDoutput.Text;
                string DeleteOrderSQL = $"DELETE from Orders WHERE id =" + id;
                MySqlCommand command = new MySqlCommand(DeleteOrderSQL, connection);
                command.ExecuteReader();
                connection.Close();

                MessageBox.Show("Заказ отменён. Напишите причину, по которой отменили заказ", "");
                var myForm = new CommentForDeletingWindow();
                myForm.Show();
                this.Hide();
            }
        }
    }
}

