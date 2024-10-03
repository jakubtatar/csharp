using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Napiste text: ");
            string text = Console.ReadLine() ?? "0";

            int length = SpocitajPismena(text);

            Console.WriteLine("Text je dlhy " + text.Length + " znakov.");

        }

        public static int SpocitajPismena(string text)
        {
            return text.Length;
        }

        //DU: NECH SPOCITA SAMOHLASKY AJ, ROZISOVAT MALE A VELKE PISMENA> a,e,i,o,u / A,E,I,O,U;
    }
}