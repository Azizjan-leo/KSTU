using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class VigenereForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.rdbtnDecryptVigenere = new System.Windows.Forms.RadioButton();
            this.rdbtnEncryptVigenere = new System.Windows.Forms.RadioButton();
            this.btnEnterVigenere = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxOutputVigenere = new System.Windows.Forms.TextBox();
            this.txbxKeywordVigenere = new System.Windows.Forms.TextBox();
            this.txbxInputVigenere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbtnDecryptVigenere
            // 
            this.rdbtnDecryptVigenere.AutoSize = true;
            this.rdbtnDecryptVigenere.Location = new System.Drawing.Point(112, 160);
            this.rdbtnDecryptVigenere.Name = "rdbtnDecryptVigenere";
            this.rdbtnDecryptVigenere.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecryptVigenere.TabIndex = 37;
            this.rdbtnDecryptVigenere.Text = "Разшифровка";
            this.rdbtnDecryptVigenere.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptVigenere
            // 
            this.rdbtnEncryptVigenere.AutoSize = true;
            this.rdbtnEncryptVigenere.Checked = true;
            this.rdbtnEncryptVigenere.Location = new System.Drawing.Point(112, 136);
            this.rdbtnEncryptVigenere.Name = "rdbtnEncryptVigenere";
            this.rdbtnEncryptVigenere.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncryptVigenere.TabIndex = 36;
            this.rdbtnEncryptVigenere.TabStop = true;
            this.rdbtnEncryptVigenere.Text = "Зашифровка";
            this.rdbtnEncryptVigenere.UseVisualStyleBackColor = true;
            // 
            // btnEnterVigenere
            // 
            this.btnEnterVigenere.Location = new System.Drawing.Point(314, 136);
            this.btnEnterVigenere.Name = "btnEnterVigenere";
            this.btnEnterVigenere.Size = new System.Drawing.Size(108, 35);
            this.btnEnterVigenere.TabIndex = 35;
            this.btnEnterVigenere.Text = "Выполнить";
            this.btnEnterVigenere.UseVisualStyleBackColor = true;
            this.btnEnterVigenere.Click += new System.EventHandler(this.btnEnterVigenere_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Исходный текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ключ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Конечный текст";
            // 
            // txbxOutputVigenere
            // 
            this.txbxOutputVigenere.Location = new System.Drawing.Point(112, 183);
            this.txbxOutputVigenere.Multiline = true;
            this.txbxOutputVigenere.Name = "txbxOutputVigenere";
            this.txbxOutputVigenere.Size = new System.Drawing.Size(310, 85);
            this.txbxOutputVigenere.TabIndex = 31;
            // 
            // txbxKeywordVigenere
            // 
            this.txbxKeywordVigenere.Location = new System.Drawing.Point(112, 110);
            this.txbxKeywordVigenere.Name = "txbxKeywordVigenere";
            this.txbxKeywordVigenere.Size = new System.Drawing.Size(310, 20);
            this.txbxKeywordVigenere.TabIndex = 30;
            this.txbxKeywordVigenere.Text = "ключ";
            // 
            // txbxInputVigenere
            // 
            this.txbxInputVigenere.Location = new System.Drawing.Point(112, 12);
            this.txbxInputVigenere.Multiline = true;
            this.txbxInputVigenere.Name = "txbxInputVigenere";
            this.txbxInputVigenere.Size = new System.Drawing.Size(310, 80);
            this.txbxInputVigenere.TabIndex = 29;
            this.txbxInputVigenere.Text = "замена";
            // 
            // VigenereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.rdbtnDecryptVigenere);
            this.Controls.Add(this.rdbtnEncryptVigenere);
            this.Controls.Add(this.btnEnterVigenere);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbxOutputVigenere);
            this.Controls.Add(this.txbxKeywordVigenere);
            this.Controls.Add(this.txbxInputVigenere);
            this.Name = "VigenereForm";
            this.Text = "Метод Вижинера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbtnDecryptVigenere;
        private RadioButton rdbtnEncryptVigenere;
        private Button btnEnterVigenere;
        private Label label11;
        private Label label6;
        private Label label9;
        private TextBox txbxOutputVigenere;
        private TextBox txbxKeywordVigenere;
        private TextBox txbxInputVigenere;
    }
}