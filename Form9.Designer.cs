
namespace IS_FISU
{
    partial class CommentForDeletingWindow
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
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.TipText = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommentBox
            // 
            this.CommentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.CommentBox.Location = new System.Drawing.Point(16, 46);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(401, 185);
            this.CommentBox.TabIndex = 0;
            this.CommentBox.Text = "";
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipText.Location = new System.Drawing.Point(12, 9);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(333, 24);
            this.TipText.TabIndex = 1;
            this.TipText.Text = "Напишите причину удаления заказа";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Location = new System.Drawing.Point(267, 237);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(150, 50);
            this.SendMessageButton.TabIndex = 2;
            this.SendMessageButton.Text = "Отправить сообщение пользователю";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // CommentForDeletingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 300);
            this.ControlBox = false;
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.CommentBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CommentForDeletingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учёта продаж интернет-магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommentBox;
        private System.Windows.Forms.Label TipText;
        private System.Windows.Forms.Button SendMessageButton;
    }
}