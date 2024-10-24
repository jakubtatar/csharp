using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObcaniaAmesto
{
    public class Lekar
    {
        public string  Meno { get; set; }
        public int Vek { get; set; }

        public Lekar() 
        { 

        }
        public Lekar(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + ", Vek: " + Vek + ", lieci ludi.");
        }
    }
}
   