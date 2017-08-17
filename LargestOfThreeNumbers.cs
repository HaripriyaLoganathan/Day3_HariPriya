using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestOfThreeNumbers
{
    class Program
    {
        static int LargestNumbers(int a,int b,int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c)
                return b;
            else
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 numbers");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Largest of 3 numbers is "+LargestNumbers(a, b, c));
            Console.ReadLine();
        }
    }
}
