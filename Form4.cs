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
    public partial class StuffStorageWindow : Form
    {

        DataBase dataBase = new DataBase();

        public StuffStorageWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
            MySqlConnection connection = new MySqlConnection(connectString);
            connection.Open();
            string query = "SELECT * FROM Products ORDER BY id";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while(reader.Read())
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
                DataBaseAdmin.Rows.Add(s);
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            var myForm = new NewProductWindow();
            myForm.Show();
            this.Hide();
        }

        private void DataBaseAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBaseAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataBaseAdmin.CurrentRow.Selected = true;
                IdOutput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                NameInputBox.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                PriceInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                AmountInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                DateInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["supply_date"].FormattedValue.ToString();
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
            MySqlConnection connection = new MySqlConnection(connectString);
            connection.Open();
            string id = IdOutput.Text;
            string name = NameInputBox.Text;
            string price = PriceInput.Text;
            string amount = AmountInput.Text;
            string supplydate = DateInput.Text;

            string SaveChangesSQL = $"UPDATE Products SET name_product = '" + name + "', price_product = '" + price + "', amount_product = '" + amount + "', supply_date = '" + supplydate + "' WHERE id =" + id;
            MySqlCommand command = new MySqlCommand(SaveChangesSQL, connection);
            command.ExecuteReader();
            connection.Close();

            MessageBox.Show("Товар успешно изменён!", "");
            // Очистка данных в DataGridView перед обновлением
            DataBaseAdmin.DataSource = null;
            DataBaseAdmin.Rows.Clear();
            DataBaseAdmin.Columns.Clear();

            LoadData1();
        }
        private void LoadData1()
        {
            string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
            using (MySqlConnection connection = new MySqlConnection(connectString))
            {
                string query = "SELECT * FROM Products"; 

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataBaseAdmin.DataSource = dataTable;
                }
            }
        }
    }
}
