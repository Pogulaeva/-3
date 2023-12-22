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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ToStuffListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new StuffStorageWindow();
            myForm.Show();
        }

        private void ToOrderListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ChooseOrderListWindow();
            myForm.Show();
        }

        private void ChangeAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

                        // Создание резервной копии базы данных
                        //BackupDatabase();

                        MessageBox.Show("Резервное копирование завершено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при резервном копировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        /*private void BackupDatabase()
        {

            // Определение пути для сохранения резервной копии
            string backupPath = "C:\\Users\\delex\\OneDrive\\Рабочий стол\\DataBaseBackup\\DB.bak";

            // Создание строки подключения с указанием параметров
            string connectionString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";


            try
            {
                // Создание соединения с базой данных
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Создание команды для создания резервной копии
                    MySqlCommand command = new MySqlCommand($"BACKUP DATABASE IS_FISU TO DISK = '{backupPath}'", connection);

                    // Выполнение команды
                    command.ExecuteNonQuery();

                    Console.WriteLine("Резервная копия базы данных успешно создана.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при создании резервной копии базы данных: " + ex.Message);
            }

            Console.ReadLine();
        }*/
    }
}
