using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jackie Zhou - 301465524

namespace TestLib
{
    public abstract class Ship : IComparable<Ship>
    {
        protected int maxPassengers;
        protected int minCrew;
        protected int passengerNumber;

        public string Name
        {
            get;
        }

        public decimal CostPerCrew
        {
            get;
        }

        public int CrewNumber
        {
            get;
            protected set;
        }

        public decimal Profit
        {
            get;
            protected set;
        }

        public int SailNumber
        {
            get;
            protected set;
        }

        public abstract decimal Sail(int passengers = 0);

        public Ship(string name, int minCreww, int maxPassengerss, decimal costPerCrew)
        {
            Name = name;
            minCrew = minCreww;
            maxPassengers = maxPassengerss;
            CostPerCrew = costPerCrew;

        }

        public override string ToString()
        {

            return $"{Name} (max passenger: {maxPassengers}, min crew {minCrew}) made {SailNumber} sails with profit of {Profit:C2}";
        }

        public int CompareTo(Ship? other)
        {
            if (other == null) return 1;

            return (other.Profit / other.SailNumber).CompareTo((this.Profit / this.SailNumber));

        }
    }
}
