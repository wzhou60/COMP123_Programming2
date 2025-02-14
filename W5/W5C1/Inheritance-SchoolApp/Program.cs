namespace Inheritance_SchoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Bob", 2000, false) { Fee = 2000.0M };
            Console.WriteLine(student);
            InternationalStudent student2 = new InternationalStudent() { Id = 2, Name = "Alice", YOB = 2001, Country = "India", Fee = 3000.0M };
            Console.WriteLine(student2);

            Student s;
            s = student2;
        }
    }
}