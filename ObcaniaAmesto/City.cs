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
        public List<Lekar> listLekarov { get; set; }
        public List<Programator> listProgramatorov { get; set; }
        public List<Ucitel> listUcitelov { get; set; }
        public City()
        {
            
        }

        public City(string nazovMiestecka)
        {
            NazovMiestecka = nazovMiestecka;
            this.obcaniaList = new List<Citizen>();
            this.listLekarov = new List<Lekar>();
            this.listProgramatorov = new List<Programator>();
            this.listUcitelov = new List<Ucitel>();
        }

        public void PridajObcanov(Citizen citizen)
        {
            obcaniaList.Add(citizen);
        }

        public void PridajProgramatorov(Programator citizen)
        {
            listProgramatorov.Add(citizen);
        }

        public void PridajUcitelov(Ucitel citizen)
        {
            listUcitelov.Add(citizen);
        }

        public void PridajLekarov(Lekar citizen)
        {
            listLekarov.Add(citizen);
        }

        public void VypisObcanov()
        {
            Console.WriteLine("Obyvatelia " + NazovMiestecka);
            foreach (var citizen in obcaniaList)
            {
                citizen.VypisInfo();
            }
            foreach (var citizen in listLekarov)
            {
                citizen.VypisInfo();
            }
            foreach (var citizen in listProgramatorov)
            {
                citizen.VypisInfo();
            }
            foreach (var citizen in listUcitelov)
            {
                citizen.VypisInfo();
            }
            Console.WriteLine("");
        }
    }
}
