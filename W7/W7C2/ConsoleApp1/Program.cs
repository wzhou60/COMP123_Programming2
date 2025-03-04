namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "a", "e", "c", "d" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort(); // Sorts the list.

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}