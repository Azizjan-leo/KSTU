using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class CaesarKeyForm
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
            this.label17 = new System.Windows.Forms.Label();
            this.txbxStepCaesarKey = new System.Windows.Forms.TextBox();
            this.rdbtnDecryptCaesarKey = new System.Windows.Forms.RadioButton();
            this.rdbtnEncryptCaesarKey = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txbxKeywordCaesarKey = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbxOutputCaesarKey = new System.Windows.Forms.TextBox();
            this.txbxInputCaesarKey = new System.Windows.Forms.TextBox();
            this.btnEnterCaesarKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Смещение";
            // 
            // txbxStepCaesarKey
            // 
            this.txbxStepCaesarKey.Location = new System.Drawing.Point(104, 158);
            this.txbxStepCaesarKey.Name = "txbxStepCaesarKey";
            this.txbxStepCaesarKey.Size = new System.Drawing.Size(100, 20);
            this.txbxStepCaesarKey.TabIndex = 38;
            // 
            // rdbtnDecryptCaesarKey
            // 
            this.rdbtnDecryptCaesarKey.AutoSize = true;
            this.rdbtnDecryptCaesarKey.Location = new System.Drawing.Point(237, 181);
            this.rdbtnDecryptCaesarKey.Name = "rdbtnDecryptCaesarKey";
            this.rdbtnDecryptCaesarKey.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecryptCaesarKey.TabIndex = 37;
            this.rdbtnDecryptCaesarKey.Text = "Разшифровка";
            this.rdbtnDecryptCaesarKey.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptCaesarKey
            // 
            this.rdbtnEncryptCaesarKey.AutoSize = true;
            this.rdbtnEncryptCaesarKey.Checked = true;
            this.rdbtnEncryptCaesarKey.Location = new System.Drawing.Point(237, 158);
            this.rdbtnEncryptCaesarKey.Name = "rdbtnEncryptCaesarKey";
            this.rdbtnEncryptCaesarKey.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncryptCaesarKey.TabIndex = 36;
            this.rdbtnEncryptCaesarKey.TabStop = true;
            this.rdbtnEncryptCaesarKey.Text = "Зашифровка";
            this.rdbtnEncryptCaesarKey.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ключевое слово";
            // 
            // txbxKeywordCaesarKey
            // 
            this.txbxKeywordCaesarKey.Location = new System.Drawing.Point(104, 132);
            this.txbxKeywordCaesarKey.Name = "txbxKeywordCaesarKey";
            this.txbxKeywordCaesarKey.Size = new System.Drawing.Size(380, 20);
            this.txbxKeywordCaesarKey.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Конечный текст";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Исходный текст";
            // 
            // txbxOutputCaesarKey
            // 
            this.txbxOutputCaesarKey.Location = new System.Drawing.Point(103, 204);
            this.txbxOutputCaesarKey.Multiline = true;
            this.txbxOutputCaesarKey.Name = "txbxOutputCaesarKey";
            this.txbxOutputCaesarKey.Size = new System.Drawing.Size(380, 110);
            this.txbxOutputCaesarKey.TabIndex = 31;
            // 
            // txbxInputCaesarKey
            // 
            this.txbxInputCaesarKey.Location = new System.Drawing.Point(104, 31);
            this.txbxInputCaesarKey.Multiline = true;
            this.txbxInputCaesarKey.Name = "txbxInputCaesarKey";
            this.txbxInputCaesarKey.Size = new System.Drawing.Size(380, 95);
            this.txbxInputCaesarKey.TabIndex = 30;
            // 
            // btnEnterCaesarKey
            // 
            this.btnEnterCaesarKey.Location = new System.Drawing.Point(369, 158);
            this.btnEnterCaesarKey.Name = "btnEnterCaesarKey";
            this.btnEnterCaesarKey.Size = new System.Drawing.Size(115, 36);
            this.btnEnterCaesarKey.TabIndex = 29;
            this.btnEnterCaesarKey.Text = "Выполнить";
            this.btnEnterCaesarKey.UseVisualStyleBackColor = true;
            this.btnEnterCaesarKey.Click += new System.EventHandler(this.btnEnterCaesarKey_Click);
            // 
            // CaesarKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 344);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txbxStepCaesarKey);
            this.Controls.Add(this.rdbtnDecryptCaesarKey);
            this.Controls.Add(this.rdbtnEncryptCaesarKey);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbxKeywordCaesarKey);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbxOutputCaesarKey);
            this.Controls.Add(this.txbxInputCaesarKey);
            this.Controls.Add(this.btnEnterCaesarKey);
            this.Name = "CaesarKeyForm";
            this.Text = "CaesarKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label17;
        private TextBox txbxStepCaesarKey;
        private RadioButton rdbtnDecryptCaesarKey;
        private RadioButton rdbtnEncryptCaesarKey;
        private Label label12;
        private TextBox txbxKeywordCaesarKey;
        private Label label15;
        private Label label16;
        private TextBox txbxOutputCaesarKey;
        private TextBox txbxInputCaesarKey;
        private Button btnEnterCaesarKey;
    }
}