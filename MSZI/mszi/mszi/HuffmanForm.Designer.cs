using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class HuffmanForm
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
            this.btnHuffmanEnter = new System.Windows.Forms.Button();
            this.txbxHuffmanInput = new System.Windows.Forms.TextBox();
            this.txbxHuffmanOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnHuffmanEnter
            // 
            this.btnHuffmanEnter.Location = new System.Drawing.Point(370, 168);
            this.btnHuffmanEnter.Name = "btnHuffmanEnter";
            this.btnHuffmanEnter.Size = new System.Drawing.Size(167, 35);
            this.btnHuffmanEnter.TabIndex = 0;
            this.btnHuffmanEnter.Text = "Выполнить";
            this.btnHuffmanEnter.UseVisualStyleBackColor = true;
            this.btnHuffmanEnter.Click += new System.EventHandler(this.btnHuffmanEnter_Click);
            // 
            // txbxHuffmanInput
            // 
            this.txbxHuffmanInput.Location = new System.Drawing.Point(113, 13);
            this.txbxHuffmanInput.Multiline = true;
            this.txbxHuffmanInput.Name = "txbxHuffmanInput";
            this.txbxHuffmanInput.Size = new System.Drawing.Size(424, 149);
            this.txbxHuffmanInput.TabIndex = 1;
            this.txbxHuffmanInput.Text = "замена";
            // 
            // txbxHuffmanOutput
            // 
            this.txbxHuffmanOutput.Location = new System.Drawing.Point(113, 211);
            this.txbxHuffmanOutput.Multiline = true;
            this.txbxHuffmanOutput.Name = "txbxHuffmanOutput";
            this.txbxHuffmanOutput.Size = new System.Drawing.Size(424, 153);
            this.txbxHuffmanOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начальный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходный текст";
            // 
            // rdbtnEncrypt
            // 
            this.rdbtnEncrypt.AutoSize = true;
            this.rdbtnEncrypt.Checked = true;
            this.rdbtnEncrypt.Location = new System.Drawing.Point(113, 177);
            this.rdbtnEncrypt.Name = "rdbtnEncrypt";
            this.rdbtnEncrypt.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncrypt.TabIndex = 5;
            this.rdbtnEncrypt.TabStop = true;
            this.rdbtnEncrypt.Text = "Зашифровка";
            this.rdbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecrypt
            // 
            this.rdbtnDecrypt.AutoSize = true;
            this.rdbtnDecrypt.Location = new System.Drawing.Point(209, 177);
            this.rdbtnDecrypt.Name = "rdbtnDecrypt";
            this.rdbtnDecrypt.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecrypt.TabIndex = 6;
            this.rdbtnDecrypt.Text = "Расшифровка";
            this.rdbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // HuffmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 405);
            this.Controls.Add(this.rdbtnDecrypt);
            this.Controls.Add(this.rdbtnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxHuffmanOutput);
            this.Controls.Add(this.txbxHuffmanInput);
            this.Controls.Add(this.btnHuffmanEnter);
            this.Name = "HuffmanForm";
            this.Text = "HuffmanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHuffmanEnter;
        private TextBox txbxHuffmanInput;
        private TextBox txbxHuffmanOutput;
        private Label label1;
        private Label label2;
        private RadioButton rdbtnEncrypt;
        private RadioButton rdbtnDecrypt;
    }
}