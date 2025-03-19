namespace FilterApp
{
    internal class Program
    {
        public delegate bool NumberPredicate(int value);

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //init delegate with function
            NumberPredicate func = isEven;

            //List<int> filteredNumbers = Filter(numbers, func);
            List<int> filteredNumbers = Filter(numbers, isEven);
            DisplayList("Even Numbers", filteredNumbers);

            filteredNumbers = Filter(numbers, isOdd);
            DisplayList("Odd Numbers", filteredNumbers);

            filteredNumbers = Filter(numbers, isGT5);
            DisplayList("Greater than 5", filteredNumbers);


        }

        private static void DisplayList(string message, List<int> filteredNumbers)
        {
            Console.WriteLine(message);
            foreach (int number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static List<int> Filter(int[] numbers, NumberPredicate predicateFunc)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (predicateFunc(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        private static List<int> FilterOdd(int[] numbers)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (isOdd(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        private static List<int> FilterEven(int[] numbers)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (isEven(number))
                {
                    filteredNumbers.Add(number);
                }
            }
            return filteredNumbers;
        }

        private static bool isOdd(int number)
        {
            return (number % 2 == 1);
        }

        private static bool isEven(int number)
        {
            return (number % 2 == 0);
        }

        private static bool isGT5(int number)
        {
            return (number > 5);
        }
    }
}