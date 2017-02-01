namespace FinalSolution
{
    partial class NSM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetBtn = new System.Windows.Forms.Button();
            this.OutX1Label = new System.Windows.Forms.Label();
            this.outYf1 = new System.Windows.Forms.TextBox();
            this.inR = new System.Windows.Forms.TextBox();
            this.inDelta = new System.Windows.Forms.TextBox();
            this.inEpsilon = new System.Windows.Forms.TextBox();
            this.inX0 = new System.Windows.Forms.TextBox();
            this.inFx = new System.Windows.Forms.TextBox();
            this.Calcs = new System.Windows.Forms.TextBox();
            this.InFxLabel = new System.Windows.Forms.Label();
            this.OutRelErrorLabel = new System.Windows.Forms.Label();
            this.OutFx1Label = new System.Windows.Forms.Label();
            this.InEpsilonLabel = new System.Windows.Forms.Label();
            this.InRLabel = new System.Windows.Forms.Label();
            this.InX0Label = new System.Windows.Forms.Label();
            this.InDeltaLabel = new System.Windows.Forms.Label();
            this.NoutX1 = new System.Windows.Forms.TextBox();
            this.OutKLabel = new System.Windows.Forms.Label();
            this.outK = new System.Windows.Forms.TextBox();
            this.outRelError = new System.Windows.Forms.TextBox();
            this.outCond = new System.Windows.Forms.TextBox();
            this.OutCondLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InKMaxLabel = new System.Windows.Forms.Label();
            this.InKMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 420);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(350, 23);
            this.ResetBtn.TabIndex = 63;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // OutX1Label
            // 
            this.OutX1Label.AutoSize = true;
            this.OutX1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutX1Label.Location = new System.Drawing.Point(13, 332);
            this.OutX1Label.Name = "OutX1Label";
            this.OutX1Label.Size = new System.Drawing.Size(25, 18);
            this.OutX1Label.TabIndex = 62;
            this.OutX1Label.Text = "x1";
            // 
            // outYf1
            // 
            this.outYf1.Enabled = false;
            this.outYf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outYf1.Location = new System.Drawing.Point(63, 358);
            this.outYf1.Name = "outYf1";
            this.outYf1.Size = new System.Drawing.Size(299, 21);
            this.outYf1.TabIndex = 58;
            // 
            // inR
            // 
            this.inR.Location = new System.Drawing.Point(192, 38);
            this.inR.Name = "inR";
            this.inR.Size = new System.Drawing.Size(39, 20);
            this.inR.TabIndex = 55;
            this.inR.Text = "4";
            // 
            // inDelta
            // 
            this.inDelta.Location = new System.Drawing.Point(55, 39);
            this.inDelta.Name = "inDelta";
            this.inDelta.Size = new System.Drawing.Size(103, 20);
            this.inDelta.TabIndex = 54;
            this.inDelta.Text = " 0.00001";
            // 
            // inEpsilon
            // 
            this.inEpsilon.Location = new System.Drawing.Point(311, 10);
            this.inEpsilon.Name = "inEpsilon";
            this.inEpsilon.Size = new System.Drawing.Size(51, 20);
            this.inEpsilon.TabIndex = 51;
            this.inEpsilon.Text = "0.01";
            // 
            // inX0
            // 
            this.inX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inX0.Location = new System.Drawing.Point(192, 10);
            this.inX0.Name = "inX0";
            this.inX0.Size = new System.Drawing.Size(38, 21);
            this.inX0.TabIndex = 48;
            this.inX0.Text = "-3";
            // 
            // inFx
            // 
            this.inFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFx.Location = new System.Drawing.Point(54, 9);
            this.inFx.Name = "inFx";
            this.inFx.Size = new System.Drawing.Size(105, 21);
            this.inFx.TabIndex = 44;
            this.inFx.Text = "x^3+x^2-8*x-8";
            // 
            // Calcs
            // 
            this.Calcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcs.Location = new System.Drawing.Point(13, 101);
            this.Calcs.Multiline = true;
            this.Calcs.Name = "Calcs";
            this.Calcs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Calcs.Size = new System.Drawing.Size(349, 228);
            this.Calcs.TabIndex = 64;
            // 
            // InFxLabel
            // 
            this.InFxLabel.AutoSize = true;
            this.InFxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InFxLabel.Location = new System.Drawing.Point(13, 10);
            this.InFxLabel.Name = "InFxLabel";
            this.InFxLabel.Size = new System.Drawing.Size(32, 15);
            this.InFxLabel.TabIndex = 65;
            this.InFxLabel.Text = "F(x)";
            // 
            // OutRelErrorLabel
            // 
            this.OutRelErrorLabel.AutoSize = true;
            this.OutRelErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutRelErrorLabel.Location = new System.Drawing.Point(13, 386);
            this.OutRelErrorLabel.Name = "OutRelErrorLabel";
            this.OutRelErrorLabel.Size = new System.Drawing.Size(61, 15);
            this.OutRelErrorLabel.TabIndex = 66;
            this.OutRelErrorLabel.Text = "RelError";
            // 
            // OutFx1Label
            // 
            this.OutFx1Label.AutoSize = true;
            this.OutFx1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutFx1Label.Location = new System.Drawing.Point(12, 358);
            this.OutFx1Label.Name = "OutFx1Label";
            this.OutFx1Label.Size = new System.Drawing.Size(40, 15);
            this.OutFx1Label.TabIndex = 67;
            this.OutFx1Label.Text = "F(x1)";
            // 
            // InEpsilonLabel
            // 
            this.InEpsilonLabel.AutoSize = true;
            this.InEpsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InEpsilonLabel.Location = new System.Drawing.Point(244, 9);
            this.InEpsilonLabel.Name = "InEpsilonLabel";
            this.InEpsilonLabel.Size = new System.Drawing.Size(55, 15);
            this.InEpsilonLabel.TabIndex = 68;
            this.InEpsilonLabel.Text = "Epsilon";
            // 
            // InRLabel
            // 
            this.InRLabel.AutoSize = true;
            this.InRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InRLabel.Location = new System.Drawing.Point(164, 40);
            this.InRLabel.Name = "InRLabel";
            this.InRLabel.Size = new System.Drawing.Size(17, 15);
            this.InRLabel.TabIndex = 69;
            this.InRLabel.Text = "R";
            // 
            // InX0Label
            // 
            this.InX0Label.AutoSize = true;
            this.InX0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InX0Label.Location = new System.Drawing.Point(165, 12);
            this.InX0Label.Name = "InX0Label";
            this.InX0Label.Size = new System.Drawing.Size(22, 15);
            this.InX0Label.TabIndex = 70;
            this.InX0Label.Text = "x0";
            // 
            // InDeltaLabel
            // 
            this.InDeltaLabel.AutoSize = true;
            this.InDeltaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDeltaLabel.Location = new System.Drawing.Point(12, 40);
            this.InDeltaLabel.Name = "InDeltaLabel";
            this.InDeltaLabel.Size = new System.Drawing.Size(41, 15);
            this.InDeltaLabel.TabIndex = 71;
            this.InDeltaLabel.Text = "Delta";
            // 
            // NoutX1
            // 
            this.NoutX1.Enabled = false;
            this.NoutX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoutX1.Location = new System.Drawing.Point(63, 332);
            this.NoutX1.Name = "NoutX1";
            this.NoutX1.Size = new System.Drawing.Size(200, 21);
            this.NoutX1.TabIndex = 72;
            // 
            // OutKLabel
            // 
            this.OutKLabel.AutoSize = true;
            this.OutKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutKLabel.Location = new System.Drawing.Point(269, 335);
            this.OutKLabel.Name = "OutKLabel";
            this.OutKLabel.Size = new System.Drawing.Size(17, 18);
            this.OutKLabel.TabIndex = 73;
            this.OutKLabel.Text = "k";
            // 
            // outK
            // 
            this.outK.Enabled = false;
            this.outK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outK.Location = new System.Drawing.Point(292, 332);
            this.outK.Name = "outK";
            this.outK.Size = new System.Drawing.Size(70, 21);
            this.outK.TabIndex = 74;
            // 
            // outRelError
            // 
            this.outRelError.Enabled = false;
            this.outRelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outRelError.Location = new System.Drawing.Point(80, 385);
            this.outRelError.Name = "outRelError";
            this.outRelError.Size = new System.Drawing.Size(150, 21);
            this.outRelError.TabIndex = 75;
            // 
            // outCond
            // 
            this.outCond.Enabled = false;
            this.outCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outCond.Location = new System.Drawing.Point(287, 385);
            this.outCond.Name = "outCond";
            this.outCond.Size = new System.Drawing.Size(75, 21);
            this.outCond.TabIndex = 77;
            // 
            // OutCondLabel
            // 
            this.OutCondLabel.AutoSize = true;
            this.OutCondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutCondLabel.Location = new System.Drawing.Point(236, 388);
            this.OutCondLabel.Name = "OutCondLabel";
            this.OutCondLabel.Size = new System.Drawing.Size(45, 18);
            this.OutCondLabel.TabIndex = 76;
            this.OutCondLabel.Text = "cond";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(13, 66);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(350, 29);
            this.StartBtn.TabIndex = 79;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InKMaxLabel
            // 
            this.InKMaxLabel.AutoSize = true;
            this.InKMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InKMaxLabel.Location = new System.Drawing.Point(243, 38);
            this.InKMaxLabel.Name = "InKMaxLabel";
            this.InKMaxLabel.Size = new System.Drawing.Size(49, 15);
            this.InKMaxLabel.TabIndex = 81;
            this.InKMaxLabel.Text = "k_Max";
            // 
            // InKMax
            // 
            this.InKMax.Location = new System.Drawing.Point(312, 37);
            this.InKMax.Name = "InKMax";
            this.InKMax.Size = new System.Drawing.Size(50, 20);
            this.InKMax.TabIndex = 80;
            this.InKMax.Text = "100";
            // 
            // NSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 454);
            this.Controls.Add(this.InKMaxLabel);
            this.Controls.Add(this.InKMax);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.outCond);
            this.Controls.Add(this.OutCondLabel);
            this.Controls.Add(this.outRelError);
            this.Controls.Add(this.outK);
            this.Controls.Add(this.OutKLabel);
            this.Controls.Add(this.NoutX1);
            this.Controls.Add(this.InDeltaLabel);
            this.Controls.Add(this.InX0Label);
            this.Controls.Add(this.InRLabel);
            this.Controls.Add(this.InEpsilonLabel);
            this.Controls.Add(this.OutFx1Label);
            this.Controls.Add(this.OutRelErrorLabel);
            this.Controls.Add(this.InFxLabel);
            this.Controls.Add(this.Calcs);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.OutX1Label);
            this.Controls.Add(this.outYf1);
            this.Controls.Add(this.inR);
            this.Controls.Add(this.inDelta);
            this.Controls.Add(this.inEpsilon);
            this.Controls.Add(this.inX0);
            this.Controls.Add(this.inFx);
            this.Name = "NSM";
            this.Text = "NSM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label OutX1Label;
        private System.Windows.Forms.TextBox outYf1;
        private System.Windows.Forms.TextBox inR;
        private System.Windows.Forms.TextBox inDelta;
        private System.Windows.Forms.TextBox inEpsilon;
        private System.Windows.Forms.TextBox inX0;
        private System.Windows.Forms.TextBox inFx;
        private System.Windows.Forms.TextBox Calcs;
        private System.Windows.Forms.Label InFxLabel;
        private System.Windows.Forms.Label OutRelErrorLabel;
        private System.Windows.Forms.Label OutFx1Label;
        private System.Windows.Forms.Label InEpsilonLabel;
        private System.Windows.Forms.Label InRLabel;
        private System.Windows.Forms.Label InX0Label;
        private System.Windows.Forms.Label InDeltaLabel;
        private System.Windows.Forms.TextBox NoutX1;
        private System.Windows.Forms.Label OutKLabel;
        private System.Windows.Forms.TextBox outK;
        private System.Windows.Forms.TextBox outRelError;
        private System.Windows.Forms.TextBox outCond;
        private System.Windows.Forms.Label OutCondLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label InKMaxLabel;
        private System.Windows.Forms.TextBox InKMax;
    }
}