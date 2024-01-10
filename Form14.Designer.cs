
namespace IS_FISU
{
    partial class ActiveOrdersWindowAdm
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
            this.AdditionalFuncMenu = new System.Windows.Forms.MenuStrip();
            this.MakeACopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.Button();
            this.DataBaseActiveOrdersAdm = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipText = new System.Windows.Forms.Label();
            this.AdditionalFuncMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseActiveOrdersAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // AdditionalFuncMenu
            // 
            this.AdditionalFuncMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeACopyMenu});
            this.AdditionalFuncMenu.Location = new System.Drawing.Point(0, 0);
            this.AdditionalFuncMenu.Name = "AdditionalFuncMenu";
            this.AdditionalFuncMenu.Size = new System.Drawing.Size(703, 24);
            this.AdditionalFuncMenu.TabIndex = 10;
            this.AdditionalFuncMenu.Text = "menuStrip1";
            // 
            // MakeACopyMenu
            // 
            this.MakeACopyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.MakeACopyMenu.Name = "MakeACopyMenu";
            this.MakeACopyMenu.Size = new System.Drawing.Size(152, 20);
            this.MakeACopyMenu.Text = "Резервное копирование";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(579, 41);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 50);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Вернуться к меню";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // DataBaseActiveOrdersAdm
            // 
            this.DataBaseActiveOrdersAdm.AllowUserToAddRows = false;
            this.DataBaseActiveOrdersAdm.AllowUserToDeleteRows = false;
            this.DataBaseActiveOrdersAdm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.DataBaseActiveOrdersAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseActiveOrdersAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.amount_product,
            this.order_price,
            this.order_date});
            this.DataBaseActiveOrdersAdm.Location = new System.Drawing.Point(12, 97);
            this.DataBaseActiveOrdersAdm.Name = "DataBaseActiveOrdersAdm";
            this.DataBaseActiveOrdersAdm.ReadOnly = true;
            this.DataBaseActiveOrdersAdm.RowHeadersVisible = false;
            this.DataBaseActiveOrdersAdm.Size = new System.Drawing.Size(673, 338);
            this.DataBaseActiveOrdersAdm.TabIndex = 8;
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
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipText.Location = new System.Drawing.Point(12, 48);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(206, 29);
            this.TipText.TabIndex = 7;
            this.TipText.Text = "Активные заказы";
            // 
            // ActiveOrdersAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.AdditionalFuncMenu);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DataBaseActiveOrdersAdm);
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AdditionalFuncMenu;
            this.MaximizeBox = false;
            this.Name = "ActiveOrdersAdminWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.AdditionalFuncMenu.ResumeLayout(false);
            this.AdditionalFuncMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseActiveOrdersAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdditionalFuncMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeACopyMenu;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView DataBaseActiveOrdersAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.Label TipText;
    }
}