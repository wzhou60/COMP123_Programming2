namespace Porject2
{
    class Student
    {
        private int id;
        public string Name { get; set; }
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
            return $"Name = {Name}, ID = {id}, YOB = {YOB}, International = {IsInternational}";
        }

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string newName)
        //{
        //    name = newName;
        //}

        //public int getID()
        //{
        //    return id;
        //}

        //public void setID(int value)
        //{
        //    if (value <= 0)
        //    {
        //        Console.WriteLine("Invalid ID value!");
        //    }

        //    else
        //    {
        //        id = value;
        //    }
        //}
    }
}