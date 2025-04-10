using Newtonsoft.Json;

namespace JackieZ_Group3_Lab89Library
{
    public class Evaluation
    {
        private Course course;
        private DateTime dueDate;
        private byte grade;
        private Guid id;
        private string name;
        private List<Task> tasks;
        private string textFile;
        private readonly EvaluationType type;
        private byte weight;

        [JsonIgnore]
        public Course Course
        {
            get { return course; }
            set { course = value; }
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
        }

        public byte Weight
        {
            get { return weight; }

            set
            {
                //try
                //{
                int currentTotalWeight = 0;
                foreach (Evaluation e in course.Evaluations)
                {
                    currentTotalWeight += e.Weight;
                }
                if (currentTotalWeight + value > 100)
                {
                    throw new ArgumentException("Total evaluations weight exceeds 100%.");
                }

                weight = value;
                //}
                //catch (Exception ex)
                //{
                //   // Console.WriteLine(ex.Message);
                //}
            }
        }

        public string EvaluationText
        {
            get
            {
                string line = "";
                try
                {
                    if (textFile == null)
                    {
                        return "";
                    }
                    else
                    {
                        FileStream fileIn = new FileStream(textFile, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fileIn);
                        line = ("\n***** EVALUATION TEXT *****\n");
                        line += reader.ReadToEnd();

                        reader.Close();
                        fileIn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving the evaluation text: {ex.Message}");
                }

                return line;
            }
        }

        public Evaluation(Course course, EvaluationType type, byte weight)
        {
            this.course = course;
            this.type = type;
            this.weight = weight;
            tasks = new List<Task>();
        }

        public virtual Task AddTask(string description)
        {
            Task task1 = new Task(description);
            task1.DueDate = dueDate;
            tasks.Add(task1);
            return task1;
        }

        public string TasksToString()
        {
            string result = $"\nAll tasks for evaluation {name}:";
            foreach (Task task in tasks)
                result += $"\n{task}, ";
            return result;
        }

        public override string ToString()
        {
            string dueDateString = "";
            if (dueDate == default(DateTime))
            {
                dueDateString = "No due date";
            }
            else
            { dueDateString = $"Due: {dueDate}"; }

            return $"Name: {name}, Type: {type}, Weight {weight}%, {dueDateString}, Grade: {grade}%";
        }
    }
}