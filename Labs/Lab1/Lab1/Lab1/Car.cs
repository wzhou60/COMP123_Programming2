namespace Lab1
{
    class Car
    {
        private int year;
        private string manufacturer;
        private string model;
        private double price;
        private bool isDriveable;

        public Car(int year, string manufacturer, string model, double price, bool isDriveable = true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDriveable = isDriveable;
        }

        public override string ToString()
        {
            return "Year: " + year + ", Manufacturer: " + manufacturer + ", Model: " + model + ", Price: " + price + ", Driveable: " + isDriveable;
        }
    }
}