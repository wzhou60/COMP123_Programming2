namespace Inheritance_SchoolApp
{
    class Student
    {
        private int id;
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public int YOB { get; set; }
        public bool IsInternational { get; }

        //property can act as accessor/ getter setter
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid ID value!");
                }
                else
                {
                    id = value;
                }
            }
        }

        public Student()
        {

        }

        public Student(int ID, string name, int yob, bool isInternational) : this(ID, name)
        {
            YOB = yob;
            IsInternational = isInternational;
        }

        public Student(int ID, string name)
        {
            Id = ID;
            Name = name;
        }

        public string SayHi()
        {
            return $"Hi, my name is {Name} and my id is {id} and I was born in {YOB}";
        }

        public override string ToString()
        {
            return $"Name = {Name}, ID = {id}, YOB = {YOB}, Fee = {Fee:C}, International = {IsInternational}";
        }
    }
}