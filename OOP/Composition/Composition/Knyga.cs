using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Knyga
    {
        private int puslapiuSkaicius;

        public int PuslapiuSkaicius
        {
            get { return puslapiuSkaicius; }
            set { puslapiuSkaicius = value; }
        }

        private string pavadinimas;

        public string Pavadinimas
        {
            get { return pavadinimas; }
            set { pavadinimas = value; }
        }

        private string autorius;

        public string Autorius
        {
            get { return autorius; }
            set { autorius = value; }
        }

        public Bukle bukle;
    }
}
