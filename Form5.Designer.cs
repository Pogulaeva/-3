
namespace IS_FISU
{
    partial class OrderListWindow
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
            this.OrderListText = new System.Windows.Forms.Label();
            this.DataBaseUnconfirmedOrders = new System.Windows.Forms.DataGridView();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_one_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_agreement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changes_confirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnconfirmedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).BeginInit();
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
            this.DataBaseUnconfirmedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseUnconfirmedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_product,
            this.name_product,
            this.price_one_product,
            this.amount_product,
            this.order_price,
            this.order_date,
            this.order_agreement,
            this.changes_confirm});
            this.DataBaseUnconfirmedOrders.Location = new System.Drawing.Point(18, 64);
            this.DataBaseUnconfirmedOrders.Name = "DataBaseUnconfirmedOrders";
            this.DataBaseUnconfirmedOrders.ReadOnly = true;
            this.DataBaseUnconfirmedOrders.RowHeadersVisible = false;
            this.DataBaseUnconfirmedOrders.Size = new System.Drawing.Size(614, 371);
            this.DataBaseUnconfirmedOrders.TabIndex = 1;
            // 
            // IDtext
            // 
            this.IDtext.AutoSize = true;
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtext.Location = new System.Drawing.Point(652, 64);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(21, 17);
            this.IDtext.TabIndex = 2;
            this.IDtext.Text = "ID";
            // 
            // IDoutput
            // 
            this.IDoutput.AutoSize = true;
            this.IDoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDoutput.Location = new System.Drawing.Point(693, 64);
            this.IDoutput.Name = "IDoutput";
            this.IDoutput.Size = new System.Drawing.Size(0, 17);
            this.IDoutput.TabIndex = 3;
            // 
            // NameProductText
            // 
            this.NameProductText.AutoSize = true;
            this.NameProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductText.Location = new System.Drawing.Point(652, 107);
            this.NameProductText.Name = "NameProductText";
            this.NameProductText.Size = new System.Drawing.Size(171, 17);
            this.NameProductText.TabIndex = 4;
            this.NameProductText.Text = "Наименование продукта";
            // 
            // NameProductOutput
            // 
            this.NameProductOutput.AutoSize = true;
            this.NameProductOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductOutput.Location = new System.Drawing.Point(839, 109);
            this.NameProductOutput.Name = "NameProductOutput";
            this.NameProductOutput.Size = new System.Drawing.Size(0, 17);
            this.NameProductOutput.TabIndex = 5;
            // 
            // AmountProductText
            // 
            this.AmountProductText.AutoSize = true;
            this.AmountProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductText.Location = new System.Drawing.Point(652, 151);
            this.AmountProductText.Name = "AmountProductText";
            this.AmountProductText.Size = new System.Drawing.Size(103, 17);
            this.AmountProductText.TabIndex = 6;
            this.AmountProductText.Text = "Кол-во товара";
            // 
            // AmountProductChange
            // 
            this.AmountProductChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountProductChange.Location = new System.Drawing.Point(771, 149);
            this.AmountProductChange.Name = "AmountProductChange";
            this.AmountProductChange.Size = new System.Drawing.Size(120, 23);
            this.AmountProductChange.TabIndex = 7;
            // 
            // OrderPriceText
            // 
            this.OrderPriceText.AutoSize = true;
            this.OrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceText.Location = new System.Drawing.Point(652, 201);
            this.OrderPriceText.Name = "OrderPriceText";
            this.OrderPriceText.Size = new System.Drawing.Size(99, 17);
            this.OrderPriceText.TabIndex = 8;
            this.OrderPriceText.Text = "Сумма заказа";
            // 
            // OrderPriceOutput
            // 
            this.OrderPriceOutput.AutoSize = true;
            this.OrderPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPriceOutput.Location = new System.Drawing.Point(768, 203);
            this.OrderPriceOutput.Name = "OrderPriceOutput";
            this.OrderPriceOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderPriceOutput.TabIndex = 9;
            // 
            // OrderDateText
            // 
            this.OrderDateText.AutoSize = true;
            this.OrderDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateText.Location = new System.Drawing.Point(652, 251);
            this.OrderDateText.Name = "OrderDateText";
            this.OrderDateText.Size = new System.Drawing.Size(91, 17);
            this.OrderDateText.TabIndex = 10;
            this.OrderDateText.Text = "Дата заказа";
            // 
            // OrderDateOutput
            // 
            this.OrderDateOutput.AutoSize = true;
            this.OrderDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateOutput.Location = new System.Drawing.Point(768, 255);
            this.OrderDateOutput.Name = "OrderDateOutput";
            this.OrderDateOutput.Size = new System.Drawing.Size(0, 17);
            this.OrderDateOutput.TabIndex = 11;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Location = new System.Drawing.Point(908, 376);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(100, 59);
            this.DeleteOrderButton.TabIndex = 14;
            this.DeleteOrderButton.Text = "Удалить заказ";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ConfirmChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(781, 376);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(100, 59);
            this.ConfirmChangesButton.TabIndex = 15;
            this.ConfirmChangesButton.Text = "Подтвердить изменения в заказе";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            // 
            // ApproveOrderButton
            // 
            this.ApproveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ApproveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveOrderButton.Location = new System.Drawing.Point(655, 376);
            this.ApproveOrderButton.Name = "ApproveOrderButton";
            this.ApproveOrderButton.Size = new System.Drawing.Size(100, 59);
            this.ApproveOrderButton.TabIndex = 16;
            this.ApproveOrderButton.Text = "Одобрить заказ";
            this.ApproveOrderButton.UseVisualStyleBackColor = false;
            // 
            // OrderApproveCheckBox
            // 
            this.OrderApproveCheckBox.AutoSize = true;
            this.OrderApproveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderApproveCheckBox.Location = new System.Drawing.Point(655, 292);
            this.OrderApproveCheckBox.Name = "OrderApproveCheckBox";
            this.OrderApproveCheckBox.Size = new System.Drawing.Size(154, 21);
            this.OrderApproveCheckBox.TabIndex = 17;
            this.OrderApproveCheckBox.Text = "Подтвердить заказ";
            this.OrderApproveCheckBox.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // id_product
            // 
            this.id_product.HeaderText = "ID продукта";
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            this.id_product.Visible = false;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование продукта";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Width = 150;
            // 
            // price_one_product
            // 
            this.price_one_product.HeaderText = "Цена шт. товара";
            this.price_one_product.Name = "price_one_product";
            this.price_one_product.ReadOnly = true;
            this.price_one_product.Visible = false;
            // 
            // amount_product
            // 
            this.amount_product.HeaderText = "Кол-во товара";
            this.amount_product.Name = "amount_product";
            this.amount_product.ReadOnly = true;
            this.amount_product.Width = 120;
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
            // order_agreement
            // 
            this.order_agreement.HeaderText = "Подтверждение заказа";
            this.order_agreement.Name = "order_agreement";
            this.order_agreement.ReadOnly = true;
            this.order_agreement.Visible = false;
            // 
            // changes_confirm
            // 
            this.changes_confirm.HeaderText = "Подтверждение от клиента";
            this.changes_confirm.Name = "changes_confirm";
            this.changes_confirm.ReadOnly = true;
            this.changes_confirm.Visible = false;
            // 
            // OrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1030, 450);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseUnconfirmedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountProductChange)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_one_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_agreement;
        private System.Windows.Forms.DataGridViewTextBoxColumn changes_confirm;
    }
}