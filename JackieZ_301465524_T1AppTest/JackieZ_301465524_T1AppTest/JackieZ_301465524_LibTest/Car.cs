using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackieZ_301465524_LibTest
{
    public class Car : Vehicle
    {

        public Car()
        {
            kmBeforeMaintenance = 2500;
            VehicleType = VehicleType.Car;
        }

        public override void Drive(int km, int passengers = 1)
        {
            Mileage += km;

        }
    }
}
