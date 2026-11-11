namespace WebTodoList.Models
{
    public class TaskType
    {
        int taskTypeId;
        string taskTypeName;
        string userId;

        public TaskType(int taskTypeId, string taskTypeName, string userId)
        {
            this.taskTypeId = taskTypeId;
            this.taskTypeName = taskTypeName;
            this.userId = userId;
        }
        public int TaskTypeId
        {
            get { return this.taskTypeId; }
            set { this.taskTypeId = value; }
        }

        public string TaskTypeName
        {
            get { return this.taskTypeName; }
            set { this.taskTypeName = value; }
        }

        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }


    }
}
