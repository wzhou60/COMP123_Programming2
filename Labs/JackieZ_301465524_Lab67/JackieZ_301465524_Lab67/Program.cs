using JackieZ_301465524_Lab67Library;
using Task = JackieZ_301465524_Lab67Library.Task;

namespace JackieZ_301465524_Lab67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0. Create instance of both TaskManager and CourseManager classes");
            TaskManager taskManager = new TaskManager();
            CourseManager courseManager = new CourseManager();

            Console.WriteLine("1. Create 2 courses");
            Course course1 = new Course(1, "COMP123");
            Course course2 = new Course(2, "COMP125");

            Console.WriteLine("2. Add courses to the course manager");
            courseManager.AddCourse(course1);
            courseManager.AddCourse(course2);

            Console.WriteLine("3. Write content of course manager to the console");
            Console.WriteLine(courseManager.ToString());

            Console.WriteLine("4. Add 2 assignments to the first course with due dates in 14 and 7 days respectively");
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A1", DateTime.Now.AddDays(14));
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A2", DateTime.Now.AddDays(7));

            Console.WriteLine("5. Add quiz, and test to the first course");
            course1.AddEvaluation(EvaluationType.Quiz, 5, "Quiz1", DateTime.Now.AddDays(14));
            course1.AddEvaluation(EvaluationType.Test, 25, "Test1", DateTime.Now.AddDays(7));

            Console.WriteLine("6. Add test to the first course");
            course1.AddEvaluation(EvaluationType.Test, 25, "Test2", DateTime.Now.AddDays(7));

            Console.WriteLine("7. Add 3 assignments to the second course with due dates in 10, 5, and 6 days respectively");
            course2.AddEvaluation(EvaluationType.Assignment, 20, "A1", DateTime.Now.AddDays(10));
            course2.AddEvaluation(EvaluationType.Assignment, 10, "A2", DateTime.Now.AddDays(5));
            course2.AddEvaluation(EvaluationType.Assignment, 10, "A3", DateTime.Now.AddDays(6));

            Console.WriteLine("\n8.Trying to add assignment with a due date in the past");
            course1.AddEvaluation(EvaluationType.Assignment, 10, "A3", DateTime.Now.AddDays(-14));

            Console.WriteLine("\n9. Trying to add assignment with a weight that exceeds total weight of 100% for all assignments");
            course1.AddEvaluation(EvaluationType.Assignment, 95, "A4", DateTime.Now.AddDays(14));

            Console.WriteLine("\n10. Trying to modify the weight of an assignment to exceeds total weight of 100% for all assignments");
            course1.Evaluations[0].Weight = 95;

            Console.WriteLine("\n11. Add test to the first course");
            course1.AddEvaluation(EvaluationType.Test, 15, "Test3", DateTime.Now.AddDays(7));

            Console.WriteLine("12. Set TextFile for the first assignment of the first course to 'Evaluations\\COMP123\\Assignmnet1.txt'");
            course1.Evaluations[0].TextFile = "Evaluations\\COMP123\\Assignmnet1.txt";

            Console.WriteLine("13. Write content of the evaluation text for the first assignment of the first course");
            Console.WriteLine(course1.Evaluations[0].EvaluationText);

            Console.WriteLine("14. Write content of course manager to the console");
            Console.WriteLine(courseManager.ToString());

            Console.WriteLine("15. Add grade to the first assignment of the first course");
            course1.Evaluations[0].Grade = 55;

            Console.WriteLine("16. Write content of course manager to the console");
            Console.WriteLine(courseManager.ToString());

            Console.WriteLine("17. Add grade to the second assignment of the first course");
            course1.Evaluations[1].Grade = 100;

            Console.WriteLine("18. Write content of course manager to the console");
            Console.WriteLine(courseManager.ToString());

            Console.WriteLine("19. Add task 'Read chapter 2' to the first course with due date in 6 days");
            Task task1 = course1.AddTask("Read chapter 2");
            task1.DueDate = DateTime.Now.AddDays(6);
            taskManager.Tasks.Add(task1);


            Console.WriteLine("20. Add task 'Read chapter 3' to the first course");
            Task task2 = course1.AddTask("Read chapter 3");
            taskManager.Tasks.Add(task2);

            Console.WriteLine("21. Output tasks for the first course to the console");
            Console.WriteLine(course1.TasksToString());

            Console.WriteLine("\n22. Add task 'Start assignment' to the first assignment of the first course");
            Task task3 = course1.Evaluations[0].AddTask("Start assignment");
            taskManager.Tasks.Add(task3);

            Console.WriteLine("23. Add task 'Write main() method' to the first assignment of the first course and mark it done");
            Task task4 = course1.Evaluations[0].AddTask("Write main() method");
            course1.Evaluations[0].Tasks[1].IsDone = true;
            taskManager.Tasks.Add(task4);

            Console.WriteLine("24. Output all task for the first evaluation of the first course to the console");
            Console.WriteLine(course1.Evaluations[0].TasksToString());

            Console.WriteLine("\n25. Create MyDay and add 2 tasks");
            MyDay myDay = MyDay.NewDay();
            myDay.AddDayTask(task1);
            myDay.AddDayTask(task2);

            Console.WriteLine("26. Output the MyDay to the console");
            Console.WriteLine(myDay.ToString());

            Console.WriteLine("\n27. Create array of 2 IPersistable elements and add instances of class and task manager");
            IPersistable[] elements = new IPersistable[2];
            elements[0] = courseManager;
            elements[1] = taskManager;

            Console.WriteLine("28. Persist all elements of the array using Save method");
            elements[0].Save($"Save\\{elements[0].GetType().Name}.json");
            elements[1].Save($"Save\\{elements[1].GetType().Name}.json");

            Console.WriteLine("29. Create instance of both TaskManager and CourseManager classes and add them to elements of the array");
            TaskManager taskManager2 = new TaskManager();
            CourseManager courseManager2 = new CourseManager();
            elements[0] = courseManager2;
            elements[1] = taskManager2;

            Console.WriteLine("30. Load all persisted content from a file in each element of the array");
            elements[0].Load($"Save\\{elements[0].GetType().Name}.json");
            elements[1].Load($"Save\\{elements[1].GetType().Name}.json");

            Console.WriteLine("31. Output a separator");
            Console.WriteLine("****************************************");

            Console.WriteLine("32. Write content of course manager to the console");
            Console.WriteLine(courseManager2.ToString());
            Console.WriteLine("33. Write all tasks in the task manager to the console");
            Console.WriteLine(taskManager2.AllTasksToString());
        }
    }
}