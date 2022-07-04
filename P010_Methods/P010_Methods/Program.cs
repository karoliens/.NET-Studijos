namespace P010_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių:");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine(SkaiciuSuma(skaicius1, skaicius2));

            Console.WriteLine("Įveskite tekstą:");
            var tekstas = Console.ReadLine();

            Console.WriteLine($"Tarpų kiekis yra: {TarpuKiekis(tekstas)}");
            Console.WriteLine($"Teksto ilgis yra: {TekstoIlgis(tekstas)}");
            Console.WriteLine($"Žodžių kiekis yra: {ZodziuKiekis(tekstas)}");
            Console.WriteLine($"Gale yra tarpų: {TarpaiGale(tekstas)}");
            Console.WriteLine($"Pradžioje yra tarpų: {TarpaiPradzioj(tekstas)}");
            Console.WriteLine($"Pradžioje yra tarpų: {TarpaiPradziojeGale(tekstas, out int tarpaiGale)}");
            Console.WriteLine($"Gale yra tarpų: {tarpaiGale}");
            Console.WriteLine($"'a' raidžių kiekis yra: {AKiekis(tekstas)}");
            Console.WriteLine($"Ar yra mokausi: {TaipArbaNe(tekstas)}");
            Console.WriteLine($"'a' raidės vieta yra: {PirmosARaidesIndex(tekstas)}");
            Console.WriteLine($"Ar yra mokausi: {TaipArbaNeNesulipes(tekstas)}");
        }

        /*
        Parašykite programą kurioje yra 2 metodai.
        - Pirmas metodas į konsolę išveda "Sveiki visi"
        - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
        */

        public static void SveikiVisi()
        {
            Console.WriteLine("Sveiki visi");
        }

        public static void GerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        /*
        Parašykite programą kurioje yra 2 metodai.
        -
        - Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
        - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
        Pvz:
        > Iveskite savo Varda:
        _ Petras
        > Labas Petras
        > Linkiu jums Petras geros dienos
        */

        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine("Įveskite savo vardą");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }

        public static void Linkejimas()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }

        /*
        Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
        - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
        N.B. būtina validacija
        - Į ekraną išveskite argumentų matematinę sumą.
        Pvz:
        > Iveskite pirmą skaičių:
        _ 15
        > Iveskite antrą skaičių:
        _ 16
        > Rezultatas: 31
        */

        public static int SkaiciuSuma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }

        /*
        Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
        - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
        - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
        - Main metode į ekraną išveskite tarpų kiekį
        Pvz:
        > Iveskite teksta:
        _ as mokausi programuoti
        > Tarpu kiekis yra: 2
        */

        public static int TarpuKiekis(string tekstas)
        {
            return tekstas.Length - tekstas.Replace(" ", "").Length;
        }

        /*
        Parašykite programą kurioje vienas metodas.
        - Naudotojo paprašome įvesti betkokį tekstą Main metode.
        - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
        Pvz:
        > Iveskite teksta:
        _ ' as mokausi '
        > Teksto ilgis yra: 10
        */

        public static int TekstoIlgis(string tekstas)
        {
            return tekstas.Trim().Length;
        }

        /*
        Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
        - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
        - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
        - Main metode į ekraną išveskite žodžių kiekį
        Pvz: 
        > Iveskite teksta:
        _ as mokausi programuoti
        > Zodziu kiekis yra: 3
        */

        public static int ZodziuKiekis(string tekstas)
        {
            return tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /*
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas grąžina tarpų kiekį teksto gale
        - Main į ekraną išveda rezultatą
        Pvz: 
        > Iveskite teksta:
        _ ' as mokausi      '
        > Gale yra tarpų: 6
        */

        public static int TarpaiGale(string tekstas)
        {
            var pilnasTekstas = tekstas.Length;
            var nukirptasGalas = tekstas.TrimEnd().Length;

            return pilnasTekstas - nukirptasGalas;
        }
        /*
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas grąžina tarpų kiekį teksto pradžioje
        - Main į ekraną išveda rezultatą
        Pvz: 
        > Iveskite teksta:
        _ ' as mokausi      '
        > Pradžioje yra tarpų: 1
        */

        public static int TarpaiPradzioj(string tekstas)
        {
            var pilnasTekstas = tekstas.Length;
            var nukirptaPradzia = tekstas.TrimStart().Length;

            return pilnasTekstas - nukirptaPradzia;
        }

        /*
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
        <hint> naudoti out 
        - Main į ekraną išveda rezultatą
        Pvz: 
        > Iveskite teksta:
        _ ' as mokausi      '
        > Pradžioje yra tarpų: 1
        > Gale yra tarpų: 6
        */
        
        public static int TarpaiPradziojeGale(string tekstas, out int tarpaiGale)
        {
            tarpaiGale = tekstas.Length - tekstas.TrimEnd().Length;

            return tekstas.Length - tekstas.TrimStart().Length;
        }

        /*
        Parašykite programą kurioje yra vienas metodas. 
        - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais 
        - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
        - Main metode į ekraną išveskite metodo darbo rezultatą
        Pvz: 
        > Iveskite teksta:
        _ as mokausi programuoti
        > 'a' raidžių kiekis yra: 3
        */

        public static int AKiekis(string tekstas)
        {
            var pilnasTekstas = tekstas.Length;
            var tekstasBeA = tekstas.Replace("a", "").Length;

            return pilnasTekstas - tekstasBeA;
        }

        /*
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
        -  Išvesti rezultatą Main metode.
        Pvz: 
        > Iveskite teksta:
        _ ' as labai mokausi programuoti     '
        > Ar yra mokausi: Taip
        */

        public static string TaipArbaNe(string tekstas)
        {
            if (tekstas.Contains("mokausi"))

                return "taip";
            else
                return "ne";
        }

        /*
        Parašykite programą kurioje yra vienas metodas. 
        - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais 
        - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
        - Main metode į ekraną išveskite metodo darbo rezultatą
        Pvz: 
        > Iveskite teksta:
        _ as mokausi programuoti
        > 'a' raides vieta yra: 0
        */

        public static int PirmosARaidesIndex(string tekstas)
        {
            return tekstas.IndexOf("a");
        }

        /*
        Parašykite programą kurioje vienas metodas. 
        - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
        - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B. grąžinama string, o ne bool.
        -  Išvesti rezultatą Main metode.
        Pvz: 
        > Iveskite teksta:
        _ ' as labai mokausi programuoti     '
        > Ar yra mokausi: Taip
        Pvz: 
        > Iveskite teksta:
        _ ' as_labai_mokausi_programuoti     '
        > Ar yra mokausi: Ne
        */

        public static string TaipArbaNeNesulipes(string tekstas)
        {
            if (tekstas.Contains(" mokausi "))
                return "taip";

            else if (tekstas.Contains(" mokausi" + "!") || tekstas.Contains(" mokausi" + "?") || tekstas.Contains(" mokausi" + ","))
                return "taip";

            else if (tekstas.Contains("mokausi ") && (tekstas.IndexOf("m")) == 0)
                return "taip";

            else if (tekstas.Contains("(mokausi)") || tekstas.Contains("\"mokausi\""))
                return "taip";

            else
                return "ne";

            /*
            tekstas.Replace("mokausi", " mokausi ");

            if (tekstas.Contains("mokausi"))
                return "taip";

            else
                return "ne";
            */
        }
    }
}
