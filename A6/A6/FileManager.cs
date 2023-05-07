namespace A6
{
    internal class FileManager
    {
        /// <summary>
        /// 
        /// </summary>
        private const string fileVersionToken = "ToDoRe_21";

        /// <summary>
        /// 
        /// </summary>
        private const double fileVersion = 1.0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskList"></param>
        public (bool, string?) SaveToFile(List<Task> taskList)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string[] data = new string[taskList.Count];

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(fileVersionToken);
                    sw.WriteLine(fileVersion.ToString());
                    sw.WriteLine(taskList.Count.ToString());
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        sw.WriteLine(taskList[i].TaskDescription);
                        sw.WriteLine(taskList[i].Priority.ToString());
                        sw.WriteLine(taskList[i].Date.Year);
                        sw.WriteLine(taskList[i].Date.Month);
                        sw.WriteLine(taskList[i].Date.Day);
                        sw.WriteLine(taskList[i].Date.Hour);
                        sw.WriteLine(taskList[i].Date.Minute);
                        sw.WriteLine(taskList[i].Date.Second);
                    }
                    return (true, fileName);
                }
            }
            return (false, null);
        }


        public bool ReadTaskListFrFile(List<Task> taskList)
        {
            if (taskList != null)
                taskList.Clear();
            else
                taskList = new List<Task>();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                using (StreamReader sr = new StreamReader(fileName))
                {
                    string? fileVersionToken = sr.ReadLine();
                    string? fileVersion = sr.ReadLine();

                    // Check if the file version is supported
                    if ((fileVersionToken != FileManager.fileVersionToken) || (fileVersion != FileManager.fileVersion.ToString()))
                    {
                        MessageBox.Show("File version is not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Read the number of tasks
                    int count = int.Parse(sr.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        /* Read task description & priority */
                        string? taskDescription = sr.ReadLine();
                        PriorityTypes prio = (PriorityTypes)Enum.Parse(typeof(PriorityTypes), sr.ReadLine());

                        /* Read date */

                        int year = int.Parse(sr.ReadLine());
                        int month = int.Parse(sr.ReadLine());
                        int day = int.Parse(sr.ReadLine());
                        int hour = int.Parse(sr.ReadLine());
                        int minute = int.Parse(sr.ReadLine());
                        int second = int.Parse(sr.ReadLine());

                        DateTime date = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(new Task(date, taskDescription, prio));
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
