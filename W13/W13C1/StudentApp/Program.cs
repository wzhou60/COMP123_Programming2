namespace StudentApp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            { 
                new Student() { Id=1, Name="John Doe 1" },
                new Student() { Id=2, Name="John Doe 2" },
                new Student() { Id=3, Name="John Doe 3" },
                new Student() { Id=4, Name="John Doe 4" },
                new Student() { Id=5, Name="John Doe 5" },
                new Student() { Id=6, Name="John Doe 6" },
            };

            var studentQuery = from student in students
                               select new { newID= student.Id+3000, Name = student.Name };

            foreach (var student in studentQuery)
            {
                Console.WriteLine($"{student}");
               // Console.WriteLine($"{student.Id} - {student.Name}");
            }


        }
    }
}