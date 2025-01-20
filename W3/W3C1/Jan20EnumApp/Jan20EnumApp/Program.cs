namespace Jan20EnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;
            Weekday day;
            day = Weekday.Sun;
            val = (int)day;
            Console.WriteLine(day);
            Console.WriteLine(val);
            val = 5;
            day = (Weekday)val;
            Console.WriteLine(day);
            Console.WriteLine(val);
            Console.WriteLine("Printing Weekday");
            for (Weekday i = Weekday.Mon; i <= Weekday.Sun; i++)
            {
                Console.WriteLine(i);
            }
            //foreach (Weekday wd in Enum.GetValues(typeof(Weekday)))
            //{
            //    Console.WriteLine(wd);
            //}
        }
    }
}