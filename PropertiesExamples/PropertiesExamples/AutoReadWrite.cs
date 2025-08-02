using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    class School
    {
        public int StudentRoll {  get; set; }
        public string StudentName {  get; set; }
        public double StudentMarks {  get; set; }


    }
    internal class AutoReadWrite
    {
        static void Main()
        {
            School stu1 = new School();
            stu1.StudentRoll=1;
            stu1.StudentName = "pavan";
            stu1.StudentMarks = 95.2;

            School stu2 = new School();
            stu2.StudentRoll=2;
            stu2.StudentName = "Srikanth";
            stu2.StudentMarks = 87.9;

            School stu3 = new School();
            stu3.StudentRoll=3;
            stu3.StudentName = "Millind";
            stu3.StudentMarks = 75.65;

            School[] Students = new School[] { stu1, stu2, stu3 };
            foreach (var student in Students)
            {
                Console.WriteLine("Student RollNo is "+student.StudentRoll+" and student name is "+student.StudentName+", student mark is "+student.StudentMarks);
                
            }

        }
    }
}
