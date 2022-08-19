using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_NamuDarbas_1
{
    internal class Durys
    {
        private string remoMedziaga;

        public string RemoMedziaga
        {
            get { return remoMedziaga; }
            set { remoMedziaga = value; }
        }

        private int paketuSkaicius;

        public int PaketuSkaicius
        {
            get { return paketuSkaicius; }
            set { paketuSkaicius = value; }
        }

        private int rankenuKiekis;

        public int RankenuKiekis
        {
            get { return rankenuKiekis; }
            set { rankenuKiekis = value; }
        }

        private string saugumoLygis;

        public string SaugumoLygis
        {
            get { return saugumoLygis; }
            set { saugumoLygis = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }

        public Matmenys matmenys;
    }
}
