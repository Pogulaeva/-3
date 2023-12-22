
namespace IS_FISU
{
    partial class NewProductWindow
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
            this.CreateNewProductText = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.Label();
            this.ProductPriceText = new System.Windows.Forms.Label();
            this.ProductAmountText = new System.Windows.Forms.Label();
            this.ProductDateText = new System.Windows.Forms.Label();
            this.NameInputBox = new System.Windows.Forms.RichTextBox();
            this.PriceInput = new System.Windows.Forms.NumericUpDown();
            this.AmountInput = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CurrencyText = new System.Windows.Forms.Label();
            this.UnitText = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.PriceStandardInfo = new System.Windows.Forms.Label();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.AdditionalFuncMenu = new System.Windows.Forms.MenuStrip();
            this.MakeACopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).BeginInit();
            this.AdditionalFuncMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewProductText
            // 
            this.CreateNewProductText.AutoSize = true;
            this.CreateNewProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewProductText.Location = new System.Drawing.Point(15, 24);
            this.CreateNewProductText.Name = "CreateNewProductText";
            this.CreateNewProductText.Size = new System.Drawing.Size(323, 31);
            this.CreateNewProductText.TabIndex = 0;
            this.CreateNewProductText.Text = "Создание нового товара";
            // 
            // ProductNameText
            // 
            this.ProductNameText.AutoSize = true;
            this.ProductNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameText.Location = new System.Drawing.Point(16, 86);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(129, 25);
            this.ProductNameText.TabIndex = 1;
            this.ProductNameText.Text = "Имя товара:";
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.AutoSize = true;
            this.ProductPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceText.Location = new System.Drawing.Point(16, 149);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(133, 25);
            this.ProductPriceText.TabIndex = 2;
            this.ProductPriceText.Text = "Цена товара:";
            // 
            // ProductAmountText
            // 
            this.ProductAmountText.AutoSize = true;
            this.ProductAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductAmountText.Location = new System.Drawing.Point(16, 215);
            this.ProductAmountText.Name = "ProductAmountText";
            this.ProductAmountText.Size = new System.Drawing.Size(150, 25);
            this.ProductAmountText.TabIndex = 3;
            this.ProductAmountText.Text = "Кол-во товара:";
            // 
            // ProductDateText
            // 
            this.ProductDateText.AutoSize = true;
            this.ProductDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductDateText.Location = new System.Drawing.Point(16, 277);
            this.ProductDateText.Name = "ProductDateText";
            this.ProductDateText.Size = new System.Drawing.Size(192, 25);
            this.ProductDateText.TabIndex = 4;
            this.ProductDateText.Text = "Дата поступления:";
            // 
            // NameInputBox
            // 
            this.NameInputBox.Location = new System.Drawing.Point(170, 90);
            this.NameInputBox.MaxLength = 80;
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(248, 50);
            this.NameInputBox.TabIndex = 5;
            this.NameInputBox.Text = "";
            this.NameInputBox.TextChanged += new System.EventHandler(this.NameInputBox_TextChanged);
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(169, 157);
            this.PriceInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PriceInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(218, 20);
            this.PriceInput.TabIndex = 6;
            this.PriceInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountInput
            // 
            this.AmountInput.Location = new System.Drawing.Point(169, 220);
            this.AmountInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AmountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(218, 20);
            this.AmountInput.TabIndex = 7;
            this.AmountInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(301, 380);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 58);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CurrencyText
            // 
            this.CurrencyText.AutoSize = true;
            this.CurrencyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyText.Location = new System.Drawing.Point(393, 157);
            this.CurrencyText.Name = "CurrencyText";
            this.CurrencyText.Size = new System.Drawing.Size(18, 20);
            this.CurrencyText.TabIndex = 11;
            this.CurrencyText.Text = "₽";
            // 
            // UnitText
            // 
            this.UnitText.AutoSize = true;
            this.UnitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitText.Location = new System.Drawing.Point(393, 220);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(35, 20);
            this.UnitText.TabIndex = 12;
            this.UnitText.Text = "шт.";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Location = new System.Drawing.Point(21, 380);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(127, 57);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Visible = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // PriceStandardInfo
            // 
            this.PriceStandardInfo.AutoSize = true;
            this.PriceStandardInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.PriceStandardInfo.Location = new System.Drawing.Point(142, 149);
            this.PriceStandardInfo.Name = "PriceStandardInfo";
            this.PriceStandardInfo.Size = new System.Drawing.Size(21, 13);
            this.PriceStandardInfo.TabIndex = 14;
            this.PriceStandardInfo.Text = "[ i ]";
            this.PriceStandardInfo.MouseEnter += new System.EventHandler(this.PriceStandardInfo_MouseEnter);
            // 
            // DateInput
            // 
            this.DateInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInput.Location = new System.Drawing.Point(223, 280);
            this.DateInput.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(163, 23);
            this.DateInput.TabIndex = 15;
            // 
            // AdditionalFuncMenu
            // 
            this.AdditionalFuncMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeACopyMenu});
            this.AdditionalFuncMenu.Location = new System.Drawing.Point(0, 0);
            this.AdditionalFuncMenu.Name = "AdditionalFuncMenu";
            this.AdditionalFuncMenu.Size = new System.Drawing.Size(453, 24);
            this.AdditionalFuncMenu.TabIndex = 16;
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
            // NewProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.PriceStandardInfo);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.UnitText);
            this.Controls.Add(this.CurrencyText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AmountInput);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.NameInputBox);
            this.Controls.Add(this.ProductDateText);
            this.Controls.Add(this.ProductAmountText);
            this.Controls.Add(this.ProductPriceText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.CreateNewProductText);
            this.Controls.Add(this.AdditionalFuncMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AdditionalFuncMenu;
            this.Name = "NewProductWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).EndInit();
            this.AdditionalFuncMenu.ResumeLayout(false);
            this.AdditionalFuncMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateNewProductText;
        private System.Windows.Forms.Label ProductNameText;
        private System.Windows.Forms.Label ProductPriceText;
        private System.Windows.Forms.Label ProductAmountText;
        private System.Windows.Forms.Label ProductDateText;
        private System.Windows.Forms.RichTextBox NameInputBox;
        private System.Windows.Forms.NumericUpDown PriceInput;
        private System.Windows.Forms.NumericUpDown AmountInput;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CurrencyText;
        private System.Windows.Forms.Label UnitText;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label PriceStandardInfo;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.MenuStrip AdditionalFuncMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeACopyMenu;
    }
}