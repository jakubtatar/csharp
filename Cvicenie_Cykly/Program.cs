using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zadanecislo = Console.ReadLine() ?? "0";
            int konecnecislo = int.Parse(zadanecislo);

            int i = 0;
            while (i < konecnecislo)
            {
                Console.WriteLine(i);
                i++;

                
            }  
        }
    }
}