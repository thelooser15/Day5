using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Dao;
using StudentProject.Models;
using StudentProject.Exceptions;

namespace StudentProj.Bal
{
    public class StudentBal
    {
        public StringBuilder sb = new StringBuilder();
        public static StudentDaoImp1 daoImp1;

        static StudentBal()
        {
            daoImp1=new StudentDaoImp1();
        }
        public List<Student> ShowStudentBal()
        {
            return daoImp1.ShowStudentDao();
        }
        public Student SearchStudentBal(int rollno)
        {
            return daoImp1.SearchStudentDao(rollno);
        }
        public string AddStudentBal(Student student)
        {
            if (ValidateStudent(student)== true){
                return daoImp1.AddStudentDao(student);
            }
            throw new StudentExceptions(sb.ToString());
            
        }
        public bool ValidateStudent(Student student)
        {
            bool flag=true;
            if (student.StudentRollno <= 0)
            {
                sb.Append("Student Rollno cannot be negative");
                flag = false;
            }
            if (student.StudentName.Length < 5)
            {
                sb.Append("Name contains minimum 5 characaters..");
                flag = false;
            }
            if(student.Grade<5 || student.Grade>10)
            {
                sb.Append("Grade should be between 5 and 10");
                flag = false;
            }
            return flag;
        }
    }
}
