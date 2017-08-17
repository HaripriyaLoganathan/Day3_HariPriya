using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static int count = 0;
        Program()
        {
            count++;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p2 = new Program();
            Program p3 = new Program();
            Program p4 = new Program();
            Console.WriteLine("Object count = "+count);
            Console.Read();
        }
    }
}
