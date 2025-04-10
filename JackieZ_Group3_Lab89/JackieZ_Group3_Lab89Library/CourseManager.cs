using Newtonsoft.Json;

namespace JackieZ_Group3_Lab89Library
{
    public class CourseManager : IPersistable
    {
        private List<Course> courses = new List<Course>();

        public List<Course> Courses
        {
            get
            {
                return courses;
            }
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
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
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented });
            courses = jsonSerializer.Deserialize(streamReader, typeof(List<Course>)) as List<Course>;
            streamReader.Close();
            fileStream.Close();
        }

        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
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
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented });
            jsonSerializer.Serialize(streamWriter, courses);
            streamWriter.Close();
            fileWriter.Close();
        }

        public string ToString()
        {
            string result = "";
            foreach (Course course in courses)
            {
                result += $"\n{course}";
            }
            return result;
        }
    }
}