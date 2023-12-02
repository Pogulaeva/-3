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
        private List<Control> originalControls = new List<Control>();

        public ClientWindow()
        {
            InitializeComponent();
            PopulateCheckListBoxes();
            foreach (Control control in Controls)
            {
                originalControls.Add(control);
            }
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

        private void PopulateCheckListBoxes()
        {
            // Замените строку подключения на свою
            string connectionString = "server=localhost; port=3306; username=root; password=root; database=IS_FISU";
            string query = "SELECT * FROM Products"; // Замените на имя вашей таблицы

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int positionY = 60;
                        while (reader.Read())
                        {
                            // Создаем новый CheckListBox
                            CheckedListBox checkListBox = new CheckedListBox();
                            checkListBox.Location = new System.Drawing.Point(5, positionY);
                            checkListBox.SelectedIndexChanged += CheckListBox_SelectedIndexChanged; // Добавляем обработчик события

                            // Собираем значения из каждого столбца в строку
                            string rowData = string.Empty;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData += $"{reader[i]}, ";
                            }

                            // Удаляем последнюю запятую и пробел
                            rowData = rowData.TrimEnd(',', ' ');

                            // Добавляем строку в CheckListBox
                            checkListBox.Items.Add(rowData);

                            checkListBox.Size = new System.Drawing.Size(500, 40);
                            checkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                            // Добавляем CheckListBox на форму
                            Controls.Add(checkListBox);
                            positionY += checkListBox.Height;
                        }
                    }
                }
            }
        }
        private void CheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, есть ли хотя бы один выбранный элемент в любом из CheckListBox
            bool anyItemSelected = false;
            foreach (Control control in Controls)
            {
                if (control is CheckedListBox checkListBox && checkListBox.CheckedItems.Count > 0)
                {
                    anyItemSelected = true;
                    break;
                }
            }

            // Показываем или скрываем кнопку в зависимости от наличия выбранных элементов
            CreateOrderButton.Visible = anyItemSelected;
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            // Собираем выбранные элементы из CheckedListBox
            foreach (Control control in Controls)
            {
                if (control is CheckedListBox checkListBox)
                {
                    foreach (var item in checkListBox.CheckedItems)
                    {
                        selectedItems.Add(item.ToString());
                    }
                }
            }

            // Скрываем все элементы на форме
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            // Создаем Label и NumericUpDown для каждого выбранного элемента
            int posY = 10;
            foreach (var selectedItem in selectedItems)
            {
                Label label = new Label();
                label.Text = selectedItem;
                label.Location = new System.Drawing.Point(10, posY);
                Controls.Add(label);

                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new System.Drawing.Point(150, posY);
                Controls.Add(numericUpDown);

                posY += 30; // Инкрементируем позицию для следующего Label и NumericUpDown
            }

            CancelButton.Visible = true;
            var placeOrderButton = new Button();
            placeOrderButton.Text = "Заказать";
            placeOrderButton.Location = new System.Drawing.Point(150, posY + 10);
            placeOrderButton.Visible = false; // По умолчанию кнопка "Заказать" скрыта
            placeOrderButton.Click += PlaceOrderButton_Click;
            Controls.Add(placeOrderButton);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки "Отмена"
            RestoreOriginalControls();

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки "Заказать"
            RestoreOriginalControls();
        }
        private void RestoreOriginalControls()
        {
            // Восстанавливаем изначальные элементы формы
            foreach (Control control in originalControls)
            {
                control.Visible = true;
                CancelButton.Visible = false;
            }
        }
    }
}
