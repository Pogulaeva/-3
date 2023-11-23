
namespace IS_FISU
{
    partial class AdminWindow
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
            this.ToStuffListButton = new System.Windows.Forms.Button();
            this.ToOrderListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToStuffListButton
            // 
            this.ToStuffListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ToStuffListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToStuffListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToStuffListButton.Location = new System.Drawing.Point(12, 25);
            this.ToStuffListButton.Name = "ToStuffListButton";
            this.ToStuffListButton.Size = new System.Drawing.Size(491, 73);
            this.ToStuffListButton.TabIndex = 0;
            this.ToStuffListButton.Text = "Перейти к списку товаров";
            this.ToStuffListButton.UseVisualStyleBackColor = false;
            this.ToStuffListButton.Click += new System.EventHandler(this.ToStuffListButton_Click);
            // 
            // ToOrderListButton
            // 
            this.ToOrderListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ToOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToOrderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToOrderListButton.Location = new System.Drawing.Point(12, 104);
            this.ToOrderListButton.Name = "ToOrderListButton";
            this.ToOrderListButton.Size = new System.Drawing.Size(491, 73);
            this.ToOrderListButton.TabIndex = 1;
            this.ToOrderListButton.Text = "Перейти к списку заказов";
            this.ToOrderListButton.UseVisualStyleBackColor = false;
            this.ToOrderListButton.Click += new System.EventHandler(this.ToOrderListButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 202);
            this.Controls.Add(this.ToOrderListButton);
            this.Controls.Add(this.ToStuffListButton);
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToStuffListButton;
        private System.Windows.Forms.Button ToOrderListButton;
    }
}