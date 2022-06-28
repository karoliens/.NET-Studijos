namespace P010_Methods
{
    internal class Program
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
            Console.WriteLine($"Žodžių kiekis yra: {TarpaiGale(tekstas)}");

            //Linkejimas();
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
            return tekstas.Split(" ").Count();
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
    }
}