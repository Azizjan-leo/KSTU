using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class AnalyticTransformationForm
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
            this.txbxInputText = new System.Windows.Forms.TextBox();
            this.txbxOutputText = new System.Windows.Forms.TextBox();
            this.rdbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.gpbxInput = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnalyticTransformationEnter = new System.Windows.Forms.Button();
            this.txbxKeyMatrix = new System.Windows.Forms.TextBox();
            this.gpbxKeyMatrix = new System.Windows.Forms.GroupBox();
            this.gpbxInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbxKeyMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbxInputText
            // 
            this.txbxInputText.Location = new System.Drawing.Point(6, 19);
            this.txbxInputText.Multiline = true;
            this.txbxInputText.Name = "txbxInputText";
            this.txbxInputText.Size = new System.Drawing.Size(337, 173);
            this.txbxInputText.TabIndex = 1;
            this.txbxInputText.Text = "гатала";
            // 
            // txbxOutputText
            // 
            this.txbxOutputText.Location = new System.Drawing.Point(6, 19);
            this.txbxOutputText.Multiline = true;
            this.txbxOutputText.Name = "txbxOutputText";
            this.txbxOutputText.Size = new System.Drawing.Size(337, 165);
            this.txbxOutputText.TabIndex = 3;
            // 
            // rdbtnEncrypt
            // 
            this.rdbtnEncrypt.AutoSize = true;
            this.rdbtnEncrypt.Checked = true;
            this.rdbtnEncrypt.Location = new System.Drawing.Point(424, 232);
            this.rdbtnEncrypt.Name = "rdbtnEncrypt";
            this.rdbtnEncrypt.Size = new System.Drawing.Size(90, 17);
            this.rdbtnEncrypt.TabIndex = 4;
            this.rdbtnEncrypt.TabStop = true;
            this.rdbtnEncrypt.Text = "Зашифровка";
            this.rdbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecrypt
            // 
            this.rdbtnDecrypt.AutoSize = true;
            this.rdbtnDecrypt.Location = new System.Drawing.Point(520, 232);
            this.rdbtnDecrypt.Name = "rdbtnDecrypt";
            this.rdbtnDecrypt.Size = new System.Drawing.Size(96, 17);
            this.rdbtnDecrypt.TabIndex = 5;
            this.rdbtnDecrypt.Text = "Расшифровка";
            this.rdbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // gpbxInput
            // 
            this.gpbxInput.Controls.Add(this.txbxInputText);
            this.gpbxInput.Location = new System.Drawing.Point(34, 12);
            this.gpbxInput.Name = "gpbxInput";
            this.gpbxInput.Size = new System.Drawing.Size(349, 198);
            this.gpbxInput.TabIndex = 6;
            this.gpbxInput.TabStop = false;
            this.gpbxInput.Text = "Исходный текст";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbxOutputText);
            this.groupBox2.Location = new System.Drawing.Point(34, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 201);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Конечный текст";
            // 
            // btnAnalyticTransformationEnter
            // 
            this.btnAnalyticTransformationEnter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalyticTransformationEnter.Location = new System.Drawing.Point(424, 266);
            this.btnAnalyticTransformationEnter.Name = "btnAnalyticTransformationEnter";
            this.btnAnalyticTransformationEnter.Size = new System.Drawing.Size(192, 52);
            this.btnAnalyticTransformationEnter.TabIndex = 0;
            this.btnAnalyticTransformationEnter.Text = "Выполнить";
            this.btnAnalyticTransformationEnter.UseVisualStyleBackColor = true;
            this.btnAnalyticTransformationEnter.Click += new System.EventHandler(this.btnAnalyticTransformationEnter_Click);
            // 
            // txbxKeyMatrix
            // 
            this.txbxKeyMatrix.Location = new System.Drawing.Point(15, 18);
            this.txbxKeyMatrix.Multiline = true;
            this.txbxKeyMatrix.Name = "txbxKeyMatrix";
            this.txbxKeyMatrix.Size = new System.Drawing.Size(229, 174);
            this.txbxKeyMatrix.TabIndex = 8;
            this.txbxKeyMatrix.Text = "14 8 3\r\n8 5 2\r\n3 2 1\r\n";
            // 
            // gpbxKeyMatrix
            // 
            this.gpbxKeyMatrix.Controls.Add(this.txbxKeyMatrix);
            this.gpbxKeyMatrix.Location = new System.Drawing.Point(424, 12);
            this.gpbxKeyMatrix.Name = "gpbxKeyMatrix";
            this.gpbxKeyMatrix.Size = new System.Drawing.Size(251, 198);
            this.gpbxKeyMatrix.TabIndex = 9;
            this.gpbxKeyMatrix.TabStop = false;
            this.gpbxKeyMatrix.Text = "Ключ матрица";
            // 
            // AnalyticTransformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 464);
            this.Controls.Add(this.gpbxKeyMatrix);
            this.Controls.Add(this.btnAnalyticTransformationEnter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbxInput);
            this.Controls.Add(this.rdbtnDecrypt);
            this.Controls.Add(this.rdbtnEncrypt);
            this.Name = "AnalyticTransformationForm";
            this.Text = "Метод аналитических преобразований";
            this.gpbxInput.ResumeLayout(false);
            this.gpbxInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbxKeyMatrix.ResumeLayout(false);
            this.gpbxKeyMatrix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbxInputText;
        private TextBox txbxOutputText;
        private RadioButton rdbtnEncrypt;
        private RadioButton rdbtnDecrypt;
        private GroupBox gpbxInput;
        private GroupBox groupBox2;
        private Button btnAnalyticTransformationEnter;
        private TextBox txbxKeyMatrix;
        private GroupBox gpbxKeyMatrix;
    }
}