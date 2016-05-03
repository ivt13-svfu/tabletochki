namespace Buildings
{
    partial class EditProviderForm
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
            this.buttonEditCancel = new System.Windows.Forms.Button();
            this.buttonEditSave = new System.Windows.Forms.Button();
            this.textBoxEditProvLis = new System.Windows.Forms.TextBox();
            this.textBoxEditProvINN = new System.Windows.Forms.TextBox();
            this.textBoxEditProvName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEditCancel
            // 
            this.buttonEditCancel.Location = new System.Drawing.Point(277, 158);
            this.buttonEditCancel.Name = "buttonEditCancel";
            this.buttonEditCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCancel.TabIndex = 15;
            this.buttonEditCancel.Text = "Отмена";
            this.buttonEditCancel.UseVisualStyleBackColor = true;
            this.buttonEditCancel.Click += new System.EventHandler(this.buttonEditCancel_Click);
            // 
            // buttonEditSave
            // 
            this.buttonEditSave.Location = new System.Drawing.Point(177, 158);
            this.buttonEditSave.Name = "buttonEditSave";
            this.buttonEditSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEditSave.TabIndex = 14;
            this.buttonEditSave.Text = "Сохранить";
            this.buttonEditSave.UseVisualStyleBackColor = true;
            this.buttonEditSave.Click += new System.EventHandler(this.buttonEditSave_Click);
            // 
            // textBoxEditProvLis
            // 
            this.textBoxEditProvLis.Location = new System.Drawing.Point(177, 91);
            this.textBoxEditProvLis.Name = "textBoxEditProvLis";
            this.textBoxEditProvLis.Size = new System.Drawing.Size(175, 20);
            this.textBoxEditProvLis.TabIndex = 13;
            // 
            // textBoxEditProvINN
            // 
            this.textBoxEditProvINN.Location = new System.Drawing.Point(177, 54);
            this.textBoxEditProvINN.Name = "textBoxEditProvINN";
            this.textBoxEditProvINN.Size = new System.Drawing.Size(175, 20);
            this.textBoxEditProvINN.TabIndex = 12;
            // 
            // textBoxEditProvName
            // 
            this.textBoxEditProvName.Location = new System.Drawing.Point(177, 21);
            this.textBoxEditProvName.Name = "textBoxEditProvName";
            this.textBoxEditProvName.Size = new System.Drawing.Size(175, 20);
            this.textBoxEditProvName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Лицензия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название поставщика";
            // 
            // EditProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 215);
            this.Controls.Add(this.buttonEditCancel);
            this.Controls.Add(this.buttonEditSave);
            this.Controls.Add(this.textBoxEditProvLis);
            this.Controls.Add(this.textBoxEditProvINN);
            this.Controls.Add(this.textBoxEditProvName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProviderForm";
            this.Text = "EditProviderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditCancel;
        private System.Windows.Forms.Button buttonEditSave;
        private System.Windows.Forms.TextBox textBoxEditProvLis;
        private System.Windows.Forms.TextBox textBoxEditProvINN;
        private System.Windows.Forms.TextBox textBoxEditProvName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}