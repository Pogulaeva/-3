
namespace IS_FISU
{
    partial class ChooseOrderListWindow
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
            this.UnapprovedOrdersButton = new System.Windows.Forms.Button();
            this.EditedOrdersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnapprovedOrdersButton
            // 
            this.UnapprovedOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.UnapprovedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnapprovedOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnapprovedOrdersButton.Location = new System.Drawing.Point(12, 12);
            this.UnapprovedOrdersButton.Name = "UnapprovedOrdersButton";
            this.UnapprovedOrdersButton.Size = new System.Drawing.Size(485, 58);
            this.UnapprovedOrdersButton.TabIndex = 0;
            this.UnapprovedOrdersButton.Text = "Список неподтверждённых заказов";
            this.UnapprovedOrdersButton.UseVisualStyleBackColor = false;
            this.UnapprovedOrdersButton.Click += new System.EventHandler(this.UnapprovedOrdersButton_Click);
            // 
            // EditedOrdersButton
            // 
            this.EditedOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.EditedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditedOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditedOrdersButton.Location = new System.Drawing.Point(12, 76);
            this.EditedOrdersButton.Name = "EditedOrdersButton";
            this.EditedOrdersButton.Size = new System.Drawing.Size(485, 58);
            this.EditedOrdersButton.TabIndex = 1;
            this.EditedOrdersButton.Text = "Список редактированых заказов";
            this.EditedOrdersButton.UseVisualStyleBackColor = false;
            this.EditedOrdersButton.Click += new System.EventHandler(this.EditedOrdersButton_Click);
            // 
            // ChooseOrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 239);
            this.Controls.Add(this.EditedOrdersButton);
            this.Controls.Add(this.UnapprovedOrdersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChooseOrderListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnapprovedOrdersButton;
        private System.Windows.Forms.Button EditedOrdersButton;
    }
}