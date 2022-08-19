using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_NamuDarbas_1
{
    internal class BuitineTechnika
    {
        private bool yraSaldytuvas;

        public bool YraSaldytuvas
        {
            get { return yraSaldytuvas; }
            set { yraSaldytuvas = value; }
        }

        private bool yraSkalbimoMasina;

        public bool YraSkalbimomasina
        {
            get { return yraSkalbimoMasina; }
            set { yraSkalbimoMasina = value; }
        }

        private bool yrakaitlente;

        public bool Yrakaitlente
        {
            get { return yrakaitlente; }
            set { yrakaitlente = value; }
        }

        private bool yraIndaplove;

        public bool YraIndaplove
        {
            get { return yraIndaplove; }
            set { yraIndaplove = value; }
        }

        private bool yraMikrobanguKrosnele;

        public bool YraMikrobanguKrosnele
        {
            get { return yraMikrobanguKrosnele; }
            set { yraMikrobanguKrosnele = value; }
        }
    }
}
