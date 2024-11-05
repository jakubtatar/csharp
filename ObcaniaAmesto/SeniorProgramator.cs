using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    class SeniorProgramator : Programator
    {
        public int PocetProjektov { get; set; }
        public SeniorProgramator(string name, int age, string programovaciJazyk, int pocetProjektov) : base(name, age, programovaciJazyk)
        {
            this.PocetProjektov = pocetProjektov;
        }

        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age + ", pise kodiky v jazyku " + programovaciJazyk + 
                ". Pocet jeho projektov je rovny " + PocetProjektov );
        }
    }
}
