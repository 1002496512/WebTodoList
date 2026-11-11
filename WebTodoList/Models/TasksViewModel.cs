namespace WebTodoList.Models
{
    public class TasksViewModel
    {
        Task[] tasks;
        TaskType[] taskTypes;

        public TasksViewModel()
        {
            tasks = null;
            taskTypes = null;
        }

        public Task[] Tasks
        {
            get { return this.tasks; }
            set { this.tasks = value; }
        }

        public TaskType[] TaskTypes
        {
            get { return this.taskTypes; }
            set { this.taskTypes = value; }
        }
    }
}
