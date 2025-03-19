using TestLib;
//Jackie Zhou - 301465524

namespace JackieZ_301465524_test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            Yacht yacht1 = new Yacht("Barracuda", 30000M, 1000M, 5, 10);
            Yacht yacht2 = new Yacht("Mona", 50000M, 2000M, 7, 20);
            CruiseShip cruiseShip1 = new CruiseShip("Oasis on the Sea", 2000M, 20, 1000M, 50, 2000);
            CruiseShip cruiseShip2 = new CruiseShip("Odyssey on the Sea", 2000M, 30, 2000M, 100, 3000) { PassengerNumber = 3500 };

            ships.Add(yacht1);
            ships.Add(yacht2);
            ships.Add(cruiseShip1);
            ships.Add(cruiseShip2);

            foreach (Ship ship in ships)
            {
                Console.WriteLine(ship);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Trip profit {yacht1.Sail(10):c}");
                Console.WriteLine($"Trip profit {yacht2.Sail(10):c}");
                Console.WriteLine($"Trip profit {cruiseShip1.Sail(1000):c}");
                Console.WriteLine($"Trip profit {cruiseShip2.Sail():c}");
            }

            Console.WriteLine("\nAfter the end of season:");
            foreach (Ship ship in ships)
            {
                Console.WriteLine(ship);
            }
            ships.Sort();
            Console.WriteLine("\nShips sorted by profit per trip");
            foreach (Ship ship in ships)
            {
                Console.WriteLine($"{ship.Name} - {ship.Profit / ship.SailNumber}");
            }




        }
    }
}
