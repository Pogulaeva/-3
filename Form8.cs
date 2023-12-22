using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace IS_FISU
{
    public partial class ChooseOrderListWindow : Form
    {
        public ChooseOrderListWindow()
        {
            InitializeComponent();
        }

        private void UnapprovedOrdersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new OrderListWindow();
            myForm.Show(); 
        }

        private void EditedOrdersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new EditedOrdersWindow();
            myForm.Show();
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
    }
}
