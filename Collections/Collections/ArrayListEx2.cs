using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListEx2
    {
        private static object stu1;

        static void Main()
        {
            Console.WriteLine("Enter no.of students you need to add");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList list=new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Student stu1 = new Student();
                Console.WriteLine("enter roll no:");
                stu1.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name:");
                stu1.Name = Console.ReadLine();
                Console.WriteLine("enter marks");
                stu1.Marks = Convert.ToDouble(Console.ReadLine());
                list.Add(stu1);
            }

            
            foreach (object o in list)
            {
                Student student = (Student)o;
                Console.WriteLine(student);
            }

        }
    }
}
