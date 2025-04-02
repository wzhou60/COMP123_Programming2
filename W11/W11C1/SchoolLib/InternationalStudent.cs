using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class InternationalStudent : Student
    {
        public string? Country { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Country = {Country}";
        }

        public override string SayHi()
        {
            return $"Hi, I am a international student and my name is {Name} and my ID is {Id} and I was born in {YOB}";
        }
    }
}