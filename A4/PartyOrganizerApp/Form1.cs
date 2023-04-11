namespace PartyOrganizerApp
{
    public partial class Form1 : Form
    {
        PartyManager eventMngr;
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {

            ClearInputControls();
            ClearOutputControls();

            inviteGuestBox.Enabled = false;
            newEventBox.Enabled = true;
        }

        private void ClearInputControls()
        {
            maxGuestsIn.Text = string.Empty;
            costIn.Text = string.Empty;
            feeIn.Text = string.Empty;
        }

        private void ClearOutputControls()
        {
            numberGuestsOut.Text = string.Empty;
            totalCostOut.Text = string.Empty;   
            totalFeesOut.Text = string.Empty; 
            surplusOut.Text = string.Empty;
            guestListBox.Items.Clear();
        }

        private void createListClck(object sender, EventArgs e)
        {

            bool eventOk = createEventOk();

            if (!eventOk)
                return;

            ClearOutputControls();

            bool amountInputsOk = readCostOk(); readFeesOk();

            if(eventOk && amountInputsOk)
            {
                inviteGuestBox.Enabled = true;
            }
        }

        /// <summary>
        /// Create event object and validate max number of guests input to the constructor.
        /// </summary>
        /// <returns></returns>
        private bool createEventOk()
        {
            bool ok = int.TryParse(maxGuestsIn.Text.Trim(), out int input);

            if(ok && input > 0)
            {
                eventMngr = new PartyManager(input);
                MessageBox.Show($"Event list for {input} guests created.", "Success");
            }else
            {
                MessageBox.Show($"Invalid total number of guests!", "Error");
                inviteGuestBox.Enabled = false;
            }

            return ok;
        }

        /// <summary>
        /// Read and validate cost value.
        /// </summary>
        /// <returns></returns>
        private bool readCostOk()
        {
            bool ok = double.TryParse(costIn.Text.Trim(), out double input);

            if (ok && input >= 0)
                eventMngr.CostPerPerson = input;
            else
                MessageBox.Show("Invalid cost value!", "Error");
         
            return ok;
        }

        /// <summary>
        /// Read and validate fee value.
        /// </summary>
        /// <returns></returns>
        private bool readFeesOk()
        {
            bool ok = double.TryParse(feeIn.Text.Trim(), out double input);

            if(ok && input >= 0)
                eventMngr.FeePerPerson = input;
            else
                MessageBox.Show("Invalid fee value!", "Error");

            return ok;
        }

        private bool readGuestNameOk()
        {
            bool firstNameOk = (!string.IsNullOrEmpty(firstNameIn.Text));
            bool lastNameOk = (!string.IsNullOrEmpty(lastNameIn.Text));

            string temp;
            if (firstNameOk)
                temp = firstNameIn.Text;
            else
                temp = "-";

            string temp2;
            if (lastNameOk)
                temp2 = lastNameIn.Text;
            else
                temp2 = "-";

            if (!firstNameOk && !lastNameOk)
                MessageBox.Show("At least one name should be given!");
            else
                eventMngr.AddNewGuest(temp, temp2);

            return firstNameOk || lastNameOk;
        }

        private void updateGui()
        {
            string[] list = eventMngr.GetGuestList();
            guestListBox.Items.Clear();

            for (int i = 0; i < eventMngr.Count; i++)
                guestListBox.Items.Insert(i, list[i]);

            numberGuestsOut.Text = $"{(eventMngr.Count*100)/100}";
            totalCostOut.Text = $"{(eventMngr.TotalCost*100)/100:0.00}";
            totalFeesOut.Text = $"{(eventMngr.TotalFees*100)/100:0.00}";
            surplusOut.Text = $"{(eventMngr.TotalEarned*100)/100:0.00}";
        }

        private void addGuestClick(object sender, EventArgs e)
        {
            if (readGuestNameOk())
                updateGui();
        }

        private void deleteClick(object sender, EventArgs e)
        {
            if ( guestListBox.SelectedIndex >= 0)
            {
                eventMngr.RemoveAt(guestListBox.SelectedIndex);
                updateGui();
            }
            else
                MessageBox.Show("Select guest on list to delete!");
        }
    }
}