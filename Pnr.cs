using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pnr
{
    class Program
    {
         void Calculate(int p,int n,int r)
        {
            Console.WriteLine((p * n * r) / 100);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount");
            int p = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter theNo of years");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest");
            int r = Convert.ToInt16(Console.ReadLine());
            Program po = new Program();
            po.Calculate(p, n, r);
        }
    }
}
