
namespace IS_FISU
{
    partial class OrdersNotConfirmedByAdminWindow
    {
        // Обязательная переменная конструктора
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        // Освобождение всех используемых ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        // Требуемый метод для поддержки конструктора
        private void InitializeComponent()
        {
            this.TipText = new System.Windows.Forms.Label();
            this.DataBaseUnwatchedOrders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateOutput = new System.Windows.Forms.Label();
            this.OrderDateText = new System.Windows.Forms.Label();
            this.OrderPriceOutput = new System.Windows.Forms.Label();
            this.OrderPriceText = new System.Windows.Forms.Label();
            this.AmountProductChange = new System.Windows.Forms.NumericUpDown();
            this.AmountProductText = new System.Windows.Forms.Label();
            this.NameProductOutput = new System.Windows.Forms.Label();
            this.NameProductText = new System.Windows.Forms.Label();
            this.IDoutput = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.Label();
            this.StorageProductText = new System.Windows.Forms.Label();
            this.StorageProductOutput = new System.Windows.Forms.Label();
            this.ActualPriceText = new System.Windows.Forms.Label();
            this.ActualPriceOutput = new System.Windows.Forms.Label();
            this.TipToClient = new System.Windows.Forms.Label();
            this.NewOrderPriceText = new System.Windows.Forms.Label();
            this.NewOrderPriceOutput = new System.Windows.Forms.Label();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnwatchedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).BeginInit();
            this.SuspendLayout();
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipText.Location = new System.Drawing.Point(12, 34);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(464, 25);
            this.TipText.TabIndex = 0;
            this.TipText.Text = "Можете изменить количество товара в заказах";
            // 
            // DataBaseUnwatchedOrders
            // 
            this.DataBaseUnwatchedOrders.AllowUserToAddRows = false;
            this.DataBaseUnwatchedOrders.AllowUserToDeleteRows = false;
            this.DataBaseUnwatchedOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DataBaseUnwatchedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseUnwatchedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.amount_product,
            this.amount_products,
            this.price_product,
            this.order_price,
            this.order_date});
            this.DataBaseUnwatchedOrders.Location = new System.Drawing.Point(17, 83);
            this.DataBaseUnwatchedOrders.Name = "DataBaseUnwatchedOrders";
            this.DataBaseUnwatchedOrders.ReadOnly = true;
            this.DataBaseUnwatchedOrders.RowHeadersVisible = false;
            this.DataBaseUnwatchedOrders.Size = new System.Drawing.Size(723, 337);
            this.DataBaseUnwatchedOrders.TabIndex = 1;
            this.DataBaseUnwatchedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseWaitingForConfirm_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Номер заказа";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование продукта";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            // 
            // amount_product
            // 
            this.amount_product.HeaderText = "Кол-во заказанного товара";
            this.amount_product.Name = "amount_product";
            this.amount_product.ReadOnly = true;
            // 
            // amount_products
            // 
            this.amount_products.HeaderText = "Кол-во имеющегося товара";
            this.amount_products.Name = "amount_products";
            this.amount_products.ReadOnly = true;
            // 
            // price_product
            // 
            this.price_product.HeaderText = "Актуальная цена товара";
            this.price_product.Name = "price_product";
            this.price_product.ReadOnly = true;
            // 
            // order_price
            // 
            this.order_price.HeaderText = "Сумма заказа";
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            // 
            // order_date
            // 
            this.order_date.HeaderText = "Дата заказа";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 120;
            // 
            // OrderDateOutput
            // 
            this.OrderDateOutput.AutoSize = true;
            this.OrderDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateOutput.Location = new System.Drawing.Point(871, 293);
            this.OrderDateOutput.Name = "OrderDateOutput";
            this.OrderDateOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderDateOutput.TabIndex = 21;
            // 
            // OrderDateText
            // 
            this.OrderDateText.AutoSize = true;
            this.OrderDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateText.Location = new System.Drawing.Point(768, 293);
            this.OrderDateText.Name = "OrderDateText";
            this.OrderDateText.Size = new System.Drawing.Size(91, 17);
            this.OrderDateText.TabIndex = 20;
            this.OrderDateText.Text = "Дата заказа";
            // 
            // OrderPriceOutput
            // 
            this.OrderPriceOutput.AutoSize = true;
            this.OrderPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceOutput.Location = new System.Drawing.Point(946, 262);
            this.OrderPriceOutput.Name = "OrderPriceOutput";
            this.OrderPriceOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderPriceOutput.TabIndex = 19;
            // 
            // OrderPriceText
            // 
            this.OrderPriceText.AutoSize = true;
            this.OrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceText.Location = new System.Drawing.Point(768, 262);
            this.OrderPriceText.Name = "OrderPriceText";
            this.OrderPriceText.Size = new System.Drawing.Size(172, 17);
            this.OrderPriceText.TabIndex = 18;
            this.OrderPriceText.Text = "Нынешняя сумма заказа";
            // 
            // AmountProductChange
            // 
            this.AmountProductChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductChange.Location = new System.Drawing.Point(914, 153);
            this.AmountProductChange.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AmountProductChange.Name = "AmountProductChange";
            this.AmountProductChange.Size = new System.Drawing.Size(120, 23);
            this.AmountProductChange.TabIndex = 17;
            this.AmountProductChange.ValueChanged += new System.EventHandler(this.AmountProductChange_ValueChanged);
            // 
            // AmountProductText
            // 
            this.AmountProductText.AutoSize = true;
            this.AmountProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductText.Location = new System.Drawing.Point(765, 142);
            this.AmountProductText.Name = "AmountProductText";
            this.AmountProductText.Size = new System.Drawing.Size(143, 34);
            this.AmountProductText.TabIndex = 16;
            this.AmountProductText.Text = "Кол-во заказанного \r\nтовара";
            // 
            // NameProductOutput
            // 
            this.NameProductOutput.AutoSize = true;
            this.NameProductOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductOutput.Location = new System.Drawing.Point(952, 114);
            this.NameProductOutput.Name = "NameProductOutput";
            this.NameProductOutput.Size = new System.Drawing.Size(0, 17);
            this.NameProductOutput.TabIndex = 15;
            // 
            // NameProductText
            // 
            this.NameProductText.AutoSize = true;
            this.NameProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductText.Location = new System.Drawing.Point(765, 112);
            this.NameProductText.Name = "NameProductText";
            this.NameProductText.Size = new System.Drawing.Size(171, 17);
            this.NameProductText.TabIndex = 14;
            this.NameProductText.Text = "Наименование продукта";
            // 
            // IDoutput
            // 
            this.IDoutput.AutoSize = true;
            this.IDoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDoutput.Location = new System.Drawing.Point(885, 83);
            this.IDoutput.Name = "IDoutput";
            this.IDoutput.Size = new System.Drawing.Size(0, 17);
            this.IDoutput.TabIndex = 13;
            // 
            // IDtext
            // 
            this.IDtext.AutoSize = true;
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtext.Location = new System.Drawing.Point(768, 83);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 17);
            this.IDtext.TabIndex = 12;
            this.IDtext.Text = "Номер заказа";
            // 
            // StorageProductText
            // 
            this.StorageProductText.AutoSize = true;
            this.StorageProductText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(249)))));
            this.StorageProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageProductText.Location = new System.Drawing.Point(765, 193);
            this.StorageProductText.Name = "StorageProductText";
            this.StorageProductText.Size = new System.Drawing.Size(189, 17);
            this.StorageProductText.TabIndex = 22;
            this.StorageProductText.Text = "Кол-во имеющегося товара";
            // 
            // StorageProductOutput
            // 
            this.StorageProductOutput.AutoSize = true;
            this.StorageProductOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageProductOutput.Location = new System.Drawing.Point(969, 195);
            this.StorageProductOutput.Name = "StorageProductOutput";
            this.StorageProductOutput.Size = new System.Drawing.Size(0, 17);
            this.StorageProductOutput.TabIndex = 23;
            // 
            // ActualPriceText
            // 
            this.ActualPriceText.AutoSize = true;
            this.ActualPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(249)))));
            this.ActualPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActualPriceText.Location = new System.Drawing.Point(768, 229);
            this.ActualPriceText.Name = "ActualPriceText";
            this.ActualPriceText.Size = new System.Drawing.Size(171, 17);
            this.ActualPriceText.TabIndex = 24;
            this.ActualPriceText.Text = "Актуальная цена товара";
            // 
            // ActualPriceOutput
            // 
            this.ActualPriceOutput.AutoSize = true;
            this.ActualPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActualPriceOutput.Location = new System.Drawing.Point(962, 229);
            this.ActualPriceOutput.Name = "ActualPriceOutput";
            this.ActualPriceOutput.Size = new System.Drawing.Size(0, 17);
            this.ActualPriceOutput.TabIndex = 25;
            // 
            // TipToClient
            // 
            this.TipToClient.AutoSize = true;
            this.TipToClient.Cursor = System.Windows.Forms.Cursors.Help;
            this.TipToClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipToClient.Location = new System.Drawing.Point(934, 218);
            this.TipToClient.Name = "TipToClient";
            this.TipToClient.Size = new System.Drawing.Size(22, 15);
            this.TipToClient.TabIndex = 26;
            this.TipToClient.Text = "[ i ]";
            this.TipToClient.MouseEnter += new System.EventHandler(this.TipToClient_MouseEnter);
            // 
            // NewOrderPriceText
            // 
            this.NewOrderPriceText.AutoSize = true;
            this.NewOrderPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(145)))));
            this.NewOrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderPriceText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewOrderPriceText.Location = new System.Drawing.Point(765, 326);
            this.NewOrderPriceText.Name = "NewOrderPriceText";
            this.NewOrderPriceText.Size = new System.Drawing.Size(153, 36);
            this.NewOrderPriceText.TabIndex = 27;
            this.NewOrderPriceText.Text = "Итоговая сумма \r\nс учётом изменений:";
            // 
            // NewOrderPriceOutput
            // 
            this.NewOrderPriceOutput.AutoSize = true;
            this.NewOrderPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderPriceOutput.Location = new System.Drawing.Point(934, 339);
            this.NewOrderPriceOutput.Name = "NewOrderPriceOutput";
            this.NewOrderPriceOutput.Size = new System.Drawing.Size(0, 18);
            this.NewOrderPriceOutput.TabIndex = 28;
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ConfirmChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(759, 381);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(162, 49);
            this.ConfirmChangesButton.TabIndex = 29;
            this.ConfirmChangesButton.Text = "Подтвердить изменения в заказе";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.CancelOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOrderButton.Location = new System.Drawing.Point(939, 381);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(162, 49);
            this.CancelOrderButton.TabIndex = 30;
            this.CancelOrderButton.Text = "Отменить заказ";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(984, 25);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 55);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "Вернуться к выбору списка заказов";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrdersNotConfirmedByAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 442);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.ConfirmChangesButton);
            this.Controls.Add(this.NewOrderPriceOutput);
            this.Controls.Add(this.NewOrderPriceText);
            this.Controls.Add(this.TipToClient);
            this.Controls.Add(this.ActualPriceOutput);
            this.Controls.Add(this.ActualPriceText);
            this.Controls.Add(this.StorageProductOutput);
            this.Controls.Add(this.StorageProductText);
            this.Controls.Add(this.OrderDateOutput);
            this.Controls.Add(this.OrderDateText);
            this.Controls.Add(this.OrderPriceOutput);
            this.Controls.Add(this.OrderPriceText);
            this.Controls.Add(this.AmountProductChange);
            this.Controls.Add(this.AmountProductText);
            this.Controls.Add(this.NameProductOutput);
            this.Controls.Add(this.NameProductText);
            this.Controls.Add(this.IDoutput);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.DataBaseUnwatchedOrders);
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrdersNotConfirmedByAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnwatchedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.DataGridView DataBaseUnwatchedOrders;
        private System.Windows.Forms.Label OrderDateOutput;
        private System.Windows.Forms.Label OrderDateText;
        private System.Windows.Forms.Label OrderPriceOutput;
        private System.Windows.Forms.Label OrderPriceText;
        private System.Windows.Forms.NumericUpDown AmountProductChange;
        private System.Windows.Forms.Label AmountProductText;
        private System.Windows.Forms.Label NameProductOutput;
        private System.Windows.Forms.Label NameProductText;
        private System.Windows.Forms.Label IDoutput;
        private System.Windows.Forms.Label IDtext;
        private System.Windows.Forms.Label StorageProductText;
        private System.Windows.Forms.Label StorageProductOutput;
        private System.Windows.Forms.Label ActualPriceText;
        private System.Windows.Forms.Label ActualPriceOutput;
        private System.Windows.Forms.Label TipToClient;
        private System.Windows.Forms.Label NewOrderPriceText;
        private System.Windows.Forms.Label NewOrderPriceOutput;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.Button BackButton;
    }
}