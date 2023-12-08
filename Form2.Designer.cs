
namespace IS_FISU
{
    partial class ClientWindow
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
            this.ProductsListText = new System.Windows.Forms.Label();
            this.ClientOrderListButton = new System.Windows.Forms.Button();
            this.ChangeAccButton = new System.Windows.Forms.Button();
            this.DataBaseClient = new System.Windows.Forms.DataGridView();
            this.NameText = new System.Windows.Forms.Label();
            this.NameOutput = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.Label();
            this.PriceOutput = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.ChangeAmountBox = new System.Windows.Forms.NumericUpDown();
            this.ForPaymentText = new System.Windows.Forms.Label();
            this.ForPaymentOutput = new System.Windows.Forms.Label();
            this.MakeOrderButton = new System.Windows.Forms.Button();
            this.NameProductHeader = new System.Windows.Forms.Label();
            this.ProceProductHeader = new System.Windows.Forms.Label();
            this.AmountProductHeader = new System.Windows.Forms.Label();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListText
            // 
            this.ProductsListText.AutoSize = true;
            this.ProductsListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsListText.Location = new System.Drawing.Point(12, 12);
            this.ProductsListText.Name = "ProductsListText";
            this.ProductsListText.Size = new System.Drawing.Size(270, 39);
            this.ProductsListText.TabIndex = 0;
            this.ProductsListText.Text = "Список товаров";
            // 
            // ClientOrderListButton
            // 
            this.ClientOrderListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ClientOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientOrderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientOrderListButton.Location = new System.Drawing.Point(491, 12);
            this.ClientOrderListButton.Name = "ClientOrderListButton";
            this.ClientOrderListButton.Size = new System.Drawing.Size(101, 62);
            this.ClientOrderListButton.TabIndex = 1;
            this.ClientOrderListButton.Text = "Список заказов";
            this.ClientOrderListButton.UseVisualStyleBackColor = false;
            this.ClientOrderListButton.Click += new System.EventHandler(this.ClientOrderListButton_Click);
            // 
            // ChangeAccButton
            // 
            this.ChangeAccButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ChangeAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeAccButton.Location = new System.Drawing.Point(598, 12);
            this.ChangeAccButton.Name = "ChangeAccButton";
            this.ChangeAccButton.Size = new System.Drawing.Size(101, 62);
            this.ChangeAccButton.TabIndex = 2;
            this.ChangeAccButton.Text = "Сменить аккаунт";
            this.ChangeAccButton.UseVisualStyleBackColor = false;
            this.ChangeAccButton.Click += new System.EventHandler(this.ChangeAccButton_Click);
            // 
            // DataBaseClient
            // 
            this.DataBaseClient.AllowUserToAddRows = false;
            this.DataBaseClient.AllowUserToDeleteRows = false;
            this.DataBaseClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseClient.ColumnHeadersVisible = false;
            this.DataBaseClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.name_product,
            this.price_product,
            this.amount_product,
            this.date_product});
            this.DataBaseClient.Location = new System.Drawing.Point(11, 99);
            this.DataBaseClient.MultiSelect = false;
            this.DataBaseClient.Name = "DataBaseClient";
            this.DataBaseClient.ReadOnly = true;
            this.DataBaseClient.RowHeadersVisible = false;
            this.DataBaseClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataBaseClient.Size = new System.Drawing.Size(424, 313);
            this.DataBaseClient.TabIndex = 3;
            this.DataBaseClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseClient_CellClick);
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(459, 111);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(72, 17);
            this.NameText.TabIndex = 4;
            this.NameText.Text = "Название";
            // 
            // NameOutput
            // 
            this.NameOutput.AutoSize = true;
            this.NameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOutput.Location = new System.Drawing.Point(547, 111);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(0, 17);
            this.NameOutput.TabIndex = 5;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceText.Location = new System.Drawing.Point(459, 155);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(160, 17);
            this.PriceText.TabIndex = 6;
            this.PriceText.Text = "Цена товара (за 1 шт.)";
            // 
            // PriceOutput
            // 
            this.PriceOutput.AutoSize = true;
            this.PriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceOutput.Location = new System.Drawing.Point(635, 155);
            this.PriceOutput.Name = "PriceOutput";
            this.PriceOutput.Size = new System.Drawing.Size(0, 17);
            this.PriceOutput.TabIndex = 7;
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountText.Location = new System.Drawing.Point(459, 202);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(103, 17);
            this.AmountText.TabIndex = 8;
            this.AmountText.Text = "Кол-во товара";
            // 
            // ChangeAmountBox
            // 
            this.ChangeAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeAmountBox.Location = new System.Drawing.Point(578, 200);
            this.ChangeAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ChangeAmountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeAmountBox.Name = "ChangeAmountBox";
            this.ChangeAmountBox.Size = new System.Drawing.Size(110, 23);
            this.ChangeAmountBox.TabIndex = 9;
            this.ChangeAmountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeAmountBox.ValueChanged += new System.EventHandler(this.ChangeAmountBox_ValueChanged);
            // 
            // ForPaymentText
            // 
            this.ForPaymentText.AutoSize = true;
            this.ForPaymentText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(145)))));
            this.ForPaymentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForPaymentText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ForPaymentText.Location = new System.Drawing.Point(458, 297);
            this.ForPaymentText.Name = "ForPaymentText";
            this.ForPaymentText.Size = new System.Drawing.Size(58, 20);
            this.ForPaymentText.TabIndex = 10;
            this.ForPaymentText.Text = "Итого:";
            // 
            // ForPaymentOutput
            // 
            this.ForPaymentOutput.AutoSize = true;
            this.ForPaymentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForPaymentOutput.Location = new System.Drawing.Point(547, 297);
            this.ForPaymentOutput.Name = "ForPaymentOutput";
            this.ForPaymentOutput.Size = new System.Drawing.Size(0, 20);
            this.ForPaymentOutput.TabIndex = 11;
            // 
            // MakeOrderButton
            // 
            this.MakeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.MakeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeOrderButton.Location = new System.Drawing.Point(598, 358);
            this.MakeOrderButton.Name = "MakeOrderButton";
            this.MakeOrderButton.Size = new System.Drawing.Size(100, 54);
            this.MakeOrderButton.TabIndex = 12;
            this.MakeOrderButton.Text = "Заказать";
            this.MakeOrderButton.UseVisualStyleBackColor = false;
            this.MakeOrderButton.Click += new System.EventHandler(this.MakeOrderButton_Click);
            // 
            // NameProductHeader
            // 
            this.NameProductHeader.AutoSize = true;
            this.NameProductHeader.Location = new System.Drawing.Point(16, 79);
            this.NameProductHeader.Name = "NameProductHeader";
            this.NameProductHeader.Size = new System.Drawing.Size(121, 13);
            this.NameProductHeader.TabIndex = 13;
            this.NameProductHeader.Text = "Наименование товара";
            // 
            // ProceProductHeader
            // 
            this.ProceProductHeader.AutoSize = true;
            this.ProceProductHeader.Location = new System.Drawing.Point(198, 79);
            this.ProceProductHeader.Name = "ProceProductHeader";
            this.ProceProductHeader.Size = new System.Drawing.Size(71, 13);
            this.ProceProductHeader.TabIndex = 14;
            this.ProceProductHeader.Text = "Цена товара";
            // 
            // AmountProductHeader
            // 
            this.AmountProductHeader.AutoSize = true;
            this.AmountProductHeader.Location = new System.Drawing.Point(320, 79);
            this.AmountProductHeader.Name = "AmountProductHeader";
            this.AmountProductHeader.Size = new System.Drawing.Size(79, 13);
            this.AmountProductHeader.TabIndex = 15;
            this.AmountProductHeader.Text = "Кол-во товара";
            // 
            // idd
            // 
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Visible = false;
            // 
            // name_product
            // 
            this.name_product.HeaderText = "Наименование товара";
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_product.Width = 180;
            // 
            // price_product
            // 
            this.price_product.HeaderText = "Цена товара";
            this.price_product.Name = "price_product";
            this.price_product.ReadOnly = true;
            this.price_product.Width = 120;
            // 
            // amount_product
            // 
            this.amount_product.HeaderText = "Кол-во товара";
            this.amount_product.Name = "amount_product";
            this.amount_product.ReadOnly = true;
            this.amount_product.Width = 120;
            // 
            // date_product
            // 
            this.date_product.HeaderText = "Дата поступления";
            this.date_product.Name = "date_product";
            this.date_product.ReadOnly = true;
            this.date_product.Visible = false;
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(711, 433);
            this.Controls.Add(this.AmountProductHeader);
            this.Controls.Add(this.ProceProductHeader);
            this.Controls.Add(this.NameProductHeader);
            this.Controls.Add(this.MakeOrderButton);
            this.Controls.Add(this.ForPaymentOutput);
            this.Controls.Add(this.ForPaymentText);
            this.Controls.Add(this.ChangeAmountBox);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.PriceOutput);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.DataBaseClient);
            this.Controls.Add(this.ChangeAccButton);
            this.Controls.Add(this.ClientOrderListButton);
            this.Controls.Add(this.ProductsListText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsListText;
        private System.Windows.Forms.Button ClientOrderListButton;
        private System.Windows.Forms.Button ChangeAccButton;
        private System.Windows.Forms.DataGridView DataBaseClient;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label NameOutput;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label PriceOutput;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.NumericUpDown ChangeAmountBox;
        private System.Windows.Forms.Label ForPaymentText;
        private System.Windows.Forms.Label ForPaymentOutput;
        private System.Windows.Forms.Button MakeOrderButton;
        private System.Windows.Forms.Label NameProductHeader;
        private System.Windows.Forms.Label ProceProductHeader;
        private System.Windows.Forms.Label AmountProductHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_product;
    }
}