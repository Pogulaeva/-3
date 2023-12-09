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
    public partial class OrdersNotConfirmedByAdminWindow : Form
    {
        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        int amounttestproduct;
        string priceproduct;
        string amountproducts;
        int amountproductint;
        public OrdersNotConfirmedByAdminWindow()
        {
            InitializeComponent();
            LoadData();
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
                            o.amount_product, 
                            p.amount_products,
                            p.price_product,
                            o.order_price, 
                            o.order_date
                        FROM 
                            Orders o
                            INNER JOIN Products p ON o.id_product = p.id
                        WHERE
                             o.order_agreement = 0
                        AND o.order_was_edited = 0
                        AND o.changes_confirm = 0";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Загрузка данных в DataGridView
                        while (reader.Read())
                        {
                            DataBaseUnwatchedOrders.Rows.Add(
                                reader["id"],
                                reader["name_product"],
                                reader["amount_product"],
                                reader["amount_products"],
                                reader["price_product"],
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
        private void DataBaseWaitingForConfirm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataBaseUnwatchedOrders.CurrentRow.Selected = true;
                IDoutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                NameProductOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                AmountProductChange.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                OrderPriceOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["order_price"].FormattedValue.ToString();
                OrderDateOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["order_date"].FormattedValue.ToString();
                ActualPriceOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                NewOrderPriceOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["order_price"].FormattedValue.ToString();
                priceproduct = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                StorageProductOutput.Text = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["amount_products"].FormattedValue.ToString();
                string amounttest = DataBaseUnwatchedOrders.Rows[e.RowIndex].Cells["amount_products"].FormattedValue.ToString();
                amounttestproduct = Int32.Parse(amounttest);
                amountproducts = AmountProductChange.Text;
                amountproductint = Int32.Parse(amountproducts);
            }
        }
        private void AmountProductChange_ValueChanged(object sender, EventArgs e)
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
            NewOrderPriceOutput.Text = changingprice;
        }

        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            if (IDoutput.Text.Length > 0)
            {

                    if (((int)AmountProductChange.Value <= amounttestproduct) && ((int)AmountProductChange.Value > 0))
                    {
                    if ((int)AmountProductChange.Value != amountproductint)
                    {
                        MySqlConnection connection = new MySqlConnection(connectString);
                        connection.Open();

                        string amountproduct = AmountProductChange.Text;
                        string orderprice = NewOrderPriceOutput.Text;
                        string id = IDoutput.Text;
                        string ChangingOrderSQL = $"UPDATE Orders SET amount_product = '" + amountproduct + "', order_price = '" + orderprice + "'  WHERE id =" + id;
                        MySqlCommand command = new MySqlCommand(ChangingOrderSQL, connection);
                        command.ExecuteReader();
                        connection.Close();

                        MessageBox.Show("Заказ изменён!", "");
                        // Очистка данных в DataGridView перед обновлением
                        DataBaseUnwatchedOrders.DataSource = null;
                        DataBaseUnwatchedOrders.Rows.Clear();
                        DataBaseUnwatchedOrders.Columns.Clear();

                        LoadData1();
                    }
                    else
                    {
                        MessageBox.Show("Вы не изменили данных о заказе", "");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Такого количества товара не имеется на складе", "");
                    }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }


        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить заказ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection(connectString);
                connection.Open();
                string id = IDoutput.Text;
                string DeleteOrderSQL = $"DELETE from Orders WHERE id =" + id;
                MySqlCommand command = new MySqlCommand(DeleteOrderSQL, connection);
                command.ExecuteReader();
                connection.Close();

                MessageBox.Show("Заказ отменён", "");
                // Очистка данных в DataGridView перед обновлением
                DataBaseUnwatchedOrders.DataSource = null;
                DataBaseUnwatchedOrders.Rows.Clear();
                DataBaseUnwatchedOrders.Columns.Clear();

                LoadData1();
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
                            o.amount_product, 
                            p.amount_products,
                            p.price_product,
                            o.order_price, 
                            o.order_date
                        FROM 
                            Orders o
                            INNER JOIN Products p ON o.id_product = p.id
                        WHERE
                             o.order_agreement = 0
                        AND o.order_was_edited = 0
                        AND o.changes_confirm = 0";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataBaseUnwatchedOrders.DataSource = dataTable;
                }
            }
        }

        private void TipToClient_MouseEnter(object sender, EventArgs e)
        {
            var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
            tooltip.SetToolTip(TipToClient, "Обратите внимание, что при изменении заказа\n товар будет приобретаться по актуальной цене,\n а не той, что была"); //Вывод текста в подсказке 
        }
    }
}
