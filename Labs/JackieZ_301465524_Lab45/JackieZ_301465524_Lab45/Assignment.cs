//Jackie Zhou 301465524 Lab4/5

namespace JackieZ_301465524_Lab45
{
    internal class Assignment : Evaluation
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

        public new Task AddTask(string description)
        {
            Task task = TaskManager.CreateTask(description);
            task.DueDate = DueDate;
            return task;
        }

        public override string ToString()
        {
            return base.ToString() + $", Group Assignment: {IsGroupAssignment}";
        }
    }
}