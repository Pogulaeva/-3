
namespace IS_FISU
{
    partial class EditedOrdersWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExplanationText = new System.Windows.Forms.Label();
            this.DataBaseRedactedOrders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderApproveCheckBox = new System.Windows.Forms.CheckBox();
            this.ApproveOrderButton = new System.Windows.Forms.Button();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseRedactedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).BeginInit();
            this.SuspendLayout();
            // 
            // ExplanationText
            // 
            this.ExplanationText.AutoSize = true;
            this.ExplanationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExplanationText.Location = new System.Drawing.Point(12, 24);
            this.ExplanationText.Name = "ExplanationText";
            this.ExplanationText.Size = new System.Drawing.Size(749, 29);
            this.ExplanationText.TabIndex = 0;
            this.ExplanationText.Text = "Список редактированных заказов, ожидающих подтверждения";
            // 
            // DataBaseRedactedOrders
            // 
            this.DataBaseRedactedOrders.AllowUserToAddRows = false;
            this.DataBaseRedactedOrders.AllowUserToDeleteRows = false;
            this.DataBaseRedactedOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.DataBaseRedactedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseRedactedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.price_product,
            this.amount_product,
            this.amount_products,
            this.order_price,
            this.order_date});
            this.DataBaseRedactedOrders.Location = new System.Drawing.Point(21, 78);
            this.DataBaseRedactedOrders.Name = "DataBaseRedactedOrders";
            this.DataBaseRedactedOrders.ReadOnly = true;
            this.DataBaseRedactedOrders.RowHeadersVisible = false;
            this.DataBaseRedactedOrders.Size = new System.Drawing.Size(603, 356);
            this.DataBaseRedactedOrders.TabIndex = 1;
            this.DataBaseRedactedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseRedactedOrders_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование товара";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
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
            // 
            // amount_products
            // 
            this.amount_products.HeaderText = "Кол-во товаров на складе";
            this.amount_products.Name = "amount_products";
            this.amount_products.ReadOnly = true;
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
            // 
            // OrderApproveCheckBox
            // 
            this.OrderApproveCheckBox.AutoSize = true;
            this.OrderApproveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderApproveCheckBox.Location = new System.Drawing.Point(633, 318);
            this.OrderApproveCheckBox.Name = "OrderApproveCheckBox";
            this.OrderApproveCheckBox.Size = new System.Drawing.Size(154, 21);
            this.OrderApproveCheckBox.TabIndex = 31;
            this.OrderApproveCheckBox.Text = "Подтвердить заказ";
            this.OrderApproveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApproveOrderButton
            // 
            this.ApproveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ApproveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveOrderButton.Location = new System.Drawing.Point(633, 374);
            this.ApproveOrderButton.Name = "ApproveOrderButton";
            this.ApproveOrderButton.Size = new System.Drawing.Size(100, 59);
            this.ApproveOrderButton.TabIndex = 30;
            this.ApproveOrderButton.Text = "Одобрить заказ";
            this.ApproveOrderButton.UseVisualStyleBackColor = false;
            this.ApproveOrderButton.Click += new System.EventHandler(this.ApproveOrderButton_Click);
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ConfirmChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(741, 374);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(100, 59);
            this.ConfirmChangesButton.TabIndex = 29;
            this.ConfirmChangesButton.Text = "Подтвердить изменения в заказе";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Location = new System.Drawing.Point(850, 374);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(100, 59);
            this.DeleteOrderButton.TabIndex = 28;
            this.DeleteOrderButton.Text = "Удалить заказ";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // OrderDateOutput
            // 
            this.OrderDateOutput.AutoSize = true;
            this.OrderDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateOutput.Location = new System.Drawing.Point(746, 281);
            this.OrderDateOutput.Name = "OrderDateOutput";
            this.OrderDateOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderDateOutput.TabIndex = 27;
            // 
            // OrderDateText
            // 
            this.OrderDateText.AutoSize = true;
            this.OrderDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateText.Location = new System.Drawing.Point(630, 277);
            this.OrderDateText.Name = "OrderDateText";
            this.OrderDateText.Size = new System.Drawing.Size(91, 17);
            this.OrderDateText.TabIndex = 26;
            this.OrderDateText.Text = "Дата заказа";
            // 
            // OrderPriceOutput
            // 
            this.OrderPriceOutput.AutoSize = true;
            this.OrderPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceOutput.Location = new System.Drawing.Point(746, 229);
            this.OrderPriceOutput.Name = "OrderPriceOutput";
            this.OrderPriceOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderPriceOutput.TabIndex = 25;
            // 
            // OrderPriceText
            // 
            this.OrderPriceText.AutoSize = true;
            this.OrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceText.Location = new System.Drawing.Point(630, 227);
            this.OrderPriceText.Name = "OrderPriceText";
            this.OrderPriceText.Size = new System.Drawing.Size(99, 17);
            this.OrderPriceText.TabIndex = 24;
            this.OrderPriceText.Text = "Сумма заказа";
            // 
            // AmountProductChange
            // 
            this.AmountProductChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductChange.Location = new System.Drawing.Point(749, 175);
            this.AmountProductChange.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AmountProductChange.Name = "AmountProductChange";
            this.AmountProductChange.Size = new System.Drawing.Size(120, 23);
            this.AmountProductChange.TabIndex = 23;
            this.AmountProductChange.ValueChanged += new System.EventHandler(this.ChangeAmountBox_ValueChanged);
            // 
            // AmountProductText
            // 
            this.AmountProductText.AutoSize = true;
            this.AmountProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductText.Location = new System.Drawing.Point(630, 177);
            this.AmountProductText.Name = "AmountProductText";
            this.AmountProductText.Size = new System.Drawing.Size(103, 17);
            this.AmountProductText.TabIndex = 22;
            this.AmountProductText.Text = "Кол-во товара";
            // 
            // NameProductOutput
            // 
            this.NameProductOutput.AutoSize = true;
            this.NameProductOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductOutput.Location = new System.Drawing.Point(817, 135);
            this.NameProductOutput.Name = "NameProductOutput";
            this.NameProductOutput.Size = new System.Drawing.Size(0, 17);
            this.NameProductOutput.TabIndex = 21;
            // 
            // NameProductText
            // 
            this.NameProductText.AutoSize = true;
            this.NameProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductText.Location = new System.Drawing.Point(630, 133);
            this.NameProductText.Name = "NameProductText";
            this.NameProductText.Size = new System.Drawing.Size(171, 17);
            this.NameProductText.TabIndex = 20;
            this.NameProductText.Text = "Наименование продукта";
            // 
            // IDoutput
            // 
            this.IDoutput.AutoSize = true;
            this.IDoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDoutput.Location = new System.Drawing.Point(671, 90);
            this.IDoutput.Name = "IDoutput";
            this.IDoutput.Size = new System.Drawing.Size(0, 17);
            this.IDoutput.TabIndex = 19;
            // 
            // IDtext
            // 
            this.IDtext.AutoSize = true;
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtext.Location = new System.Drawing.Point(630, 90);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(21, 17);
            this.IDtext.TabIndex = 18;
            this.IDtext.Text = "ID";
            // 
            // EditedOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 452);
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
            this.Controls.Add(this.DataBaseRedactedOrders);
            this.Controls.Add(this.ExplanationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditedOrdersWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseRedactedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExplanationText;
        private System.Windows.Forms.DataGridView DataBaseRedactedOrders;
        private System.Windows.Forms.CheckBox OrderApproveCheckBox;
        private System.Windows.Forms.Button ApproveOrderButton;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Button DeleteOrderButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
    }
}