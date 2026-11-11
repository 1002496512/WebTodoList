namespace WebTodoList.Models
{
    public class TaskViewModel
    {
        TaskType[] taskTypes;
        TaskTodo[] taskTodos;
        int taskTypesCount;
        int taskTodosCount;

        public TaskViewModel(int taskCount, int taskTodoCount)
        {
            this.taskTypes = new TaskType[taskCount];
            this.taskTodos = new TaskTodo[taskTodoCount];
            this.taskTypesCount = 0;
            this.taskTodosCount = 0;

        }

        public void AddTaskType(TaskType taskType)
        {
            this.taskTypes[this.taskTypesCount] = taskType;
            this.taskTypesCount++;
        }

        public TaskType[] TaskTypes
        {
            get { return this.taskTypes; }
            set { this.taskTypes = value; }
        }

        public TaskTodo[] TaskTodos
        {
            get { return this.taskTodos; }
            set { this.taskTodos = value; }
        }

        public int TaskTypesCount
        {
            get { return this.taskTypesCount; }
            set { this.taskTypesCount = value; }
        }

        public int TaskTodosCount
        {
            get { return this.taskTodosCount; }
            set { this.taskTodosCount = value; }
        }


    }
}
