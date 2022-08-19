using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11_NamuDarbas_2
{
    internal class Skaiciuoklis
    {
        private int Skaicius { get; set; }

        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
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
            Console.WriteLine($"Skaičius: {Skaicius}");
        }

        public void Perkrauti()
        {

        }
    }
}
