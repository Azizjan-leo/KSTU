using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class ReverseForm
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
            this.rdbtnDecryptReverse = new System.Windows.Forms.RadioButton();
            this.rdbtnEncryptReverse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxOutputReverse = new System.Windows.Forms.TextBox();
            this.txbxInputReverse = new System.Windows.Forms.TextBox();
            this.btnEnterReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnDecryptReverse
            // 
            this.rdbtnDecryptReverse.AutoSize = true;
            this.rdbtnDecryptReverse.Location = new System.Drawing.Point(102, 141);
            this.rdbtnDecryptReverse.Name = "rdbtnDecryptReverse";
            this.rdbtnDecryptReverse.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecryptReverse.TabIndex = 15;
            this.rdbtnDecryptReverse.Text = "Расшифровка";
            this.rdbtnDecryptReverse.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptReverse
            // 
            this.rdbtnEncryptReverse.AutoSize = true;
            this.rdbtnEncryptReverse.Checked = true;
            this.rdbtnEncryptReverse.Location = new System.Drawing.Point(102, 122);
            this.rdbtnEncryptReverse.Name = "rdbtnEncryptReverse";
            this.rdbtnEncryptReverse.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncryptReverse.TabIndex = 14;
            this.rdbtnEncryptReverse.TabStop = true;
            this.rdbtnEncryptReverse.Text = "Зашифровка";
            this.rdbtnEncryptReverse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Конечный текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Исходный текст";
            // 
            // txbxOutputReverse
            // 
            this.txbxOutputReverse.Location = new System.Drawing.Point(102, 164);
            this.txbxOutputReverse.Multiline = true;
            this.txbxOutputReverse.Name = "txbxOutputReverse";
            this.txbxOutputReverse.Size = new System.Drawing.Size(380, 116);
            this.txbxOutputReverse.TabIndex = 11;
            // 
            // txbxInputReverse
            // 
            this.txbxInputReverse.Location = new System.Drawing.Point(102, 21);
            this.txbxInputReverse.Multiline = true;
            this.txbxInputReverse.Name = "txbxInputReverse";
            this.txbxInputReverse.Size = new System.Drawing.Size(380, 95);
            this.txbxInputReverse.TabIndex = 10;
            // 
            // btnEnterReverse
            // 
            this.btnEnterReverse.Location = new System.Drawing.Point(361, 122);
            this.btnEnterReverse.Name = "btnEnterReverse";
            this.btnEnterReverse.Size = new System.Drawing.Size(121, 36);
            this.btnEnterReverse.TabIndex = 9;
            this.btnEnterReverse.Text = "Выполнить";
            this.btnEnterReverse.UseVisualStyleBackColor = true;
            this.btnEnterReverse.Click += new System.EventHandler(this.btnEnterReverse_Click);
            // 
            // ReverseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 318);
            this.Controls.Add(this.rdbtnDecryptReverse);
            this.Controls.Add(this.rdbtnEncryptReverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxOutputReverse);
            this.Controls.Add(this.txbxInputReverse);
            this.Controls.Add(this.btnEnterReverse);
            this.Name = "ReverseForm";
            this.Text = "ReverseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbtnDecryptReverse;
        private RadioButton rdbtnEncryptReverse;
        private Label label2;
        private Label label1;
        private TextBox txbxOutputReverse;
        private TextBox txbxInputReverse;
        private Button btnEnterReverse;
    }
}