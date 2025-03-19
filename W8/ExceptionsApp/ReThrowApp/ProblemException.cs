using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReThrowApp
{
    internal class ProblemException: Exception
    {

        public ProblemException(string message): base(message)
        {
            
        }
    }
}
