using Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Knyga
    {
        public Knyga()
        {
            PuslapiuSkaicius = 0;
            Pavadinimas = "nežinomas";
            Autorius = "nežinomas";
        }

        public Knyga(int puslapiuSkaicius, string pavadinimas, string autorius, Bukle bukle)
        {
            PuslapiuSkaicius = puslapiuSkaicius;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Bukle = bukle;
        }

        public Knyga(Bukle bukle)
        {
            Bukle = bukle;
        }

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

        private Bukle bukle;

        public Bukle Bukle
        {
            get { return bukle; }
            set { bukle = value; }
        }
    }
}
