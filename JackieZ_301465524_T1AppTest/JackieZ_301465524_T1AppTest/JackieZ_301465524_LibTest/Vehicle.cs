namespace JackieZ_301465524_LibTest
{
    public abstract class Vehicle
    {
        bool isDueForMaintenance;
        protected int kmBeforeMaintenance;
        int mileage;

        public bool IsDueForMaintenance
        {
            get { return isDueForMaintenance; }
        }

        public string MakeModel { get; set; }

        public int Mileage
        {
            get { return mileage; }
            protected set
            {
                mileage = value;
                if (mileage > kmBeforeMaintenance)
                {
                    isDueForMaintenance = true;
                }


            }
        }

        public VehicleType VehicleType { get; set; }

        public abstract void Drive(int km, int passengers = 1);

        public override string ToString()
        {
            string not = (IsDueForMaintenance ? "" : "not");
            return $"{VehicleType} {MakeModel} TRAVELLED {Mileage} and it is {not} due for maintanance ";
        }



    }
}
