namespace W4C2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsInternational { get; set; }

        public Student(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, International: {IsInternational}";
        }
    }
}