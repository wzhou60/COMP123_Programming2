//Jackie Zhou 301465524 Lab2/3

namespace JackieZ_301465524_Lab23
{
    internal class Evaluation
    {
        private Course course;
        private DateTime dueDate;
        private byte grade;
        private Guid id;
        private string name;
        private List<Task> tasks;
        private string textFile;
        private EvaluationType type;
        private byte weight;

        public Course Course
        {
            get { return course; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }

            set { dueDate = value; }
        }

        public byte Grade
        {
            get { return grade; }

            set { grade = value; }
        }

        public Guid Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public List<Task> Tasks

        {
            get { return tasks; }
        }

        public string TextFile
        {
            get { return textFile; }

            set { textFile = value; }
        }

        public EvaluationType Type
        {
            get { return type; }

            set { type = value; }
        }

        public byte Weight
        {
            get { return weight; }

            set { weight = value; }
        }

        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            this.type = type;
            this.weight = weight;
            this.dueDate = new DateTime(2025, 12, 31);
            this.grade = 0;
            this.name = "Placeholder Evaluation";
            this.weight = 10;
            this.textFile = "Placeholder";
            this.id = new Guid();
            this.tasks = new List<Task>();
        }

        public Task AddTask(string description)
        {
            Task task1 = new Task(description);
            tasks.Add(task1);
            return (task1);
        }

        public string TasksToString()
        {
            string result = "";
            foreach (Task task in tasks)
                result += $"\n{task}, ";
            return result;
        }

        public override string ToString()
        {
            return $"Evaluation Name: {name}, Type: {type}, Weight: {weight}, Grade: {grade}, Due: {dueDate}, Id: {id}, TextFile: {textFile}";
        }
    }
}