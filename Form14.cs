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
    public partial class ActiveOrdersWindowAdm : Form
    {
        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        public ActiveOrdersWindowAdm()
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
                            DataBaseActiveOrdersAdm.Rows.Add(
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

