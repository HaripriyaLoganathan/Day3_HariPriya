﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            try
            {
                Console.WriteLine("Answer" + a / b);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("NullPointerException.");
                Console.ReadLine();
            }
        }
    }
}
