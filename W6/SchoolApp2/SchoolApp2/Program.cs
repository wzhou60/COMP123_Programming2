using SchoolLib;

namespace SchoolApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student student1 = new Student(1, "Bob", 2000) { Fee = 2000m };
            InternationalStudent student2 = new InternationalStudent() { Id = 2, Name = "Alice", YOB = 2001, Fee = 4000m, Country = "Canada" };
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student1.SayHi());
            Console.WriteLine(student2.SayHi());

            Student s = student2;
            Console.WriteLine(s.SayHi());

            Console.WriteLine("*******************");
            List<Student> students = new List<Student>() { student1, student2 };
            foreach (Student student in students)
            {
                Console.WriteLine(student.SayHi());
            }

            //compile time type: typ when it is compiled
            //runtime type: type reference holds (override looks for method in runtim type first)
            //polymorphism
            //
        }
    }
}