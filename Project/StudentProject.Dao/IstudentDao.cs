using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Models; 

namespace StudentProject.Dao
{
    internal interface IstudentDao
    {
        string AddStudentDao(Student student);
        List<Student> ShowStudentDao();

        Student SearchStudentDao(int rollno);
    }
}
