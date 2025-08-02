using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject.Exceptions;
using StudentProj.Bal;
using StudentProject.Models;
using System.Collections.Concurrent;
using System.Net.Http.Headers;

namespace StudentProject.Main
{
    internal class Program
    {
        static StudentBal studentBal;
        static Program()
        {
            studentBal = new StudentBal();
        }
        public static void SearchStudentMain()
        {
            int rollno;
            Console.WriteLine("Enter Rollno ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Student student = studentBal.SearchStudentBal(rollno);
            if (student != null) {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("**** Student details not Found*****");

            }
        }
        public static void ShowStudentMain()
        {
            List<Student> studentlist = studentBal.ShowStudentBal();
            Console.WriteLine("student Details are ");
            foreach (Student student in studentlist) {
                Console.WriteLine(student);
            }
        }
        public static void AddStudentMain()
        {
            Student student =new Student();
            Console.WriteLine("Enter Student Rollno");
            student.StudentRollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            student.StudentName=Console.ReadLine();
            Console.WriteLine("Enter Gender (MAlE/FEMALE)");
            student.Gender = Console.ReadLine();
            Console.WriteLine("Enter Department");
            student.Dept=Console.ReadLine();
            Console.WriteLine("Enter Grade");
            student.Grade=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number");
            student.MobileNo=Console.ReadLine();
            Console.WriteLine(studentBal.AddStudentBal(student));

        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Your Options");
                Console.WriteLine("---------------");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Student Details");
                Console.WriteLine("3.Search Student");
                Console.WriteLine("4.Update Details");
                Console.WriteLine("5.Delete Student");
                Console.WriteLine("6.Write to file");
                Console.WriteLine("7.Read from file");
                Console.WriteLine("Enter your Choice");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddStudentMain();
                        }
                        catch(StudentExceptions e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 2:
                        ShowStudentMain();
                        break;
                    case 3:
                        SearchStudentMain();
                        break;
                    case 8:
                        return;
                }
            } while (choice != 8);
            
        }
    }
}
