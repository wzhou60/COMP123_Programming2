namespace VehicleAppTestReview
{
    abstract class Vehicle
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public virtual string FullDescription
        {
            get
            {
                return $"{Make}, {Model} ({Year})";
            }
        }

        public abstract double Value { get; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public abstract string StartEngine();
    }
}