namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar1 = new Car(2028, "Honda", "Civic", 30000.00, true);
            Car myCar2 = new Car(2020, "Toyota", "Sprinter", 35000.00, true);
            Car myCar3 = new Car(2012, "Tesla", "F150", 40000.00, true);
            Car myCar4 = new Car(2013, "Ford", "Model Y", 450000.00, false);
            Car myCar5 = new Car(2013, "Audi", "Corolla", 650000.00);
            Console.WriteLine(myCar1.ToString());
            Console.WriteLine(myCar2.ToString());
            Console.WriteLine(myCar3.ToString());
            Console.WriteLine(myCar4.ToString());
            Console.WriteLine(myCar5.ToString());
        }
    }
}