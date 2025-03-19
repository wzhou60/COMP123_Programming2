using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Student
    {
        private int id;

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                throw new InvalidOperationException("Invalid Id");
            }
            get { return id; }
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}