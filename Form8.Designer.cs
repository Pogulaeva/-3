
namespace IS_FISU
{
    partial class ChooseOrderListWindow
    {
        // Обязательная переменная конструктора
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        // Освобождение всех используемых ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        // Требуемый метод для поддержки конструктора
        private void InitializeComponent()
        {
            this.UnapprovedOrdersButton = new System.Windows.Forms.Button();
            this.EditedOrdersButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdditionalFuncMenu = new System.Windows.Forms.MenuStrip();
            this.MakeACopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalFuncMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnapprovedOrdersButton
            // 
            this.UnapprovedOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.UnapprovedOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnapprovedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnapprovedOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnapprovedOrdersButton.Location = new System.Drawing.Point(11, 36);
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
            this.EditedOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditedOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditedOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditedOrdersButton.Location = new System.Drawing.Point(11, 100);
            this.EditedOrdersButton.Name = "EditedOrdersButton";
            this.EditedOrdersButton.Size = new System.Drawing.Size(485, 58);
            this.EditedOrdersButton.TabIndex = 1;
            this.EditedOrdersButton.Text = "Список редактированых заказов";
            this.EditedOrdersButton.UseVisualStyleBackColor = false;
            this.EditedOrdersButton.Click += new System.EventHandler(this.EditedOrdersButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(376, 164);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 61);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Вернуться к меню";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdditionalFuncMenu
            // 
            this.AdditionalFuncMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeACopyMenu});
            this.AdditionalFuncMenu.Location = new System.Drawing.Point(0, 0);
            this.AdditionalFuncMenu.Name = "AdditionalFuncMenu";
            this.AdditionalFuncMenu.Size = new System.Drawing.Size(508, 24);
            this.AdditionalFuncMenu.TabIndex = 3;
            this.AdditionalFuncMenu.Text = "menuStrip1";
            // 
            // MakeACopyMenu
            // 
            this.MakeACopyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.MakeACopyMenu.Name = "MakeACopyMenu";
            this.MakeACopyMenu.Size = new System.Drawing.Size(152, 20);
            this.MakeACopyMenu.Text = "Резервное копирование";
            this.MakeACopyMenu.Click += new System.EventHandler(this.MakeACopyMenu_Click);
            // 
            // ChooseOrderListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 237);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditedOrdersButton);
            this.Controls.Add(this.UnapprovedOrdersButton);
            this.Controls.Add(this.AdditionalFuncMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AdditionalFuncMenu;
            this.MaximizeBox = false;
            this.Name = "ChooseOrderListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.AdditionalFuncMenu.ResumeLayout(false);
            this.AdditionalFuncMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnapprovedOrdersButton;
        private System.Windows.Forms.Button EditedOrdersButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip AdditionalFuncMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeACopyMenu;
    }
}