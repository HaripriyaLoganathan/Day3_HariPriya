using System;
namespace Bookss
{
    class Books
    {
        static void Main(string[] args)
        {
            int flag = 0;
            string[] book = { "Turning point", "It is always possible", "India2020", "By god's Decree", "Wingsof Fire" };
            string[] author = { "abj", "kiran bedi", "abj", "Kapil Dev", "abj" };
            int[] quantity = { 20, 50, 70, 67, 44 };
            Console.WriteLine("Enter the book name");
            string b = Console.ReadLine();
            Console.WriteLine("Enter the author name");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the  quantity of book");
            int q = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (b == book[i] && a == author[i])
                {
                    if (q <= quantity[i])
                    {
                        Console.WriteLine("Books are avalible");
                    }
                    else
                        Console.WriteLine("Insufficient quantity");

                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("No books found ");

            Console.Read();
        }
        }
    }

