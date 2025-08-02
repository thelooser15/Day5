using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Student
    {
        public int StudentRollno {  get; set; }
        public string StudentName { get; set; }
        public string Gender {  get; set; }
        public string Dept {  get; set; }
        public double Grade {  get; set; }
        public string MobileNo {  get; set; }

        public Student() { }// constructor without parametrs used for object creation
        // by using the above one we have to set the proeprties manually
        public Student(int rollno, string studentName, string gender, string dept, double grade, string mobileNo) //this is for object creation all data at once 
        {
            StudentRollno = rollno;
            StudentName = studentName;
            Gender = gender;
            Dept = dept;
            Grade = grade;
            MobileNo = mobileNo;
        }
        //its better to use both the constrcutors so we define the both 
        public override string ToString()
        {
            return "Student RollNo is : " + StudentRollno +"\n"+
                    "student name is : " + StudentName + "\n" +
                    "Gender is : " + Gender+"\n" +
                    "Department is : " + Dept+"\n" +
                    "CGPA is : " + Grade + "\n" +
                    "Mobile number is : " + MobileNo;
        }
    }
}
