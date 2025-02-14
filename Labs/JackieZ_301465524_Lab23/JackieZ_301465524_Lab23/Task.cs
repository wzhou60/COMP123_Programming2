//Jackie Zhou 301465524 Lab2/3
namespace JackieZ_301465524_Lab23
{
    internal struct Task
    {
        public string Description;
        private bool done;
        public DateTime DueDate; 

        public bool Done
        {
            get { return done; }

            set { done = value; }
        }

        public Task(string description)
        {
            Description = description;
            DueDate = DateTime.MaxValue;
            done = false;
        }

        public override string ToString()
        {
            return $"Task: {Description}, Due: {DueDate}, Done: {Done}";
        }
    }
}