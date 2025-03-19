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
            //catch (Exception){ } // catch is top to bottom, exception on top makes the others obsolete 

            catch (FormatException ex) //do code block if you get this object (exception)
            {
                Console.WriteLine("An format exception occured");
                //Console.WriteLine(ex.StackTrace);
            }
            catch (OverflowException)
            {
                Console.WriteLine("An overflow exception occured");
            }

            Console.WriteLine(userInput);
            Console.WriteLine(aNumber);
        }
    }
}