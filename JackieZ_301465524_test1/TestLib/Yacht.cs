using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jackie Zhou - 301465524

namespace TestLib
{
    public class Yacht : Ship
    {

        public decimal Cost
        {
            get;
        }

        public Yacht(string name, decimal cost, decimal costPerCrew, int minCrew, int maxPassengers): base (name,  minCrew,  maxPassengers, costPerCrew)
        {
            Cost = cost;
        }

        public override decimal Sail(int passengers = 0)
        {
            CrewNumber = minCrew;
            SailNumber++;
            Profit = Profit + (Cost - (CrewNumber * CostPerCrew));
            if (maxPassengers > passengers)
            {
                passengerNumber = passengers;

            }
            else
            {
                passengerNumber = maxPassengers;

            }
            Console.WriteLine($"Yacht {Name} sailed with {passengerNumber} passengers and {CrewNumber} crew");

            return Profit;

        }

        public override string ToString()
        {
            return $"{base.ToString()} Cost: {Cost:C2}";
        }

    }
}
