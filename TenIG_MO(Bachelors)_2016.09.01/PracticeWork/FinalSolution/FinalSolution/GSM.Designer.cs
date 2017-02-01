namespace FinalSolution
{
    partial class GSM
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
            this.minCheckBox = new System.Windows.Forms.CheckBox();
            this.OutAbsBALabel = new System.Windows.Forms.Label();
            this.outAbsBA = new System.Windows.Forms.TextBox();
            this.OutX1Label = new System.Windows.Forms.Label();
            this.OutYLabel = new System.Windows.Forms.Label();
            this.outX1 = new System.Windows.Forms.TextBox();
            this.SolY = new System.Windows.Forms.TextBox();
            this.InBLabel = new System.Windows.Forms.Label();
            this.InA = new System.Windows.Forms.TextBox();
            this.InALabel = new System.Windows.Forms.Label();
            this.FuncLabel = new System.Windows.Forms.Label();
            this.Calcs = new System.Windows.Forms.TextBox();
            this.InFx = new System.Windows.Forms.TextBox();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.InTol = new System.Windows.Forms.TextBox();
            this.InTolLabel = new System.Windows.Forms.Label();
            this.InB = new System.Windows.Forms.TextBox();
            this.maxCheckBox = new System.Windows.Forms.CheckBox();
            this.InKMax = new System.Windows.Forms.TextBox();
            this.InKMaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(13, 349);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(419, 23);
            this.Reset_Btn.TabIndex = 51;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // minCheckBox
            // 
            this.minCheckBox.AutoSize = true;
            this.minCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCheckBox.Location = new System.Drawing.Point(380, 16);
            this.minCheckBox.Name = "minCheckBox";
            this.minCheckBox.Size = new System.Drawing.Size(54, 22);
            this.minCheckBox.TabIndex = 50;
            this.minCheckBox.Text = "Min";
            this.minCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutAbsBALabel
            // 
            this.OutAbsBALabel.AutoSize = true;
            this.OutAbsBALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutAbsBALabel.Location = new System.Drawing.Point(12, 328);
            this.OutAbsBALabel.Name = "OutAbsBALabel";
            this.OutAbsBALabel.Size = new System.Drawing.Size(71, 18);
            this.OutAbsBALabel.TabIndex = 49;
            this.OutAbsBALabel.Text = "abs(b-a)";
            // 
            // outAbsBA
            // 
            this.outAbsBA.Enabled = false;
            this.outAbsBA.Location = new System.Drawing.Point(89, 327);
            this.outAbsBA.Name = "outAbsBA";
            this.outAbsBA.Size = new System.Drawing.Size(174, 20);
            this.outAbsBA.TabIndex = 48;
            // 
            // OutX1Label
            // 
            this.OutX1Label.AutoSize = true;
            this.OutX1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutX1Label.Location = new System.Drawing.Point(13, 301);
            this.OutX1Label.Name = "OutX1Label";
            this.OutX1Label.Size = new System.Drawing.Size(25, 18);
            this.OutX1Label.TabIndex = 47;
            this.OutX1Label.Text = "x1";
            // 
            // OutYLabel
            // 
            this.OutYLabel.AutoSize = true;
            this.OutYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutYLabel.Location = new System.Drawing.Point(13, 274);
            this.OutYLabel.Name = "OutYLabel";
            this.OutYLabel.Size = new System.Drawing.Size(18, 18);
            this.OutYLabel.TabIndex = 46;
            this.OutYLabel.Text = "Y";
            // 
            // outX1
            // 
            this.outX1.Enabled = false;
            this.outX1.Location = new System.Drawing.Point(44, 302);
            this.outX1.Name = "outX1";
            this.outX1.Size = new System.Drawing.Size(219, 20);
            this.outX1.TabIndex = 45;
            // 
            // SolY
            // 
            this.SolY.Enabled = false;
            this.SolY.Location = new System.Drawing.Point(44, 277);
            this.SolY.Name = "SolY";
            this.SolY.Size = new System.Drawing.Size(219, 20);
            this.SolY.TabIndex = 44;
            // 
            // InBLabel
            // 
            this.InBLabel.AutoSize = true;
            this.InBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBLabel.Location = new System.Drawing.Point(247, 17);
            this.InBLabel.Name = "InBLabel";
            this.InBLabel.Size = new System.Drawing.Size(17, 18);
            this.InBLabel.TabIndex = 42;
            this.InBLabel.Text = "b";
            // 
            // InA
            // 
            this.InA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InA.Location = new System.Drawing.Point(195, 16);
            this.InA.Name = "InA";
            this.InA.Size = new System.Drawing.Size(46, 21);
            this.InA.TabIndex = 41;
            this.InA.Text = "-4";
            // 
            // InALabel
            // 
            this.InALabel.AutoSize = true;
            this.InALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InALabel.Location = new System.Drawing.Point(172, 16);
            this.InALabel.Name = "InALabel";
            this.InALabel.Size = new System.Drawing.Size(17, 18);
            this.InALabel.TabIndex = 40;
            this.InALabel.Text = "a";
            // 
            // FuncLabel
            // 
            this.FuncLabel.AutoSize = true;
            this.FuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncLabel.Location = new System.Drawing.Point(12, 18);
            this.FuncLabel.Name = "FuncLabel";
            this.FuncLabel.Size = new System.Drawing.Size(33, 18);
            this.FuncLabel.TabIndex = 39;
            this.FuncLabel.Text = "f(x)";
            // 
            // Calcs
            // 
            this.Calcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcs.Location = new System.Drawing.Point(17, 65);
            this.Calcs.Multiline = true;
            this.Calcs.Name = "Calcs";
            this.Calcs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Calcs.Size = new System.Drawing.Size(415, 201);
            this.Calcs.TabIndex = 38;
            // 
            // InFx
            // 
            this.InFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InFx.Location = new System.Drawing.Point(51, 15);
            this.InFx.Name = "InFx";
            this.InFx.Size = new System.Drawing.Size(115, 21);
            this.InFx.TabIndex = 37;
            this.InFx.Text = "x^3+x^2-8*x-8";
            // 
            // Start_Btn
            // 
            this.Start_Btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(269, 277);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(163, 69);
            this.Start_Btn.TabIndex = 36;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // InTol
            // 
            this.InTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTol.Location = new System.Drawing.Point(51, 42);
            this.InTol.Name = "InTol";
            this.InTol.Size = new System.Drawing.Size(141, 21);
            this.InTol.TabIndex = 52;
            this.InTol.Text = "0.000000001";
            // 
            // InTolLabel
            // 
            this.InTolLabel.AutoSize = true;
            this.InTolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTolLabel.Location = new System.Drawing.Point(14, 44);
            this.InTolLabel.Name = "InTolLabel";
            this.InTolLabel.Size = new System.Drawing.Size(27, 18);
            this.InTolLabel.TabIndex = 53;
            this.InTolLabel.Text = "tol";
            // 
            // InB
            // 
            this.InB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InB.Location = new System.Drawing.Point(269, 16);
            this.InB.Name = "InB";
            this.InB.Size = new System.Drawing.Size(46, 21);
            this.InB.TabIndex = 54;
            this.InB.Text = "2";
            // 
            // maxCheckBox
            // 
            this.maxCheckBox.AutoSize = true;
            this.maxCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCheckBox.Location = new System.Drawing.Point(320, 17);
            this.maxCheckBox.Name = "maxCheckBox";
            this.maxCheckBox.Size = new System.Drawing.Size(58, 22);
            this.maxCheckBox.TabIndex = 55;
            this.maxCheckBox.Text = "Max";
            this.maxCheckBox.UseVisualStyleBackColor = true;
            // 
            // InKMax
            // 
            this.InKMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InKMax.Location = new System.Drawing.Point(269, 42);
            this.InKMax.Name = "InKMax";
            this.InKMax.Size = new System.Drawing.Size(46, 21);
            this.InKMax.TabIndex = 57;
            this.InKMax.Text = "100";
            // 
            // InKMaxLabel
            // 
            this.InKMaxLabel.AutoSize = true;
            this.InKMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InKMaxLabel.Location = new System.Drawing.Point(218, 43);
            this.InKMaxLabel.Name = "InKMaxLabel";
            this.InKMaxLabel.Size = new System.Drawing.Size(48, 18);
            this.InKMaxLabel.TabIndex = 56;
            this.InKMaxLabel.Text = "kMax";
            // 
            // GSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 382);
            this.Controls.Add(this.InKMax);
            this.Controls.Add(this.InKMaxLabel);
            this.Controls.Add(this.maxCheckBox);
            this.Controls.Add(this.InB);
            this.Controls.Add(this.InTolLabel);
            this.Controls.Add(this.InTol);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.minCheckBox);
            this.Controls.Add(this.OutAbsBALabel);
            this.Controls.Add(this.outAbsBA);
            this.Controls.Add(this.OutX1Label);
            this.Controls.Add(this.OutYLabel);
            this.Controls.Add(this.outX1);
            this.Controls.Add(this.SolY);
            this.Controls.Add(this.InBLabel);
            this.Controls.Add(this.InA);
            this.Controls.Add(this.InALabel);
            this.Controls.Add(this.FuncLabel);
            this.Controls.Add(this.Calcs);
            this.Controls.Add(this.InFx);
            this.Controls.Add(this.Start_Btn);
            this.Name = "GSM";
            this.Text = "GSM";
            this.Load += new System.EventHandler(this.GSM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.CheckBox minCheckBox;
        private System.Windows.Forms.Label OutAbsBALabel;
        private System.Windows.Forms.TextBox outAbsBA;
        private System.Windows.Forms.Label OutX1Label;
        private System.Windows.Forms.Label OutYLabel;
        private System.Windows.Forms.TextBox outX1;
        private System.Windows.Forms.TextBox SolY;
        private System.Windows.Forms.Label InBLabel;
        private System.Windows.Forms.TextBox InA;
        private System.Windows.Forms.Label InALabel;
        private System.Windows.Forms.Label FuncLabel;
        private System.Windows.Forms.TextBox Calcs;
        private System.Windows.Forms.TextBox InFx;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.TextBox InTol;
        private System.Windows.Forms.Label InTolLabel;
        private System.Windows.Forms.TextBox InB;
        private System.Windows.Forms.CheckBox maxCheckBox;
        private System.Windows.Forms.TextBox InKMax;
        private System.Windows.Forms.Label InKMaxLabel;
    }
}