using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class CaesarForm
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
            this.rdbtnDecryptCaesar = new System.Windows.Forms.RadioButton();
            this.rdbtnEncryptCaesar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txbxStepCaesar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxOutputCaesar = new System.Windows.Forms.TextBox();
            this.txbxInputCaesar = new System.Windows.Forms.TextBox();
            this.btnEnterCaesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnDecryptCaesar
            // 
            this.rdbtnDecryptCaesar.AutoSize = true;
            this.rdbtnDecryptCaesar.Location = new System.Drawing.Point(271, 149);
            this.rdbtnDecryptCaesar.Name = "rdbtnDecryptCaesar";
            this.rdbtnDecryptCaesar.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecryptCaesar.TabIndex = 26;
            this.rdbtnDecryptCaesar.Text = "Разшифровка";
            this.rdbtnDecryptCaesar.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptCaesar
            // 
            this.rdbtnEncryptCaesar.AutoSize = true;
            this.rdbtnEncryptCaesar.Checked = true;
            this.rdbtnEncryptCaesar.Location = new System.Drawing.Point(271, 131);
            this.rdbtnEncryptCaesar.Name = "rdbtnEncryptCaesar";
            this.rdbtnEncryptCaesar.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncryptCaesar.TabIndex = 25;
            this.rdbtnEncryptCaesar.TabStop = true;
            this.rdbtnEncryptCaesar.Text = "Зашифровка";
            this.rdbtnEncryptCaesar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Смещение";
            // 
            // txbxStepCaesar
            // 
            this.txbxStepCaesar.Location = new System.Drawing.Point(138, 131);
            this.txbxStepCaesar.Name = "txbxStepCaesar";
            this.txbxStepCaesar.Size = new System.Drawing.Size(100, 20);
            this.txbxStepCaesar.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Конечный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Исходный текст";
            // 
            // txbxOutputCaesar
            // 
            this.txbxOutputCaesar.Location = new System.Drawing.Point(138, 173);
            this.txbxOutputCaesar.Multiline = true;
            this.txbxOutputCaesar.Name = "txbxOutputCaesar";
            this.txbxOutputCaesar.Size = new System.Drawing.Size(380, 116);
            this.txbxOutputCaesar.TabIndex = 20;
            // 
            // txbxInputCaesar
            // 
            this.txbxInputCaesar.Location = new System.Drawing.Point(138, 30);
            this.txbxInputCaesar.Multiline = true;
            this.txbxInputCaesar.Name = "txbxInputCaesar";
            this.txbxInputCaesar.Size = new System.Drawing.Size(380, 95);
            this.txbxInputCaesar.TabIndex = 19;
            // 
            // btnEnterCaesar
            // 
            this.btnEnterCaesar.Location = new System.Drawing.Point(403, 131);
            this.btnEnterCaesar.Name = "btnEnterCaesar";
            this.btnEnterCaesar.Size = new System.Drawing.Size(115, 36);
            this.btnEnterCaesar.TabIndex = 18;
            this.btnEnterCaesar.Text = "Выполнить";
            this.btnEnterCaesar.UseVisualStyleBackColor = true;
            this.btnEnterCaesar.Click += new System.EventHandler(this.btnEnterCaesar_Click);
            // 
            // CaesarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 320);
            this.Controls.Add(this.rdbtnDecryptCaesar);
            this.Controls.Add(this.rdbtnEncryptCaesar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbxStepCaesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbxOutputCaesar);
            this.Controls.Add(this.txbxInputCaesar);
            this.Controls.Add(this.btnEnterCaesar);
            this.Name = "CaesarForm";
            this.Text = "CaesarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbtnDecryptCaesar;
        private RadioButton rdbtnEncryptCaesar;
        private Label label5;
        private TextBox txbxStepCaesar;
        private Label label3;
        private Label label4;
        private TextBox txbxOutputCaesar;
        private TextBox txbxInputCaesar;
        private Button btnEnterCaesar;
    }
}