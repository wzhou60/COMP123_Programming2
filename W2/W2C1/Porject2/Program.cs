namespace Porject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student(12345, "Bob", 2000, true);
            //Console.WriteLine(bob.SayHi());
            //Console.WriteLine(bob);

            Section section = new Section();
            section.Name = "COMP123S1";
            section.Add(bob);
            section.Add(new Student(12346, "Joe", 2001, false));
            section.Add(new Student(12346, "Donald"));
            Console.WriteLine(section);
        }
    }
}