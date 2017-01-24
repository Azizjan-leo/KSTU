namespace New_МСЗКИ
{
    partial class Main_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.The_Method_of_reverse_encryption = new System.Windows.Forms.Button();
            this.Method_Caesar = new System.Windows.Forms.Button();
            this.Analysis_of_the_number_of_letters = new System.Windows.Forms.Button();
            this.Key_Method_Caesar = new System.Windows.Forms.Button();
            this.Trithemius_cipher = new System.Windows.Forms.Button();
            this.Playfair_cipher = new System.Windows.Forms.Button();
            this.Cipher_Vigenère = new System.Windows.Forms.Button();
            this.Analytical_conversion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cod_of_Haffman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // The_Method_of_reverse_encryption
            // 
            this.The_Method_of_reverse_encryption.Location = new System.Drawing.Point(6, 19);
            this.The_Method_of_reverse_encryption.Name = "The_Method_of_reverse_encryption";
            this.The_Method_of_reverse_encryption.Size = new System.Drawing.Size(262, 23);
            this.The_Method_of_reverse_encryption.TabIndex = 0;
            this.The_Method_of_reverse_encryption.Text = "Метод обратной шифровки";
            this.The_Method_of_reverse_encryption.UseVisualStyleBackColor = true;
            this.The_Method_of_reverse_encryption.Click += new System.EventHandler(this.The_Method_of_reverse_encryption_Click);
            // 
            // Method_Caesar
            // 
            this.Method_Caesar.Location = new System.Drawing.Point(6, 49);
            this.Method_Caesar.Name = "Method_Caesar";
            this.Method_Caesar.Size = new System.Drawing.Size(262, 23);
            this.Method_Caesar.TabIndex = 1;
            this.Method_Caesar.Text = "Шифр Цезаря";
            this.Method_Caesar.UseVisualStyleBackColor = true;
            this.Method_Caesar.Click += new System.EventHandler(this.Method_Caesar_Click);
            // 
            // Analysis_of_the_number_of_letters
            // 
            this.Analysis_of_the_number_of_letters.Location = new System.Drawing.Point(6, 78);
            this.Analysis_of_the_number_of_letters.Name = "Analysis_of_the_number_of_letters";
            this.Analysis_of_the_number_of_letters.Size = new System.Drawing.Size(262, 23);
            this.Analysis_of_the_number_of_letters.TabIndex = 2;
            this.Analysis_of_the_number_of_letters.Text = "Частотный анализ";
            this.Analysis_of_the_number_of_letters.UseVisualStyleBackColor = true;
            this.Analysis_of_the_number_of_letters.Click += new System.EventHandler(this.Analysis_of_the_number_of_letters_Click);
            // 
            // Key_Method_Caesar
            // 
            this.Key_Method_Caesar.Location = new System.Drawing.Point(6, 107);
            this.Key_Method_Caesar.Name = "Key_Method_Caesar";
            this.Key_Method_Caesar.Size = new System.Drawing.Size(262, 23);
            this.Key_Method_Caesar.TabIndex = 3;
            this.Key_Method_Caesar.Text = "Шифр Цезаря с ключом";
            this.Key_Method_Caesar.UseVisualStyleBackColor = true;
            this.Key_Method_Caesar.Click += new System.EventHandler(this.Key_Method_Caesar_Click);
            // 
            // Trithemius_cipher
            // 
            this.Trithemius_cipher.Location = new System.Drawing.Point(6, 136);
            this.Trithemius_cipher.Name = "Trithemius_cipher";
            this.Trithemius_cipher.Size = new System.Drawing.Size(262, 23);
            this.Trithemius_cipher.TabIndex = 4;
            this.Trithemius_cipher.Text = "Шифр Трисемуса";
            this.Trithemius_cipher.UseVisualStyleBackColor = true;
            this.Trithemius_cipher.Click += new System.EventHandler(this.Trithemius_cipher_Click);
            // 
            // Playfair_cipher
            // 
            this.Playfair_cipher.Location = new System.Drawing.Point(6, 165);
            this.Playfair_cipher.Name = "Playfair_cipher";
            this.Playfair_cipher.Size = new System.Drawing.Size(262, 23);
            this.Playfair_cipher.TabIndex = 5;
            this.Playfair_cipher.Text = "Шифр Плэйфера";
            this.Playfair_cipher.UseVisualStyleBackColor = true;
            this.Playfair_cipher.Click += new System.EventHandler(this.Playfair_cipher_Click);
            // 
            // Cipher_Vigenère
            // 
            this.Cipher_Vigenère.Location = new System.Drawing.Point(6, 194);
            this.Cipher_Vigenère.Name = "Cipher_Vigenère";
            this.Cipher_Vigenère.Size = new System.Drawing.Size(262, 23);
            this.Cipher_Vigenère.TabIndex = 6;
            this.Cipher_Vigenère.Text = "Шифр Вижинера";
            this.Cipher_Vigenère.UseVisualStyleBackColor = true;
            this.Cipher_Vigenère.Click += new System.EventHandler(this.Cipher_Vigenère_Click);
            // 
            // Analytical_conversion
            // 
            this.Analytical_conversion.Location = new System.Drawing.Point(6, 223);
            this.Analytical_conversion.Name = "Analytical_conversion";
            this.Analytical_conversion.Size = new System.Drawing.Size(262, 23);
            this.Analytical_conversion.TabIndex = 7;
            this.Analytical_conversion.Text = "Аналитическое преобразование";
            this.Analytical_conversion.UseVisualStyleBackColor = true;
            this.Analytical_conversion.Click += new System.EventHandler(this.Analytical_conversion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Cod_of_Haffman);
            this.groupBox1.Controls.Add(this.Analytical_conversion);
            this.groupBox1.Controls.Add(this.Cipher_Vigenère);
            this.groupBox1.Controls.Add(this.Playfair_cipher);
            this.groupBox1.Controls.Add(this.Trithemius_cipher);
            this.groupBox1.Controls.Add(this.Key_Method_Caesar);
            this.groupBox1.Controls.Add(this.Analysis_of_the_number_of_letters);
            this.groupBox1.Controls.Add(this.Method_Caesar);
            this.groupBox1.Controls.Add(this.The_Method_of_reverse_encryption);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Cod_of_Haffman
            // 
            this.Cod_of_Haffman.Location = new System.Drawing.Point(6, 252);
            this.Cod_of_Haffman.Name = "Cod_of_Haffman";
            this.Cod_of_Haffman.Size = new System.Drawing.Size(262, 23);
            this.Cod_of_Haffman.TabIndex = 8;
            this.Cod_of_Haffman.Text = "Код Хаффмана";
            this.Cod_of_Haffman.UseVisualStyleBackColor = true;
            this.Cod_of_Haffman.Click += new System.EventHandler(this.Cod_of_Haffman_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Метод Вернама";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(298, 338);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_Form";
            this.Text = "Методы шифрования";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Analytical_conversion;
        private System.Windows.Forms.Button Cipher_Vigenère;
        private System.Windows.Forms.Button Playfair_cipher;
        private System.Windows.Forms.Button Trithemius_cipher;
        private System.Windows.Forms.Button Key_Method_Caesar;
        private System.Windows.Forms.Button Analysis_of_the_number_of_letters;
        private System.Windows.Forms.Button Method_Caesar;
        private System.Windows.Forms.Button The_Method_of_reverse_encryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cod_of_Haffman;
        private System.Windows.Forms.Button button1;
    }
}

