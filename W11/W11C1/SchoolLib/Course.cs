using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; } = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override string ToString()
        {
            return $"{Code} , {Name}";
        }
    }
}