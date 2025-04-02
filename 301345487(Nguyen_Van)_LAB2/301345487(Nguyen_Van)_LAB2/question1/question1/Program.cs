using System;
using System.Collections.Generic;

class Course
{
    public string Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Credits { get; set; }

    public Course(string code, string title, string description, int credits)
    {
        Code = code;
        Title = title;
        Description = description;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"Code: {Code}, Title: {Title}, Description: {Description}, Credits: {Credits}";
    }
}

class Program
{
    static Dictionary<string, Course> courses = new Dictionary<string, Course>();

    static void Main()
    {
        // Sample Data
        courses.Add("COMP101", new Course("COMP101", "Intro to Programming", "Basic programming concepts", 3));
        courses.Add("COMP202", new Course("COMP202", "Data Structures", "Introduction to data structures", 4));

        while (true)
        {
            Console.WriteLine("\nCourse Management System:");
            Console.WriteLine("1. Add Course");
            Console.WriteLine("2. Search Course");
            Console.WriteLine("3. Display All Courses");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCourse();
                    break;
                case "2":
                    SearchCourse();
                    break;
                case "3":
                    DisplayAllCourses();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddCourse()
    {
        Console.Write("Enter course code: ");
        string code = Console.ReadLine();
        if (courses.ContainsKey(code))
        {
            Console.WriteLine("Course already exists.");
            return;
        }

        Console.Write("Enter course title: ");
        string title = Console.ReadLine();
        Console.Write("Enter course description: ");
        string description = Console.ReadLine();
        Console.Write("Enter course credits: ");
        int credits = int.Parse(Console.ReadLine());

        courses.Add(code, new Course(code, title, description, credits));
        Console.WriteLine("Course added successfully!");
    }

    static void SearchCourse()
    {
        Console.Write("Enter course code to search: ");
        string code = Console.ReadLine();
        if (courses.TryGetValue(code, out Course course))
        {
            Console.WriteLine(course);
        }
        else
        {
            Console.WriteLine("Course not found.");
        }
    }

    static void DisplayAllCourses()
    {
        Console.WriteLine("\nAll Courses:");
        foreach (var course in courses.Values)
        {
            Console.WriteLine(course);
        }
    }
}
