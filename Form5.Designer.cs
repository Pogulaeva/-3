
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
            this.SuspendLayout();
            // 
            // OrderListText
            // 
            this.OrderListText.AutoSize = true;
            this.OrderListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderListText.Location = new System.Drawing.Point(16, 17);
            this.OrderListText.Name = "OrderListText";
            this.OrderListText.Size = new System.Drawing.Size(245, 37);
            this.OrderListText.TabIndex = 0;
            this.OrderListText.Text = "Список заказов";
            // 
            // OrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderListText);
            this.Name = "OrderListWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderListText;
    }
}