namespace AnimalLibrary
{
    public abstract class Animal : IComparable
    {
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            Animal animal = obj as Animal;
            if (animal == null)
            {
                return -1;
            }

            return Name.CompareTo(animal.Name);
            //return this.Name.CompareTo(animal.Name); //opposite order descending?
        }

        public abstract void Talk();

        public override string ToString()
        {
            return $"{GetType()} Name: {Name}";
        }
    }
}