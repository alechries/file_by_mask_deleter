namespace FileByMaskDeleter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.StartDeletionButton = new System.Windows.Forms.Button();
            this.SetPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mask:";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskTextBox.Location = new System.Drawing.Point(54, 37);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(266, 20);
            this.MaskTextBox.TabIndex = 2;
            this.MaskTextBox.TextChanged += new System.EventHandler(this.MaskTextBox_TextChanged);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextBox.Location = new System.Drawing.Point(54, 11);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(266, 20);
            this.PathTextBox.TabIndex = 3;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // StartDeletionButton
            // 
            this.StartDeletionButton.BackColor = System.Drawing.Color.Firebrick;
            this.StartDeletionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDeletionButton.ForeColor = System.Drawing.Color.Snow;
            this.StartDeletionButton.Location = new System.Drawing.Point(12, 75);
            this.StartDeletionButton.Name = "StartDeletionButton";
            this.StartDeletionButton.Size = new System.Drawing.Size(151, 23);
            this.StartDeletionButton.TabIndex = 4;
            this.StartDeletionButton.Text = "Start deletion";
            this.StartDeletionButton.UseVisualStyleBackColor = false;
            this.StartDeletionButton.Click += new System.EventHandler(this.StartDeletionButton_Click);
            this.StartDeletionButton.Enabled = false;
            // 
            // SetPathButton
            // 
            this.SetPathButton.Location = new System.Drawing.Point(169, 75);
            this.SetPathButton.Name = "SetPathButton";
            this.SetPathButton.Size = new System.Drawing.Size(151, 23);
            this.SetPathButton.TabIndex = 5;
            this.SetPathButton.Text = "Set path";
            this.SetPathButton.UseVisualStyleBackColor = true;
            this.SetPathButton.Click += new System.EventHandler(this.SetPathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 110);
            this.Controls.Add(this.SetPathButton);
            this.Controls.Add(this.StartDeletionButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File By Mask Deleter";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button StartDeletionButton;
        private System.Windows.Forms.Button SetPathButton;
    }
}

