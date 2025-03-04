namespace ExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int aNumber = 0;

            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            try
            {
                aNumber = Convert.ToInt32(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("An exception occured");
            }
            Console.WriteLine(userInput);
            Console.WriteLine(aNumber);
        }
    }
}