using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P018_Composition
{
    internal class IsmanusisTelefonas
    {
        private string dimensija;

        public string Dimensija
        {
            get { return dimensija; }
            set { dimensija = value; }
        }

        private double svoris;

        public double Svoris
        {
            get { return svoris; }
            set { svoris = value; }
        }

        private int stiklas;

        public int Stiklas
        {
            get { return stiklas; }
            set { stiklas = value; }
        }

        private int rezoliucija;

        public int Rezoliucija
        {
            get { return rezoliucija; }
            set { rezoliucija = value; }
        }

        private int atmintis;

        public int Atmintis
        {
            get { return atmintis; }
            set { atmintis = value; }
        }
    }
}
