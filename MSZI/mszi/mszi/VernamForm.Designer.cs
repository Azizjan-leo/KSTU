namespace mszi
{
    partial class VernamForm
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txbxInputText = new System.Windows.Forms.TextBox();
            this.txbxOutputText = new System.Windows.Forms.TextBox();
            this.txbxKeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(389, 205);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(106, 36);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Выполнить";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txbxInputText
            // 
            this.txbxInputText.Location = new System.Drawing.Point(137, 12);
            this.txbxInputText.Multiline = true;
            this.txbxInputText.Name = "txbxInputText";
            this.txbxInputText.Size = new System.Drawing.Size(373, 97);
            this.txbxInputText.TabIndex = 2;
            // 
            // txbxOutputText
            // 
            this.txbxOutputText.Location = new System.Drawing.Point(137, 269);
            this.txbxOutputText.Multiline = true;
            this.txbxOutputText.Name = "txbxOutputText";
            this.txbxOutputText.Size = new System.Drawing.Size(373, 76);
            this.txbxOutputText.TabIndex = 3;
            // 
            // txbxKeyText
            // 
            this.txbxKeyText.Location = new System.Drawing.Point(137, 124);
            this.txbxKeyText.Multiline = true;
            this.txbxKeyText.Name = "txbxKeyText";
            this.txbxKeyText.Size = new System.Drawing.Size(373, 70);
            this.txbxKeyText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Открытый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Закрытый текст";
            // 
            // rdbtnEncrypt
            // 
            this.rdbtnEncrypt.AutoSize = true;
            this.rdbtnEncrypt.Checked = true;
            this.rdbtnEncrypt.Location = new System.Drawing.Point(160, 215);
            this.rdbtnEncrypt.Name = "rdbtnEncrypt";
            this.rdbtnEncrypt.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncrypt.TabIndex = 8;
            this.rdbtnEncrypt.TabStop = true;
            this.rdbtnEncrypt.Text = "Зашифровка";
            this.rdbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecrypt
            // 
            this.rdbtnDecrypt.AutoSize = true;
            this.rdbtnDecrypt.Location = new System.Drawing.Point(251, 215);
            this.rdbtnDecrypt.Name = "rdbtnDecrypt";
            this.rdbtnDecrypt.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecrypt.TabIndex = 9;
            this.rdbtnDecrypt.TabStop = true;
            this.rdbtnDecrypt.Text = "Расшифровка";
            this.rdbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // VernamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 387);
            this.Controls.Add(this.rdbtnDecrypt);
            this.Controls.Add(this.rdbtnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxKeyText);
            this.Controls.Add(this.txbxOutputText);
            this.Controls.Add(this.txbxInputText);
            this.Controls.Add(this.btnEnter);
            this.Name = "VernamForm";
            this.Text = "Метод Вернама";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txbxInputText;
        private System.Windows.Forms.TextBox txbxOutputText;
        private System.Windows.Forms.TextBox txbxKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtnEncrypt;
        private System.Windows.Forms.RadioButton rdbtnDecrypt;
    }
}