using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jackie Zhou - 301465524
namespace TestLib
{
    public class CruiseShip : Ship
    {
        public decimal PricePerPassenger
        {
            get;
        }

        public int PassengersPerCrew
        {
            get { return PassengerNumber / minCrew; }
        }

        public int PassengerNumber
        {

            get { return passengerNumber; }
            set
            {
                passengerNumber = maxPassengers;
                CrewNumber = minCrew + (passengerNumber / PassengersPerCrew);
            }
        }


        public CruiseShip(string name, decimal pricePerPassenger, int crewPerPassenger, decimal costPerCrew, int minCrew, int maxPassengers) :
            base(name, minCrew, maxPassengers, costPerCrew)
        {
            PricePerPassenger = pricePerPassenger;
            int additionalCrew = passengerNumber / (crewPerPassenger);

            CrewNumber = minCrew + additionalCrew;
        }

        public override decimal Sail(int passengers = 0)
        {
            if (maxPassengers > passengers)
            {
                passengerNumber = passengers;
            }
            else
            {
                passengerNumber = maxPassengers;
            }

            SailNumber++;
            Profit = Profit+ (PassengerNumber * PricePerPassenger) - (CrewNumber * CostPerCrew);

            Console.WriteLine($"Cruise ship {Name} sailed with {passengerNumber} passengers and {CrewNumber} crew");

            return Profit;

        }

        public override string ToString()
        {
            return $"{base.ToString()} Cost per passenger: {PricePerPassenger:C2} Passengers per crew: {PassengersPerCrew}";
        }

    }
}
