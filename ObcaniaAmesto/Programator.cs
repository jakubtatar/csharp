using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Programator
    {
        public string Meno { get; set; }
        public int Vek { get; set; }

        public Programator()
        {
            
        }
        public Programator(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + ", Vek: " + Vek + ", pise kodiky.");
        }
    }
}
