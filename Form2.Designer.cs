﻿
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
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductsListText);
            this.Name = "ClientWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsListText;
    }
}