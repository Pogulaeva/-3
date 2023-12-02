
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
            this.CreateOrderButton = new System.Windows.Forms.Button();
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
            this.ClientOrderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientOrderListButton.Location = new System.Drawing.Point(543, 80);
            this.ClientOrderListButton.Name = "ClientOrderListButton";
            this.ClientOrderListButton.Size = new System.Drawing.Size(143, 63);
            this.ClientOrderListButton.TabIndex = 1;
            this.ClientOrderListButton.Text = "Список заказов";
            this.ClientOrderListButton.UseVisualStyleBackColor = false;
            this.ClientOrderListButton.Click += new System.EventHandler(this.ClientOrderListButton_Click);
            // 
            // ChangeAccButton
            // 
            this.ChangeAccButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ChangeAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeAccButton.Location = new System.Drawing.Point(544, 12);
            this.ChangeAccButton.Name = "ChangeAccButton";
            this.ChangeAccButton.Size = new System.Drawing.Size(142, 62);
            this.ChangeAccButton.TabIndex = 2;
            this.ChangeAccButton.Text = "Сменить аккаунт";
            this.ChangeAccButton.UseVisualStyleBackColor = false;
            this.ChangeAccButton.Click += new System.EventHandler(this.ChangeAccButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrderButton.Location = new System.Drawing.Point(544, 369);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(143, 63);
            this.CreateOrderButton.TabIndex = 3;
            this.CreateOrderButton.Text = "Сформировать заказ";
            this.CreateOrderButton.UseVisualStyleBackColor = false;
            this.CreateOrderButton.Visible = false;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.ChangeAccButton);
            this.Controls.Add(this.ClientOrderListButton);
            this.Controls.Add(this.ProductsListText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsListText;
        private System.Windows.Forms.Button ClientOrderListButton;
        private System.Windows.Forms.Button ChangeAccButton;
        private System.Windows.Forms.Button CreateOrderButton;
    }
}