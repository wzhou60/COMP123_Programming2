using System.Text.Json.Serialization;

namespace JackieZ_Group3_Lab89Library
{
    public class Course
    {
        private string code;

        [JsonInclude]
        private List<Evaluation> evaluations;

        private uint id;
        private string name;
        private byte semester;

        [JsonInclude]
        private List<Task> tasks;

        public string Code
        {
            get { return code; }

            set { code = value; }
        }

        [JsonIgnore]
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
                    total += (ushort)((float)(e.Weight / 100.0) * e.Grade);
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

        [JsonIgnore]
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
        }

        public void AddEvaluation(EvaluationType type, byte weight, string name, DateTime dueDate = default)
        {
            try
            {
                if (dueDate < DateTime.Now)
                {
                    throw new ArgumentException("Due date must be in the future.");
                }

                int currentTotalWeight = 0;
                foreach (Evaluation e in evaluations)
                {
                    currentTotalWeight += e.Weight;
                }
                if (currentTotalWeight + weight > 100)
                {
                    throw new ArgumentException("Total evaluations weight exceeds 100%.");
                }

                if (type == EvaluationType.Assignment)
                {
                    evaluations.Add(new Assignment(this, weight, dueDate) { Name = name });
                }
                else if (type == EvaluationType.Quiz)
                {
                    evaluations.Add(new Quiz(this, weight) { Name = name, DueDate = dueDate });
                }
                else
                {
                    evaluations.Add(new Evaluation(this, type, weight) { Name = name, DueDate = dueDate });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Task AddTask(string description)
        {
            Task task1 = new Task(description);
            tasks.Add(task1);
            return (task1);
        }

        public string TasksToString()
        {
            string result = $"{code} all tasks: ";
            foreach (Task task in tasks)
            {
                result += $"\n{task} ";
            }
            return result;
        }

        public override string ToString()
        {
            //string result = "";

            //foreach (Evaluation evaluation in evaluations)
            //{
            //    result += $" {evaluation}";
            //}
            return $"ID: {id}, Course Code: {code}, Name: {name}, Semester: {semester}, Total Grade: {Grade}% ";
        }
    }
}