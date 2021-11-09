using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antal med gröna kort? ");

            string str1 = Console.ReadLine();
            int N = int.Parse(str1);
            if (N<2)
            {
                Console.Write("Det är för få med gröna kort");
            }
            if (N>400000000)
            {
                Console.Write("Det är för många med gröna kort");
            }

            Console.WriteLine("Antal utan gröna kort? ");

            string str2 = Console.ReadLine();
            int M = int.Parse(str2);
            if (N<0)
            {
                Console.WriteLine("Det är för få utan gröna kort");
            }
            if (N>400000000)
            {
                Console.WriteLine("Det är för många utan gröna kort");
            }

            int minuter = 0;

            if (M>0)
            {
                minuter = ((((M+M+N)/N)*10));
            }
            else
            {
                minuter = (N*10);
            }

            Console.WriteLine("Svar: "+minuter+" minuter.");
        }
    }
}
