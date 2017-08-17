using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Name");    
                string name = Console.ReadLine();
                Console.WriteLine("Length of the Name is " + name.Length);
                Console.Read();
            }
            catch
            {
                Console.WriteLine("Object reference not set to an instance of object.");
                Console.Read();
            }
        }
    }
}
