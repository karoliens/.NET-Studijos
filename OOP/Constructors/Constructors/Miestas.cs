using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Miestas
    {
        private int dydis;

        public int Dydis
        {
            get { return dydis; }
            set { dydis = value; }
        }

        private int koordinates;

        public int Koordinates
        {
            get { return koordinates; }
            set { koordinates = value; }
        }

        private string pavadinimas;

        public string Pavadinimas
        {
            get { return pavadinimas; }
            set { pavadinimas = value; }
        }

    }
}
