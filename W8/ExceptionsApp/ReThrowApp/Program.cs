namespace ReThrowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main");
            A();
            Console.WriteLine("End of Main");
        }

        private static void A()
        {
            Console.WriteLine("In A");
            try
            {
                B();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"In A {ex.Message}");
                throw;
            }
            Console.WriteLine("End of A");
        }

        private static void B()
        {
            Console.WriteLine("In B");
            try
            {
                C();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ProblemException("Problematic");
            }
            Console.WriteLine("End of B");
        }

        private static void C()
        {
            throw new NotImplementedException();
        }
    }
}