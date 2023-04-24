using System.DirectoryServices.ActiveDirectory;

namespace A5
{
    public partial class EventForm : Form
    {
        private EventManager _eventManager;

        public EventForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        #region INITIAILIZATION
        /// <summary>
        /// 
        /// </summary>
        private void InitializeGui()
        {
            InitializeEventBox();
            InitializeGuestBox();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeEventBox()
        {
            newEventBox.Enabled = true;
            eventNameIn.Text = "";
            costPerGuestIn.Text = "0.00";
            feePerGuest.Text = "0.00";
        }


        /// <summary>
        /// 
        /// </summary>
        private void InitializeGuestBox()
        {
            addGuestBox.Enabled = false;
            eventEconomyBox.Enabled = false;
            firstNameIn.Text = "";
            secondNameIn.Text = "";
            streetIn.Text = "";
            cityIn.Text = "";
            zipCodeIn.Text = "";
            guestListBox.Items.Clear();
            InitializeCountryBox();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeCountryBox()
        {
            countryDropDown.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Countries)))
                countryDropDown.Items.Add(item);
            countryDropDown.SelectedIndex = Convert.ToInt16(Countries.Sweden);
        }

        #endregion

        #region CREATE_EVENT

        private void clickCreateEvent(object sender, EventArgs e)
        {
            _eventManager = new EventManager();

            ReadEventTitle();

            if(ReadEventInputOk())
            {
                addGuestBox.Enabled = true;
                eventEconomyBox.Enabled = true;
                UpdateEventWindow();
                MessageBox.Show("Event created successfully","Success");

            }else
                MessageBox.Show("Event creation failed","Error");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void ReadEventTitle()
        {
            bool empty = string.IsNullOrEmpty(eventNameIn.Text.Trim());

            if (empty)
                eventNameIn.Text = "Undifined Title";
            
            _eventManager.Title = eventNameIn.Text.Trim() + " by Bengt Svedling Cruz";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadCostPerGuest()
        {
            bool ok = double.TryParse(costPerGuestIn.Text.Trim(), out double input);

            if (ok && input >= 0)
            {
                _eventManager.CostPerPerson = input;
                return true;
            }

            MessageBox.Show("Please enter a valid cost value, please try again.","Error");
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadFeePerGuest()
        {
            bool ok = double.TryParse(feePerGuest.Text.Trim(), out double input);

            if (ok && input >= 0)
            {
                _eventManager.FeePerPerson = input;
                return true;
            }

            MessageBox.Show("Please enter a valid fee value, please try again.", "Error");
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ReadEventInputOk() => ReadCostPerGuest() && ReadFeePerGuest();

        /// <summary>
        /// 
        /// </summary>
        private void UpdateEventWindow() { Text = _eventManager.Title; guestListBox.Items.Clear(); }

        #endregion

        #region ADD_GUEST

        private void clickAddGuest(object sender, EventArgs e)
        {
            Participant guest = new Participant();

            if (ReadGuestDataOk(ref guest))
            {
                _eventManager.ParticipantMnger.AddParticipant(guest);
                UpdateGuestList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool ReadGuestDataOk(ref Participant participant)
        {
            participant.FirstName = firstNameIn.Text.Trim();
            participant.SecondName = secondNameIn.Text.Trim();
            Address address = ReadGuestAddress();

            participant.Address = address;

            if (participant.Validate())
                return true;
            else
            {
                MessageBox.Show("Please make sure all fields are filled in correctly.\n" +
                    "Requires:\nFirst Name\nSecond Name\nStreet\nCity\nZip Code", "Error");
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Address ReadGuestAddress()
        {
            Address address = new Address();

            address.Street = streetIn.Text.Trim();
            address.ZipCode = zipCodeIn.Text.Trim();
            address.City = cityIn.Text.Trim();
            address.Country = (Countries)countryDropDown.SelectedIndex;

            return address;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGuestList()
        {

            if (_eventManager.ParticipantMnger.GetParticipantsInfo() != null)
            {
                guestListBox.Items.Clear();
                guestListBox.Items.AddRange(_eventManager.ParticipantMnger.GetParticipantsInfo());
            }

            UpdateEventEconomy();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateEventEconomy()
        {
            numbGuestOut.Text = _eventManager.ParticipantMnger.Count.ToString();
            totalCostOut.Text = _eventManager.CalcTotalCost().ToString();
            totalFeesOut.Text = _eventManager.CalcTotalFee().ToString();
            incomeOut.Text = _eventManager.CalcTotalIncome().ToString();
        }

        #endregion

        #region CHANGE_GUEST

        private void clickChange(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex;

            if (i < 0) return;

            Participant participant = _eventManager.ParticipantMnger.GetParticipantAt(i);

            if(ReadGuestDataOk(ref participant))
            {
                _eventManager.ParticipantMnger.ChangeParticipantAt(participant, i);
                UpdateGuestList();
            }

        }

        #endregion

        #region DELETE_GUEST

        private void clickDelete(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex;

            if (i < 0) return;

            _eventManager.ParticipantMnger.DeleteParticipantAt(i);
            UpdateGuestList();

        }

        #endregion

        #region AUX_METHODS

        private void guestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex;

            if (i >= 0)
            {
                Participant participant = _eventManager.ParticipantMnger.GetParticipantAt(i);

                if (participant != null)
                {
                    firstNameIn.Text = participant.FirstName;
                    secondNameIn.Text = participant.SecondName;
                    streetIn.Text = participant.Address.Street;
                    cityIn.Text = participant.Address.City;
                    zipCodeIn.Text = participant.Address.ZipCode;
                    countryDropDown.SelectedIndex = Convert.ToInt16(participant.Address.Country);
                }
            }else
                MessageBox.Show("Please select a guest from the list", "Error");
        }

        #endregion
    }
}