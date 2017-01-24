using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mszi
{
    partial class msziMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new TabControl();
            this.tbpReverse = new TabPage();
            this.rdbtnDecryptReverse = new RadioButton();
            this.rdbtnEncryptReverse = new RadioButton();
            this.label2 = new Label();
            this.label1 = new Label();
            this.txbxOutputReverse = new TextBox();
            this.txbxInputReverse = new TextBox();
            this.btnEnterReverse = new Button();
            this.tbpCaesar = new TabPage();
            this.tbpCaesarKey = new TabPage();
            this.label17 = new Label();
            this.txbxStepCaesarKey = new TextBox();
            this.rdbtnDecryptCaesarKey = new RadioButton();
            this.rdbtnEncryptCaesarKey = new RadioButton();
            this.label12 = new Label();
            this.txbxKeywordCaesarKey = new TextBox();
            this.label15 = new Label();
            this.label16 = new Label();
            this.txbxOutputCaesarKey = new TextBox();
            this.txbxInputCaesarKey = new TextBox();
            this.btnEnterCaesarKey = new Button();
            this.tbpFrequency = new TabPage();
            this.label7 = new Label();
            this.label8 = new Label();
            this.txbxOutputFrequency = new TextBox();
            this.txbxInputFrequency = new TextBox();
            this.btnEnterFrequency = new Button();
            this.tbpVigenere = new TabPage();
            this.rdbtnDecryptVigenere = new RadioButton();
            this.rdbtnEncryptVigenere = new RadioButton();
            this.btnEnterVigenere = new Button();
            this.label11 = new Label();
            this.label6 = new Label();
            this.label9 = new Label();
            this.txbxOutputVigenere = new TextBox();
            this.txbxKeywordVigenere = new TextBox();
            this.txbxInputVigenere = new TextBox();
            this.tbpTrisemus = new TabPage();
            this.label14 = new Label();
            this.txbxKeywordTrisemus = new TextBox();
            this.label10 = new Label();
            this.label13 = new Label();
            this.btnEnterTrisemus = new Button();
            this.rdbtnDecryptTrisemus = new RadioButton();
            this.rdbtnEncryptTrisemus = new RadioButton();
            this.txbxOutputTrisemus = new TextBox();
            this.txbxInputTrisemus = new TextBox();
            this.btnEnterCaesar = new Button();
            this.txbxInputCaesar = new TextBox();
            this.txbxOutputCaesar = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.txbxStepCaesar = new TextBox();
            this.label5 = new Label();
            this.rdbtnEncryptCaesar = new RadioButton();
            this.rdbtnDecryptCaesar = new RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbpReverse.SuspendLayout();
            this.tbpCaesar.SuspendLayout();
            this.tbpCaesarKey.SuspendLayout();
            this.tbpFrequency.SuspendLayout();
            this.tbpVigenere.SuspendLayout();
            this.tbpTrisemus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpReverse);
            this.tabControl1.Controls.Add(this.tbpCaesar);
            this.tabControl1.Controls.Add(this.tbpCaesarKey);
            this.tabControl1.Controls.Add(this.tbpFrequency);
            this.tabControl1.Controls.Add(this.tbpVigenere);
            this.tabControl1.Controls.Add(this.tbpTrisemus);
            this.tabControl1.Location = new Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(732, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpReverse
            // 
            this.tbpReverse.Controls.Add(this.rdbtnDecryptReverse);
            this.tbpReverse.Controls.Add(this.rdbtnEncryptReverse);
            this.tbpReverse.Controls.Add(this.label2);
            this.tbpReverse.Controls.Add(this.label1);
            this.tbpReverse.Controls.Add(this.txbxOutputReverse);
            this.tbpReverse.Controls.Add(this.txbxInputReverse);
            this.tbpReverse.Controls.Add(this.btnEnterReverse);
            this.tbpReverse.Location = new Point(4, 22);
            this.tbpReverse.Name = "tbpReverse";
            this.tbpReverse.Padding = new Padding(3);
            this.tbpReverse.Size = new Size(724, 367);
            this.tbpReverse.TabIndex = 0;
            this.tbpReverse.Text = "Обратный метод";
            this.tbpReverse.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecryptReverse
            // 
            this.rdbtnDecryptReverse.AutoSize = true;
            this.rdbtnDecryptReverse.Location = new Point(183, 149);
            this.rdbtnDecryptReverse.Name = "rdbtnDecryptReverse";
            this.rdbtnDecryptReverse.Size = new Size(96, 17);
            this.rdbtnDecryptReverse.TabIndex = 8;
            this.rdbtnDecryptReverse.Text = "Расшифровка";
            this.rdbtnDecryptReverse.UseVisualStyleBackColor = true;
            this.rdbtnDecryptReverse.CheckedChanged += new EventHandler(this.rdbtnDecryptReverse_CheckedChanged);
            // 
            // rdbtnEncryptReverse
            // 
            this.rdbtnEncryptReverse.AutoSize = true;
            this.rdbtnEncryptReverse.Checked = true;
            this.rdbtnEncryptReverse.Location = new Point(183, 130);
            this.rdbtnEncryptReverse.Name = "rdbtnEncryptReverse";
            this.rdbtnEncryptReverse.Size = new Size(90, 17);
            this.rdbtnEncryptReverse.TabIndex = 7;
            this.rdbtnEncryptReverse.TabStop = true;
            this.rdbtnEncryptReverse.Text = "Зашифровка";
            this.rdbtnEncryptReverse.UseVisualStyleBackColor = true;
            this.rdbtnEncryptReverse.CheckedChanged += new EventHandler(this.rdbtnEncryptReverse_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(88, 172);
            this.label2.Name = "label2";
            this.label2.Size = new Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конечный текст";
            this.label2.Click += new EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный текст";
            this.label1.Click += new EventHandler(this.label1_Click);
            // 
            // txbxOutputReverse
            // 
            this.txbxOutputReverse.Location = new Point(183, 172);
            this.txbxOutputReverse.Multiline = true;
            this.txbxOutputReverse.Name = "txbxOutputReverse";
            this.txbxOutputReverse.Size = new Size(380, 116);
            this.txbxOutputReverse.TabIndex = 2;
            this.txbxOutputReverse.TextChanged += new EventHandler(this.txbxOutputReverse_TextChanged);
            // 
            // txbxInputReverse
            // 
            this.txbxInputReverse.Location = new Point(183, 29);
            this.txbxInputReverse.Multiline = true;
            this.txbxInputReverse.Name = "txbxInputReverse";
            this.txbxInputReverse.Size = new Size(380, 95);
            this.txbxInputReverse.TabIndex = 1;
            this.txbxInputReverse.TextChanged += new EventHandler(this.txbxInputReverse_TextChanged);
            // 
            // btnEnterReverse
            // 
            this.btnEnterReverse.Location = new Point(442, 130);
            this.btnEnterReverse.Name = "btnEnterReverse";
            this.btnEnterReverse.Size = new Size(121, 36);
            this.btnEnterReverse.TabIndex = 0;
            this.btnEnterReverse.Text = "Выполнить";
            this.btnEnterReverse.UseVisualStyleBackColor = true;
            this.btnEnterReverse.Click += new EventHandler(this.btnEnterReverse_Click);
            // 
            // tbpCaesar
            // 
            this.tbpCaesar.Controls.Add(this.rdbtnDecryptCaesar);
            this.tbpCaesar.Controls.Add(this.rdbtnEncryptCaesar);
            this.tbpCaesar.Controls.Add(this.label5);
            this.tbpCaesar.Controls.Add(this.txbxStepCaesar);
            this.tbpCaesar.Controls.Add(this.label3);
            this.tbpCaesar.Controls.Add(this.label4);
            this.tbpCaesar.Controls.Add(this.txbxOutputCaesar);
            this.tbpCaesar.Controls.Add(this.txbxInputCaesar);
            this.tbpCaesar.Controls.Add(this.btnEnterCaesar);
            this.tbpCaesar.Location = new Point(4, 22);
            this.tbpCaesar.Name = "tbpCaesar";
            this.tbpCaesar.Padding = new Padding(3);
            this.tbpCaesar.Size = new Size(724, 367);
            this.tbpCaesar.TabIndex = 1;
            this.tbpCaesar.Text = "Метод Цезаря";
            this.tbpCaesar.UseVisualStyleBackColor = true;
            // 
            // tbpCaesarKey
            // 
            this.tbpCaesarKey.Controls.Add(this.label17);
            this.tbpCaesarKey.Controls.Add(this.txbxStepCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.rdbtnDecryptCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.rdbtnEncryptCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.label12);
            this.tbpCaesarKey.Controls.Add(this.txbxKeywordCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.label15);
            this.tbpCaesarKey.Controls.Add(this.label16);
            this.tbpCaesarKey.Controls.Add(this.txbxOutputCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.txbxInputCaesarKey);
            this.tbpCaesarKey.Controls.Add(this.btnEnterCaesarKey);
            this.tbpCaesarKey.Location = new Point(4, 22);
            this.tbpCaesarKey.Name = "tbpCaesarKey";
            this.tbpCaesarKey.Padding = new Padding(3);
            this.tbpCaesarKey.Size = new Size(724, 367);
            this.tbpCaesarKey.TabIndex = 5;
            this.tbpCaesarKey.Text = "Метод Цезаря с ключом";
            this.tbpCaesarKey.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new Point(79, 166);
            this.label17.Name = "label17";
            this.label17.Size = new Size(61, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Смещение";
            // 
            // txbxStepCaesarKey
            // 
            this.txbxStepCaesarKey.Location = new Point(176, 159);
            this.txbxStepCaesarKey.Name = "txbxStepCaesarKey";
            this.txbxStepCaesarKey.Size = new Size(100, 20);
            this.txbxStepCaesarKey.TabIndex = 27;
            // 
            // rdbtnDecryptCaesarKey
            // 
            this.rdbtnDecryptCaesarKey.AutoSize = true;
            this.rdbtnDecryptCaesarKey.Location = new Point(309, 182);
            this.rdbtnDecryptCaesarKey.Name = "rdbtnDecryptCaesarKey";
            this.rdbtnDecryptCaesarKey.Size = new Size(96, 17);
            this.rdbtnDecryptCaesarKey.TabIndex = 26;
            this.rdbtnDecryptCaesarKey.Text = "Разшифровка";
            this.rdbtnDecryptCaesarKey.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptCaesarKey
            // 
            this.rdbtnEncryptCaesarKey.AutoSize = true;
            this.rdbtnEncryptCaesarKey.Checked = true;
            this.rdbtnEncryptCaesarKey.Location = new Point(309, 159);
            this.rdbtnEncryptCaesarKey.Name = "rdbtnEncryptCaesarKey";
            this.rdbtnEncryptCaesarKey.Size = new Size(90, 17);
            this.rdbtnEncryptCaesarKey.TabIndex = 25;
            this.rdbtnEncryptCaesarKey.TabStop = true;
            this.rdbtnEncryptCaesarKey.Text = "Зашифровка";
            this.rdbtnEncryptCaesarKey.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new Point(79, 133);
            this.label12.Name = "label12";
            this.label12.Size = new Size(90, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ключевое слово";
            // 
            // txbxKeywordCaesarKey
            // 
            this.txbxKeywordCaesarKey.Location = new Point(176, 133);
            this.txbxKeywordCaesarKey.Name = "txbxKeywordCaesarKey";
            this.txbxKeywordCaesarKey.Size = new Size(380, 20);
            this.txbxKeywordCaesarKey.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new Point(81, 255);
            this.label15.Name = "label15";
            this.label15.Size = new Size(88, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Конечный текст";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new Point(81, 35);
            this.label16.Name = "label16";
            this.label16.Size = new Size(89, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Исходный текст";
            // 
            // txbxOutputCaesarKey
            // 
            this.txbxOutputCaesarKey.Location = new Point(175, 205);
            this.txbxOutputCaesarKey.Multiline = true;
            this.txbxOutputCaesarKey.Name = "txbxOutputCaesarKey";
            this.txbxOutputCaesarKey.Size = new Size(380, 110);
            this.txbxOutputCaesarKey.TabIndex = 20;
            // 
            // txbxInputCaesarKey
            // 
            this.txbxInputCaesarKey.Location = new Point(176, 32);
            this.txbxInputCaesarKey.Multiline = true;
            this.txbxInputCaesarKey.Name = "txbxInputCaesarKey";
            this.txbxInputCaesarKey.Size = new Size(380, 95);
            this.txbxInputCaesarKey.TabIndex = 19;
            // 
            // btnEnterCaesarKey
            // 
            this.btnEnterCaesarKey.Location = new Point(441, 159);
            this.btnEnterCaesarKey.Name = "btnEnterCaesarKey";
            this.btnEnterCaesarKey.Size = new Size(115, 36);
            this.btnEnterCaesarKey.TabIndex = 18;
            this.btnEnterCaesarKey.Text = "Выполнить";
            this.btnEnterCaesarKey.UseVisualStyleBackColor = true;
            this.btnEnterCaesarKey.Click += new EventHandler(this.btnEnterCaesarKey_Click);
            // 
            // tbpFrequency
            // 
            this.tbpFrequency.Controls.Add(this.label7);
            this.tbpFrequency.Controls.Add(this.label8);
            this.tbpFrequency.Controls.Add(this.txbxOutputFrequency);
            this.tbpFrequency.Controls.Add(this.txbxInputFrequency);
            this.tbpFrequency.Controls.Add(this.btnEnterFrequency);
            this.tbpFrequency.Location = new Point(4, 22);
            this.tbpFrequency.Name = "tbpFrequency";
            this.tbpFrequency.Size = new Size(724, 367);
            this.tbpFrequency.TabIndex = 2;
            this.tbpFrequency.Text = "Частотный метод";
            this.tbpFrequency.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(125, 197);
            this.label7.Name = "label7";
            this.label7.Size = new Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Анализ";
            this.label7.Click += new EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(125, 57);
            this.label8.Name = "label8";
            this.label8.Size = new Size(89, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Исходный текст";
            this.label8.Click += new EventHandler(this.label8_Click);
            // 
            // txbxOutputFrequency
            // 
            this.txbxOutputFrequency.Location = new Point(220, 197);
            this.txbxOutputFrequency.Multiline = true;
            this.txbxOutputFrequency.Name = "txbxOutputFrequency";
            this.txbxOutputFrequency.ScrollBars = ScrollBars.Both;
            this.txbxOutputFrequency.Size = new Size(380, 116);
            this.txbxOutputFrequency.TabIndex = 18;
            this.txbxOutputFrequency.TextChanged += new EventHandler(this.txbxOutputFrequency_TextChanged);
            // 
            // txbxInputFrequency
            // 
            this.txbxInputFrequency.Location = new Point(220, 54);
            this.txbxInputFrequency.Multiline = true;
            this.txbxInputFrequency.Name = "txbxInputFrequency";
            this.txbxInputFrequency.Size = new Size(380, 95);
            this.txbxInputFrequency.TabIndex = 17;
            this.txbxInputFrequency.TextChanged += new EventHandler(this.txbxInputFrequency_TextChanged);
            // 
            // btnEnterFrequency
            // 
            this.btnEnterFrequency.Location = new Point(485, 155);
            this.btnEnterFrequency.Name = "btnEnterFrequency";
            this.btnEnterFrequency.Size = new Size(115, 36);
            this.btnEnterFrequency.TabIndex = 16;
            this.btnEnterFrequency.Text = "Анализ";
            this.btnEnterFrequency.UseVisualStyleBackColor = true;
            this.btnEnterFrequency.Click += new EventHandler(this.btnEnterFrequency_Click);
            // 
            // tbpVigenere
            // 
            this.tbpVigenere.Controls.Add(this.rdbtnDecryptVigenere);
            this.tbpVigenere.Controls.Add(this.rdbtnEncryptVigenere);
            this.tbpVigenere.Controls.Add(this.btnEnterVigenere);
            this.tbpVigenere.Controls.Add(this.label11);
            this.tbpVigenere.Controls.Add(this.label6);
            this.tbpVigenere.Controls.Add(this.label9);
            this.tbpVigenere.Controls.Add(this.txbxOutputVigenere);
            this.tbpVigenere.Controls.Add(this.txbxKeywordVigenere);
            this.tbpVigenere.Controls.Add(this.txbxInputVigenere);
            this.tbpVigenere.Location = new Point(4, 22);
            this.tbpVigenere.Name = "tbpVigenere";
            this.tbpVigenere.Padding = new Padding(3);
            this.tbpVigenere.Size = new Size(724, 367);
            this.tbpVigenere.TabIndex = 3;
            this.tbpVigenere.Text = "Шифр Вижинера";
            this.tbpVigenere.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecryptVigenere
            // 
            this.rdbtnDecryptVigenere.AutoSize = true;
            this.rdbtnDecryptVigenere.Location = new Point(252, 224);
            this.rdbtnDecryptVigenere.Name = "rdbtnDecryptVigenere";
            this.rdbtnDecryptVigenere.Size = new Size(96, 17);
            this.rdbtnDecryptVigenere.TabIndex = 28;
            this.rdbtnDecryptVigenere.Text = "Разшифровка";
            this.rdbtnDecryptVigenere.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptVigenere
            // 
            this.rdbtnEncryptVigenere.AutoSize = true;
            this.rdbtnEncryptVigenere.Checked = true;
            this.rdbtnEncryptVigenere.Location = new Point(252, 200);
            this.rdbtnEncryptVigenere.Name = "rdbtnEncryptVigenere";
            this.rdbtnEncryptVigenere.Size = new Size(90, 17);
            this.rdbtnEncryptVigenere.TabIndex = 27;
            this.rdbtnEncryptVigenere.TabStop = true;
            this.rdbtnEncryptVigenere.Text = "Зашифровка";
            this.rdbtnEncryptVigenere.UseVisualStyleBackColor = true;
            // 
            // btnEnterVigenere
            // 
            this.btnEnterVigenere.Location = new Point(454, 200);
            this.btnEnterVigenere.Name = "btnEnterVigenere";
            this.btnEnterVigenere.Size = new Size(108, 35);
            this.btnEnterVigenere.TabIndex = 26;
            this.btnEnterVigenere.Text = "Выполнить";
            this.btnEnterVigenere.UseVisualStyleBackColor = true;
            this.btnEnterVigenere.Click += new EventHandler(this.btnEnterVigenere_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new Point(157, 30);
            this.label11.Name = "label11";
            this.label11.Size = new Size(89, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Исходный текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(158, 90);
            this.label6.Name = "label6";
            this.label6.Size = new Size(33, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ключ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new Point(158, 250);
            this.label9.Name = "label9";
            this.label9.Size = new Size(88, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Конечный текст";
            // 
            // txbxOutputVigenere
            // 
            this.txbxOutputVigenere.Location = new Point(252, 247);
            this.txbxOutputVigenere.Multiline = true;
            this.txbxOutputVigenere.Name = "txbxOutputVigenere";
            this.txbxOutputVigenere.Size = new Size(310, 80);
            this.txbxOutputVigenere.TabIndex = 2;
            // 
            // txbxKeywordVigenere
            // 
            this.txbxKeywordVigenere.Location = new Point(252, 113);
            this.txbxKeywordVigenere.Multiline = true;
            this.txbxKeywordVigenere.Name = "txbxKeywordVigenere";
            this.txbxKeywordVigenere.Size = new Size(310, 80);
            this.txbxKeywordVigenere.TabIndex = 1;
            // 
            // txbxInputVigenere
            // 
            this.txbxInputVigenere.Location = new Point(252, 27);
            this.txbxInputVigenere.Multiline = true;
            this.txbxInputVigenere.Name = "txbxInputVigenere";
            this.txbxInputVigenere.Size = new Size(310, 80);
            this.txbxInputVigenere.TabIndex = 0;
            // 
            // tbpTrisemus
            // 
            this.tbpTrisemus.Controls.Add(this.label14);
            this.tbpTrisemus.Controls.Add(this.txbxKeywordTrisemus);
            this.tbpTrisemus.Controls.Add(this.label10);
            this.tbpTrisemus.Controls.Add(this.label13);
            this.tbpTrisemus.Controls.Add(this.btnEnterTrisemus);
            this.tbpTrisemus.Controls.Add(this.rdbtnDecryptTrisemus);
            this.tbpTrisemus.Controls.Add(this.rdbtnEncryptTrisemus);
            this.tbpTrisemus.Controls.Add(this.txbxOutputTrisemus);
            this.tbpTrisemus.Controls.Add(this.txbxInputTrisemus);
            this.tbpTrisemus.Location = new Point(4, 22);
            this.tbpTrisemus.Name = "tbpTrisemus";
            this.tbpTrisemus.Padding = new Padding(3);
            this.tbpTrisemus.Size = new Size(724, 367);
            this.tbpTrisemus.TabIndex = 4;
            this.tbpTrisemus.Text = "Метод Трисемуса";
            this.tbpTrisemus.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new Point(78, 101);
            this.label14.Name = "label14";
            this.label14.Size = new Size(90, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Ключевое слово";
            // 
            // txbxKeywordTrisemus
            // 
            this.txbxKeywordTrisemus.Location = new Point(172, 98);
            this.txbxKeywordTrisemus.Multiline = true;
            this.txbxKeywordTrisemus.Name = "txbxKeywordTrisemus";
            this.txbxKeywordTrisemus.Size = new Size(354, 24);
            this.txbxKeywordTrisemus.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new Point(77, 20);
            this.label10.Name = "label10";
            this.label10.Size = new Size(89, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Исходный текст";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new Point(77, 180);
            this.label13.Name = "label13";
            this.label13.Size = new Size(88, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Конечный текст";
            // 
            // btnEnterTrisemus
            // 
            this.btnEnterTrisemus.Location = new Point(433, 128);
            this.btnEnterTrisemus.Name = "btnEnterTrisemus";
            this.btnEnterTrisemus.Size = new Size(93, 43);
            this.btnEnterTrisemus.TabIndex = 5;
            this.btnEnterTrisemus.Text = "Выполнить";
            this.btnEnterTrisemus.UseVisualStyleBackColor = true;
            this.btnEnterTrisemus.Click += new EventHandler(this.btnEnterTrisemus_Click);
            // 
            // rdbtnDecryptTrisemus
            // 
            this.rdbtnDecryptTrisemus.AutoSize = true;
            this.rdbtnDecryptTrisemus.Location = new Point(325, 151);
            this.rdbtnDecryptTrisemus.Name = "rdbtnDecryptTrisemus";
            this.rdbtnDecryptTrisemus.Size = new Size(96, 17);
            this.rdbtnDecryptTrisemus.TabIndex = 4;
            this.rdbtnDecryptTrisemus.Text = "Разшифровка";
            this.rdbtnDecryptTrisemus.UseVisualStyleBackColor = true;
            // 
            // rdbtnEncryptTrisemus
            // 
            this.rdbtnEncryptTrisemus.AutoSize = true;
            this.rdbtnEncryptTrisemus.Checked = true;
            this.rdbtnEncryptTrisemus.Location = new Point(325, 128);
            this.rdbtnEncryptTrisemus.Name = "rdbtnEncryptTrisemus";
            this.rdbtnEncryptTrisemus.Size = new Size(90, 17);
            this.rdbtnEncryptTrisemus.TabIndex = 3;
            this.rdbtnEncryptTrisemus.TabStop = true;
            this.rdbtnEncryptTrisemus.Text = "Зашифровка";
            this.rdbtnEncryptTrisemus.UseVisualStyleBackColor = true;
            // 
            // txbxOutputTrisemus
            // 
            this.txbxOutputTrisemus.Location = new Point(172, 177);
            this.txbxOutputTrisemus.Multiline = true;
            this.txbxOutputTrisemus.Name = "txbxOutputTrisemus";
            this.txbxOutputTrisemus.Size = new Size(354, 97);
            this.txbxOutputTrisemus.TabIndex = 2;
            // 
            // txbxInputTrisemus
            // 
            this.txbxInputTrisemus.Location = new Point(172, 17);
            this.txbxInputTrisemus.Multiline = true;
            this.txbxInputTrisemus.Name = "txbxInputTrisemus";
            this.txbxInputTrisemus.Size = new Size(354, 75);
            this.txbxInputTrisemus.TabIndex = 0;
            // 
            // btnEnterCaesar
            // 
            this.btnEnterCaesar.Location = new Point(485, 155);
            this.btnEnterCaesar.Name = "btnEnterCaesar";
            this.btnEnterCaesar.Size = new Size(115, 36);
            this.btnEnterCaesar.TabIndex = 7;
            this.btnEnterCaesar.Text = "Выполнить";
            this.btnEnterCaesar.UseVisualStyleBackColor = true;
            this.btnEnterCaesar.Click += new EventHandler(this.btnEnterCaesar_Click);
            // 
            // txbxInputCaesar
            // 
            this.txbxInputCaesar.Location = new Point(220, 54);
            this.txbxInputCaesar.Multiline = true;
            this.txbxInputCaesar.Name = "txbxInputCaesar";
            this.txbxInputCaesar.Size = new Size(380, 95);
            this.txbxInputCaesar.TabIndex = 8;
            // 
            // txbxOutputCaesar
            // 
            this.txbxOutputCaesar.Location = new Point(220, 197);
            this.txbxOutputCaesar.Multiline = true;
            this.txbxOutputCaesar.Name = "txbxOutputCaesar";
            this.txbxOutputCaesar.Size = new Size(380, 116);
            this.txbxOutputCaesar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(125, 57);
            this.label4.Name = "label4";
            this.label4.Size = new Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Исходный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(125, 197);
            this.label3.Name = "label3";
            this.label3.Size = new Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Конечный текст";
            // 
            // txbxStepCaesar
            // 
            this.txbxStepCaesar.Location = new Point(220, 155);
            this.txbxStepCaesar.Name = "txbxStepCaesar";
            this.txbxStepCaesar.Size = new Size(100, 20);
            this.txbxStepCaesar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(126, 155);
            this.label5.Name = "label5";
            this.label5.Size = new Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Смещение";
            // 
            // rdbtnEncryptCaesar
            // 
            this.rdbtnEncryptCaesar.AutoSize = true;
            this.rdbtnEncryptCaesar.Checked = true;
            this.rdbtnEncryptCaesar.Location = new Point(353, 155);
            this.rdbtnEncryptCaesar.Name = "rdbtnEncryptCaesar";
            this.rdbtnEncryptCaesar.Size = new Size(90, 17);
            this.rdbtnEncryptCaesar.TabIndex = 16;
            this.rdbtnEncryptCaesar.TabStop = true;
            this.rdbtnEncryptCaesar.Text = "Зашифровка";
            this.rdbtnEncryptCaesar.UseVisualStyleBackColor = true;
            // 
            // rdbtnDecryptCaesar
            // 
            this.rdbtnDecryptCaesar.AutoSize = true;
            this.rdbtnDecryptCaesar.Location = new Point(353, 173);
            this.rdbtnDecryptCaesar.Name = "rdbtnDecryptCaesar";
            this.rdbtnDecryptCaesar.Size = new Size(96, 17);
            this.rdbtnDecryptCaesar.TabIndex = 17;
            this.rdbtnDecryptCaesar.Text = "Разшифровка";
            this.rdbtnDecryptCaesar.UseVisualStyleBackColor = true;
            // 
            // msziMain
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(747, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "msziMain";
            this.Text = "Методы и средства защиты информации";
            this.FormClosing += new FormClosingEventHandler(this.msziMain_FormClosing);
            this.Load += new EventHandler(this.msziMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpReverse.ResumeLayout(false);
            this.tbpReverse.PerformLayout();
            this.tbpCaesar.ResumeLayout(false);
            this.tbpCaesar.PerformLayout();
            this.tbpCaesarKey.ResumeLayout(false);
            this.tbpCaesarKey.PerformLayout();
            this.tbpFrequency.ResumeLayout(false);
            this.tbpFrequency.PerformLayout();
            this.tbpVigenere.ResumeLayout(false);
            this.tbpVigenere.PerformLayout();
            this.tbpTrisemus.ResumeLayout(false);
            this.tbpTrisemus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpReverse;
        private TextBox txbxOutputReverse;
        private TextBox txbxInputReverse;
        private Button btnEnterReverse;
        private TabPage tbpCaesar;
        private Label label2;
        private Label label1;
        private TabPage tbpFrequency;
        private Label label7;
        private Label label8;
        private TextBox txbxOutputFrequency;
        private TextBox txbxInputFrequency;
        private Button btnEnterFrequency;
        private RadioButton rdbtnDecryptReverse;
        private RadioButton rdbtnEncryptReverse;
        private TabPage tbpVigenere;
        private RadioButton rdbtnDecryptVigenere;
        private RadioButton rdbtnEncryptVigenere;
        private Button btnEnterVigenere;
        private Label label11;
        private Label label6;
        private Label label9;
        private TextBox txbxOutputVigenere;
        private TextBox txbxKeywordVigenere;
        private TextBox txbxInputVigenere;
        private TabPage tbpTrisemus;
        private Label label14;
        private TextBox txbxKeywordTrisemus;
        private Label label10;
        private Label label13;
        private Button btnEnterTrisemus;
        private RadioButton rdbtnDecryptTrisemus;
        private RadioButton rdbtnEncryptTrisemus;
        private TextBox txbxOutputTrisemus;
        private TextBox txbxInputTrisemus;
        private TabPage tbpCaesarKey;
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
        private Label label17;
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

