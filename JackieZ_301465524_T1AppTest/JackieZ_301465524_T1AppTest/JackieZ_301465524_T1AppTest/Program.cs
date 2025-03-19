using JackieZ_301465524_LibTest;

namespace JackieZ_301465524_T1AppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car() { MakeModel = "HondaCRV" };
            Vehicle car2 = new Car() { MakeModel = "Ford Mustang" };


            Bus bus1 = new Bus() { MakeModel = "ShodaTransport" };
            bus1.Drive(300, 0);
            bus1.Drive(500, 10);

            Console.WriteLine($"{car1.MakeModel} maintanence: {car1.IsDueForMaintenance} ");

            for (int i = 0; i < 10; i++)
            {

                Drive(bus1, 500, 10);
                Drive(car1, 299);
                Drive(car2, 250);

            }


            Console.WriteLine($"{car1.MakeModel} maintanence: {car1.IsDueForMaintenance} ");
            Console.WriteLine($"{car2.MakeModel} maintanence: {car2.IsDueForMaintenance} ");
            Console.WriteLine($"{bus1.MakeModel} maintanence: {bus1.IsDueForMaintenance} ");

            Console.WriteLine(bus1);
            Console.WriteLine(car1);
            Console.WriteLine(car2);


        }

        private static void Drive(Vehicle vehicle, int km, int passengers=1)
        {
            vehicle.Drive(km, passengers);

        }
    }
}
