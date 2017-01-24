using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class FrequencyForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.txbxInputFrequency = new System.Windows.Forms.TextBox();
            this.btnEnterFrequency = new System.Windows.Forms.Button();
            this.txbxOutputFrequency = new System.Windows.Forms.TextBox();
            this.gpbxInput = new System.Windows.Forms.GroupBox();
            this.gpbxResult = new System.Windows.Forms.GroupBox();
            this.gpbxInput.SuspendLayout();
            this.gpbxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-38, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Анализ";
            // 
            // txbxInputFrequency
            // 
            this.txbxInputFrequency.Location = new System.Drawing.Point(21, 29);
            this.txbxInputFrequency.Multiline = true;
            this.txbxInputFrequency.Name = "txbxInputFrequency";
            this.txbxInputFrequency.Size = new System.Drawing.Size(400, 95);
            this.txbxInputFrequency.TabIndex = 24;
            // 
            // btnEnterFrequency
            // 
            this.btnEnterFrequency.Location = new System.Drawing.Point(288, 130);
            this.btnEnterFrequency.Name = "btnEnterFrequency";
            this.btnEnterFrequency.Size = new System.Drawing.Size(133, 36);
            this.btnEnterFrequency.TabIndex = 23;
            this.btnEnterFrequency.Text = "Анализ";
            this.btnEnterFrequency.UseVisualStyleBackColor = true;
            this.btnEnterFrequency.Click += new System.EventHandler(this.btnEnterFrequency_Click);
            // 
            // txbxOutputFrequency
            // 
            this.txbxOutputFrequency.Location = new System.Drawing.Point(21, 33);
            this.txbxOutputFrequency.Multiline = true;
            this.txbxOutputFrequency.Name = "txbxOutputFrequency";
            this.txbxOutputFrequency.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbxOutputFrequency.Size = new System.Drawing.Size(398, 116);
            this.txbxOutputFrequency.TabIndex = 25;
            // 
            // gpbxInput
            // 
            this.gpbxInput.Controls.Add(this.btnEnterFrequency);
            this.gpbxInput.Controls.Add(this.txbxInputFrequency);
            this.gpbxInput.Location = new System.Drawing.Point(37, 12);
            this.gpbxInput.Name = "gpbxInput";
            this.gpbxInput.Size = new System.Drawing.Size(443, 172);
            this.gpbxInput.TabIndex = 28;
            this.gpbxInput.TabStop = false;
            this.gpbxInput.Text = "Исходный текст";
            // 
            // gpbxResult
            // 
            this.gpbxResult.Controls.Add(this.txbxOutputFrequency);
            this.gpbxResult.Location = new System.Drawing.Point(37, 190);
            this.gpbxResult.Name = "gpbxResult";
            this.gpbxResult.Size = new System.Drawing.Size(443, 169);
            this.gpbxResult.TabIndex = 29;
            this.gpbxResult.TabStop = false;
            this.gpbxResult.Text = "Результат";
            // 
            // FrequencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.gpbxResult);
            this.Controls.Add(this.gpbxInput);
            this.Controls.Add(this.label7);
            this.Name = "FrequencyForm";
            this.Text = "FrequencyForm";
            this.gpbxInput.ResumeLayout(false);
            this.gpbxInput.PerformLayout();
            this.gpbxResult.ResumeLayout(false);
            this.gpbxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private TextBox txbxInputFrequency;
        private Button btnEnterFrequency;
        private TextBox txbxOutputFrequency;
        private GroupBox gpbxInput;
        private GroupBox gpbxResult;
    }
}