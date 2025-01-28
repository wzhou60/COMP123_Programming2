//Jackie Zhou - 301465524
namespace Lab103
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            Date date1 = new Date(2022, 11, 29);
            Date date2 = new Date(2020, 2, 29);

            Console.WriteLine(date.ToString());
            Console.WriteLine(date1.ToString());
            date1.Add(33);
            Console.WriteLine(date1.ToString());
            date1.Add(3, 3);
            Console.WriteLine(date1.ToString());
            date1.Add(date);
            Console.WriteLine(date1.ToString());
            //lepa year test
            Console.WriteLine(date2.ToString());
            date2.Add(1);
            Console.WriteLine(date2.ToString());
        }
    }
}