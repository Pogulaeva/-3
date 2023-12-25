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
    //Создание формы
    public partial class OrderListWindow : Form
    {

        DataBase dataBase = new DataBase();
        string connectString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
        int amounttestproduct;
        string priceproduct;
        public OrderListWindow()
        {
            InitializeComponent();
            LoadData(); // Вызов метода для загрузки данных в DataGridView при загрузке формы
        }

        //Загрузка данных из БД в элемент формы DataBaseUnconfirmedOrders
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
                            p.price_product, 
                            o.amount_product, 
                            p.amount_products,
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
                        // Загрузка данных в DataBaseUnconfirmedOrders
                        while (reader.Read())
                        {
                            DataBaseUnconfirmedOrders.Rows.Add(
                                reader["id"],
                                reader["name_product"],
                                reader["price_product"],
                                reader["amount_product"],
                                reader["amount_products"],
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

        //Функция переноса выбранных из DataBaseUnconfirmedOrders данных в удобный просмотр, подтверждение и редактирование информации о совершённых клиентом заказах
        private void DataBaseUnconfirmedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Загрузка данных каждой ячейки из выбранной строки в элементы для редактирования
                if (DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataBaseUnconfirmedOrders.CurrentRow.Selected = true;
                    IDoutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    NameProductOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["name_product"].FormattedValue.ToString();
                    AmountProductChange.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                    OrderPriceOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["order_price"].FormattedValue.ToString();
                    OrderDateOutput.Text = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["order_date"].FormattedValue.ToString();
                    string amounttest = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["amount_product"].FormattedValue.ToString();
                    priceproduct = DataBaseUnconfirmedOrders.Rows[e.RowIndex].Cells["price_product"].FormattedValue.ToString();
                    amounttestproduct = Int32.Parse(amounttest);
                    MakeOfFinalPrice();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите одну запись, а не шапку таблицы", "");
            }
        }

        //Функция проверки в случае того, если администратор вдруг захочет поменять значение в ChangeAmountBox, не выбрав заказ клиента из списка
        private void ChangeAmountBox_ValueChanged(object sender, EventArgs e)
        {
            if (IDoutput.Text.Length > 0)
            {
                MakeOfFinalPrice();
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }

        //Функция подсчёта итоговой суммы заказа(выполняется, если совершены изменения в заказе)
        private void MakeOfFinalPrice()
        {
            // Обновление текста в OrderPriceOutput при изменении значения в AmountProductChange
            int amount = (int)AmountProductChange.Value;
            int price = Int32.Parse(priceproduct);
            int finalprice = amount * price;
            String changingprice = finalprice.ToString();
            OrderPriceOutput.Text = changingprice;
        }

        //Функция подтверждения заказа клиента
        private void ApproveOrderButton_Click(object sender, EventArgs e)
        {
            if (IDoutput.Text.Length > 0) //Проверка выбранности заказа из списка
            {
                if (OrderApproveCheckBox.Checked) //Проверка установленной галочки в OrderApproveCheckBox
                {
                    if ((int)AmountProductChange.Value == amounttestproduct) //Проверка на то, не изменена ли информация о заказе
                    {
                        //Отправка информации о заказе в БД
                        MySqlConnection connection = new MySqlConnection(connectString);
                        connection.Open();

                        int orderagreement = 1;
                        string id = IDoutput.Text;
                        string ApproveOrderSQL = $"UPDATE Orders SET order_agreement = '" + orderagreement + "' WHERE id =" + id;
                        MySqlCommand command = new MySqlCommand(ApproveOrderSQL, connection);
                        command.ExecuteReader();
                        connection.Close();

                        MessageBox.Show("Заказ подтверждён!", "");

                        //Обновление всех данных в DataBaseUnconfirmedOrders
                        this.Hide();
                        var myForm = new OrderListWindow();
                        myForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("При подтверждении заказа количество товара менять нельзя, верните изначальное количество товара в заказе", "");
                    }
                }
                else
                {
                    MessageBox.Show("Если вы хотите подтвердить заказ, установите галочку рядом с надписью «подтвердить заказ»", "");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }
        //Функция изменения информации о заказе администратором
        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            if (IDoutput.Text.Length > 0) //Проверка выбранности заказа из списка
            {
                if ((int)AmountProductChange.Value != amounttestproduct) //Проверка на внесённые изменения в заказ
                {
                    if ((int)AmountProductChange.Value > 0) //Проверка указанного кол-ва товара(не должно быть меньше 1)
                    {
                        if ((int)AmountProductChange.Value <= amounttestproduct) //Проверка указанного кол-ва товара(не должно быть больше, чем есть на складе)
                        {
                            if (OrderApproveCheckBox.Checked) //Проверка на непроставленность галочки в OrderApproveCheckBox
                            {
                                MessageBox.Show("При внесении изменений в заказ нельзя ставить галочку рядом с надписью «подтвердить заказ»", "");
                            }
                            else
                            {
                                if (MessageBox.Show("Изменить данные о заказе?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Проверка возможного случайного нажатия администратором кнопки
                                {
                                    //Отправка информации о заказе в БД
                                    MySqlConnection connection = new MySqlConnection(connectString);
                                    connection.Open();

                                    string id = IDoutput.Text;
                                    string amount = AmountProductChange.Text;
                                    int orderwasedited = 1;
                                    string SaveChangesSQL = $"UPDATE Orders SET amount_product = '" + amount + "', order_was_edited = '" + orderwasedited + "' WHERE id =" + id;
                                    MySqlCommand command = new MySqlCommand(SaveChangesSQL, connection);
                                    command.ExecuteReader();
                                    connection.Close();

                                    MessageBox.Show("Заказ успешно изменён!", "");

                                    //Обновление всех данных в DataBaseUnconfirmedOrders
                                    this.Hide();
                                    var myForm = new OrderListWindow();
                                    myForm.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Количество товара не должно превышать количество заказанного товара клиентом!", "");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого количества товара нет на складе", "");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не внесли никаких изменений в поле количества товара, внесите изменения, если хотите изменить заказ", "");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }

        //Функция удаления заказа администратором
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (IDoutput.Text.Length > 0) //Проверка выбранности заказа из списка
            {
                if (MessageBox.Show("Вы действительно хотите отменить заказ клиента? (Если вы нажмёте «да», запись о заказе автоматически удалится)", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) //Проверка возможного случайного нажатия администратором кнопки
                {
                    //Удаление информации о заказе в БД
                    MySqlConnection connection = new MySqlConnection(connectString);
                    connection.Open();
                    string id = IDoutput.Text;
                    string DeleteOrderSQL = $"DELETE from Orders WHERE id =" + id;
                    MySqlCommand command = new MySqlCommand(DeleteOrderSQL, connection);
                    command.ExecuteReader();
                    connection.Close();

                    MessageBox.Show("Заказ отменён. Напишите причину, по которой отменили заказ", "");

                    //Открытие окна для написания приничины удаления заказа
                    var myForm = new CommentForDeletingWindow();
                    myForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ из списка", "");
            }
        }

        //Функция открытия окна ChooseOrderListWindow
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new ChooseOrderListWindow();
            myForm.Show();
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

