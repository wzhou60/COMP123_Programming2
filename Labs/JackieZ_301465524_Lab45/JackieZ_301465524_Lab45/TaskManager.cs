//Jackie Zhou 301465524 Lab4/5

using Newtonsoft.Json;

namespace JackieZ_301465524_Lab45
{
    static class TaskManager
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

        public static void Load(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            tasks = jsonSerializer.Deserialize(streamReader, typeof(List<Task>)) as List<Task>;
            fileStream.Close();
            streamReader.Close();
        }

        public static void Save(string path)
        {
            FileStream fileWriter = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileWriter);
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            jsonSerializer.Serialize(streamWriter, tasks);
            streamWriter.Close();
            fileWriter.Close();
        }

        public static Task CreateTask(string description)
        {
            Task task = new Task(description);
            tasks.Add(task);
            return task;
        }
    }
}