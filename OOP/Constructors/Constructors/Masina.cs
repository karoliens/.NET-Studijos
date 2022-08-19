using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Masina
    {
        public Masina()
        {
            Spalva = "Nenurodyta";
            DuruKiekis = 5;
            KedziuKiekis = 5;
            ArDrausta = true;
            SavininkoVardas = "Nenurodyta";
        }

        public Masina(string gamintojas, string modelis, int gamybosMetai, bool arDrausta, string savininkoVardas)
        {
            Gamintojas = gamintojas;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            ArDrausta = arDrausta;
            SavininkoVardas = savininkoVardas;
        }

        public Masina(Masina masina)
        {
            Gamintojas = masina.Gamintojas;
            Modelis = masina.Modelis;
            GamybosMetai = masina.GamybosMetai;
            SavininkoVardas = masina.SavininkoVardas;
            ArDrausta = masina.ArDrausta;
        }
        public string Gamintojas { get; set; }
        public string Modelis { get; set; }
        public int GamybosMetai { get; set; }
        public bool ArDrausta { get; set; }
        public string SavininkoVardas { get; set; }
        public int DuruKiekis { get; set; }
        public string VariklioTipas { get; set; }
        public double MaksimaliGalia { get; set; }
        public double EmisijuKiekis { get; set; }
        public int DidziausiasGreitis { get; set; }
        public int Pagreitis { get; set; }
        public string Spalva { get; set; }
        public int Aukstis { get; set; }
        public int Plotis { get; set; }
        public int Ilgis { get; set; }
        public int KedziuKiekis { get; set; }
        public ApsaugosSistema ApsaugosSistema { get; set; } = new ApsaugosSistema();
    }
}
