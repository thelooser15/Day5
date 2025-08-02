using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Exceptions
{
    public class StudentExceptions : ApplicationException
    {
        public StudentExceptions() { }
        public StudentExceptions(string message) : base(message) { }
    }
}
