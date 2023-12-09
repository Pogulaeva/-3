
namespace IS_FISU
{
    partial class OrdersNotConfirmByClientWindow
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
            this.TipText = new System.Windows.Forms.Label();
            this.DataBaseWaitingForConfirm = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOutput = new System.Windows.Forms.Label();
            this.ForPaymentText = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.IDOutput = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.Label();
            this.NameOutput = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.AmountOutput = new System.Windows.Forms.Label();
            this.DateText = new System.Windows.Forms.Label();
            this.DateOutput = new System.Windows.Forms.Label();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseWaitingForConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipText.Location = new System.Drawing.Point(21, 28);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(639, 25);
            this.TipText.TabIndex = 0;
            this.TipText.Text = "Подтвердите изменения или отмените заказ в случае несогласия";
            // 
            // DataBaseWaitingForConfirm
            // 
            this.DataBaseWaitingForConfirm.AllowUserToAddRows = false;
            this.DataBaseWaitingForConfirm.AllowUserToDeleteRows = false;
            this.DataBaseWaitingForConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DataBaseWaitingForConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseWaitingForConfirm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.amount_product,
            this.order_price,
            this.order_date});
            this.DataBaseWaitingForConfirm.Location = new System.Drawing.Point(12, 75);
            this.DataBaseWaitingForConfirm.Name = "DataBaseWaitingForConfirm";
            this.DataBaseWaitingForConfirm.ReadOnly = true;
            this.DataBaseWaitingForConfirm.RowHeadersVisible = false;
            this.DataBaseWaitingForConfirm.Size = new System.Drawing.Size(664, 313);
            this.DataBaseWaitingForConfirm.TabIndex = 1;
            this.DataBaseWaitingForConfirm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseWaitingForConfirm_CellClick);
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
            this.order_date.Width = 140;
            // 
            // PriceOutput
            // 
            this.PriceOutput.AutoSize = true;
            this.PriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceOutput.Location = new System.Drawing.Point(825, 278);
            this.PriceOutput.Name = "PriceOutput";
            this.PriceOutput.Size = new System.Drawing.Size(0, 20);
            this.PriceOutput.TabIndex = 19;
            // 
            // ForPaymentText
            // 
            this.ForPaymentText.AutoSize = true;
            this.ForPaymentText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(145)))));
            this.ForPaymentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForPaymentText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ForPaymentText.Location = new System.Drawing.Point(691, 278);
            this.ForPaymentText.Name = "ForPaymentText";
            this.ForPaymentText.Size = new System.Drawing.Size(117, 20);
            this.ForPaymentText.TabIndex = 18;
            this.ForPaymentText.Text = "Сумма заказа:";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountText.Location = new System.Drawing.Point(692, 166);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(103, 17);
            this.AmountText.TabIndex = 16;
            this.AmountText.Text = "Кол-во товара";
            // 
            // IDOutput
            // 
            this.IDOutput.AutoSize = true;
            this.IDOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDOutput.Location = new System.Drawing.Point(808, 85);
            this.IDOutput.Name = "IDOutput";
            this.IDOutput.Size = new System.Drawing.Size(0, 17);
            this.IDOutput.TabIndex = 15;
            // 
            // IDtext
            // 
            this.IDtext.AutoSize = true;
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtext.Location = new System.Drawing.Point(692, 85);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 17);
            this.IDtext.TabIndex = 14;
            this.IDtext.Text = "Номер заказа";
            // 
            // NameOutput
            // 
            this.NameOutput.AutoSize = true;
            this.NameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOutput.Location = new System.Drawing.Point(780, 128);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(0, 17);
            this.NameOutput.TabIndex = 13;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(692, 128);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(72, 17);
            this.NameText.TabIndex = 12;
            this.NameText.Text = "Название";
            // 
            // AmountOutput
            // 
            this.AmountOutput.AutoSize = true;
            this.AmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountOutput.Location = new System.Drawing.Point(808, 170);
            this.AmountOutput.Name = "AmountOutput";
            this.AmountOutput.Size = new System.Drawing.Size(0, 17);
            this.AmountOutput.TabIndex = 20;
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateText.Location = new System.Drawing.Point(692, 206);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(95, 17);
            this.DateText.TabIndex = 21;
            this.DateText.Text = "Дата заказа:";
            // 
            // DateOutput
            // 
            this.DateOutput.AutoSize = true;
            this.DateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOutput.Location = new System.Drawing.Point(795, 210);
            this.DateOutput.Name = "DateOutput";
            this.DateOutput.Size = new System.Drawing.Size(0, 17);
            this.DateOutput.TabIndex = 22;
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ConfirmChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmChangesButton.Location = new System.Drawing.Point(692, 336);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(106, 51);
            this.ConfirmChangesButton.TabIndex = 23;
            this.ConfirmChangesButton.Text = "Подтвердить изменения в заказе";
            this.ConfirmChangesButton.UseVisualStyleBackColor = false;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.CancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOrderButton.Location = new System.Drawing.Point(829, 336);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(105, 51);
            this.CancelOrderButton.TabIndex = 24;
            this.CancelOrderButton.Text = "Отменить заказ";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(829, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 51);
            this.BackButton.TabIndex = 25;
            this.BackButton.Text = "Вернуться к выбору списка заказов";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrdersNotConfirmByClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 403);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.ConfirmChangesButton);
            this.Controls.Add(this.DateOutput);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.AmountOutput);
            this.Controls.Add(this.PriceOutput);
            this.Controls.Add(this.ForPaymentText);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.IDOutput);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.DataBaseWaitingForConfirm);
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrdersNotConfirmByClientWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseWaitingForConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.DataGridView DataBaseWaitingForConfirm;
        private System.Windows.Forms.Label PriceOutput;
        private System.Windows.Forms.Label ForPaymentText;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.Label IDOutput;
        private System.Windows.Forms.Label IDtext;
        private System.Windows.Forms.Label NameOutput;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label AmountOutput;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.Label DateOutput;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.Button BackButton;
    }
}