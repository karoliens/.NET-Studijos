using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_NamuDarbas_1
{
    internal class Grindys
    {
        private string spalva;

        public string Spalva
        {
            get { return spalva; }
            set { spalva = value; }
        }

        private string medziaga;

        public string Medziaga
        {
            get { return medziaga; }
            set { medziaga = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }

        private string tekstura;

        public string Tekstura
        {
            get { return tekstura; }
            set { tekstura = value; }
        }

        private bool arBraizosi;

        public bool ArBraizosi
        {
            get { return arBraizosi; }
            set { arBraizosi = value; }
        }
    }
}
