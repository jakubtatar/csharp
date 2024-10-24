using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Ucitel
    {
        public string Meno { get; set; }
        public int Vek { get; set; }

        public Ucitel()
        {

        }
        public Ucitel(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + ", Vek: " + Vek + ", uci detiska nepodarene.");
        }
    }
}
