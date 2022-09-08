using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Salis
    {
        public Salis()
        {
            Plotas = 1000;
            Kalba = "lietuvių";
            GyventojuSkaicius = 90000;
        }

        public Salis(int plotas, string kalba, int gyventojuSkaicius, Miestas miestas)
        {
            Plotas = plotas;
            Kalba = kalba;
            GyventojuSkaicius = gyventojuSkaicius;
            Miestas = miestas;
        }

        public Salis(string kalba, int gyventojuSkaicius, Miestas miestas)
        {
            Kalba = kalba;
            GyventojuSkaicius = gyventojuSkaicius;
            Miestas = miestas;
        }

        public int Plotas { get; set; }
        public string Kalba { get; set; }
        public int GyventojuSkaicius { get; set; }
        public Miestas Miestas { get; set; }
    }
}
