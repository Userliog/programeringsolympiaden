using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kuvert ? ");

            string str1 = Console.ReadLine();
            int Kuvert = int.Parse(str1);

            Console.Write("Affisch ? ");

            string str2 = Console.ReadLine();
            int Affisch = int.Parse(str2);

            Console.Write("Blad ? ");

            string str3 = Console.ReadLine();
            int Blad = int.Parse(str3);

            double ivägsick = (Kuvert*0.148392)+(Affisch*0.24948)+(Blad*0.06237);
            double total = Math.Round(ivägsick, 7);

            Console.WriteLine("Svar: "+(total));
        }
    }
}
