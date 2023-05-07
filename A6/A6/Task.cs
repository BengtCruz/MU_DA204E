namespace A6
{
    internal class Task
    {
        #region FIELDS

        private DateTime date;
        private string taskDesc;
        private PriorityTypes priority;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="task"></param>
        /// <param name="priority"></param>
        public Task(DateTime date, string task, PriorityTypes priority)
        {
            this.date = date;
            this.taskDesc = task;
            this.priority = priority;
        }

        /// <summary>
        /// 
        /// </summary>
        public Task() : this(DateTime.Now, "", PriorityTypes.Normal) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public Task(Task task) : this(task.date, task.taskDesc, task.priority) { }

        #endregion

        #region PROPERTIES

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string TaskDescription
        {
            get { return taskDesc; }
            set { if (!string.IsNullOrEmpty(value)) taskDesc = value; }
        }

        public PriorityTypes Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => string.Format("{0,-34}{1,-7}{2,-15}{3}", date.ToString("dd MMMM yyyy").Trim(), GetTimeString(), priority.ToString().Replace("_", " "), taskDesc);

        public string GetTimeString() => date.ToString("HH:mm").Trim();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate() => (date != null) && !string.IsNullOrEmpty(taskDesc) && (priority != null);

        #endregion

    }
}
