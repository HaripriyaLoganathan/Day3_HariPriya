using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    interface Inter
    {
        string getGrade();
        void getDescription(string s);
    }
    class Employee
        {
            string dep;
            public void getDescription(string s)
            {
                Console.WriteLine("Employee works in {0} department",s);
                // throw new NotImplementedException();
            }
            void setGrade(string dep)
            {
                this.dep = dep;
            }
            public string getGrade()
            {
                return dep;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the name of department employee works in");
                string dep = Console.ReadLine();
                Employee e = new Employee();
                e.setGrade(dep);
                string gg = e.getGrade();
                e.getDescription(gg);
                Console.Read();
            }
        }
    }



   


