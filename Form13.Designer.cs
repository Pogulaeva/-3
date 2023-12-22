
namespace IS_FISU
{
    partial class ActiveOrdersWindow
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
            this.DataBaseActiveOrders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseActiveOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipText.Location = new System.Drawing.Point(21, 34);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(185, 25);
            this.TipText.TabIndex = 0;
            this.TipText.Text = "Заказы уже в пути";
            // 
            // DataBaseActiveOrders
            // 
            this.DataBaseActiveOrders.AllowUserToAddRows = false;
            this.DataBaseActiveOrders.AllowUserToDeleteRows = false;
            this.DataBaseActiveOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DataBaseActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseActiveOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.amount_product,
            this.order_price,
            this.order_date});
            this.DataBaseActiveOrders.Location = new System.Drawing.Point(21, 83);
            this.DataBaseActiveOrders.Name = "DataBaseActiveOrders";
            this.DataBaseActiveOrders.ReadOnly = true;
            this.DataBaseActiveOrders.RowHeadersVisible = false;
            this.DataBaseActiveOrders.Size = new System.Drawing.Size(673, 338);
            this.DataBaseActiveOrders.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Номер заказа";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование товара";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Width = 180;
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
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(588, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 50);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Вернуться к выбору списка заказов";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ActiveOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 441);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DataBaseActiveOrders);
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActiveOrdersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseActiveOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.DataGridView DataBaseActiveOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.Button BackButton;
    }
}