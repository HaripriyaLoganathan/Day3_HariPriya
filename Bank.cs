using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public int bal;
       
        public void Assign()
        {
            bal = 100000;   
        }
        public int Deposit(int amt)
        {
            bal = bal + amt;
            return bal;
        }
        public int Withdraw(int amt)
        {
            if(bal>=amt)
            {
                bal = bal - amt;
            }
            return bal;
        }
        public void Display(string name)
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Balance " + bal);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the accnum");
            int accno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Amount to be deposited..");
            int amt = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("After deposit the balance is "+p.Deposit(amt));
            Console.WriteLine("Enter the Amount to withdraw");
            int withamt = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("After withdraw the balance is " + p.Withdraw(withamt));
            p.Display(name);

        }
    }
}

