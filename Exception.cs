using System;
namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number");
                byte num = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Squareroot of the number is {0}", Math.Sqrt(num));
                
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            finally
            {
                Console.WriteLine("Good Bye..");
                Console.ReadLine();
            }
        }
    }
}
