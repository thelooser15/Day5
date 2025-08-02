using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Models;

namespace StudentProject.Dao
{
    public class StudentDaoImp1 : IStudentDao
    {
        static List<Student> studentlist;
        static StudentDaoImp1()
        {
            studentlist = new List<Student>();
        }
    }
}
