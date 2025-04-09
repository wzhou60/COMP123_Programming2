 

namespace JackieZ_Group3_Lab89Library
{
    public class Assignment : Evaluation
    {
        public bool IsGroupAssignment
        {
            get; set;
        }

        public Assignment(Course course, byte weight, DateTime dueDate = default, bool isGroupAssignment = false)
            : base(course, EvaluationType.Assignment, weight)
        {
            IsGroupAssignment = isGroupAssignment;
            DueDate = dueDate;
        }

        public override Task AddTask(string description)
        {
            Task task = new Task(description);
            task.DueDate = DueDate;
            Tasks.Add(task);
            return task;
        }

        public override string ToString()
        {
            return base.ToString() + $", Group Assignment: {IsGroupAssignment}";
        }
    }
}