using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static bool Prime(int num)
        {
            int count = 0;
            for(int i=1;i<= num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if (count == 2)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Prime(n));
            Console.Read();
        }
    }
}
