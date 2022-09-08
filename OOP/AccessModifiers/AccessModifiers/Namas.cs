using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Namas
    {
        public Namas()
        {
            Plotas = 0;
            Vieta = "nežinoma";
            KambariuSkaicius = 0;
        }

        public Namas(int plotas, string vieta, int kambariuSkaicius)
        {
            Plotas = plotas;
            Vieta = vieta;
            KambariuSkaicius = kambariuSkaicius;
        }
   
        public Namas(int plotas, string vieta)
        {
            Plotas = plotas;
            Vieta = vieta;
        }

        public int Plotas { get; private set; }
        public string Vieta { get; private set; }
        public int KambariuSkaicius { get; private set; }
    }
}
