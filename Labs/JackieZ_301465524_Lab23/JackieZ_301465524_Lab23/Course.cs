//Jackie Zhou 301465524 Lab2/3

namespace JackieZ_301465524_Lab23
{
    internal class Course
    {
        private string code;
        private List<Evaluation> evaluations;
        private uint id;
        private string name;
        private byte semester;
        private List<Task> tasks;

        public string Code
        {
            get { return code; }

            set { code = value; }
        }

        public List<Evaluation> Evaluations
        {
            get { return evaluations; }
        }

        public ushort Grade
        {
            get
            {
                ushort total = 0;
                foreach (Evaluation e in evaluations)
                {
                    total += (ushort)(e.Weight * e.Grade);
                }

                return total;
            }
        }

        public uint Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public byte Semester
        {
            get { return semester; }

            set { semester = value; }
        }

        public List<Task> Tasks
        {
            get { return tasks; }
        }

        public Course(uint id, string code)
        {
            this.id = id;
            Code = code;
            tasks = new List<Task>();
            evaluations = new List<Evaluation>();
            semester = 1;
            name = "Placeholder";
        }

        public void AddEvaluation(EvaluationType type, byte weight, string name)
        {
            evaluations.Add(new Evaluation(this, type, weight) { Name = name });
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
            {
                result += $"\n{task}, ";
            }
            return result;
        }

        public override string ToString()
        {
            string result = "";

            foreach (Evaluation evaluation in evaluations)
            {
                result += $" \n{evaluation},";
            }
            return $"Course: {name}, Code: {code}, Semester: {semester}, ID: {id}, Evaluations: {result}";
        }
    }
}