namespace FinalSolution
{
    partial class ESM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.AbsHLabel = new System.Windows.Forms.Label();
            this.AbsH = new System.Windows.Forms.TextBox();
            this.SolXLabel = new System.Windows.Forms.Label();
            this.SolYLabel = new System.Windows.Forms.Label();
            this.SolX = new System.Windows.Forms.TextBox();
            this.SolY = new System.Windows.Forms.TextBox();
            this.ToleranceBox = new System.Windows.Forms.TextBox();
            this.ToleranceLabel = new System.Windows.Forms.Label();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.X0Label = new System.Windows.Forms.Label();
            this.FuncLabel = new System.Windows.Forms.Label();
            this.Calcs = new System.Windows.Forms.TextBox();
            this.FuncBox = new System.Windows.Forms.TextBox();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.MaxMinLabel = new System.Windows.Forms.Label();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.k_maxLabel = new System.Windows.Forms.Label();
            this.kmaxBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(8, 343);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(419, 23);
            this.Reset_Btn.TabIndex = 35;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMin.Location = new System.Drawing.Point(273, 37);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(54, 22);
            this.checkBoxMin.TabIndex = 34;
            this.checkBoxMin.Text = "Min";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // AbsHLabel
            // 
            this.AbsHLabel.AutoSize = true;
            this.AbsHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsHLabel.Location = new System.Drawing.Point(7, 322);
            this.AbsHLabel.Name = "AbsHLabel";
            this.AbsHLabel.Size = new System.Drawing.Size(60, 18);
            this.AbsHLabel.TabIndex = 33;
            this.AbsHLabel.Text = "Abs(H)";
            // 
            // AbsH
            // 
            this.AbsH.Enabled = false;
            this.AbsH.Location = new System.Drawing.Point(72, 321);
            this.AbsH.Name = "AbsH";
            this.AbsH.Size = new System.Drawing.Size(186, 20);
            this.AbsH.TabIndex = 32;
            // 
            // SolXLabel
            // 
            this.SolXLabel.AutoSize = true;
            this.SolXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolXLabel.Location = new System.Drawing.Point(8, 295);
            this.SolXLabel.Name = "SolXLabel";
            this.SolXLabel.Size = new System.Drawing.Size(25, 18);
            this.SolXLabel.TabIndex = 31;
            this.SolXLabel.Text = "x1";
            // 
            // SolYLabel
            // 
            this.SolYLabel.AutoSize = true;
            this.SolYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolYLabel.Location = new System.Drawing.Point(8, 268);
            this.SolYLabel.Name = "SolYLabel";
            this.SolYLabel.Size = new System.Drawing.Size(18, 18);
            this.SolYLabel.TabIndex = 30;
            this.SolYLabel.Text = "Y";
            // 
            // SolX
            // 
            this.SolX.Enabled = false;
            this.SolX.Location = new System.Drawing.Point(39, 296);
            this.SolX.Name = "SolX";
            this.SolX.Size = new System.Drawing.Size(219, 20);
            this.SolX.TabIndex = 29;
            // 
            // SolY
            // 
            this.SolY.Enabled = false;
            this.SolY.Location = new System.Drawing.Point(39, 271);
            this.SolY.Name = "SolY";
            this.SolY.Size = new System.Drawing.Size(219, 20);
            this.SolY.TabIndex = 28;
            // 
            // ToleranceBox
            // 
            this.ToleranceBox.Location = new System.Drawing.Point(343, 11);
            this.ToleranceBox.Name = "ToleranceBox";
            this.ToleranceBox.Size = new System.Drawing.Size(51, 20);
            this.ToleranceBox.TabIndex = 27;
            this.ToleranceBox.Text = "0.01";
            // 
            // ToleranceLabel
            // 
            this.ToleranceLabel.AutoSize = true;
            this.ToleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToleranceLabel.Location = new System.Drawing.Point(258, 9);
            this.ToleranceLabel.Name = "ToleranceLabel";
            this.ToleranceLabel.Size = new System.Drawing.Size(83, 18);
            this.ToleranceLabel.TabIndex = 26;
            this.ToleranceLabel.Text = "Tolerance";
            // 
            // X0Box
            // 
            this.X0Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0Box.Location = new System.Drawing.Point(214, 8);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(38, 21);
            this.X0Box.TabIndex = 25;
            this.X0Box.Text = "-2.99";
            // 
            // X0Label
            // 
            this.X0Label.AutoSize = true;
            this.X0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0Label.Location = new System.Drawing.Point(183, 8);
            this.X0Label.Name = "X0Label";
            this.X0Label.Size = new System.Drawing.Size(25, 18);
            this.X0Label.TabIndex = 24;
            this.X0Label.Text = "x0";
            // 
            // FuncLabel
            // 
            this.FuncLabel.AutoSize = true;
            this.FuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncLabel.Location = new System.Drawing.Point(33, 10);
            this.FuncLabel.Name = "FuncLabel";
            this.FuncLabel.Size = new System.Drawing.Size(33, 18);
            this.FuncLabel.TabIndex = 23;
            this.FuncLabel.Text = "f(x)";
            // 
            // Calcs
            // 
            this.Calcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcs.Location = new System.Drawing.Point(12, 59);
            this.Calcs.Multiline = true;
            this.Calcs.Name = "Calcs";
            this.Calcs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Calcs.Size = new System.Drawing.Size(415, 201);
            this.Calcs.TabIndex = 22;
            // 
            // FuncBox
            // 
            this.FuncBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncBox.Location = new System.Drawing.Point(72, 7);
            this.FuncBox.Name = "FuncBox";
            this.FuncBox.Size = new System.Drawing.Size(105, 21);
            this.FuncBox.TabIndex = 21;
            this.FuncBox.Text = "x^3+x^2-8*x-8";
            // 
            // Start_Btn
            // 
            this.Start_Btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(264, 271);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(163, 69);
            this.Start_Btn.TabIndex = 20;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // MaxMinLabel
            // 
            this.MaxMinLabel.AutoSize = true;
            this.MaxMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMinLabel.Location = new System.Drawing.Point(163, 37);
            this.MaxMinLabel.Name = "MaxMinLabel";
            this.MaxMinLabel.Size = new System.Drawing.Size(104, 18);
            this.MaxMinLabel.TabIndex = 36;
            this.MaxMinLabel.Text = "What to find:";
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMax.Location = new System.Drawing.Point(333, 37);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(58, 22);
            this.checkBoxMax.TabIndex = 37;
            this.checkBoxMax.Text = "Max";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // k_maxLabel
            // 
            this.k_maxLabel.AutoSize = true;
            this.k_maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_maxLabel.Location = new System.Drawing.Point(40, 37);
            this.k_maxLabel.Name = "k_maxLabel";
            this.k_maxLabel.Size = new System.Drawing.Size(48, 18);
            this.k_maxLabel.TabIndex = 39;
            this.k_maxLabel.Text = "kMax";
            // 
            // kmaxBox
            // 
            this.kmaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmaxBox.Location = new System.Drawing.Point(95, 34);
            this.kmaxBox.Name = "kmaxBox";
            this.kmaxBox.Size = new System.Drawing.Size(62, 21);
            this.kmaxBox.TabIndex = 38;
            this.kmaxBox.Text = "200";
            // 
            // ESM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 370);
            this.Controls.Add(this.k_maxLabel);
            this.Controls.Add(this.kmaxBox);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.MaxMinLabel);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.checkBoxMin);
            this.Controls.Add(this.AbsHLabel);
            this.Controls.Add(this.AbsH);
            this.Controls.Add(this.SolXLabel);
            this.Controls.Add(this.SolYLabel);
            this.Controls.Add(this.SolX);
            this.Controls.Add(this.SolY);
            this.Controls.Add(this.ToleranceBox);
            this.Controls.Add(this.ToleranceLabel);
            this.Controls.Add(this.X0Box);
            this.Controls.Add(this.X0Label);
            this.Controls.Add(this.FuncLabel);
            this.Controls.Add(this.Calcs);
            this.Controls.Add(this.FuncBox);
            this.Controls.Add(this.Start_Btn);
            this.Name = "ESM";
            this.Text = "ESM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.Label AbsHLabel;
        private System.Windows.Forms.TextBox AbsH;
        private System.Windows.Forms.Label SolXLabel;
        private System.Windows.Forms.Label SolYLabel;
        private System.Windows.Forms.TextBox SolX;
        private System.Windows.Forms.TextBox SolY;
        private System.Windows.Forms.TextBox ToleranceBox;
        private System.Windows.Forms.Label ToleranceLabel;
        private System.Windows.Forms.TextBox X0Box;
        private System.Windows.Forms.Label X0Label;
        private System.Windows.Forms.Label FuncLabel;
        private System.Windows.Forms.TextBox Calcs;
        private System.Windows.Forms.TextBox FuncBox;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Label MaxMinLabel;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.Label k_maxLabel;
        private System.Windows.Forms.TextBox kmaxBox;
    }
}