using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer
{
    class Program
    {
        public void Swap(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value after swapping \nA={0}\nB={1}", a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers");
            Console.Write("A=");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("B=");
            int b = Convert.ToInt16(Console.ReadLine());
            Program pobj = new Program();
            pobj.Swap(a, b);
            Console.ReadLine();
        }
    }
}
