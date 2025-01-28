namespace StructApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address;
            address.Street = "123 Main Street";
            address.City = "Anytown";
            address.Country = "Canada";
            Console.WriteLine(address.Street);

            Address address2 = new Address();
   
            Console.WriteLine(address2);
        }
    }
}