namespace W4C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name = "John", Id = 301 };
            Console.WriteLine(student);

            Student student2 = new Student() { Name = "Jane", Id = 302 };
            Console.WriteLine(student2);

            Student.StudentType studentType = student.Type;

            Student student3 = new Student() { Name = "Joe", Id = 303 };

            Console.WriteLine(student3);
            Console.WriteLine(Student.getNumberOfStudents());

        }
    }
}