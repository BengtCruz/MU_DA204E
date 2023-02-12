namespace SuperCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bmiBox = new System.Windows.Forms.GroupBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightIn = new System.Windows.Forms.TextBox();
            this.heightIn = new System.Windows.Forms.TextBox();
            this.nameIn = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.unitBox = new System.Windows.Forms.GroupBox();
            this.imperialBtn = new System.Windows.Forms.RadioButton();
            this.metricBtn = new System.Windows.Forms.RadioButton();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.normalWeightOut = new System.Windows.Forms.Label();
            this.normalBmiOut = new System.Windows.Forms.Label();
            this.weightCatOut = new System.Windows.Forms.Label();
            this.weightCatLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.bmiOut = new System.Windows.Forms.Label();
            this.bmiBox.SuspendLayout();
            this.unitBox.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiBox
            // 
            this.bmiBox.Controls.Add(this.weightLabel);
            this.bmiBox.Controls.Add(this.heightLabel);
            this.bmiBox.Controls.Add(this.nameLabel);
            this.bmiBox.Controls.Add(this.weightIn);
            this.bmiBox.Controls.Add(this.heightIn);
            this.bmiBox.Controls.Add(this.nameIn);
            this.bmiBox.Controls.Add(this.calcBtn);
            this.bmiBox.Controls.Add(this.unitBox);
            this.bmiBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bmiBox.Location = new System.Drawing.Point(29, 27);
            this.bmiBox.Name = "bmiBox";
            this.bmiBox.Size = new System.Drawing.Size(481, 199);
            this.bmiBox.TabIndex = 0;
            this.bmiBox.TabStop = false;
            this.bmiBox.Text = "BMI Calculator";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 106);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(47, 14);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 77);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 14);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 14);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // weightIn
            // 
            this.weightIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightIn.Location = new System.Drawing.Point(177, 98);
            this.weightIn.Name = "weightIn";
            this.weightIn.Size = new System.Drawing.Size(100, 22);
            this.weightIn.TabIndex = 4;
            // 
            // heightIn
            // 
            this.heightIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightIn.Location = new System.Drawing.Point(177, 69);
            this.heightIn.Name = "heightIn";
            this.heightIn.Size = new System.Drawing.Size(100, 22);
            this.heightIn.TabIndex = 3;
            // 
            // nameIn
            // 
            this.nameIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameIn.Location = new System.Drawing.Point(69, 40);
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(208, 22);
            this.nameIn.TabIndex = 2;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(122, 170);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(226, 23);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // unitBox
            // 
            this.unitBox.Controls.Add(this.imperialBtn);
            this.unitBox.Controls.Add(this.metricBtn);
            this.unitBox.Location = new System.Drawing.Point(298, 40);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(144, 84);
            this.unitBox.TabIndex = 0;
            this.unitBox.TabStop = false;
            this.unitBox.Text = "Unit";
            // 
            // imperialBtn
            // 
            this.imperialBtn.AutoSize = true;
            this.imperialBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imperialBtn.Location = new System.Drawing.Point(6, 45);
            this.imperialBtn.Name = "imperialBtn";
            this.imperialBtn.Size = new System.Drawing.Size(124, 18);
            this.imperialBtn.TabIndex = 1;
            this.imperialBtn.Text = "Imperial (ft, lbs)";
            this.imperialBtn.UseVisualStyleBackColor = true;
            this.imperialBtn.Click += new System.EventHandler(this.imperial_click);
            // 
            // metricBtn
            // 
            this.metricBtn.AutoSize = true;
            this.metricBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metricBtn.Location = new System.Drawing.Point(6, 21);
            this.metricBtn.Name = "metricBtn";
            this.metricBtn.Size = new System.Drawing.Size(117, 18);
            this.metricBtn.TabIndex = 0;
            this.metricBtn.Text = "Metric (cm, kg)";
            this.metricBtn.UseVisualStyleBackColor = true;
            this.metricBtn.Click += new System.EventHandler(this.metric_click);
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.normalWeightOut);
            this.resultBox.Controls.Add(this.normalBmiOut);
            this.resultBox.Controls.Add(this.weightCatOut);
            this.resultBox.Controls.Add(this.weightCatLabel);
            this.resultBox.Controls.Add(this.bmiLabel);
            this.resultBox.Controls.Add(this.bmiOut);
            this.resultBox.Location = new System.Drawing.Point(29, 247);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(481, 191);
            this.resultBox.TabIndex = 1;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Results";
            // 
            // normalWeightOut
            // 
            this.normalWeightOut.AutoSize = true;
            this.normalWeightOut.Location = new System.Drawing.Point(203, 157);
            this.normalWeightOut.Name = "normalWeightOut";
            this.normalWeightOut.Size = new System.Drawing.Size(38, 15);
            this.normalWeightOut.TabIndex = 7;
            this.normalWeightOut.Text = "label2";
            // 
            // normalBmiOut
            // 
            this.normalBmiOut.AutoSize = true;
            this.normalBmiOut.Location = new System.Drawing.Point(203, 132);
            this.normalBmiOut.Name = "normalBmiOut";
            this.normalBmiOut.Size = new System.Drawing.Size(38, 15);
            this.normalBmiOut.TabIndex = 6;
            this.normalBmiOut.Text = "label1";
            // 
            // weightCatOut
            // 
            this.weightCatOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightCatOut.Location = new System.Drawing.Point(220, 91);
            this.weightCatOut.Name = "weightCatOut";
            this.weightCatOut.Size = new System.Drawing.Size(222, 23);
            this.weightCatOut.TabIndex = 5;
            // 
            // weightCatLabel
            // 
            this.weightCatLabel.AutoSize = true;
            this.weightCatLabel.Location = new System.Drawing.Point(17, 99);
            this.weightCatLabel.Name = "weightCatLabel";
            this.weightCatLabel.Size = new System.Drawing.Size(96, 15);
            this.weightCatLabel.TabIndex = 2;
            this.weightCatLabel.Text = "Weight Category";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(17, 52);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(28, 15);
            this.bmiLabel.TabIndex = 1;
            this.bmiLabel.Text = "BMI";
            // 
            // bmiOut
            // 
            this.bmiOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiOut.Location = new System.Drawing.Point(342, 44);
            this.bmiOut.Name = "bmiOut";
            this.bmiOut.Size = new System.Drawing.Size(100, 23);
            this.bmiOut.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.bmiBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculator by Bengt Svedling Cruz";
            this.bmiBox.ResumeLayout(false);
            this.bmiBox.PerformLayout();
            this.unitBox.ResumeLayout(false);
            this.unitBox.PerformLayout();
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox bmiBox;
        private GroupBox unitBox;
        private RadioButton imperialBtn;
        private RadioButton metricBtn;
        private Button calcBtn;
        private Label weightLabel;
        private Label heightLabel;
        private Label nameLabel;
        private TextBox weightIn;
        private TextBox heightIn;
        private TextBox nameIn;
        private GroupBox resultBox;
        private Label bmiOut;
        private Label weightCatOut;
        private Label weightCatLabel;
        private Label bmiLabel;
        private Label normalWeightOut;
        private Label normalBmiOut;
    }
}