namespace MaxApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Maximum of \"6\", \"7\" and \"8\" is {Max("6", "7", "8")}");
            Console.WriteLine($"Maximum of \"6\", \"7\" and \"a\" is {Max("6", "7", "a")}");
        }

        private static T Max<T>(T v1, T v2, T v3)
            where T : IComparable<T>
        {
            T max = v1;
            if (max.CompareTo(v2) < 0)
            {
                max = v2;
            }
            if (max.CompareTo(v3) < 0)
            {
                max = v3;
            }
            return max;
        }
    }
}