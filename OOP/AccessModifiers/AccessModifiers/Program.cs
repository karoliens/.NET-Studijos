namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 4: Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta) taip, kad atributu reiksmes galima butu skaityti is isores, bet nustatyti reiksmes butu galima tik klases viduje. (Namas, salis, knyga)

            Uzduotis 5:(Savarankiskai)Sukurti klases Hobis ir Profesija 
            Klasės interfeise turi būti properčiai: Id (int), TekstasLietuviskai(string) ir TekstasAngliskai(string) 
            Sukurti tuscia konstruktorių.
            Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
            Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
            Sukurkite po 3 skirtingus hobius ir profesijas(Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus. 1.Konstruktoriaus pagalba 2. Tuscio objekto sukurimas ir pildymas eigoje (Palikit 1 seteri kaip public) 3. Deklaravimo metu priskirti reiksmes)

            Uzduotis 6: (Savarankiskai)Sukurkite klasę “Bendrabutis”. Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:       BendrabucioId       KambariuSkaicius       KainaSujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip, kad kiekviename bendrabutyje galėtų gyventi daug žmonių, tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje.

            Uzduotis 7: Sukurkite 5 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos sukomponuokite (Sudekite rysius tarp ju).
            Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
            Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
            Kiekvienas studentas turi 1 pažymių knygelę.
            Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
            Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
            Inicializuokite klases su duomenimis (turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus, kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. Objektai gali buti skirtingi tarp metodu):       
            Mokyklos pavadinima + Kiekviena mokytoja kartu su jo mokiniu vardais
            (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
            (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki
            */

            var hobis = new Hobis(1, "Futbolas", "Football");

            var hobis1 = new Hobis();
            hobis1.TekstasAngliskai = "Tenis"; 

            var hobis2 = new Hobis()
            {
                TekstasAngliskai = "Basketball"
            };


            var profesija = new Profesija(1, "Mokytojas", "Teacher");

            var profesija1 = new Profesija();
            hobis1.TekstasAngliskai = "Engineer";

            var profesija2 = new Profesija()
            {
                TekstasAngliskai = "Designer"
            };
        }

        static void AtspausdintiMokykla(Mokykla mokykla)
        {
            Console.WriteLine($"Mokyklos pavadinimas: {mokykla.Pavadinimas}");
            foreach (var mokytojas in mokykla.Mokytojai)
            {
                Console.WriteLine($"Mokytojas: {mokytojas.Vardas}");
                foreach (var mokinys in mokytojas.Studentai)
                {
                    Console.WriteLine($"Mokinio vardas: {mokinys.Vardas}");
                }
            }
        }

        static void AtspausdintiMokiniuVidurkius(Mokykla mokykla)
        {
            foreach (var mokytojas in mokykla.Mokytojai)
            {
                foreach (var mokinys in mokytojas.Studentai)
                {
                    foreach (var pamoka in mokinys.PazymiuKnygele.Pamokos)
                    {

                        Console.WriteLine($"Mokinys: {mokinys.Vardas}\nPamoka: {pamoka} - {ApskaiciuotiVidurki(pamoka.Value)}\n");
                    }
                }
            }
        }

        static double ApskaiciuotiVidurki(List<int> pazymiai)
        {
            var vidurkis = 0;
            foreach (var pazymys in pazymiai)
            {
                vidurkis += pazymys;
            }

            vidurkis = vidurkis / pazymiai.Count;

            return vidurkis;
        }
    }
}