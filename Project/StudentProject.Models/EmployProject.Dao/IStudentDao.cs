using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Models;

namespace StudentProject.Dao
{
    internal interface IStudentDao
    {
        string AddStudent(Student student);
        List<Student> ShowStudentDao();

        Student SearchStudentDao(int StudentRollNo);
    }
}
