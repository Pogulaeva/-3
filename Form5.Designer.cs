
namespace IS_FISU
{
    partial class OrderListWindow
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
            this.OrderListText = new System.Windows.Forms.Label();
            this.DataBaseUnconfirmedOrders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDtext = new System.Windows.Forms.Label();
            this.IDoutput = new System.Windows.Forms.Label();
            this.NameProductText = new System.Windows.Forms.Label();
            this.NameProductOutput = new System.Windows.Forms.Label();
            this.AmountProductText = new System.Windows.Forms.Label();
            this.AmountProductChange = new System.Windows.Forms.NumericUpDown();
            this.OrderPriceText = new System.Windows.Forms.Label();
            this.OrderPriceOutput = new System.Windows.Forms.Label();
            this.OrderDateText = new System.Windows.Forms.Label();
            this.OrderDateOutput = new System.Windows.Forms.Label();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.ApproveOrderButton = new System.Windows.Forms.Button();
            this.OrderApproveCheckBox = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdditionalFuncMenu = new System.Windows.Forms.MenuStrip();
            this.MakeACopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnconfirmedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).BeginInit();
            this.AdditionalFuncMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderListText
            // 
            this.OrderListText.AutoSize = true;
            this.OrderListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderListText.Location = new System.Drawing.Point(12, 24);
            this.OrderListText.Name = "OrderListText";
            this.OrderListText.Size = new System.Drawing.Size(521, 37);
            this.OrderListText.TabIndex = 0;
            this.OrderListText.Text = "Список неподтверждённых заказов";
            // 
            // DataBaseUnconfirmedOrders
            // 
            this.DataBaseUnconfirmedOrders.AllowUserToAddRows = false;
            this.DataBaseUnconfirmedOrders.AllowUserToDeleteRows = false;
            this.DataBaseUnconfirmedOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.DataBaseUnconfirmedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseUnconfirmedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.price_product,
            this.amount_product,
            this.product_storage,
            this.order_price,
            this.order_date});
            this.DataBaseUnconfirmedOrders.Location = new System.Drawing.Point(18, 75);
            this.DataBaseUnconfirmedOrders.Name = "DataBaseUnconfirmedOrders";
            this.DataBaseUnconfirmedOrders.ReadOnly = true;
            this.DataBaseUnconfirmedOrders.RowHeadersVisible = false;
            this.DataBaseUnconfirmedOrders.Size = new System.Drawing.Size(713, 360);
            this.DataBaseUnconfirmedOrders.TabIndex = 1;
            this.DataBaseUnconfirmedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseUnconfirmedOrders_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование продукта";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Width = 150;
            // 
            // price_product
            // 
            this.price_product.HeaderText = "Цена шт. товара";
            this.price_product.Name = "price_product";
            this.price_product.ReadOnly = true;
            this.price_product.Visible = false;
            // 
            // amount_product
            // 
            this.amount_product.HeaderText = "Кол-во товара";
            this.amount_product.Name = "amount_product";
            this.amount_product.ReadOnly = true;
            this.amount_product.Width = 120;
            // 
            // product_storage
            // 
            this.product_storage.HeaderText = "Кол-во товара на складе";
            this.product_storage.Name = "product_storage";
            this.product_storage.ReadOnly = true;
            // 
            // order_price
            // 
            this.order_price.HeaderText = "Сумма заказа";
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            this.order_price.Width = 120;
            // 
            // order_date
            // 
            this.order_date.HeaderText = "Дата заказа";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 150;
            // 
            // IDtext
            // 
            this.IDtext.AutoSize = true;
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtext.Location = new System.Drawing.Point(737, 92);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(21, 17);
            this.IDtext.TabIndex = 2;
            this.IDtext.Text = "ID";
            // 
            // IDoutput
            // 
            this.IDoutput.AutoSize = true;
            this.IDoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDoutput.Location = new System.Drawing.Point(778, 92);
            this.IDoutput.Name = "IDoutput";
            this.IDoutput.Size = new System.Drawing.Size(0, 17);
            this.IDoutput.TabIndex = 3;
            // 
            // NameProductText
            // 
            this.NameProductText.AutoSize = true;
            this.NameProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductText.Location = new System.Drawing.Point(737, 135);
            this.NameProductText.Name = "NameProductText";
            this.NameProductText.Size = new System.Drawing.Size(171, 17);
            this.NameProductText.TabIndex = 4;
            this.NameProductText.Text = "Наименование продукта";
            // 
            // NameProductOutput
            // 
            this.NameProductOutput.AutoSize = true;
            this.NameProductOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductOutput.Location = new System.Drawing.Point(924, 137);
            this.NameProductOutput.Name = "NameProductOutput";
            this.NameProductOutput.Size = new System.Drawing.Size(0, 17);
            this.NameProductOutput.TabIndex = 5;
            // 
            // AmountProductText
            // 
            this.AmountProductText.AutoSize = true;
            this.AmountProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductText.Location = new System.Drawing.Point(737, 179);
            this.AmountProductText.Name = "AmountProductText";
            this.AmountProductText.Size = new System.Drawing.Size(103, 17);
            this.AmountProductText.TabIndex = 6;
            this.AmountProductText.Text = "Кол-во товара";
            // 
            // AmountProductChange
            // 
            this.AmountProductChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductChange.Location = new System.Drawing.Point(856, 177);
            this.AmountProductChange.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AmountProductChange.Name = "AmountProductChange";
            this.AmountProductChange.Size = new System.Drawing.Size(120, 23);
            this.AmountProductChange.TabIndex = 7;
            this.AmountProductChange.ValueChanged += new System.EventHandler(this.ChangeAmountBox_ValueChanged);
            // 
            // OrderPriceText
            // 
            this.OrderPriceText.AutoSize = true;
            this.OrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceText.Location = new System.Drawing.Point(737, 229);
            this.OrderPriceText.Name = "OrderPriceText";
            this.OrderPriceText.Size = new System.Drawing.Size(99, 17);
            this.OrderPriceText.TabIndex = 8;
            this.OrderPriceText.Text = "Сумма заказа";
            // 
            // OrderPriceOutput
            // 
            this.OrderPriceOutput.AutoSize = true;
            this.OrderPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceOutput.Location = new System.Drawing.Point(853, 231);
            this.OrderPriceOutput.Name = "OrderPriceOutput";
            this.OrderPriceOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderPriceOutput.TabIndex = 9;
            // 
            // OrderDateText
            // 
            this.OrderDateText.AutoSize = true;
            this.OrderDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateText.Location = new System.Drawing.Point(737, 279);
            this.OrderDateText.Name = "OrderDateText";
            this.OrderDateText.Size = new System.Drawing.Size(91, 17);
            this.OrderDateText.TabIndex = 10;
            this.OrderDateText.Text = "Дата заказа";
            // 
            // OrderDateOutput
            // 
            this.OrderDateOutput.AutoSize = true;
            this.OrderDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateOutput.Location = new System.Drawing.Point(853, 283);
            this.OrderDateOutput.Name = "OrderDateOutput";
            this.OrderDateOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderDateOutput.TabIndex = 11;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.DeleteOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Location = new System.Drawing.Point(957, 376);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(100, 59);
            this.DeleteOrderButton.TabIndex = 14;
            this.DeleteOrderButton.Text = "Удалить заказ";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ConfirmChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(848, 376);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(100, 59);
            this.ConfirmChangesButton.TabIndex = 15;
            this.ConfirmChangesButton.Text = "Подтвердить изменения в заказе";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // ApproveOrderButton
            // 
            this.ApproveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ApproveOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApproveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveOrderButton.Location = new System.Drawing.Point(740, 376);
            this.ApproveOrderButton.Name = "ApproveOrderButton";
            this.ApproveOrderButton.Size = new System.Drawing.Size(100, 59);
            this.ApproveOrderButton.TabIndex = 16;
            this.ApproveOrderButton.Text = "Одобрить заказ";
            this.ApproveOrderButton.UseVisualStyleBackColor = false;
            this.ApproveOrderButton.Click += new System.EventHandler(this.ApproveOrderButton_Click);
            // 
            // OrderApproveCheckBox
            // 
            this.OrderApproveCheckBox.AutoSize = true;
            this.OrderApproveCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderApproveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderApproveCheckBox.Location = new System.Drawing.Point(740, 320);
            this.OrderApproveCheckBox.Name = "OrderApproveCheckBox";
            this.OrderApproveCheckBox.Size = new System.Drawing.Size(154, 21);
            this.OrderApproveCheckBox.TabIndex = 17;
            this.OrderApproveCheckBox.Text = "Подтвердить заказ";
            this.OrderApproveCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(977, 25);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 47);
            this.BackButton.TabIndex = 51;
            this.BackButton.Text = "Вернуться к меню";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdditionalFuncMenu
            // 
            this.AdditionalFuncMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeACopyMenu});
            this.AdditionalFuncMenu.Location = new System.Drawing.Point(0, 0);
            this.AdditionalFuncMenu.Name = "AdditionalFuncMenu";
            this.AdditionalFuncMenu.Size = new System.Drawing.Size(1078, 24);
            this.AdditionalFuncMenu.TabIndex = 52;
            this.AdditionalFuncMenu.Text = "menuStrip1";
            // 
            // MakeACopyMenu
            // 
            this.MakeACopyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.MakeACopyMenu.Name = "MakeACopyMenu";
            this.MakeACopyMenu.Size = new System.Drawing.Size(152, 20);
            this.MakeACopyMenu.Text = "Резервное копирование";
            this.MakeACopyMenu.Click += new System.EventHandler(this.MakeACopyMenu_Click);
            // 
            // OrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderApproveCheckBox);
            this.Controls.Add(this.ApproveOrderButton);
            this.Controls.Add(this.ConfirmChangesButton);
            this.Controls.Add(this.DeleteOrderButton);
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
            this.Controls.Add(this.DataBaseUnconfirmedOrders);
            this.Controls.Add(this.OrderListText);
            this.Controls.Add(this.AdditionalFuncMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AdditionalFuncMenu;
            this.Name = "OrderListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnconfirmedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).EndInit();
            this.AdditionalFuncMenu.ResumeLayout(false);
            this.AdditionalFuncMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderListText;
        private System.Windows.Forms.DataGridView DataBaseUnconfirmedOrders;
        private System.Windows.Forms.Label IDtext;
        private System.Windows.Forms.Label IDoutput;
        private System.Windows.Forms.Label NameProductText;
        private System.Windows.Forms.Label NameProductOutput;
        private System.Windows.Forms.Label AmountProductText;
        private System.Windows.Forms.NumericUpDown AmountProductChange;
        private System.Windows.Forms.Label OrderPriceText;
        private System.Windows.Forms.Label OrderPriceOutput;
        private System.Windows.Forms.Label OrderDateText;
        private System.Windows.Forms.Label OrderDateOutput;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Button ApproveOrderButton;
        private System.Windows.Forms.CheckBox OrderApproveCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip AdditionalFuncMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeACopyMenu;
    }
}