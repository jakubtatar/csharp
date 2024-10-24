using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public City(string nazovMiestecka)
        {
            NazovMiestecka = nazovMiestecka;
            this.obcaniaList = new List<Citizen>();
        }

        public void PridajObcanov(Citizen citizen)
        {
            obcaniaList.Add(citizen);
        }

        public void VypisObcanov()
        {
            Console.WriteLine("Obyvatelia " + NazovMiestecka);
            foreach (var citizen in obcaniaList)
            {
                citizen.VypisInfo();
            }
            Console.WriteLine("");
        }
    }
}
