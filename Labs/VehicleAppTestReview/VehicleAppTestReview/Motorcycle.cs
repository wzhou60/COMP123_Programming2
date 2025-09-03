using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppTestReview
{
    internal class Motorcycle : Vehicle
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public bool HasSideCar { get; private set; }

        public override string FullDescription
        {
            get
            {
                return $"{base.FullDescription}, HasSidecar: {HasSideCar}, Value: {Value}";
            }
        }

        public override double Value
        {
            get
            {
                return 15_000 - 1_000 * (DateTime.Now.Year + 1 - Year) + 1_000 * (HasSideCar ? 1 : 0);
            }
        }

        public Motorcycle(string make, string model, int year, bool hasSideCar) : base(make, model, year)
        {
            HasSideCar = hasSideCar;
        }

        public override string StartEngine()
        {
            return $"Motorcycle engine started: Vroom Vroom!";
        }
    }
}