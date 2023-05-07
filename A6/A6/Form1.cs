using System.Reflection;

namespace A6
{
    public partial class MainForm : Form
    {
        private TaskManger taskManger;

        public MainForm()
        {
            InitializeComponent();
            InitiailizeGUI();
        }

        private void InitiailizeGUI()
        {
            this.Text = "Task Manager by Bengt Svedling Cruz";

            // Create a task manager object
            taskManger = new TaskManger();

            // Create a tooltip object

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(addBtn, "Add task to list...");
            toolTip1.SetToolTip(changeBtn, "Change selected task ...");
            toolTip1.SetToolTip(deleteBtn, "Delete selected task...");
            toolTip1.SetToolTip(dateTimePicker, "Select the date and time for the task...");

            // Initialize Inpts
            toDoIn.Text = string.Empty;

            string[] priorities = Enum.GetNames(typeof(PriorityTypes));
            for (int i = 0; i < priorities.Length; i++)
                priorities[i] = priorities[i].Replace('_', ' ');

            priorityBox.Items.Clear();
            priorityBox.Items.AddRange(priorities);
            priorityBox.SelectedIndex = (int)PriorityTypes.Normal;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

            // Initialize List
            toDoList.Items.Clear();

            saveDataSubFileMenu.Enabled = true;
            openDataSubFileMenu.Enabled = true;
            deleteBtn.Enabled = false;
            changeBtn.Enabled = false;

        }

        void UpdateGui()
        {
            toDoList.Items.Clear();
            toDoList.Items.AddRange(taskManger.GetTaskDescriptions());


            if (toDoList.SelectedIndex >= 0)
            {
                deleteBtn.Enabled = true;
                changeBtn.Enabled = true;

                return;
            }

            deleteBtn.Enabled = false;
            changeBtn.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (taskManger.AddTask(ReadInput()))
            {
                UpdateGui();
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            int i = toDoList.SelectedIndex;

            if (i >= 0)
            {
                Task task = ReadInput();
                if (taskManger.ChangeTask(i, task))
                {
                    MessageBox.Show("Task changed...", "Change Task",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGui();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int i = toDoList.SelectedIndex;

            if (i >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really wish to delete this task?",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Cancel)
                    return;

                taskManger.DeleteTask(i);
                UpdateGui();
            }
        }

        private void newSubFileMenu_Click(object sender, EventArgs e)
        {
            InitiailizeGUI();
        }

        private void openDataSubFileMenu_Click(object sender, EventArgs e)
        {
            if (taskManger.ReadDataFromFile())
            {
                MessageBox.Show("Data read from file...", "Read Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGui();
            }
            else
                MessageBox.Show("No data read...", "Read Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveDataSubFileMenu_Click(object sender, EventArgs e)
        {
            (bool ok, string? fileName) = taskManger.WriteDataToFile();

            if (ok)
                MessageBox.Show("Data saved to " + fileName, "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No data saved...", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void exitSubFileMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to exit your task manager?",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
                return;

            this.Close();
        }

        private void aboutSubHelpMenu_Click(object sender, EventArgs e)
        {
           /* Skipped */
        }

        private Task ReadInput()
        {
            string description = toDoIn.Text.Trim();
            PriorityTypes priority = (PriorityTypes)priorityBox.SelectedIndex;
            DateTime date = dateTimePicker.Value;
            return new Task(date, description, priority);
        }

        private void toDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toDoList.SelectedIndex >= 0)
            {
                deleteBtn.Enabled = true;
                changeBtn.Enabled = true;

                return;
            }

            deleteBtn.Enabled = false;
            changeBtn.Enabled = false;
        }
    }
}