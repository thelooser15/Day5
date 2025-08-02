using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    internal class StackEx
    {
        static void Main()
        {
            Stack s=new Stack();
            s.Push("pavan");
            s.Push("vamshi");
            s.Push("Manjula");
            s.Push("Akhil");
            s.Push("Mounika");
            foreach(object o in s)
            {
                Console.WriteLine(o);
            }
        }
    }
}
