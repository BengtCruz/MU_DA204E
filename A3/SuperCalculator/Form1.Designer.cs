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
            this.ftBox = new System.Windows.Forms.TextBox();
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
            this.savingPlanBox = new System.Windows.Forms.GroupBox();
            this.feesIn = new System.Windows.Forms.TextBox();
            this.feesLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.interestIn = new System.Windows.Forms.TextBox();
            this.initialDepositIn = new System.Windows.Forms.TextBox();
            this.initialDepositLabel = new System.Windows.Forms.Label();
            this.futureValueBox = new System.Windows.Forms.GroupBox();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.totalFeesOut = new System.Windows.Forms.Label();
            this.totalEarnedOut = new System.Windows.Forms.Label();
            this.totalEarnedLabel = new System.Windows.Forms.Label();
            this.finalBalanceOut = new System.Windows.Forms.Label();
            this.totalDepositOut = new System.Windows.Forms.Label();
            this.finalBalanceLabel = new System.Windows.Forms.Label();
            this.amountPayedLabel = new System.Windows.Forms.Label();
            this.calculateSaving = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.periodIn = new System.Windows.Forms.TextBox();
            this.depositIn = new System.Windows.Forms.TextBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.monthlyLabel = new System.Windows.Forms.Label();
            this.bmiBox.SuspendLayout();
            this.unitBox.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.savingPlanBox.SuspendLayout();
            this.futureValueBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiBox
            // 
            this.bmiBox.Controls.Add(this.ftBox);
            this.bmiBox.Controls.Add(this.weightLabel);
            this.bmiBox.Controls.Add(this.heightLabel);
            this.bmiBox.Controls.Add(this.nameLabel);
            this.bmiBox.Controls.Add(this.weightIn);
            this.bmiBox.Controls.Add(this.heightIn);
            this.bmiBox.Controls.Add(this.nameIn);
            this.bmiBox.Controls.Add(this.calcBtn);
            this.bmiBox.Controls.Add(this.unitBox);
            this.bmiBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bmiBox.Location = new System.Drawing.Point(54, 58);
            this.bmiBox.Margin = new System.Windows.Forms.Padding(6);
            this.bmiBox.Name = "bmiBox";
            this.bmiBox.Padding = new System.Windows.Forms.Padding(6);
            this.bmiBox.Size = new System.Drawing.Size(893, 425);
            this.bmiBox.TabIndex = 0;
            this.bmiBox.TabStop = false;
            this.bmiBox.Text = "BMI Calculator";
            // 
            // ftBox
            // 
            this.ftBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ftBox.Location = new System.Drawing.Point(243, 147);
            this.ftBox.Margin = new System.Windows.Forms.Padding(6);
            this.ftBox.Name = "ftBox";
            this.ftBox.Size = new System.Drawing.Size(121, 36);
            this.ftBox.TabIndex = 8;
            this.ftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(11, 213);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(87, 29);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(11, 151);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 29);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 90);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 29);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // weightIn
            // 
            this.weightIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightIn.Location = new System.Drawing.Point(377, 209);
            this.weightIn.Margin = new System.Windows.Forms.Padding(6);
            this.weightIn.Name = "weightIn";
            this.weightIn.Size = new System.Drawing.Size(136, 36);
            this.weightIn.TabIndex = 4;
            this.weightIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightIn
            // 
            this.heightIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightIn.Location = new System.Drawing.Point(377, 147);
            this.heightIn.Margin = new System.Windows.Forms.Padding(6);
            this.heightIn.Name = "heightIn";
            this.heightIn.Size = new System.Drawing.Size(136, 36);
            this.heightIn.TabIndex = 3;
            this.heightIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameIn
            // 
            this.nameIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameIn.Location = new System.Drawing.Point(128, 85);
            this.nameIn.Margin = new System.Windows.Forms.Padding(6);
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(385, 36);
            this.nameIn.TabIndex = 2;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(243, 322);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(6);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(420, 49);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // unitBox
            // 
            this.unitBox.Controls.Add(this.imperialBtn);
            this.unitBox.Controls.Add(this.metricBtn);
            this.unitBox.Location = new System.Drawing.Point(553, 85);
            this.unitBox.Margin = new System.Windows.Forms.Padding(6);
            this.unitBox.Name = "unitBox";
            this.unitBox.Padding = new System.Windows.Forms.Padding(6);
            this.unitBox.Size = new System.Drawing.Size(267, 179);
            this.unitBox.TabIndex = 0;
            this.unitBox.TabStop = false;
            this.unitBox.Text = "Unit";
            // 
            // imperialBtn
            // 
            this.imperialBtn.AutoSize = true;
            this.imperialBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imperialBtn.Location = new System.Drawing.Point(11, 96);
            this.imperialBtn.Margin = new System.Windows.Forms.Padding(6);
            this.imperialBtn.Name = "imperialBtn";
            this.imperialBtn.Size = new System.Drawing.Size(243, 33);
            this.imperialBtn.TabIndex = 1;
            this.imperialBtn.Text = "Imperial (ft, lbs)";
            this.imperialBtn.UseVisualStyleBackColor = true;
            this.imperialBtn.Click += new System.EventHandler(this.imperial_click);
            // 
            // metricBtn
            // 
            this.metricBtn.AutoSize = true;
            this.metricBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metricBtn.Location = new System.Drawing.Point(11, 45);
            this.metricBtn.Margin = new System.Windows.Forms.Padding(6);
            this.metricBtn.Name = "metricBtn";
            this.metricBtn.Size = new System.Drawing.Size(228, 33);
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
            this.resultBox.Location = new System.Drawing.Point(54, 527);
            this.resultBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultBox.Name = "resultBox";
            this.resultBox.Padding = new System.Windows.Forms.Padding(6);
            this.resultBox.Size = new System.Drawing.Size(893, 459);
            this.resultBox.TabIndex = 1;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Results";
            // 
            // normalWeightOut
            // 
            this.normalWeightOut.Location = new System.Drawing.Point(128, 380);
            this.normalWeightOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.normalWeightOut.Name = "normalWeightOut";
            this.normalWeightOut.Size = new System.Drawing.Size(654, 45);
            this.normalWeightOut.TabIndex = 7;
            this.normalWeightOut.Text = "label2";
            this.normalWeightOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalBmiOut
            // 
            this.normalBmiOut.Location = new System.Drawing.Point(201, 305);
            this.normalBmiOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.normalBmiOut.Name = "normalBmiOut";
            this.normalBmiOut.Size = new System.Drawing.Size(511, 45);
            this.normalBmiOut.TabIndex = 6;
            this.normalBmiOut.Text = "label1";
            this.normalBmiOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightCatOut
            // 
            this.weightCatOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightCatOut.Location = new System.Drawing.Point(409, 194);
            this.weightCatOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weightCatOut.Name = "weightCatOut";
            this.weightCatOut.Size = new System.Drawing.Size(412, 49);
            this.weightCatOut.TabIndex = 5;
            this.weightCatOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightCatLabel
            // 
            this.weightCatLabel.AutoSize = true;
            this.weightCatLabel.Location = new System.Drawing.Point(30, 203);
            this.weightCatLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weightCatLabel.Name = "weightCatLabel";
            this.weightCatLabel.Size = new System.Drawing.Size(193, 32);
            this.weightCatLabel.TabIndex = 2;
            this.weightCatLabel.Text = "Weight Category";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(30, 102);
            this.bmiLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(56, 32);
            this.bmiLabel.TabIndex = 1;
            this.bmiLabel.Text = "BMI";
            // 
            // bmiOut
            // 
            this.bmiOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiOut.Location = new System.Drawing.Point(409, 94);
            this.bmiOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bmiOut.Name = "bmiOut";
            this.bmiOut.Size = new System.Drawing.Size(186, 49);
            this.bmiOut.TabIndex = 0;
            this.bmiOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingPlanBox
            // 
            this.savingPlanBox.Controls.Add(this.feesIn);
            this.savingPlanBox.Controls.Add(this.feesLabel);
            this.savingPlanBox.Controls.Add(this.interestLabel);
            this.savingPlanBox.Controls.Add(this.interestIn);
            this.savingPlanBox.Controls.Add(this.initialDepositIn);
            this.savingPlanBox.Controls.Add(this.initialDepositLabel);
            this.savingPlanBox.Controls.Add(this.futureValueBox);
            this.savingPlanBox.Controls.Add(this.calculateSaving);
            this.savingPlanBox.Controls.Add(this.button1);
            this.savingPlanBox.Controls.Add(this.periodIn);
            this.savingPlanBox.Controls.Add(this.depositIn);
            this.savingPlanBox.Controls.Add(this.periodLabel);
            this.savingPlanBox.Controls.Add(this.monthlyLabel);
            this.savingPlanBox.Location = new System.Drawing.Point(1092, 58);
            this.savingPlanBox.Margin = new System.Windows.Forms.Padding(6);
            this.savingPlanBox.Name = "savingPlanBox";
            this.savingPlanBox.Padding = new System.Windows.Forms.Padding(6);
            this.savingPlanBox.Size = new System.Drawing.Size(607, 915);
            this.savingPlanBox.TabIndex = 2;
            this.savingPlanBox.TabStop = false;
            this.savingPlanBox.Text = "Saving Plan";
            // 
            // feesIn
            // 
            this.feesIn.Location = new System.Drawing.Point(375, 315);
            this.feesIn.Name = "feesIn";
            this.feesIn.Size = new System.Drawing.Size(182, 39);
            this.feesIn.TabIndex = 12;
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Location = new System.Drawing.Point(40, 318);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(103, 32);
            this.feesLabel.TabIndex = 11;
            this.feesLabel.Text = "Fees (%)";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(40, 264);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(135, 32);
            this.interestLabel.TabIndex = 10;
            this.interestLabel.Text = "Interest (%)";
            // 
            // interestIn
            // 
            this.interestIn.Location = new System.Drawing.Point(375, 261);
            this.interestIn.Name = "interestIn";
            this.interestIn.Size = new System.Drawing.Size(182, 39);
            this.interestIn.TabIndex = 9;
            // 
            // initialDepositIn
            // 
            this.initialDepositIn.Location = new System.Drawing.Point(375, 203);
            this.initialDepositIn.Name = "initialDepositIn";
            this.initialDepositIn.Size = new System.Drawing.Size(182, 39);
            this.initialDepositIn.TabIndex = 8;
            // 
            // initialDepositLabel
            // 
            this.initialDepositLabel.AutoSize = true;
            this.initialDepositLabel.Location = new System.Drawing.Point(40, 206);
            this.initialDepositLabel.Name = "initialDepositLabel";
            this.initialDepositLabel.Size = new System.Drawing.Size(161, 32);
            this.initialDepositLabel.TabIndex = 7;
            this.initialDepositLabel.Text = "Initial Deposit";
            // 
            // futureValueBox
            // 
            this.futureValueBox.Controls.Add(this.totalFeesLabel);
            this.futureValueBox.Controls.Add(this.totalFeesOut);
            this.futureValueBox.Controls.Add(this.totalEarnedOut);
            this.futureValueBox.Controls.Add(this.totalEarnedLabel);
            this.futureValueBox.Controls.Add(this.finalBalanceOut);
            this.futureValueBox.Controls.Add(this.totalDepositOut);
            this.futureValueBox.Controls.Add(this.finalBalanceLabel);
            this.futureValueBox.Controls.Add(this.amountPayedLabel);
            this.futureValueBox.Location = new System.Drawing.Point(50, 499);
            this.futureValueBox.Margin = new System.Windows.Forms.Padding(6);
            this.futureValueBox.Name = "futureValueBox";
            this.futureValueBox.Padding = new System.Windows.Forms.Padding(6);
            this.futureValueBox.Size = new System.Drawing.Size(511, 395);
            this.futureValueBox.TabIndex = 6;
            this.futureValueBox.TabStop = false;
            this.futureValueBox.Text = "Future Value";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(17, 258);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(120, 32);
            this.totalFeesLabel.TabIndex = 7;
            this.totalFeesLabel.Text = "Total Fees";
            // 
            // totalFeesOut
            // 
            this.totalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesOut.Location = new System.Drawing.Point(314, 257);
            this.totalFeesOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalFeesOut.Name = "totalFeesOut";
            this.totalFeesOut.Size = new System.Drawing.Size(186, 49);
            this.totalFeesOut.TabIndex = 6;
            // 
            // totalEarnedOut
            // 
            this.totalEarnedOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalEarnedOut.Location = new System.Drawing.Point(314, 194);
            this.totalEarnedOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalEarnedOut.Name = "totalEarnedOut";
            this.totalEarnedOut.Size = new System.Drawing.Size(186, 49);
            this.totalEarnedOut.TabIndex = 5;
            // 
            // totalEarnedLabel
            // 
            this.totalEarnedLabel.AutoSize = true;
            this.totalEarnedLabel.Location = new System.Drawing.Point(17, 195);
            this.totalEarnedLabel.Name = "totalEarnedLabel";
            this.totalEarnedLabel.Size = new System.Drawing.Size(145, 32);
            this.totalEarnedLabel.TabIndex = 4;
            this.totalEarnedLabel.Text = "Total Earned";
            // 
            // finalBalanceOut
            // 
            this.finalBalanceOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finalBalanceOut.Location = new System.Drawing.Point(314, 134);
            this.finalBalanceOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.finalBalanceOut.Name = "finalBalanceOut";
            this.finalBalanceOut.Size = new System.Drawing.Size(186, 49);
            this.finalBalanceOut.TabIndex = 3;
            // 
            // totalDepositOut
            // 
            this.totalDepositOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDepositOut.Location = new System.Drawing.Point(314, 70);
            this.totalDepositOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalDepositOut.Name = "totalDepositOut";
            this.totalDepositOut.Size = new System.Drawing.Size(186, 49);
            this.totalDepositOut.TabIndex = 2;
            // 
            // finalBalanceLabel
            // 
            this.finalBalanceLabel.AutoSize = true;
            this.finalBalanceLabel.Location = new System.Drawing.Point(17, 137);
            this.finalBalanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.finalBalanceLabel.Name = "finalBalanceLabel";
            this.finalBalanceLabel.Size = new System.Drawing.Size(153, 32);
            this.finalBalanceLabel.TabIndex = 1;
            this.finalBalanceLabel.Text = "Final Balance";
            // 
            // amountPayedLabel
            // 
            this.amountPayedLabel.AutoSize = true;
            this.amountPayedLabel.Location = new System.Drawing.Point(17, 79);
            this.amountPayedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amountPayedLabel.Name = "amountPayedLabel";
            this.amountPayedLabel.Size = new System.Drawing.Size(170, 32);
            this.amountPayedLabel.TabIndex = 0;
            this.amountPayedLabel.Text = "Amount Payed";
            // 
            // calculateSaving
            // 
            this.calculateSaving.Location = new System.Drawing.Point(148, 397);
            this.calculateSaving.Margin = new System.Windows.Forms.Padding(6);
            this.calculateSaving.Name = "calculateSaving";
            this.calculateSaving.Size = new System.Drawing.Size(312, 49);
            this.calculateSaving.TabIndex = 5;
            this.calculateSaving.Text = "Calculate Savings";
            this.calculateSaving.UseVisualStyleBackColor = true;
            this.calculateSaving.Click += new System.EventHandler(this.calculateSavings_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 570);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // periodIn
            // 
            this.periodIn.Location = new System.Drawing.Point(375, 145);
            this.periodIn.Margin = new System.Windows.Forms.Padding(6);
            this.periodIn.Name = "periodIn";
            this.periodIn.Size = new System.Drawing.Size(182, 39);
            this.periodIn.TabIndex = 3;
            // 
            // depositIn
            // 
            this.depositIn.Location = new System.Drawing.Point(375, 90);
            this.depositIn.Margin = new System.Windows.Forms.Padding(6);
            this.depositIn.Name = "depositIn";
            this.depositIn.Size = new System.Drawing.Size(182, 39);
            this.depositIn.TabIndex = 2;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(40, 148);
            this.periodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(157, 32);
            this.periodLabel.TabIndex = 1;
            this.periodLabel.Text = "Period (years)";
            // 
            // monthlyLabel
            // 
            this.monthlyLabel.AutoSize = true;
            this.monthlyLabel.Location = new System.Drawing.Point(40, 93);
            this.monthlyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthlyLabel.Name = "monthlyLabel";
            this.monthlyLabel.Size = new System.Drawing.Size(193, 32);
            this.monthlyLabel.TabIndex = 0;
            this.monthlyLabel.Text = "Monthly Deposit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 998);
            this.Controls.Add(this.savingPlanBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.bmiBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
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
            this.savingPlanBox.ResumeLayout(false);
            this.savingPlanBox.PerformLayout();
            this.futureValueBox.ResumeLayout(false);
            this.futureValueBox.PerformLayout();
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
        private TextBox ftBox;
        private GroupBox savingPlanBox;
        private Label periodLabel;
        private Label monthlyLabel;
        private Button calculateSaving;
        private Button button1;
        private TextBox periodIn;
        private TextBox depositIn;
        private GroupBox futureValueBox;
        private Label amountPayedLabel;
        private Label finalBalanceLabel;
        private Label totalDepositOut;
        private Label finalBalanceOut;
        private Label totalFeesLabel;
        private Label totalFeesOut;
        private Label totalEarnedOut;
        private Label totalEarnedLabel;
        private TextBox initialDepositIn;
        private Label initialDepositLabel;
        private Label interestLabel;
        private TextBox interestIn;
        private TextBox feesIn;
        private Label feesLabel;
    }
}