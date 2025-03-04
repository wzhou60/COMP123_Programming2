//Jackie Zhou 301465524 Lab4/5

using Newtonsoft.Json;

namespace JackieZ_301465524_Lab45
{
    static class CourseManager
    {
        private static List<Course> courses = new List<Course>();

        public static List<Course> Courses
        {
            get
            {
                return courses;
            }
        }

        public static void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public static void Load(string path)
        {
            FileStream fileReader = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileReader);
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            courses = jsonSerializer.Deserialize(streamReader, typeof(List<Course>)) as List<Course>;
            streamReader.Close();
            fileReader.Close();
        }

        public static void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }

        public static void Save(string path)
        {
            FileStream fileWriter = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileWriter);
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            jsonSerializer.Serialize(streamWriter, courses);
            streamWriter.Close();
            fileWriter.Close();
        }

        public static string ToString()
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