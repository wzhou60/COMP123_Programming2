//Jackie Zhou 301465524 Lab2/3

namespace JackieZ_301465524_Lab23
{
    internal class TaskManager
    {
        private static List<Task> tasks;

        public static List<Task> Tasks
        {
            get { return tasks; }
        }

        static TaskManager()
        {
            tasks = new List<Task>();
        }

        public static string AllTasksToString()
        {
            string result = "";
            foreach (Task task in tasks)
            {
                result += $"\n{task}, ";
            }
            return result;
        }

        public static Task CreateTask(string description)
        {
            Task task = new Task(description);
            tasks.Add(task);
            return task;
        }
    }
}