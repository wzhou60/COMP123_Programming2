namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "FirstString";
            string s2 = "SecondString";

            Console.WriteLine($"s1= {s1}, s2= {s2} ");
            SwapApp(ref s1, ref s2);
            Console.WriteLine($"s1= {s1}, s2= {s2} ");
            int i1=1, i2=2;
            Console.WriteLine($"i1= {i1}, i2= {i2} ");
            SwapApp(ref i1, ref i2);
            Console.WriteLine($"i1= {i1}, i2= {i2} ");

        }

        private static void SwapApp<T>(ref T s1, ref T s2)
        {
            T temp;
            temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}