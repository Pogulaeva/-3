
namespace IS_FISU
{
    partial class StuffStorageWindow
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
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.AddNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProductButton.Location = new System.Drawing.Point(68, 12);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(650, 47);
            this.AddNewProductButton.TabIndex = 0;
            this.AddNewProductButton.Text = "Добавить новый товар";
            this.AddNewProductButton.UseVisualStyleBackColor = false;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // StuffStorageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewProductButton);
            this.Name = "StuffStorageWindow";
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewProductButton;
    }
}