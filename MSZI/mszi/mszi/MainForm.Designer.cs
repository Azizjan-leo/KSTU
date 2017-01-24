using System.ComponentModel;
using System.Windows.Forms;

namespace mszi
{
    partial class MainForm
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
            this.btnOpenTrisemusForm = new System.Windows.Forms.Button();
            this.btnOpenCaesarForm = new System.Windows.Forms.Button();
            this.btnOpenCaesarKey = new System.Windows.Forms.Button();
            this.btnOpenVigenereForm = new System.Windows.Forms.Button();
            this.btnOpenReverseForm = new System.Windows.Forms.Button();
            this.btnOpenFrequenceForm = new System.Windows.Forms.Button();
            this.btnOpenHuffmanForm = new System.Windows.Forms.Button();
            this.btnOpenAnalyticTransformationForm = new System.Windows.Forms.Button();
            this.btnOpenVernamForm = new System.Windows.Forms.Button();
            this.btnOpenPlayfairForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenTrisemusForm
            // 
            this.btnOpenTrisemusForm.Location = new System.Drawing.Point(81, 12);
            this.btnOpenTrisemusForm.Name = "btnOpenTrisemusForm";
            this.btnOpenTrisemusForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenTrisemusForm.TabIndex = 0;
            this.btnOpenTrisemusForm.Text = "Метод Трисемуса";
            this.btnOpenTrisemusForm.UseVisualStyleBackColor = true;
            this.btnOpenTrisemusForm.Click += new System.EventHandler(this.btnOpenTrisemusForm_Click);
            // 
            // btnOpenCaesarForm
            // 
            this.btnOpenCaesarForm.Location = new System.Drawing.Point(81, 58);
            this.btnOpenCaesarForm.Name = "btnOpenCaesarForm";
            this.btnOpenCaesarForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenCaesarForm.TabIndex = 1;
            this.btnOpenCaesarForm.Text = "Метод Цезаря";
            this.btnOpenCaesarForm.UseVisualStyleBackColor = true;
            this.btnOpenCaesarForm.Click += new System.EventHandler(this.btnOpenCaesarForm_Click);
            // 
            // btnOpenCaesarKey
            // 
            this.btnOpenCaesarKey.Location = new System.Drawing.Point(81, 104);
            this.btnOpenCaesarKey.Name = "btnOpenCaesarKey";
            this.btnOpenCaesarKey.Size = new System.Drawing.Size(140, 40);
            this.btnOpenCaesarKey.TabIndex = 2;
            this.btnOpenCaesarKey.Text = "Метод Цезаря с ключом";
            this.btnOpenCaesarKey.UseVisualStyleBackColor = true;
            this.btnOpenCaesarKey.Click += new System.EventHandler(this.btnOpenCaesarKey_Click);
            // 
            // btnOpenVigenereForm
            // 
            this.btnOpenVigenereForm.Location = new System.Drawing.Point(236, 12);
            this.btnOpenVigenereForm.Name = "btnOpenVigenereForm";
            this.btnOpenVigenereForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenVigenereForm.TabIndex = 3;
            this.btnOpenVigenereForm.Text = "Метод Вижинера";
            this.btnOpenVigenereForm.UseVisualStyleBackColor = true;
            this.btnOpenVigenereForm.Click += new System.EventHandler(this.btnOpenVigenereForm_Click);
            // 
            // btnOpenReverseForm
            // 
            this.btnOpenReverseForm.Location = new System.Drawing.Point(81, 150);
            this.btnOpenReverseForm.Name = "btnOpenReverseForm";
            this.btnOpenReverseForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenReverseForm.TabIndex = 4;
            this.btnOpenReverseForm.Text = "Обратный метод";
            this.btnOpenReverseForm.UseVisualStyleBackColor = true;
            this.btnOpenReverseForm.Click += new System.EventHandler(this.btnOpenReverseForm_Click);
            // 
            // btnOpenFrequenceForm
            // 
            this.btnOpenFrequenceForm.Location = new System.Drawing.Point(81, 197);
            this.btnOpenFrequenceForm.Name = "btnOpenFrequenceForm";
            this.btnOpenFrequenceForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenFrequenceForm.TabIndex = 5;
            this.btnOpenFrequenceForm.Text = "Частотный метод";
            this.btnOpenFrequenceForm.UseVisualStyleBackColor = true;
            this.btnOpenFrequenceForm.Click += new System.EventHandler(this.btnOpenFrequenceForm_Click);
            // 
            // btnOpenHuffmanForm
            // 
            this.btnOpenHuffmanForm.Location = new System.Drawing.Point(236, 150);
            this.btnOpenHuffmanForm.Name = "btnOpenHuffmanForm";
            this.btnOpenHuffmanForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenHuffmanForm.TabIndex = 7;
            this.btnOpenHuffmanForm.Text = "Метод Хаффмана";
            this.btnOpenHuffmanForm.UseVisualStyleBackColor = true;
            this.btnOpenHuffmanForm.Click += new System.EventHandler(this.btnOpenHuffmanForm_Click);
            // 
            // btnOpenAnalyticTransformationForm
            // 
            this.btnOpenAnalyticTransformationForm.Location = new System.Drawing.Point(236, 58);
            this.btnOpenAnalyticTransformationForm.Name = "btnOpenAnalyticTransformationForm";
            this.btnOpenAnalyticTransformationForm.Size = new System.Drawing.Size(140, 40);
            this.btnOpenAnalyticTransformationForm.TabIndex = 8;
            this.btnOpenAnalyticTransformationForm.Text = "Метод аналитических преобразований";
            this.btnOpenAnalyticTransformationForm.UseVisualStyleBackColor = true;
            this.btnOpenAnalyticTransformationForm.Click += new System.EventHandler(this.btnOpenAnalyticTransformationForm_Click);
            // 
            // btnOpenVernamForm
            // 
            this.btnOpenVernamForm.Location = new System.Drawing.Point(236, 197);
            this.btnOpenVernamForm.Name = "btnOpenVernamForm";
            this.btnOpenVernamForm.Size = new System.Drawing.Size(140, 38);
            this.btnOpenVernamForm.TabIndex = 9;
            this.btnOpenVernamForm.Text = "Метод Вернама";
            this.btnOpenVernamForm.UseVisualStyleBackColor = true;
            this.btnOpenVernamForm.Click += new System.EventHandler(this.btnOpenVernamForm_Click);
            // 
            // btnOpenPlayfairForm
            // 
            this.btnOpenPlayfairForm.Location = new System.Drawing.Point(236, 108);
            this.btnOpenPlayfairForm.Name = "btnOpenPlayfairForm";
            this.btnOpenPlayfairForm.Size = new System.Drawing.Size(140, 38);
            this.btnOpenPlayfairForm.TabIndex = 10;
            this.btnOpenPlayfairForm.Text = "Метод Плейфера";
            this.btnOpenPlayfairForm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 294);
            this.Controls.Add(this.btnOpenPlayfairForm);
            this.Controls.Add(this.btnOpenVernamForm);
            this.Controls.Add(this.btnOpenAnalyticTransformationForm);
            this.Controls.Add(this.btnOpenHuffmanForm);
            this.Controls.Add(this.btnOpenFrequenceForm);
            this.Controls.Add(this.btnOpenReverseForm);
            this.Controls.Add(this.btnOpenVigenereForm);
            this.Controls.Add(this.btnOpenCaesarKey);
            this.Controls.Add(this.btnOpenCaesarForm);
            this.Controls.Add(this.btnOpenTrisemusForm);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpenTrisemusForm;
        private Button btnOpenCaesarForm;
        private Button btnOpenCaesarKey;
        private Button btnOpenVigenereForm;
        private Button btnOpenReverseForm;
        private Button btnOpenFrequenceForm;
        private Button btnOpenHuffmanForm;
        private Button btnOpenAnalyticTransformationForm;
        private Button btnOpenVernamForm;
        private Button btnOpenPlayfairForm;
    }
}