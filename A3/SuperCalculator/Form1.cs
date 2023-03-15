using System.Security.Policy;

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();

        private SavingCalculator savingsCalc = new SavingCalculator();

<<<<<<< HEAD
        private BMRCalculator bmrCalc = new BMRCalculator();

=======
>>>>>>> 096696a816e379bdf20a40fd18cfd563cb4e54ec
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {

            /* Clear Inputs */
            nameIn.Text = string.Empty;
            heightIn.Text = string.Empty;
            weightIn.Text = string.Empty;

            /* Unit group defaults */
            metricBtn.Checked = true;
            imperialBtn.Checked = false;

            /* Clear Outputs */
            bmiOut.Text = string.Empty;
            weightCatOut.Text = string.Empty;
            normalBmiOut.Text = string.Empty;
            normalWeightOut.Text = string.Empty;


        }

        private void metric_click(object sender, EventArgs e)
        {
            if (metricBtn.Checked)
            {
                heightLabel.Text = "Height (cm)";
                weightLabel.Text = "Weight (kg)";

                bmiCalc.SetUnit(UnitTypes.Metric);

                ftBox.Enabled = false;
                ftBox.Text = string.Empty;
            }
        }

        private void imperial_click(object sender, EventArgs e)
        {
            if (imperialBtn.Checked)
            {
                heightLabel.Text = "Height (ft and in)";
                weightLabel.Text = "Weight (lb)";

                bmiCalc.SetUnit(UnitTypes.Imperial);

                ftBox.Enabled = true;
            }
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            ReadName();

            if (ReadInputBMI)
                DisplayBMIResults();
            
        }
        private void calculateSavings_click(object sender, EventArgs e)
        { 

            if(ReadInputSavings)
                DisplaySavingsResults();

        }

<<<<<<< HEAD
        private void calculateBMRClick(object sender, EventArgs e)
        {
            if (readBMRInput())
                DisplayBMRResults();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayBMRResults()
        {
            _ = bmrResultsBox.Items.Add($"To loose 500g in a week = {bmrCalc.CalculateBMR(bmiCalc.GetWeight(), bmiCalc.GetHeight()) - 500}");
            _ = bmrResultsBox.Items.Add($"To loose 1000g in a week = {bmrCalc.CalculateBMR(bmiCalc.GetWeight(), bmiCalc.GetHeight()) - 1000}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool readBMRInput() => BMR_ReadActivity() & BMR_ReadAge() & BMR_ReadGender();

        /// <summary>
        /// 
        /// </summary>
=======
>>>>>>> 096696a816e379bdf20a40fd18cfd563cb4e54ec
        void DisplaySavingsResults()
        {
            totalDepositOut.Text = $"{savingsCalc.CalculateTotalDeposit():0.00}";
            finalBalanceOut.Text = $"{savingsCalc.CalculateFinalBalance() - savingsCalc.CalculateTotalFees():0.00}";
            totalEarnedOut.Text  = $"{savingsCalc.CalculateTotalEarned():0.00}";
            totalFeesOut.Text    = $"{savingsCalc.CalculateTotalFees():0.00}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadInputSavings => ReadYears() && ReadMonthlyDeposit() && ReadFees() && ReadInterest() && ReadInitialDeposit();


        /// <summary>
        /// 
        /// </summary>
        void DisplayBMIResults() 
        {

            resultBox.Text = $"Results for {bmiCalc.GetName()}";
            bmiOut.Text = $"{bmiCalc.CalculateBMI():0.00}";
            weightCatOut.Text = bmiCalc.BmiWeightCat();
            normalBmiOut.Text = "Normal BMI is between 18.5 and 24.9";
            normalWeightOut.Text = "Normal weight should be between " + bmiCalc.NormalWeight();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadInputBMI => ReadHeight() & ReadWeight();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadName()
        {
            bool ok = !string.IsNullOrEmpty(nameIn.Text);

            if (ok)
                bmiCalc.SetName(nameIn.Text.Trim());
            else
                bmiCalc.SetName("Unknown");

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadHeight()
        {
            double height;
            double ft;
            bool ok;

            if(bmiCalc.GetUnit()==UnitTypes.Imperial) {

                ok = double.TryParse(heightIn.Text.Trim(), out height);

                if (double.TryParse(ftBox.Text.Trim(), out ft) && ok)
                { 
                    double totInch = (ft * 12.00) + height;
                    
                    if (totInch > 0)
                        bmiCalc.SetHeight(totInch);
                    else
                        ok = false;
                }

            }else
            {
                ok = double.TryParse(heightIn.Text.Trim(), out height);

                if(ok)
                {
                    if (height > 0)
                        bmiCalc.SetHeight(height / 100.0);
                    else
                        ok = false;
                }

            }
                

            if (!ok)
                _ = MessageBox.Show("Invalid height!", "Error");
                    

            return ok;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadWeight()
        {
            
            bool ok = double.TryParse(weightIn.Text.Trim(), out double weight);

            if (ok)
                if (weight > 0) // Guard for zero or negative
                    bmiCalc.SetWeight(weight);
                else
                    ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid weight!", "Error");

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadMonthlyDeposit()
        {

            bool ok = double.TryParse(depositIn.Text.Trim(), out double monthlyDeposit);

            if (ok)
                savingsCalc.SetMonthlyDeposit(monthlyDeposit);
            else
                ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid deposit value!", "Error");

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadYears()
        {

            bool ok = double.TryParse(periodIn.Text.Trim(), out double years);

            if (ok)
                savingsCalc.SetSavingPeriod(years);
            else
                ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid period value!", "Error");

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadInterest()
        {
            bool ok = double.TryParse(interestIn.Text.Trim(), out double interest);

            if (ok)
                savingsCalc.SetInterestRate(interest);
            else
                ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid interest value!", "Error");

            return ok;

        }

<<<<<<< HEAD
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
=======
>>>>>>> 096696a816e379bdf20a40fd18cfd563cb4e54ec
        private bool ReadInitialDeposit()
        {

            bool ok = double.TryParse(initialDepositIn.Text.Trim(), out double iniDeposit);

            if (ok)
                savingsCalc.SetInitialDepo(iniDeposit);
            else
                ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid initial deposit value!", "Error");

            return ok;
        }

<<<<<<< HEAD
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadFees()
        {
=======
        private bool ReadFees()
        {

>>>>>>> 096696a816e379bdf20a40fd18cfd563cb4e54ec
            bool ok = double.TryParse(feesIn.Text.Trim(), out double fees);

            if (ok)
                savingsCalc.SetFees(fees);
            else
                ok = false;

            if (!ok)
                _ = MessageBox.Show("Invalid fee value!", "Error");

            return ok;
        }

<<<<<<< HEAD
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool BMR_ReadGender()
        {
            var gender = genderBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            bool ok = gender != null;

            if (ok) {

                if (gender == genderInFemale)
                    bmrCalc.SetGender(Gender.Female);
                else
                    bmrCalc.SetGender(Gender.Male);
            }

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool BMR_ReadActivity()
        {

            var activity = activityLevelBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            bool ok = activity != null;

            if (ok)
            {
                if (activity == sedentaryLevel)
                    bmrCalc.SetActivityLevel(ActivityLevel.Sedentary);
                else if (activity == lightLevel)
                    bmrCalc.SetActivityLevel(ActivityLevel.Lightly_Active);
                else if (activity == moderateLevel)
                    bmrCalc.SetActivityLevel(ActivityLevel.Moderately_Active);
                else if (activity == veryActiveLevel)
                    bmrCalc.SetActivityLevel(ActivityLevel.Very_Active);
                else
                    bmrCalc.SetActivityLevel(ActivityLevel.Extra_Active);
            }

            return ok;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool BMR_ReadAge()
        {
            bool ok = byte.TryParse(bmrAgeIn.Text.Trim(), out var age);

            if (ok)
                bmrCalc.SetAge(age);
            else
                _ = MessageBox.Show("Invalid BMR age value!", "Error");

            return ok;
        }
=======
>>>>>>> 096696a816e379bdf20a40fd18cfd563cb4e54ec
    }

}