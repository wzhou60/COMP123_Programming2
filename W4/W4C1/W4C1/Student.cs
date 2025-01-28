using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4C1
{
    internal class Student
    {
        public enum StudentType
        {
            Domestic,
            International
        };

        private static int nOfStudents = 0;
        public string Name { get; set; }
        public int Id { get; set; }

        public StudentType Type { get; set; }

        static Student()
        {
            Console.WriteLine("Static Constructor");
            nOfStudents = 300;
        }

        public Student()
        {
            nOfStudents++;
        }

        public override string ToString()
        {
            return $"No. of students: {nOfStudents}, Name: {Name}, Id: {Id}";
        }

        public static int getNumberOfStudents()
        {
            return nOfStudents;
        }

        ~Student()
        {
            Console.WriteLine($"Destructor, destroying Student with Id: {Id}");
        }
    }
}