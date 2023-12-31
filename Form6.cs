﻿using System;
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
    //Создание формы
    public partial class NewProductWindow : Form
    {

        DataBase dataBase = new DataBase();

        public NewProductWindow()
        {
            InitializeComponent();
        }

        //Функция, которая делает видимой кнопку AddProductButton
        private void NameInputBox_TextChanged(object sender, EventArgs e)
        {
            AddProductButton.Visible = NameInputBox.Text.Length > 0; //Если в NameInputBox что-то написано, то кнопка AddProductButton становится видимой
        }

        //Функция отображения подсказки при записи цены
        private void PriceStandardInfo_MouseEnter(object sender, EventArgs e)
        {
           var tooltip = new ToolTip(); //Создание подсказки, в которой поясняется правильность записи цены в поле
           tooltip.SetToolTip(PriceStandardInfo, "Писать в поле цены товара нужно только цифры, ничего более"); //Вывод текста в подсказке 
        }

        //Функция добавления нового товара в ИС
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что готовы добавить товар?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Проверка возможного случайного нажатия администратором кнопки
            {
                //Отправка информации о новом товаре в БД
                DataBase dataBase = new DataBase();

                var name = NameInputBox.Text;
                var price = PriceInput.Value;
                var amount = AmountInput.Value;
                var supplydate = DateInput.Text;

                string AddingProduct = $"insert into Products(name_product, price_product, amount_products, supply_date) values ('{name}', '{price}', '{amount}', '{supplydate}')";

                MySqlCommand command = new MySqlCommand(AddingProduct, dataBase.getConnection());

                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Товар успешно добавлен!", "");

                    //Открытие окна StuffStorageWindow
                    this.Hide();
                    var myForm = new StuffStorageWindow();
                    myForm.Show();
                }
                else
                {
                    MessageBox.Show("Товар не добавлен", "");
                }
                dataBase.closeConnection();
            }
        }

        //Функция отмены добавления нового товара
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (NameInputBox.Text.Length > 0)
            {
                if (MessageBox.Show("Вы действительно хотите закрыть окно добавления товара? (Все записи будут сброшены)", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Проверка возможного случайного нажатия администратором кнопки
                {
                    this.Hide();
                }
            }
            else
            {
                this.Hide();
            }
        }

        //Функция создания резервной копии проекта и БД
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
                        // Путь к папке, откуда будут браться файлы для копирования
                        string sourceDirectory = @"C:\\Users\\delex\\source\\repos\\Pogulaeva\\-3";


                        // Создание zip-архива
                        ZipFile.CreateFromDirectory(sourceDirectory, saveFileDialog.FileName);

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
