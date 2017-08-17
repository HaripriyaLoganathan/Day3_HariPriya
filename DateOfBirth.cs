using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOfBirth
{
    struct Dob
    {
        public int date;
        public int month;
        public int year;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter date");
            int d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter month");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter year");
            int y = Convert.ToInt16(Console.ReadLine());
            Dob dobj;
            dobj.date = d;
            dobj.month = m;
            dobj.year = y;
            Console.WriteLine("My date of birth is {0}/{1}/{2}", dobj.date, dobj.month, dobj.year);
            Console.Read();
        }
    }
}
