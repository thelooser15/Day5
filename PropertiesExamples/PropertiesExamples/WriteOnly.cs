using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    class Vendor
    {
        int id;
        string name;
        public int Id
        {
            set { id = value; }
        }
        public string Name
        {
            set { name=value; }
        }
        public override string ToString()
        {
            return "My Id is "+ id +" name is "+ name;  
        }
    }
    internal class WriteOnly
    {
        static void Main(string[] args)
        {
            Vendor v = new Vendor();
            v.Id = 27;
            v.Name = "Pavan";
            Console.WriteLine(v);
        }
    }
}
