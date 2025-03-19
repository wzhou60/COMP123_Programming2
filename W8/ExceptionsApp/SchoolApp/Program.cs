namespace SchoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Id = 1, Name = "John Doe" };
            Console.WriteLine(student);
            try
            {
                student.Id = -1;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Id");
            }
            Console.WriteLine(student);
        }
    }
}