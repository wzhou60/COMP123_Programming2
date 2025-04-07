namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 i = 56;
            i.PrintDigits("Digits are");
        }
    }

    public static class ExtensionMethod
    {
        public static void PrintDigits(this Int32 x, string message)
        {
            Console.Write($"{message}: "); 
            Console.WriteLine(x % 10);
            Console.WriteLine((x / 10) % 10);
            //Console.Write(x.ToString());
        }
    }
}