
namespace IS_FISU
{
    partial class AccountChooseWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.ChooseAccountText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientButton.Location = new System.Drawing.Point(12, 85);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(217, 94);
            this.ClientButton.TabIndex = 0;
            this.ClientButton.Text = "Клиент";
            this.ClientButton.UseVisualStyleBackColor = false;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Location = new System.Drawing.Point(286, 85);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(217, 94);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Администратор";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // ChooseAccountText
            // 
            this.ChooseAccountText.AutoSize = true;
            this.ChooseAccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseAccountText.Location = new System.Drawing.Point(117, 27);
            this.ChooseAccountText.Name = "ChooseAccountText";
            this.ChooseAccountText.Size = new System.Drawing.Size(277, 36);
            this.ChooseAccountText.TabIndex = 2;
            this.ChooseAccountText.Text = "Выберите аккаунт";
            // 
            // AccountChooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 202);
            this.Controls.Add(this.ChooseAccountText);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.ClientButton);
            this.MaximizeBox = false;
            this.Name = "AccountChooseWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label ChooseAccountText;
    }
}

