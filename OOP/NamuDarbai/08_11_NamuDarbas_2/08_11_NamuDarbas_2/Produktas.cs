﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11_NamuDarbas_2
{
    internal class Produktas
    {
        public float Kaina { get; private set; }
        public int Kiekis { get; private set; }
        public string Pavadinimas { get; private set; }

        public void SpausdintiProdukta()
        {
            Console.WriteLine($"{Pavadinimas} kaina {Kaina}$: {Kiekis} vnt");
        }
    }
}
