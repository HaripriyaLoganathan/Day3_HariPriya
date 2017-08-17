using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSort
{
    class Program
    {
         static void SortArray(int []a)
        {
            Array.Sort(a);
            Console.WriteLine("Sorted Array is...");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i< n;i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            SortArray(arr);
            Console.ReadLine();
        }
    }
}
