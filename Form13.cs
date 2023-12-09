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
    public partial class ActiveOrdersWindow : Form
    {
        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        public ActiveOrdersWindow()
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
                             o.order_agreement = 1";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Загрузка данных в DataGridView
                        while (reader.Read())
                        {
                            DataBaseActiveOrders.Rows.Add(
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ClientOrdersWindow();
            myForm.Show();
        }
    }
}
