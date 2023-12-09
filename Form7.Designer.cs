
namespace IS_FISU
{
    partial class ClientOrdersWindow
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
            this.OrdersNotConfirmByClientButton = new System.Windows.Forms.Button();
            this.OrdersNotConfirmedByAdminButton = new System.Windows.Forms.Button();
            this.ActiveOrdersButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrdersNotConfirmByClientButton
            // 
            this.OrdersNotConfirmByClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.OrdersNotConfirmByClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersNotConfirmByClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersNotConfirmByClientButton.Location = new System.Drawing.Point(12, 25);
            this.OrdersNotConfirmByClientButton.Name = "OrdersNotConfirmByClientButton";
            this.OrdersNotConfirmByClientButton.Size = new System.Drawing.Size(349, 65);
            this.OrdersNotConfirmByClientButton.TabIndex = 2;
            this.OrdersNotConfirmByClientButton.Text = "Список заказов, ожидающих подтверждения от пользователя";
            this.OrdersNotConfirmByClientButton.UseVisualStyleBackColor = false;
            this.OrdersNotConfirmByClientButton.Click += new System.EventHandler(this.OrdersNotConfirmByClientButton_Click);
            this.OrdersNotConfirmByClientButton.MouseEnter += new System.EventHandler(this.OrdersNotConfirmByClientButton_MouseEnter);
            // 
            // OrdersNotConfirmedByAdminButton
            // 
            this.OrdersNotConfirmedByAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.OrdersNotConfirmedByAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersNotConfirmedByAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersNotConfirmedByAdminButton.Location = new System.Drawing.Point(12, 96);
            this.OrdersNotConfirmedByAdminButton.Name = "OrdersNotConfirmedByAdminButton";
            this.OrdersNotConfirmedByAdminButton.Size = new System.Drawing.Size(349, 65);
            this.OrdersNotConfirmedByAdminButton.TabIndex = 3;
            this.OrdersNotConfirmedByAdminButton.Text = "Список непроверенных администратором заказов";
            this.OrdersNotConfirmedByAdminButton.UseVisualStyleBackColor = false;
            this.OrdersNotConfirmedByAdminButton.Click += new System.EventHandler(this.OrdersNotConfirmedByAdminButton_Click);
            this.OrdersNotConfirmedByAdminButton.MouseEnter += new System.EventHandler(this.OrdersNotConfirmedByAdminButton_MouseEnter);
            // 
            // ActiveOrdersButton
            // 
            this.ActiveOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.ActiveOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveOrdersButton.Location = new System.Drawing.Point(12, 167);
            this.ActiveOrdersButton.Name = "ActiveOrdersButton";
            this.ActiveOrdersButton.Size = new System.Drawing.Size(349, 65);
            this.ActiveOrdersButton.TabIndex = 4;
            this.ActiveOrdersButton.Text = "Список активных заказов";
            this.ActiveOrdersButton.UseVisualStyleBackColor = false;
            this.ActiveOrdersButton.Click += new System.EventHandler(this.ActiveOrdersButton_Click);
            this.ActiveOrdersButton.MouseEnter += new System.EventHandler(this.ActiveOrdersButton_MouseEnter);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(237, 252);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 58);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Вернуться к списку товаров";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ClientOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 322);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ActiveOrdersButton);
            this.Controls.Add(this.OrdersNotConfirmedByAdminButton);
            this.Controls.Add(this.OrdersNotConfirmByClientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientOrdersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrdersNotConfirmByClientButton;
        private System.Windows.Forms.Button OrdersNotConfirmedByAdminButton;
        private System.Windows.Forms.Button ActiveOrdersButton;
        private System.Windows.Forms.Button BackButton;
    }
}