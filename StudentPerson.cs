using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerson
{
    interface Person
    {
       string  getGrade();
        void getDescription(string s);
        
    }
    class Student : Person
    {
        string g;
        
        public void getDescription(string s)
        {
            int a = 8, n = 0;
            Console.WriteLine("A {0} grade student",s);
           // throw new NotImplementedException();
        }
          void setGrade(string g)
        {
            this.g = g;
        }
        public string getGrade()
        {
            return g;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the Grade");
            string grade = Console.ReadLine();
            Student ss = new Student();
            ss.setGrade(grade);
            string gg=ss.getGrade();
            ss.getDescription(gg);
            Console.Read();

        }

    }
}
