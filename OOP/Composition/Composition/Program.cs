﻿namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:ŽmogųMašinąNamą(Savarankiskai)Išmanųjį telefonąŠalį(Savarankiskai)Knygą(Savarankiskai)
            
            Uzduotis 2: Parasyti kiekvienai is klasiu bent po 1 kompozicijos atributa (Naujas atributas turetu buti naujai sukurta klase su bent 3 naujais atributais). Kompozicijos atributas yra atributas su kitos klases duomenu tipu kintamuosiuose. Pvz: Zmogus gali tureti augintini
            */

            DirbtiSuPirmaUzduotimi();
        }

        public static void DirbtiSuPirmaUzduotimi()
        {
            Zmogus zmogus = new Zmogus();
            zmogus.akiuSpalva = "Mėlyna";
            zmogus.vardas = "Ričardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Kelionės";
            zmogus.augintinis = new Augintinis()
            {
                Budas = "Zaismingas",
                GimimoMetai = 2021,
                Rusis = "Suo",
                Vardas = "Bapsis"
            };

            Console.WriteLine($"Informacija apie {zmogus.vardas} zmogaus augintini:\n---------------------\nVardas: {zmogus.augintinis.Vardas}\nRusis: {zmogus.augintinis.Rusis}\nGimimo metai: {zmogus.augintinis.GimimoMetai}\nBudas: {zmogus.augintinis.Budas}");

            Zmogus zmogus2 = new Zmogus();
            zmogus.akiuSpalva = "Melyna";
            zmogus.vardas = "Ricardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Keliones";

            Console.WriteLine($"zmogus.akiuSpalva:{zmogus.akiuSpalva}\nzmogus.vardas:{zmogus.vardas}\nzmogus.pavarde:{zmogus.pavarde}\nzmogus.pareigos:{zmogus.pareigos}\nzmogus.megstamiausiasHobis:{zmogus.megstamiausiasHobis}");

            var masina = new Masina()
            {
                Modelis = "Corolla",
                Gamintojas = "Toyota",
                ArDrausta = true,
                DidziausiasGreitis = 100,
                EmisijuKiekis = 0,
                KedziuKiekis = 4,
                Spalva = "Raudona",
                VariklioTipas = "Elektrinis",
                ApsaugosSistema = new ApsaugosSistema()
                {
                    Gamintojas = "SecurCo",
                    Lygis = 9,
                    Pavadinimas = "ProSecure",
                    Rusis = "Blokuojanti, garsine"
                }
            };

            var apsaugosSistema2 = new ApsaugosSistema()
            {
                Gamintojas = "SecurCo",
                Lygis = 9,
                Pavadinimas = "ProSecure",
                Rusis = "Blokuojanti, garsine"
            };

            var masina2 = new Masina();
            masina2.Gamintojas = "Audi";
            masina2.Modelis = "A4";
            masina2.ApsaugosSistema = apsaugosSistema2;

            var masinos = new List<Masina>()
            {
                new Masina(),
                new Masina(),
                new Masina(),
                new Masina(),
                new Masina()
            };

            Console.WriteLine($"Modelis:{masina.Modelis}\nmasina.Gamintojas:{masina.Gamintojas}\nmasina.DidziausiasGreitis:{masina.DidziausiasGreitis}\nmasina.Spalva:{masina.Spalva}\n------------------------\nSaugos sistema:\nPavadinimas: {masina.ApsaugosSistema.Pavadinimas}\nGamintojas: {masina.ApsaugosSistema.Gamintojas}");

            var ismaniejiTelefonai = new Dictionary<int, IsmanusisTelefonas>();
            var samsung = new IsmanusisTelefonas()
            {
                OperacineSistema = "Android",
                Gamintojas = "Samsung",
                Modelis = "Galaxy S22",
                Dekliukas = new Dekliukas()
            };
            samsung.Dekliukas.Gamintojas = "NewCore";
            samsung.Dekliukas.Medziaga = "Guminis";
            samsung.Dekliukas.Kaina = 9.99;
            var iPhone = new IsmanusisTelefonas();
            ismaniejiTelefonai.Add(1, samsung);
            ismaniejiTelefonai.Add(2, iPhone);

            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Gamintojas);
            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Medziaga);
            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Kaina + "$");
        }
    }
}