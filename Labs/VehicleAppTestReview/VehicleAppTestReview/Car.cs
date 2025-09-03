namespace VehicleAppTestReview
{
    internal class Car : Vehicle
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public int DoorCount { get; private set; }

        public override string FullDescription
        {
            get
            {
                return $"{base.FullDescription}, Number of Doors: {DoorCount}, Value: {Value}";
            }
        }

        public override double Value
        {
            get
            {
                return (20000 - 1000 * (DateTime.Now.Year + 1 - Year) + 10000 * (6 - DoorCount));
            }
        }

        public Car(string make, string model, int year, int doorCount) : base(make, model, year)
        {
            DoorCount = doorCount;
        }

        public override string StartEngine()
        {
            return $"Car engine started: Vroom!";
        }
    }
}