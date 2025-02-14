namespace SchoolLib
{
    public class Student
    {
        private int id;
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public int YOB { get; set; }
        // public bool IsInternational { get; }

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
            Console.WriteLine("Default constructor called");
        }

        public Student(int ID, string name, int yob)
        {
            Id = ID;
            Name = name;
            YOB = yob;
        }

        //public Student(int ID, string name, int yob, bool isInternational) : this(ID, name, yob)
        //{
        //    IsInternational = isInternational;
        //}

        public virtual string SayHi()
        {
            return $"Hi, my name is {Name} and my ID is {id} and I was born in {YOB}";
        }

        public override string ToString()
        {
            return $"Name = {Name}, ID = {id}, YOB = {YOB}, Fee = {Fee:C}";
        }
    }
}