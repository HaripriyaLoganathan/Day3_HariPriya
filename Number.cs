using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Numbers
    {
        int count = 0;
        Numbers()
        {
            Console.WriteLine("object is created" + count++);
        }
        ~Numbers()
        {
            Console.WriteLine("object is destroyed");
        }
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers();
            Numbers n2 = new Numbers();
            Numbers n3 = new Numbers();
            
            Console.Read();
        }
    }
}
