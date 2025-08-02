using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListEx1
    {
        static void Main()
        {
            ArrayList list =new ArrayList();
            list.Add("pavan");
            list.Add("vamshi");
            list.Add("Bunny");
            list.Add("Rock");
            foreach(object o in list)
            {
                Console.WriteLine(o);
            }
            list.Insert(0, "mine");
            Console.WriteLine("the new list is ");
            foreach(object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(list.Contains("vamshi"));

            

        }
    }
}
