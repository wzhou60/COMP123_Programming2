namespace StructApp
{
    internal struct Address
    {
        public string Street; //{ get; set; }
        public string City; //{ get; set; }
        public string Country;   //{ get; set; }

        public Address()
        {
            Street = "No Street";
            City = "NOne";
            Country = "USA";
        }
        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }
    }
}