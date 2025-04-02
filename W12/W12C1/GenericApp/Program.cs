namespace GenericApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

            DisplayArray(intArray);
            DisplayArray(doubleArray);
            DisplayArray(charArray);
        }

        private static void DisplayArray<T>(T[] Array)
        {
            foreach (T i in Array)
            {
                Console.WriteLine(i);
            }
        }

        //private static void DisplayArray(int[] intArray)
        //{
        //    foreach (int i in intArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //private static void DisplayArray(double[] intArray)
        //{
        //    foreach (double i in intArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //private static void DisplayArray(char[] intArray)
        //{
        //    foreach (char i in intArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}