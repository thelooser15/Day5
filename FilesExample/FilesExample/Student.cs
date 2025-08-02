using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class Student
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }

        public int Age { get; set; }
        public double Marks { get; set; }


        public override string ToString()
        {
            return "student name is " + Name + " age is " + Age + " and marks are " + Marks;
        }
    }
}
