namespace WebTodoList.Models
{
    public class TaskTodo
    {
        int taskId;
        string taskName;
        string taskDescription;
        int taskUrgent;
        string taskDate;
        int taskStatus;
        string userId;
        int taskTypeId;

        public TaskTodo(int taskId, string taskDescription, int taskUrgent, string taskDate, int taskStatus, string userId, int taskTypeId)
        {
            this.taskId = taskId;
            this.taskDescription = taskDescription;
            this.taskUrgent = taskUrgent;
            this.taskDate = taskDate;
            this.taskStatus = taskStatus;
            this.userId = userId;
            this.taskTypeId = taskTypeId;
        }
        public int TaskId
        {
            get { return this.taskId; }
            set { this.taskId = value; }
        }

        public string TaskName
        {
            get { return this.taskName; }
            set { this.taskName = value; }
        }

        public string TaskDescription
        {
            get { return this.taskDescription; }
            set { this.taskDescription = value; }
        }

        public int TaskUrgent
        {
            get { return this.taskUrgent; }
            set { this.taskUrgent = value; }
        }

        public string TaskDate
        {
            get { return this.taskDate; }
            set { this.taskDate = value; }
        }

        public int TaskStatus
        {
            get { return this.taskStatus; }
            set { this.taskStatus = value; }
        }

        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        public int TaskTypeId
        {
            get { return this.taskTypeId; }
            set { this.taskTypeId = value; }
        }



    }
}
