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
    public partial class ClientWindow : Form
    {

        DataBase dataBase = new DataBase();
        String ID;

        public ClientWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void ClientOrderListButton_Click(object sender, EventArgs e)
        {
            var myForm = new ClientOrdersWindow();
            myForm.Show();
        }

        private void ChangeAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new AccountChooseWindow();
            myForm.Show();
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

        private void DataBaseClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBaseClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataBaseClient.CurrentRow.Selected = true;
                ID = DataBaseClient.Rows[e.RowIndex].Cells["idd"].FormattedValue.ToString();
                NameOutput.Text = DataBaseClient.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                PriceOutput.Text = DataBaseClient.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
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
            int amount = (int)ChangeAmountBox.Value;
            int price = Int32.Parse(PriceOutput.Text);
            int finalprice = amount * price;
            String changingprice = finalprice.ToString();
            ForPaymentOutput.Text = changingprice;
        }

    }
}
