using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int vygenerovanecislo = rnd.Next(maxValue:100);

            bool isGame = true;

            while (isGame == true)
            {
                Console.WriteLine("Uhadni cislo:");
                string hadanecislo = Console.ReadLine() ?? "0";
                int hadanecisloint = int.Parse(hadanecislo);

                if (hadanecisloint == vygenerovanecislo)
                {
                    isGame = false;
                    Console.WriteLine("Vyhrali ste!");
                }
                else if (hadanecisloint > vygenerovanecislo)
                {
                    Console.WriteLine("Vase cislo je vacsie ako random cislo!");
                }
                else if (hadanecisloint < vygenerovanecislo)
                {
                    Console.WriteLine("Vase cislo je mensie ako random cislo!");
                }
            }

        }
    }
}