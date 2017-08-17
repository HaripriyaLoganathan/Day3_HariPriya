using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenntLecturer
{
    interface Person
    {
        string getGrade();
        void getDescription(string s);
    }
    class Lecturer
    {
        string sub;
        public void getDescription(string s)
        {
            Console.WriteLine("Teaches "+ s);
            // throw new NotImplementedException();
        }
        void setGrade(string sub)
        {
            this.sub = sub;
        }
        public string getGrade()
        {
            return sub;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the subject name");
            string sub = Console.ReadLine();
            Lecturer l = new Lecturer();
            l.setGrade(sub);
            string gg = l.getGrade();
            l.getDescription(gg);
            Console.Read();
        }
    }
}



   

