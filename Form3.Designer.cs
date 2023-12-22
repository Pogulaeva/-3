
namespace IS_FISU
{
    partial class AdminWindow
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
            this.ToStuffListButton = new System.Windows.Forms.Button();
            this.ToOrderListButton = new System.Windows.Forms.Button();
            this.ChangeAccButton = new System.Windows.Forms.Button();
            this.AdditionalFuncMenu = new System.Windows.Forms.MenuStrip();
            this.MakeACopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalFuncMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToStuffListButton
            // 
            this.ToStuffListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ToStuffListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToStuffListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToStuffListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToStuffListButton.Location = new System.Drawing.Point(31, 27);
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
            this.ToOrderListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToOrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToOrderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToOrderListButton.Location = new System.Drawing.Point(31, 106);
            this.ToOrderListButton.Name = "ToOrderListButton";
            this.ToOrderListButton.Size = new System.Drawing.Size(491, 73);
            this.ToOrderListButton.TabIndex = 1;
            this.ToOrderListButton.Text = "Перейти к списку заказов";
            this.ToOrderListButton.UseVisualStyleBackColor = false;
            this.ToOrderListButton.Click += new System.EventHandler(this.ToOrderListButton_Click);
            // 
            // ChangeAccButton
            // 
            this.ChangeAccButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.ChangeAccButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeAccButton.Location = new System.Drawing.Point(380, 185);
            this.ChangeAccButton.Name = "ChangeAccButton";
            this.ChangeAccButton.Size = new System.Drawing.Size(142, 62);
            this.ChangeAccButton.TabIndex = 3;
            this.ChangeAccButton.Text = "Сменить аккаунт";
            this.ChangeAccButton.UseVisualStyleBackColor = false;
            this.ChangeAccButton.Click += new System.EventHandler(this.ChangeAccButton_Click);
            // 
            // AdditionalFuncMenu
            // 
            this.AdditionalFuncMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeACopyMenu});
            this.AdditionalFuncMenu.Location = new System.Drawing.Point(0, 0);
            this.AdditionalFuncMenu.Name = "AdditionalFuncMenu";
            this.AdditionalFuncMenu.Size = new System.Drawing.Size(541, 24);
            this.AdditionalFuncMenu.TabIndex = 4;
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
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 263);
            this.Controls.Add(this.ChangeAccButton);
            this.Controls.Add(this.ToOrderListButton);
            this.Controls.Add(this.ToStuffListButton);
            this.Controls.Add(this.AdditionalFuncMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AdditionalFuncMenu;
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.AdditionalFuncMenu.ResumeLayout(false);
            this.AdditionalFuncMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToStuffListButton;
        private System.Windows.Forms.Button ToOrderListButton;
        private System.Windows.Forms.Button ChangeAccButton;
        private System.Windows.Forms.MenuStrip AdditionalFuncMenu;
        private System.Windows.Forms.ToolStripMenuItem MakeACopyMenu;
    }
}