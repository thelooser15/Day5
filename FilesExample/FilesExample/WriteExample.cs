using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesExample
{
    internal class WriteExample
    {
        static void Main() 
        {          

            FileStream fs = new FileStream(@"C:\Users\PAVAN\Desktop\wipro\training\Day5\file.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine("My name is pavan");
            sw.WriteLine("currently im staying in hyderabad");
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("File has been created successfully");

        }

    }
}
