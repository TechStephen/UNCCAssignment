using System;
using System.IO;

namespace evensandodds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Stephen\source\repos\evensandodds\evensandodds\Numbers.txt");
            int[] arr = new int[lines.Length];

            for(int i = 0; i < lines.Length; i++)
            {
                arr[i] = Int16.Parse(lines[i]);
                isEven(arr[i]);
            }
        }

        static void isEven(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }
            else
            {
                Console.WriteLine(num + " is odd");
            }
        }
    }
}
