namespace A6
{
    internal class TaskManger
    {
        #region FIELDS
        private List<Task> tasks;

        #endregion

        #region CONSTRUCTORS
        public TaskManger()
        {
            tasks = new List<Task>();
        }
        #endregion

        #region PROPERTIES
        public int Count
        {
            get { return tasks.Count; }
        }

        public Task this[int index]
        {
            get { if (CheckIndexOk(index)) return tasks[index]; else return null; }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool AddTask(Task task)
        {
            if (task.Validate())
            {
                tasks.Add(task);
                return true;
            }

            MessageBox.Show("Invalid task,\ncheck that task description is filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetTaskDescriptions()
        {
            string[] descriptions = new string[Count];
            for (int i = 0; i < Count; i++)
                descriptions[i] = tasks[i].ToString();
            return descriptions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public bool DeleteTask(int index)
        {
            if (!CheckIndexOk(index))
                return false;

            tasks.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool ChangeTask(int index, Task task)
        {
            if (!(CheckIndexOk(index) && task.Validate()))
                return false;

            tasks[index] = task;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Task? GetTaskAt(int i) => !CheckIndexOk(i) ? null : tasks[i];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool CheckIndexOk(int i) => i >= 0 && i < Count;

        public (bool, string?) WriteDataToFile()
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveToFile(tasks);
        }

        public bool ReadDataFromFile()
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFrFile(tasks);
        }
        #endregion
    }
}
