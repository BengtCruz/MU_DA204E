namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {

            /* Init Clear Inputs */
            nameBox.Text = null;
            heightBox.Text = null;
            weightBox.Text = null;

            /* Init Unit Defaults */
            metricBtn.Checked = false;
            imperialBtn.Checked = false;


        }

        private void metric_click(object sender, EventArgs e)
        {

            heightLabel.Text = "Height (cm)";
            weightLabel.Text = "Weight (kg)";

        }

        private void imperial_click(object sender, EventArgs e)
        {
            heightLabel.Text = "Height (ft and in)";
            weightLabel.Text = "Weight (lb)";
        }
    }
}