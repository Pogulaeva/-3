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
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace IS_FISU
{
    public partial class StuffStorageWindow : Form
    {

        DataBase dataBase = new DataBase();

        string nametest;
        string pricetest;
        string amounttest;
        string supplydatetest;

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
            this.Hide();
            var myForm = new NewProductWindow();
            myForm.Show();
        }

        private void DataBaseAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataBaseAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataBaseAdmin.CurrentRow.Selected = true;
                    IdOutput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    NameInputBox.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                    PriceInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                    AmountInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["amount_products"].FormattedValue.ToString();
                    DateInput.Text = DataBaseAdmin.Rows[e.RowIndex].Cells["supply_date"].FormattedValue.ToString();

                    nametest = NameInputBox.Text;
                    pricetest = PriceInput.Text;
                    amounttest = AmountInput.Text;
                    supplydatetest = DateInput.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите одну запись, а не шапку таблицы", "");
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (IdOutput.Text.Length > 0)
            {
                if (MessageBox.Show("Вы уверены что хотите изменить данные о товаре?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string id = IdOutput.Text;
                    string name = NameInputBox.Text;
                    string price = PriceInput.Text;
                    string amount = AmountInput.Text;
                    string supplydate = DateInput.Text;
                    if ((NameInputBox.Text != nametest) | (PriceInput.Text != pricetest) | (AmountInput.Text != amounttest) | (DateInput.Text != supplydatetest))
                    {
                        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
                        MySqlConnection connection = new MySqlConnection(connectString);
                        connection.Open();


                        string SaveChangesSQL = $"UPDATE Products SET name_product = '" + name + "', price_product = '" + price + "', amount_products = '" + amount + "', supply_date = '" + supplydate + "' WHERE id =" + id;
                        MySqlCommand command = new MySqlCommand(SaveChangesSQL, connection);
                        command.ExecuteReader();
                        connection.Close();

                        MessageBox.Show("Товар успешно изменён!", "");
                        this.Hide();
                        var myForm = new StuffStorageWindow();
                        myForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Вы не внесли никаких изменений в данные о товаре", "");
                    }
                }
                else
                {
                    MessageBox.Show("Сначала выберите товар из списка", "");
                }
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (IdOutput.Text.Length > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить товар?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
                        MySqlConnection connection = new MySqlConnection(connectString);
                        connection.Open();
                        string id = IdOutput.Text;
                        string DeleteProductsSQL = $"DELETE from Products WHERE id =" + id;

                        MySqlCommand command = new MySqlCommand(DeleteProductsSQL, connection);
                        command.ExecuteReader();

                        connection.Close();

                        MessageBox.Show("Товар успешно удалён!", "");
                        this.Hide();
                        var myForm = new StuffStorageWindow();
                        myForm.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вы не можете удалить товар из базы данных так как он используется в таблице заказов!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Сначала выберите товар из списка", "");
            }
        }

        private void PriceStandardInfo_MouseEnter(object sender, EventArgs e)
        {
            var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
            tooltip.SetToolTip(PriceStandardInfo, "Писать в поле цены товара нужно только цифры, ничего более"); //Вывод текста в подсказке 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new AdminWindow();
            myForm.Show();
        }

        private void MakeACopyMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите сделать резервную копию информационной системы на компьютере?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                // Открытие диалога сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Zip Files (*.zip)|*.zip";
                saveFileDialog.Title = "Выберите место для сохранения резервной копии";
                saveFileDialog.FileName = "Backup.zip";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Путь к папке Pogulaeva
                        string sourceDirectory = @"C:\\Users\\delex\\source\\repos\\Pogulaeva\\-3";


                        // Создание zip-архива
                        ZipFile.CreateFromDirectory(sourceDirectory, saveFileDialog.FileName);

                        MessageBox.Show("Резервное копирование завершено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при резервном копировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
