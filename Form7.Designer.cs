
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
            this.CanceledOrdersText = new System.Windows.Forms.Label();
            this.ActiveOrdersText = new System.Windows.Forms.Label();
            this.ClosedOrdersText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CanceledOrdersText
            // 
            this.CanceledOrdersText.AutoSize = true;
            this.CanceledOrdersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanceledOrdersText.Location = new System.Drawing.Point(12, 38);
            this.CanceledOrdersText.Name = "CanceledOrdersText";
            this.CanceledOrdersText.Size = new System.Drawing.Size(198, 48);
            this.CanceledOrdersText.TabIndex = 0;
            this.CanceledOrdersText.Text = "Список \r\nотменённых заказов";
            // 
            // ActiveOrdersText
            // 
            this.ActiveOrdersText.AutoSize = true;
            this.ActiveOrdersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveOrdersText.Location = new System.Drawing.Point(305, 38);
            this.ActiveOrdersText.Name = "ActiveOrdersText";
            this.ActiveOrdersText.Size = new System.Drawing.Size(171, 48);
            this.ActiveOrdersText.TabIndex = 1;
            this.ActiveOrdersText.Text = "Список \r\nактивных заказов";
            // 
            // ClosedOrdersText
            // 
            this.ClosedOrdersText.AutoSize = true;
            this.ClosedOrdersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClosedOrdersText.Location = new System.Drawing.Point(563, 38);
            this.ClosedOrdersText.Name = "ClosedOrdersText";
            this.ClosedOrdersText.Size = new System.Drawing.Size(209, 48);
            this.ClosedOrdersText.TabIndex = 2;
            this.ClosedOrdersText.Text = "Список \r\nзавершённых заказов";
            // 
            // ClientOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ClosedOrdersText);
            this.Controls.Add(this.ActiveOrdersText);
            this.Controls.Add(this.CanceledOrdersText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientOrdersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CanceledOrdersText;
        private System.Windows.Forms.Label ActiveOrdersText;
        private System.Windows.Forms.Label ClosedOrdersText;
    }
}