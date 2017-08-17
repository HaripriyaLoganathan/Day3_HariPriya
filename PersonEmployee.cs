using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    class Person
    {
        public string name;
        public int age;
        public string gender;
       
    }
    class Employee:Person
    {
        int empcode;
         public Employee()
        {

        }
      public Employee(string name,int age,string gender,int empcode)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.empcode = empcode;
        }
       public void Display()
        {
            Console.WriteLine("Emp name={0}\nEmp age={1}\nEmp gender={2}\nEmpcode={3}", name, age, gender, empcode);
        }
    }
    class Specialist:Employee
    {
        static void Main(string[] args)
        {
            Specialist sss = new Specialist();
            Employee e = new Employee();
            Console.WriteLine("Enter the no of employees");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the employee details");
            for(int i=0;i< n;i++)
            {
                Console.WriteLine("Enter the employee name");
                string s = Console.ReadLine();
                Console.WriteLine("Enter the employee age");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the employee gender");
                string g = Console.ReadLine();
                Console.WriteLine("Enter the employee code");
                int c = Convert.ToInt16(Console.ReadLine());
                e=new Employee(s, a, g, c);
                e.Display();
            }
            Console.ReadLine();
        }

    }
}
