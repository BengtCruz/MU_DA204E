using System.Security.Policy;

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();

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
            }
        }

        private void imperial_click(object sender, EventArgs e)
        {
            if (imperialBtn.Checked)
            {
                heightLabel.Text = "Height (ft and in)";
                weightLabel.Text = "Weight (lb)";

                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (ReadInputBMI)
                DisplayResults();
            //else
                //DisplayErrors();
        }


        /// <summary>
        /// 
        /// </summary>
        void DisplayError()
        {



        }

        /// <summary>
        /// 
        /// </summary>
        void DisplayResults()
        {

            resultBox.Text = $"Results for {bmiCalc.GetName()}";
            bmiOut.Text = "";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadInputBMI => ReadName() && ReadHeight() && ReadWeight();

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
            double height = 0.0;
            
            bool ok = double.TryParse(heightIn.Text.Trim(), out height);

            if (ok)
                if (height > 0) // Guard for zero or negative
                    if (bmiCalc.GetUnit() == UnitTypes.Imperial)
                        bmiCalc.SetHeight(height * 12.00);
                    else
                        bmiCalc.SetHeight(height / 100.0);
                else
                    ok = false;

            if(!ok)
                errorLabel.Text = "*";
                    

            return ok;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadWeight()
        {

            double weight = 0.0;
            
            bool ok = double.TryParse(weightIn.Text.Trim(), out weight);

            if (ok)
                bmiCalc.SetWeight(weight);

            return ok;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}