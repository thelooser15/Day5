using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Models;

namespace StudentProject.Dao
{
    public class StudentDaoImp1 : IstudentDao
    {
        static List<Student> studentlist;// by use of static is it will return all the data in the list
        static StudentDaoImp1()// constructor 
        {
            studentlist = new List<Student>();
        }
        public string AddStudentDao(Student student)
        {
            studentlist.Add(student);
            return "student record has been Inserted";
        }
        public Student SearchStudentDao(int rollno)
        {
            Student studentfound= null;
            foreach (Student student in studentlist) {
                if (student.StudentRollno == rollno)
                {
                    studentfound = student;
                    break;
                }
            }
            return studentfound;

        }
        public List<Student> ShowStudentDao()
        {
            return studentlist;
        }

    }
}
