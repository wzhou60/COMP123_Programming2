﻿namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Time> times = new List<Time>(){
                new Time(9, 35),
                new Time(18, 5),
                new Time(20, 500),
                new Time(10),
                new Time(10),
                new Time()
            };
            //display all the objects
            TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"\n\nTime format is {format}");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Mil;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetTimeFormat(format);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Hour24;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetTimeFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
        }
    }
}