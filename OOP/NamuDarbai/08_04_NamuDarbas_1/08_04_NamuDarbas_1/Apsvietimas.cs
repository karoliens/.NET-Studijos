using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Apsvietimas
    {
        private string temperatura;

        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        private int sviestuvuKiekis;

        public int SviestuvuKiekis
        {
            get { return sviestuvuKiekis; }
            set { sviestuvuKiekis = value; }
        }

        private bool judesioDaviklis;

        public bool JudesioDaviklis
        {
            get { return judesioDaviklis; }
            set { judesioDaviklis = value; }
        }

        private int galia;

        public int Galia
        {
            get { return galia; }
            set { galia = value; }
        }

        private int stiprumas;

        public int Stiprumas
        {
            get { return stiprumas; }
            set { stiprumas = value; }
        }
    }
}
