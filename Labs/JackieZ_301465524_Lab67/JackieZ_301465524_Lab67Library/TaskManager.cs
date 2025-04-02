//Jackie Zhou 301465524 Lab6/7

using Newtonsoft.Json;

namespace JackieZ_301465524_Lab67Library
{
    public class TaskManager : IPersistable
    {
        private List<Task> tasks;

        public List<Task> Tasks
        {
            get { return tasks; }
        }

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public string AllTasksToString()
        {
            string result = "";
            foreach (Task task in tasks)
            {
                result += $"\n{task} ";
            }
            return result;
        }

        public void Load(string path)
        {
            FileStream fileStream;
            StreamReader streamReader;
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fileStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
                return;
            }
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            tasks = jsonSerializer.Deserialize(streamReader, typeof(List<Task>)) as List<Task>;
            fileStream.Close();
            streamReader.Close();
        }

        public void Save(string path)
        {
            FileStream fileWriter;
            StreamWriter streamWriter;
            try
            {
                fileWriter = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileWriter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
                return;
            }
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            jsonSerializer.Serialize(streamWriter, tasks);
            streamWriter.Close();
            fileWriter.Close();
        }

        public Task CreateTask(string description)
        {
            Task task = new Task(description);
            tasks.Add(task);
            return task;
        }
    }
}