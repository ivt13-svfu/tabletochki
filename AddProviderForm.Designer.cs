namespace Buildings
{
    partial class AddProviderForm
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
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.buttonAddAdd = new System.Windows.Forms.Button();
            this.textBoxAddProvLis = new System.Windows.Forms.TextBox();
            this.textBoxAddProvINN = new System.Windows.Forms.TextBox();
            this.textBoxAddProvName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.Location = new System.Drawing.Point(166, 128);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(98, 42);
            this.buttonAddCancel.TabIndex = 16;
            this.buttonAddCancel.Text = "Отмена";
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdd
            // 
            this.buttonAddAdd.Location = new System.Drawing.Point(60, 128);
            this.buttonAddAdd.Name = "buttonAddAdd";
            this.buttonAddAdd.Size = new System.Drawing.Size(87, 42);
            this.buttonAddAdd.TabIndex = 15;
            this.buttonAddAdd.Text = "Добавить";
            this.buttonAddAdd.UseVisualStyleBackColor = true;
            this.buttonAddAdd.Click += new System.EventHandler(this.buttonAddAdd_Click);
            // 
            // textBoxAddProvLis
            // 
            this.textBoxAddProvLis.Location = new System.Drawing.Point(166, 74);
            this.textBoxAddProvLis.Name = "textBoxAddProvLis";
            this.textBoxAddProvLis.Size = new System.Drawing.Size(144, 20);
            this.textBoxAddProvLis.TabIndex = 14;
            // 
            // textBoxAddProvINN
            // 
            this.textBoxAddProvINN.Location = new System.Drawing.Point(166, 47);
            this.textBoxAddProvINN.Name = "textBoxAddProvINN";
            this.textBoxAddProvINN.Size = new System.Drawing.Size(144, 20);
            this.textBoxAddProvINN.TabIndex = 13;
            // 
            // textBoxAddProvName
            // 
            this.textBoxAddProvName.Location = new System.Drawing.Point(166, 21);
            this.textBoxAddProvName.Name = "textBoxAddProvName";
            this.textBoxAddProvName.Size = new System.Drawing.Size(144, 20);
            this.textBoxAddProvName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Лицензия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название поставщика";
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(this.buttonAddCancel);
            this.Controls.Add(this.buttonAddAdd);
            this.Controls.Add(this.textBoxAddProvLis);
            this.Controls.Add(this.textBoxAddProvINN);
            this.Controls.Add(this.textBoxAddProvName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddProviderForm";
            this.Text = "AddProviderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.Button buttonAddAdd;
        private System.Windows.Forms.TextBox textBoxAddProvLis;
        private System.Windows.Forms.TextBox textBoxAddProvINN;
        private System.Windows.Forms.TextBox textBoxAddProvName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}