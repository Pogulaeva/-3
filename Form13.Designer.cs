
namespace IS_FISU
{
    partial class ActiveOrdersWindow
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
            this.DataBaseActiveOrders = new System.Windows.Forms.DataGridView();
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
            this.DataBaseActiveOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.DataBaseActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseActiveOrders.Location = new System.Drawing.Point(21, 83);
            this.DataBaseActiveOrders.Name = "DataBaseActiveOrders";
            this.DataBaseActiveOrders.Size = new System.Drawing.Size(490, 338);
            this.DataBaseActiveOrders.TabIndex = 1;
            // 
            // ActiveOrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataBaseActiveOrders);
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}