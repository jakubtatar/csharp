using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class City
    {
        public string NazovMiestecka { get; set; }
        public List<Citizen> obcaniaList { get; set; }

        public City()
        {

        }

        public City(string nazovMiestecka, List<Citizen> obcaniaList)
        {
            NazovMiestecka = nazovMiestecka;
            this.obcaniaList = obcaniaList;
        }

        public void PridajObcana(Citizen obcaniaList)
        {
            
        }

        public void VypisObcanov()
        {
            foreach (var citizen in obcaniaList)
            {
                
                Console.WriteLine();
            }
        }
    }
}
