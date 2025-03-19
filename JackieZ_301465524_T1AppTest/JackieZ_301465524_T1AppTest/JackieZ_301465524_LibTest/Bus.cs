using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackieZ_301465524_LibTest
{
    public class Bus : Vehicle
    {
        public int Passengers { get; set; }

        public Bus()
        {
            kmBeforeMaintenance = 3000;
            VehicleType = VehicleType.Bus;
        }

        public override void Drive(int km, int passengers)
        {
            if (passengers > 0)
            {
                Mileage += km;
                Passengers += passengers;

            }
        }
        public override string ToString()
        {
            return $"{base.ToString()} It carried {Passengers} passengers.";
        }
    }
}
