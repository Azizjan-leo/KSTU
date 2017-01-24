using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class TrisemusForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.txbxKeywordTrisemus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEnterTrisemus = new System.Windows.Forms.Button();
            this.rdbtnDecryptTrisemus = new System.Windows.Forms.RadioButton();
            this.rdbtnEncryptTrisemus = new System.Windows.Forms.RadioButton();
            this.txbxOutputTrisemus = new System.Windows.Forms.TextBox();
            this.txbxInputTrisemus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Ключевое слово";
            // 
            // txbxKeywordTrisemus
            // 
            this.txbxKeywordTrisemus.Location = new System.Drawing.Point(128, 134);
            this.txbxKeywordTrisemus.Multiline = true;
            this.txbxKeywordTrisemus.Name = "txbxKeywordTrisemus";
            this.txbxKeywordTrisemus.Size = new System.Drawing.Size(354, 24);
            this.txbxKeywordTrisemus.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Исходный текст";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Конечный текст";
            // 
            // btnEnterTrisemus
            // 
            this.btnEnterTrisemus.Location = new System.Drawing.Point(389, 164);
            this.btnEnterTrisemus.Name = "btnEnterTrisemus";
            this.btnEnterTrisemus.Size = new System.Drawing.Size(93, 43);
            this.btnEnterTrisemus.TabIndex = 35;
            this.btnEnterTrisemus.Text = "Выполнить";
            this.btnEnterTrisemus.UseVisualStyleBackColor = true;
            this.btnEnterTrisemus.Click += new System.EventHandler(this.btnEnterTrisemus_Click);
            // 
            // rdbtnDecryptTrisemus
            // 
            this.rdbtnDecryptTrisemus.AutoSize = true;
            this.rdbtnDecryptTrisemus.Location = new System.Drawing.Point(281, 187);
            this.rdbtnDecryptTrisemus.Name = "rdbtnDecryptTrisemus";
            this.rdbtnDecryptTrisemus.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecryptTrisemus.TabIndex = 34;
            this.rdbtnDecryptTrisemus.Text = "Разшифровка";
            this.rdbtnDecryptTrisemus.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptTrisemus
            // 
            this.rdbtnEncryptTrisemus.AutoSize = true;
            this.rdbtnEncryptTrisemus.Checked = true;
            this.rdbtnEncryptTrisemus.Location = new System.Drawing.Point(281, 164);
            this.rdbtnEncryptTrisemus.Name = "rdbtnEncryptTrisemus";
            this.rdbtnEncryptTrisemus.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncryptTrisemus.TabIndex = 33;
            this.rdbtnEncryptTrisemus.TabStop = true;
            this.rdbtnEncryptTrisemus.Text = "Зашифровка";
            this.rdbtnEncryptTrisemus.UseVisualStyleBackColor = true;
            // 
            // txbxOutputTrisemus
            // 
            this.txbxOutputTrisemus.Location = new System.Drawing.Point(128, 213);
            this.txbxOutputTrisemus.Multiline = true;
            this.txbxOutputTrisemus.Name = "txbxOutputTrisemus";
            this.txbxOutputTrisemus.Size = new System.Drawing.Size(354, 97);
            this.txbxOutputTrisemus.TabIndex = 32;
            // 
            // txbxInputTrisemus
            // 
            this.txbxInputTrisemus.Location = new System.Drawing.Point(128, 53);
            this.txbxInputTrisemus.Multiline = true;
            this.txbxInputTrisemus.Name = "txbxInputTrisemus";
            this.txbxInputTrisemus.Size = new System.Drawing.Size(354, 75);
            this.txbxInputTrisemus.TabIndex = 31;
            // 
            // TrisemusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 363);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbxKeywordTrisemus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEnterTrisemus);
            this.Controls.Add(this.rdbtnDecryptTrisemus);
            this.Controls.Add(this.rdbtnEncryptTrisemus);
            this.Controls.Add(this.txbxOutputTrisemus);
            this.Controls.Add(this.txbxInputTrisemus);
            this.Name = "TrisemusForm";
            this.Text = "TrisemusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label14;
        private TextBox txbxKeywordTrisemus;
        private Label label10;
        private Label label13;
        private Button btnEnterTrisemus;
        private RadioButton rdbtnDecryptTrisemus;
        private RadioButton rdbtnEncryptTrisemus;
        private TextBox txbxOutputTrisemus;
        private TextBox txbxInputTrisemus;
    }
}