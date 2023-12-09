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
    public partial class OrdersNotConfirmByClientWindow : Form
    {
        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        public OrdersNotConfirmByClientWindow()
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
                            o.order_price, 
                            o.order_date
                        FROM 
                            Orders o
                            INNER JOIN Products p ON o.id_product = p.id
                        WHERE
                             o.order_agreement = 0
                        AND o.order_was_edited = 1
                        AND o.changes_confirm = 0";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Загрузка данных в DataGridView
                        while (reader.Read())
                        {
                            DataBaseWaitingForConfirm.Rows.Add(
                                reader["id"],
                                reader["name_product"],
                                reader["amount_product"],
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
            try
            {
                if (DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataBaseWaitingForConfirm.CurrentRow.Selected = true;
                    IDOutput.Text = DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    NameOutput.Text = DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                    AmountOutput.Text = DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                    PriceOutput.Text = DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells["order_price"].FormattedValue.ToString();
                    DateOutput.Text = DataBaseWaitingForConfirm.Rows[e.RowIndex].Cells["order_date"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите одну запись, а не шапку таблицы", "");
            }
        }

        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            if (IDOutput.Text.Length > 0)
            {
                if (MessageBox.Show("Вы подтверждаете изменения в своём заказе?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection(connectString);
                    connection.Open();

                    string id = IDOutput.Text;
                    int ChangesConfirm = 1;
                    string ConfirmChangesSQL = $"UPDATE Orders SET changes_confirm = '" + ChangesConfirm + "' WHERE id =" + id;
                    MySqlCommand command = new MySqlCommand(ConfirmChangesSQL, connection);
                    command.ExecuteReader();
                    connection.Close();

                    MessageBox.Show("Ваш заказ отправлен на рассмотрение администратору!", "");
                    this.Hide();
                    var myForm = new OrdersNotConfirmByClientWindow();
                    myForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }
        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            if (IDOutput.Text.Length > 0)
            {
                if (MessageBox.Show("Вы действительно хотите отменить заказ?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection(connectString);
                    connection.Open();
                    string id = IDOutput.Text;
                    string DeleteOrderSQL = $"DELETE from Orders WHERE id =" + id;
                    MySqlCommand command = new MySqlCommand(DeleteOrderSQL, connection);
                    command.ExecuteReader();
                    connection.Close();

                    MessageBox.Show("Заказ отменён", "");
                    this.Hide();
                    var myForm = new OrdersNotConfirmByClientWindow();
                    myForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ClientOrdersWindow();
            myForm.Show();
        }
     
    }
}
