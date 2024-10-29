using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObcaniaAmesto
{
    class Lekar : Citizen
    {
        public Lekar(string meno, int vek) : base(meno, vek){ }

        public void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + ", Vek: " + vek + ", lieci ludi.");
        }
    }
}
   