using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11_NamuDarbas_2
{
    internal class Skaiciuoklis
    {
        private int pradinisSkaicius; // Sukuriamas, kad būtų galima nustatyti pradinį skaičių paduodant į konstruktorių
        private int Skaicius { get; set; }

        public Skaiciuoklis()
        {
            Skaicius = 0;
            pradinisSkaicius = 0;
        }

        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
            pradinisSkaicius = skaicius; 
        }

        public void Didinti()
        {
            Skaicius++;
        }

        public void Mazinti()
        {
            Skaicius--;
        }

        public void Atspausdinti()
        {
            Console.WriteLine(Skaicius);
        }

        public void Perkrauti()
        {
            Skaicius = pradinisSkaicius; // pradinisSkaicius reikšmė perduodama Skaicius
        }
    }
}
