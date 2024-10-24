using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Lekar
    {
        public List<Citizen> zamestnanci { get; set; }

        public Lekar()
        {

        }

        public Lekar(List<Citizen> zamestnanci)
        {
            this.zamestnanci = zamestnanci;
        }

        public void PridajDoZamestnaniaLekar(Citizen citizen)
        {
            zamestnanci.Add(citizen);
        }
    }
}
