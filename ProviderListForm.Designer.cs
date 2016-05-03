namespace Buildings
{
    partial class ProviderListForm
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
            this.ListBoxProvider = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeleteProvider = new System.Windows.Forms.Button();
            this.buttonEditProvider = new System.Windows.Forms.Button();
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxProvider
            // 
            this.ListBoxProvider.FormattingEnabled = true;
            this.ListBoxProvider.Location = new System.Drawing.Point(13, 16);
            this.ListBoxProvider.Name = "ListBoxProvider";
            this.ListBoxProvider.Size = new System.Drawing.Size(488, 160);
            this.ListBoxProvider.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(426, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProvider
            // 
            this.buttonDeleteProvider.Location = new System.Drawing.Point(261, 210);
            this.buttonDeleteProvider.Name = "buttonDeleteProvider";
            this.buttonDeleteProvider.Size = new System.Drawing.Size(75, 36);
            this.buttonDeleteProvider.TabIndex = 8;
            this.buttonDeleteProvider.Text = "Удалить";
            this.buttonDeleteProvider.UseVisualStyleBackColor = true;
            // 
            // buttonEditProvider
            // 
            this.buttonEditProvider.Location = new System.Drawing.Point(128, 210);
            this.buttonEditProvider.Name = "buttonEditProvider";
            this.buttonEditProvider.Size = new System.Drawing.Size(106, 36);
            this.buttonEditProvider.TabIndex = 7;
            this.buttonEditProvider.Text = "Редактировать";
            this.buttonEditProvider.UseVisualStyleBackColor = true;
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Location = new System.Drawing.Point(13, 210);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(85, 36);
            this.buttonAddProvider.TabIndex = 6;
            this.buttonAddProvider.Text = "Добавить поставщика";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            this.buttonAddProvider.Click += new System.EventHandler(this.buttonAddProvider_Click);
            // 
            // ProviderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.ListBoxProvider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDeleteProvider);
            this.Controls.Add(this.buttonEditProvider);
            this.Controls.Add(this.buttonAddProvider);
            this.Name = "ProviderListForm";
            this.Text = "ProviderListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProvider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeleteProvider;
        private System.Windows.Forms.Button buttonEditProvider;
        private System.Windows.Forms.Button buttonAddProvider;

    }
}