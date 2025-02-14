//Jackie Zhou 301465524 Lab2/3

namespace JackieZ_301465524_Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course(1, "COMP123") { Name = "Programming 2", Semester = 1 };
            Course course2 = new Course(2, "COMP125") { Name = "Programming 3", Semester = 1 };
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine();

            course1.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 1");
            course1.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 2");
            course1.AddEvaluation(EvaluationType.Quiz, 10, "Quiz 1");
            course1.AddEvaluation(EvaluationType.Quiz, 10, "Quiz 2");
            course1.AddEvaluation(EvaluationType.Test, 20, "Test 1");
            course1.AddEvaluation(EvaluationType.Test, 20, "Test 2");

            course2.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 1");
            course2.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 2");
            course2.AddEvaluation(EvaluationType.Assignment, 10, "Assignment 3");
            course2.AddEvaluation(EvaluationType.Test, 20, "Test 1");
            course2.AddEvaluation(EvaluationType.Test, 20, "Test 2");
            course2.AddEvaluation(EvaluationType.Test, 20, "Test 3");

            Console.WriteLine(course1);
            Console.WriteLine();
            Console.WriteLine(course2);
            Console.WriteLine();

            course1.Evaluations[0].DueDate = DateTime.Today.AddDays(2);
            course1.Evaluations[0].Grade = 75;
            course1.Evaluations[1].Grade = 95;
            Console.WriteLine(course1);

            Task task1 = TaskManager.CreateTask("Course 1 Task 1");
            course1.AddTask(task1.Description);
            task1.DueDate = new DateTime(2025, 12, 31);
            course1.Tasks[0] = task1;
            Task task2 = TaskManager.CreateTask("Course 1 Task 2");
            course1.AddTask(task2.Description);
            Console.WriteLine(course1.TasksToString());

            Task task3 = TaskManager.CreateTask("Evaluation 2 Task 1");
            course1.Evaluations[1].AddTask(task3.Description);
            Console.WriteLine(course1.Evaluations[1].TasksToString());
            Console.WriteLine();

            MyDay newMyDay = MyDay.NewDay();
            task1.Done = true;
            newMyDay.AddDayTask(task1);
            newMyDay.AddDayTask(task2);
            Console.WriteLine(newMyDay.ToString());
        }
    }
}