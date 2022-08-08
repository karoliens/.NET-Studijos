using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Komunikacijos
    {
        private bool yraVanduo;

        public bool YraVanduo
        {
            get { return yraVanduo; }
            set { yraVanduo = value; }
        }

        private bool yraElektra;

        public bool YraElektra
        {
            get { return yraElektra; }
            set { yraElektra = value; }
        }

        private bool yraNuotekos;

        public bool YraNuotekos
        {
            get { return yraNuotekos; }
            set { yraNuotekos = value; }
        }

        private bool yraInternetas;

        public bool YraInternetas
        {
            get { return yraInternetas; }
            set { yraInternetas = value; }
        }

        private bool yraDujos;

        public bool YraDujos
        {
            get { return yraDujos; }
            set { yraDujos = value; }
        }
    }
}
