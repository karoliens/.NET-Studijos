using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_08_04_NamuDarbas_1ment6
{
    internal class Sienos
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

        private int sluoksniuKiekis;

        public int SluoksniuKiekis
        {
            get { return sluoksniuKiekis; }
            set { sluoksniuKiekis = value; }
        }

        private string tekstura;

        public string Tekstura
        {
            get { return tekstura; }
            set { tekstura = value; }
        }

        private bool arPlaunamos;

        public bool ArPlaunamos
        {
            get { return arPlaunamos; }
            set { arPlaunamos = value; }
        }
    }
}
