namespace FinalSolution
{
    partial class PSM
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
            this.OutAbsH0Label = new System.Windows.Forms.Label();
            this.OutX1Label = new System.Windows.Forms.Label();
            this.OutYf1Label = new System.Windows.Forms.Label();
            this.outX1 = new System.Windows.Forms.TextBox();
            this.outYf1 = new System.Windows.Forms.TextBox();
            this.outAbsH0 = new System.Windows.Forms.TextBox();
            this.minCheckBox = new System.Windows.Forms.CheckBox();
            this.inR = new System.Windows.Forms.TextBox();
            this.inH0 = new System.Windows.Forms.TextBox();
            this.H0Label = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.inEpsilon = new System.Windows.Forms.TextBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.inX0 = new System.Windows.Forms.TextBox();
            this.X0Label = new System.Windows.Forms.Label();
            this.FuncLabel = new System.Windows.Forms.Label();
            this.Calcs = new System.Windows.Forms.TextBox();
            this.inFx = new System.Windows.Forms.TextBox();
            this.maxCheckBox = new System.Windows.Forms.CheckBox();
            this.inKMax = new System.Windows.Forms.TextBox();
            this.KmaxLabel = new System.Windows.Forms.Label();
            this.MaxMinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(17, 342);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(342, 23);
            this.Reset_Btn.TabIndex = 43;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // OutAbsH0Label
            // 
            this.OutAbsH0Label.AutoSize = true;
            this.OutAbsH0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutAbsH0Label.Location = new System.Drawing.Point(171, 291);
            this.OutAbsH0Label.Name = "OutAbsH0Label";
            this.OutAbsH0Label.Size = new System.Drawing.Size(68, 18);
            this.OutAbsH0Label.TabIndex = 42;
            this.OutAbsH0Label.Text = "abs(H0)";
            // 
            // OutX1Label
            // 
            this.OutX1Label.AutoSize = true;
            this.OutX1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutX1Label.Location = new System.Drawing.Point(20, 293);
            this.OutX1Label.Name = "OutX1Label";
            this.OutX1Label.Size = new System.Drawing.Size(25, 18);
            this.OutX1Label.TabIndex = 41;
            this.OutX1Label.Text = "x1";
            // 
            // OutYf1Label
            // 
            this.OutYf1Label.AutoSize = true;
            this.OutYf1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutYf1Label.Location = new System.Drawing.Point(20, 320);
            this.OutYf1Label.Name = "OutYf1Label";
            this.OutYf1Label.Size = new System.Drawing.Size(32, 18);
            this.OutYf1Label.TabIndex = 40;
            this.OutYf1Label.Text = "Yf1";
            // 
            // outX1
            // 
            this.outX1.Enabled = false;
            this.outX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outX1.Location = new System.Drawing.Point(60, 290);
            this.outX1.Name = "outX1";
            this.outX1.Size = new System.Drawing.Size(105, 21);
            this.outX1.TabIndex = 39;
            // 
            // outYf1
            // 
            this.outYf1.Enabled = false;
            this.outYf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outYf1.Location = new System.Drawing.Point(60, 317);
            this.outYf1.Name = "outYf1";
            this.outYf1.Size = new System.Drawing.Size(105, 21);
            this.outYf1.TabIndex = 38;
            // 
            // outAbsH0
            // 
            this.outAbsH0.Enabled = false;
            this.outAbsH0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outAbsH0.Location = new System.Drawing.Point(171, 317);
            this.outAbsH0.Name = "outAbsH0";
            this.outAbsH0.Size = new System.Drawing.Size(105, 21);
            this.outAbsH0.TabIndex = 37;
            // 
            // minCheckBox
            // 
            this.minCheckBox.AutoSize = true;
            this.minCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCheckBox.Location = new System.Drawing.Point(258, 60);
            this.minCheckBox.Name = "minCheckBox";
            this.minCheckBox.Size = new System.Drawing.Size(54, 22);
            this.minCheckBox.TabIndex = 36;
            this.minCheckBox.Text = "Min";
            this.minCheckBox.UseVisualStyleBackColor = true;
            // 
            // inR
            // 
            this.inR.Location = new System.Drawing.Point(187, 36);
            this.inR.Name = "inR";
            this.inR.Size = new System.Drawing.Size(52, 20);
            this.inR.TabIndex = 35;
            this.inR.Text = "2";
            // 
            // inH0
            // 
            this.inH0.Location = new System.Drawing.Point(51, 37);
            this.inH0.Name = "inH0";
            this.inH0.Size = new System.Drawing.Size(103, 20);
            this.inH0.TabIndex = 34;
            this.inH0.Text = "0.2";
            // 
            // H0Label
            // 
            this.H0Label.AutoSize = true;
            this.H0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H0Label.Location = new System.Drawing.Point(13, 40);
            this.H0Label.Name = "H0Label";
            this.H0Label.Size = new System.Drawing.Size(34, 18);
            this.H0Label.TabIndex = 33;
            this.H0Label.Text = "H0:";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel.Location = new System.Drawing.Point(160, 37);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(25, 18);
            this.RLabel.TabIndex = 32;
            this.RLabel.Text = "R:";
            // 
            // inEpsilon
            // 
            this.inEpsilon.Location = new System.Drawing.Point(308, 7);
            this.inEpsilon.Name = "inEpsilon";
            this.inEpsilon.Size = new System.Drawing.Size(51, 20);
            this.inEpsilon.TabIndex = 31;
            this.inEpsilon.Text = "0.01";
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpsilonLabel.Location = new System.Drawing.Point(233, 8);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(69, 18);
            this.EpsilonLabel.TabIndex = 30;
            this.EpsilonLabel.Text = "Epsilon:";
            // 
            // Start_Btn
            // 
            this.Start_Btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(287, 290);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(72, 48);
            this.Start_Btn.TabIndex = 29;
            this.Start_Btn.Text = "Go";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // inX0
            // 
            this.inX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inX0.Location = new System.Drawing.Point(189, 7);
            this.inX0.Name = "inX0";
            this.inX0.Size = new System.Drawing.Size(38, 21);
            this.inX0.TabIndex = 28;
            this.inX0.Text = "-3";
            // 
            // X0Label
            // 
            this.X0Label.AutoSize = true;
            this.X0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0Label.Location = new System.Drawing.Point(162, 7);
            this.X0Label.Name = "X0Label";
            this.X0Label.Size = new System.Drawing.Size(30, 18);
            this.X0Label.TabIndex = 27;
            this.X0Label.Text = "x0:";
            // 
            // FuncLabel
            // 
            this.FuncLabel.AutoSize = true;
            this.FuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncLabel.Location = new System.Drawing.Point(12, 9);
            this.FuncLabel.Name = "FuncLabel";
            this.FuncLabel.Size = new System.Drawing.Size(33, 18);
            this.FuncLabel.TabIndex = 26;
            this.FuncLabel.Text = "f(x)";
            // 
            // Calcs
            // 
            this.Calcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcs.Location = new System.Drawing.Point(17, 85);
            this.Calcs.Multiline = true;
            this.Calcs.Name = "Calcs";
            this.Calcs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Calcs.Size = new System.Drawing.Size(342, 199);
            this.Calcs.TabIndex = 25;
            // 
            // inFx
            // 
            this.inFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFx.Location = new System.Drawing.Point(51, 6);
            this.inFx.Name = "inFx";
            this.inFx.Size = new System.Drawing.Size(105, 21);
            this.inFx.TabIndex = 24;
            this.inFx.Text = "x^3+x^2-8*x-8";
            // 
            // maxCheckBox
            // 
            this.maxCheckBox.AutoSize = true;
            this.maxCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCheckBox.Location = new System.Drawing.Point(189, 60);
            this.maxCheckBox.Name = "maxCheckBox";
            this.maxCheckBox.Size = new System.Drawing.Size(58, 22);
            this.maxCheckBox.TabIndex = 44;
            this.maxCheckBox.Text = "Max";
            this.maxCheckBox.UseVisualStyleBackColor = true;
            // 
            // inKMax
            // 
            this.inKMax.Location = new System.Drawing.Point(299, 33);
            this.inKMax.Name = "inKMax";
            this.inKMax.Size = new System.Drawing.Size(60, 20);
            this.inKMax.TabIndex = 46;
            this.inKMax.Text = "100";
            // 
            // KmaxLabel
            // 
            this.KmaxLabel.AutoSize = true;
            this.KmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmaxLabel.Location = new System.Drawing.Point(245, 36);
            this.KmaxLabel.Name = "KmaxLabel";
            this.KmaxLabel.Size = new System.Drawing.Size(48, 18);
            this.KmaxLabel.TabIndex = 45;
            this.KmaxLabel.Text = "kMax";
            // 
            // MaxMinLabel
            // 
            this.MaxMinLabel.AutoSize = true;
            this.MaxMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMinLabel.Location = new System.Drawing.Point(78, 60);
            this.MaxMinLabel.Name = "MaxMinLabel";
            this.MaxMinLabel.Size = new System.Drawing.Size(104, 18);
            this.MaxMinLabel.TabIndex = 47;
            this.MaxMinLabel.Text = "What to find:";
            // 
            // PSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 374);
            this.Controls.Add(this.MaxMinLabel);
            this.Controls.Add(this.inKMax);
            this.Controls.Add(this.KmaxLabel);
            this.Controls.Add(this.maxCheckBox);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.OutAbsH0Label);
            this.Controls.Add(this.OutX1Label);
            this.Controls.Add(this.OutYf1Label);
            this.Controls.Add(this.outX1);
            this.Controls.Add(this.outYf1);
            this.Controls.Add(this.outAbsH0);
            this.Controls.Add(this.minCheckBox);
            this.Controls.Add(this.inR);
            this.Controls.Add(this.inH0);
            this.Controls.Add(this.H0Label);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.inEpsilon);
            this.Controls.Add(this.EpsilonLabel);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.inX0);
            this.Controls.Add(this.X0Label);
            this.Controls.Add(this.FuncLabel);
            this.Controls.Add(this.Calcs);
            this.Controls.Add(this.inFx);
            this.Name = "PSM";
            this.Text = "PSM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Label OutAbsH0Label;
        private System.Windows.Forms.Label OutX1Label;
        private System.Windows.Forms.Label OutYf1Label;
        private System.Windows.Forms.TextBox outX1;
        private System.Windows.Forms.TextBox outYf1;
        private System.Windows.Forms.TextBox outAbsH0;
        private System.Windows.Forms.CheckBox minCheckBox;
        private System.Windows.Forms.TextBox inR;
        private System.Windows.Forms.TextBox inH0;
        private System.Windows.Forms.Label H0Label;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.TextBox inEpsilon;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.TextBox inX0;
        private System.Windows.Forms.Label X0Label;
        private System.Windows.Forms.Label FuncLabel;
        private System.Windows.Forms.TextBox Calcs;
        private System.Windows.Forms.TextBox inFx;
        private System.Windows.Forms.CheckBox maxCheckBox;
        private System.Windows.Forms.TextBox inKMax;
        private System.Windows.Forms.Label KmaxLabel;
        private System.Windows.Forms.Label MaxMinLabel;
    }
}