
namespace IS_FISU
{
    partial class StuffStorageWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.DataBaseAdmin = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supply_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.PriceStandardInfo = new System.Windows.Forms.Label();
            this.UnitText = new System.Windows.Forms.Label();
            this.CurrencyText = new System.Windows.Forms.Label();
            this.AmountInput = new System.Windows.Forms.NumericUpDown();
            this.PriceInput = new System.Windows.Forms.NumericUpDown();
            this.NameInputBox = new System.Windows.Forms.RichTextBox();
            this.ProductDateText = new System.Windows.Forms.Label();
            this.ProductAmountText = new System.Windows.Forms.Label();
            this.ProductPriceText = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IdOutput = new System.Windows.Forms.Label();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.IDHeader = new System.Windows.Forms.Label();
            this.NameProductHeader = new System.Windows.Forms.Label();
            this.PriceProductHeader = new System.Windows.Forms.Label();
            this.AmountProductHeader = new System.Windows.Forms.Label();
            this.DateHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.AddNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProductButton.Location = new System.Drawing.Point(168, 30);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(650, 47);
            this.AddNewProductButton.TabIndex = 0;
            this.AddNewProductButton.Text = "Добавить новый товар";
            this.AddNewProductButton.UseVisualStyleBackColor = false;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // DataBaseAdmin
            // 
            this.DataBaseAdmin.AllowUserToAddRows = false;
            this.DataBaseAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.DataBaseAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseAdmin.ColumnHeadersVisible = false;
            this.DataBaseAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.price_product,
            this.amount_products,
            this.supply_date});
            this.DataBaseAdmin.Location = new System.Drawing.Point(12, 131);
            this.DataBaseAdmin.Name = "DataBaseAdmin";
            this.DataBaseAdmin.ReadOnly = true;
            this.DataBaseAdmin.RowHeadersVisible = false;
            this.DataBaseAdmin.Size = new System.Drawing.Size(638, 296);
            this.DataBaseAdmin.TabIndex = 1;
            this.DataBaseAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseAdmin_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // name_product
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.name_product.DefaultCellStyle = dataGridViewCellStyle1;
            this.name_product.HeaderText = "Наименование товара";
            this.name_product.MinimumWidth = 15;
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_product.Width = 200;
            // 
            // price_product
            // 
            this.price_product.HeaderText = "Цена товара";
            this.price_product.Name = "price_product";
            this.price_product.ReadOnly = true;
            this.price_product.Width = 120;
            // 
            // amount_products
            // 
            this.amount_products.HeaderText = "Кол-во товара";
            this.amount_products.Name = "amount_products";
            this.amount_products.ReadOnly = true;
            this.amount_products.Width = 120;
            // 
            // supply_date
            // 
            this.supply_date.HeaderText = "Дата поступления";
            this.supply_date.Name = "supply_date";
            this.supply_date.ReadOnly = true;
            this.supply_date.Width = 120;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Location = new System.Drawing.Point(917, 387);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(127, 57);
            this.SaveChangesButton.TabIndex = 41;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // PriceStandardInfo
            // 
            this.PriceStandardInfo.AutoSize = true;
            this.PriceStandardInfo.Location = new System.Drawing.Point(776, 265);
            this.PriceStandardInfo.Name = "PriceStandardInfo";
            this.PriceStandardInfo.Size = new System.Drawing.Size(21, 13);
            this.PriceStandardInfo.TabIndex = 39;
            this.PriceStandardInfo.Text = "[ i ]";
            this.PriceStandardInfo.MouseEnter += new System.EventHandler(this.PriceStandardInfo_MouseEnter);
            // 
            // UnitText
            // 
            this.UnitText.AutoSize = true;
            this.UnitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitText.Location = new System.Drawing.Point(1027, 311);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(35, 20);
            this.UnitText.TabIndex = 38;
            this.UnitText.Text = "шт.";
            // 
            // CurrencyText
            // 
            this.CurrencyText.AutoSize = true;
            this.CurrencyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyText.Location = new System.Drawing.Point(1027, 268);
            this.CurrencyText.Name = "CurrencyText";
            this.CurrencyText.Size = new System.Drawing.Size(18, 20);
            this.CurrencyText.TabIndex = 37;
            this.CurrencyText.Text = "₽";
            // 
            // AmountInput
            // 
            this.AmountInput.Location = new System.Drawing.Point(803, 311);
            this.AmountInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(218, 20);
            this.AmountInput.TabIndex = 35;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(803, 268);
            this.PriceInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(218, 20);
            this.PriceInput.TabIndex = 34;
            // 
            // NameInputBox
            // 
            this.NameInputBox.Location = new System.Drawing.Point(779, 202);
            this.NameInputBox.MaxLength = 80;
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(248, 50);
            this.NameInputBox.TabIndex = 33;
            this.NameInputBox.Text = "";
            // 
            // ProductDateText
            // 
            this.ProductDateText.AutoSize = true;
            this.ProductDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductDateText.Location = new System.Drawing.Point(671, 349);
            this.ProductDateText.Name = "ProductDateText";
            this.ProductDateText.Size = new System.Drawing.Size(153, 20);
            this.ProductDateText.TabIndex = 32;
            this.ProductDateText.Text = "Дата поступления:";
            // 
            // ProductAmountText
            // 
            this.ProductAmountText.AutoSize = true;
            this.ProductAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductAmountText.Location = new System.Drawing.Point(671, 311);
            this.ProductAmountText.Name = "ProductAmountText";
            this.ProductAmountText.Size = new System.Drawing.Size(123, 20);
            this.ProductAmountText.TabIndex = 31;
            this.ProductAmountText.Text = "Кол-во товара:";
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.AutoSize = true;
            this.ProductPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceText.Location = new System.Drawing.Point(671, 265);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(110, 20);
            this.ProductPriceText.TabIndex = 30;
            this.ProductPriceText.Text = "Цена товара:";
            // 
            // ProductNameText
            // 
            this.ProductNameText.AutoSize = true;
            this.ProductNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameText.Location = new System.Drawing.Point(671, 202);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(102, 20);
            this.ProductNameText.TabIndex = 29;
            this.ProductNameText.Text = "Имя товара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(666, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Изменение данных о товаре";
            // 
            // DateInput
            // 
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateInput.Location = new System.Drawing.Point(830, 349);
            this.DateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(204, 20);
            this.DateInput.TabIndex = 36;
            this.DateInput.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(671, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID";
            // 
            // IdOutput
            // 
            this.IdOutput.AutoSize = true;
            this.IdOutput.Location = new System.Drawing.Point(712, 167);
            this.IdOutput.Name = "IdOutput";
            this.IdOutput.Size = new System.Drawing.Size(0, 13);
            this.IdOutput.TabIndex = 43;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Location = new System.Drawing.Point(675, 387);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(127, 57);
            this.DeleteProductButton.TabIndex = 44;
            this.DeleteProductButton.Text = "Удалить товар";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // IDHeader
            // 
            this.IDHeader.AutoSize = true;
            this.IDHeader.Location = new System.Drawing.Point(12, 115);
            this.IDHeader.Name = "IDHeader";
            this.IDHeader.Size = new System.Drawing.Size(18, 13);
            this.IDHeader.TabIndex = 45;
            this.IDHeader.Text = "ID";
            // 
            // NameProductHeader
            // 
            this.NameProductHeader.AutoSize = true;
            this.NameProductHeader.Location = new System.Drawing.Point(99, 115);
            this.NameProductHeader.Name = "NameProductHeader";
            this.NameProductHeader.Size = new System.Drawing.Size(121, 13);
            this.NameProductHeader.TabIndex = 46;
            this.NameProductHeader.Text = "Наименование товара";
            // 
            // PriceProductHeader
            // 
            this.PriceProductHeader.AutoSize = true;
            this.PriceProductHeader.Location = new System.Drawing.Point(298, 115);
            this.PriceProductHeader.Name = "PriceProductHeader";
            this.PriceProductHeader.Size = new System.Drawing.Size(71, 13);
            this.PriceProductHeader.TabIndex = 47;
            this.PriceProductHeader.Text = "Цена товара";
            // 
            // AmountProductHeader
            // 
            this.AmountProductHeader.AutoSize = true;
            this.AmountProductHeader.Location = new System.Drawing.Point(417, 115);
            this.AmountProductHeader.Name = "AmountProductHeader";
            this.AmountProductHeader.Size = new System.Drawing.Size(79, 13);
            this.AmountProductHeader.TabIndex = 48;
            this.AmountProductHeader.Text = "Кол-во товара";
            // 
            // DateHeader
            // 
            this.DateHeader.AutoSize = true;
            this.DateHeader.Location = new System.Drawing.Point(539, 115);
            this.DateHeader.Name = "DateHeader";
            this.DateHeader.Size = new System.Drawing.Size(100, 13);
            this.DateHeader.TabIndex = 49;
            this.DateHeader.Text = "Дата поступления";
            // 
            // StuffStorageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1072, 464);
            this.Controls.Add(this.DateHeader);
            this.Controls.Add(this.AmountProductHeader);
            this.Controls.Add(this.PriceProductHeader);
            this.Controls.Add(this.NameProductHeader);
            this.Controls.Add(this.IDHeader);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.IdOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.PriceStandardInfo);
            this.Controls.Add(this.UnitText);
            this.Controls.Add(this.CurrencyText);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.AmountInput);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.NameInputBox);
            this.Controls.Add(this.ProductDateText);
            this.Controls.Add(this.ProductAmountText);
            this.Controls.Add(this.ProductPriceText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBaseAdmin);
            this.Controls.Add(this.AddNewProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StuffStorageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.DataGridView DataBaseAdmin;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label PriceStandardInfo;
        private System.Windows.Forms.Label UnitText;
        private System.Windows.Forms.Label CurrencyText;
        private System.Windows.Forms.NumericUpDown AmountInput;
        private System.Windows.Forms.NumericUpDown PriceInput;
        private System.Windows.Forms.RichTextBox NameInputBox;
        private System.Windows.Forms.Label ProductDateText;
        private System.Windows.Forms.Label ProductAmountText;
        private System.Windows.Forms.Label ProductPriceText;
        private System.Windows.Forms.Label ProductNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdOutput;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Label IDHeader;
        private System.Windows.Forms.Label NameProductHeader;
        private System.Windows.Forms.Label PriceProductHeader;
        private System.Windows.Forms.Label AmountProductHeader;
        private System.Windows.Forms.Label DateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn supply_date;
    }
}