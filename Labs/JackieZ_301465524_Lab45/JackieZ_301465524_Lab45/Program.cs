//Jackie Zhou 301465524 Lab4/5

namespace JackieZ_301465524_Lab45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Create two courses");
            Course course1 = new Course(1, "COMP123") { Name = "Programming 2", Semester = 1 };
            Course course2 = new Course(2, "COMP125") { Name = "Programming 3", Semester = 1 };

            Console.WriteLine("2. Add courses to the course manager");
            CourseManager.AddCourse(course1);
            CourseManager.AddCourse(course2);

            Console.WriteLine("3. Write content of course manager to the console");
            Console.WriteLine(CourseManager.ToString());

            Console.WriteLine("4. Add 2 assignments to the first course with due dates in 14 and 7 days respectively");
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A1", DateTime.Now.AddDays(14));
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A2", DateTime.Now.AddDays(7));

            Console.WriteLine("5. Add quiz, and test to the first course");
            course1.AddEvaluation(EvaluationType.Quiz, 10, "Q1");
            course1.AddEvaluation(EvaluationType.Test, 20, "T1");

            Console.WriteLine("6. Add test to the first course");
            course1.AddEvaluation(EvaluationType.Test, 20, "T2");

            Console.WriteLine("7. Add 2 assignments to the second course with due dates in 10, 5, and 6 days respectively");
            course2.AddEvaluation(EvaluationType.Assignment, 10, "A1", DateTime.Now.AddDays(10));
            course2.AddEvaluation(EvaluationType.Assignment, 10, "A2", DateTime.Now.AddDays(5));
            course2.AddEvaluation(EvaluationType.Assignment, 10, "A3", DateTime.Now.AddDays(6));

            Console.WriteLine("8. Add test to the first course");
            course1.AddEvaluation(EvaluationType.Test, 20, "T3");

            Console.WriteLine("9. Set TextFile for the first assignment of the first course to 'Evaluations\\COMP123\\Assignmnet1.txt'");
            course1.Evaluations[0].TextFile = "Evaluations\\COMP123\\Assignmnet1.txt";

            Console.WriteLine("10. Write content of the evaluation text for the first assignment of the first course");
            Console.WriteLine(course1.Evaluations[0].EvaluationText);

            Console.WriteLine("\n11. Write content of course manager to the console");
            Console.WriteLine(CourseManager.ToString());

            Console.WriteLine("12. Add grade to the first assignment of the first course");
            course1.Evaluations[0].Grade = 90;
            Console.WriteLine("13. Write content of course manager to the console");
            Console.WriteLine(CourseManager.ToString());

            Console.WriteLine("14. Add grade to the second assignment of the first course ");
            course1.Evaluations[1].Grade = 100;
            Console.WriteLine("15. Write content of course manager to the console ");
            Console.WriteLine(CourseManager.ToString());

            Console.WriteLine("16. Add task 'Read chapter 2' to the first course with due date in 6 days");
            Task task1 = course1.AddTask("Read chapter 2");
            task1.DueDate = DateTime.Now.AddDays(6);

            Console.WriteLine("17. Add task 'Read chapter 3' to the first course");
            Task task2 = course1.AddTask("Read chapter 3");

            Console.WriteLine("18. Output tasks for the first course to the console \n");
            Console.WriteLine(course1.TasksToString());

            Console.WriteLine("\n19. Add task 'Start assignment' to the first assignment of the first course");
            Task task3 = course1.Evaluations[0].AddTask("Start assignment");

            Console.WriteLine("20. Add task 'Write main() method' to the first assignment of the first course and mark it done ");
            Task task4 = course1.Evaluations[0].AddTask("Write main() method");
            task4.IsDone = true;

            Console.WriteLine("21. Output all task for the first evaluation of the first course to the console");
            Console.WriteLine(course1.Evaluations[0].TasksToString());

            Console.WriteLine("\n22. Create MyDay and add two tasks");
            MyDay myDay = MyDay.NewDay();
            myDay.AddDayTask(task1);
            myDay.AddDayTask(task2);

            Console.WriteLine("23. Output the MyDay to the console");
            Console.WriteLine(myDay.ToString());

            Console.WriteLine("24. Save content of the course manager to courses.json");
            CourseManager.Save("courses.json");

            Console.WriteLine("25. Save content of the task manager to tasks.json");
            TaskManager.Save("tasks.json");

            Console.WriteLine("26. Load content to the course manager from courses.json");
            CourseManager.Load("courses.json");

            Console.WriteLine("27. Load content to the task manager from tasks.json");
            TaskManager.Load("tasks.json");

            Console.WriteLine("28. Output a separator");
            Console.WriteLine("****************************************");

            Console.WriteLine("29. Write content of course manager to the console");
            Console.WriteLine(CourseManager.ToString());

            Console.WriteLine("30. Write all tasks in the task manager to the console");
            Console.WriteLine(TaskManager.AllTasksToString());
        }
    }
}