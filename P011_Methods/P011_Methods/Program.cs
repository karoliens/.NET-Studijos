using System.Diagnostics;

namespace P011_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius:");
            var pirmasSkaicius = int.Parse(Console.ReadLine());
            var antrasSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sudėtis: {Suma(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Atimtis: {Atimtis(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Daugyba: {Daugyba(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Dalyba: {Dalyba(pirmasSkaicius, antrasSkaicius)}");

            Console.WriteLine($"Visų gautų rezultatų suma: {Suma(pirmasSkaicius, antrasSkaicius) + Atimtis(pirmasSkaicius, antrasSkaicius) + Daugyba(pirmasSkaicius, antrasSkaicius) + Dalyba(pirmasSkaicius, antrasSkaicius)}");

            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) a^2");
            Console.WriteLine("6) a^3");

            var menuPasirinkimas = Console.ReadLine();

            if (menuPasirinkimas == "1" || menuPasirinkimas == "2" || menuPasirinkimas == "3" || menuPasirinkimas == "4" || menuPasirinkimas == "+" || menuPasirinkimas == "-" || menuPasirinkimas == "*" || menuPasirinkimas == "/")
            {
                Console.WriteLine("Įveskite du skaičius:");
                var pirmasSkaicius1 = Console.ReadLine();
                var antrasSkaicius1 = Console.ReadLine();

                    switch (menuPasirinkimas)
                    {
                        case "1" or "+":
                    if (ArSvekiejiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToInt32(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToInt32(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Suma(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas int");
                    }

                    else if (ArDesimtainiaiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToDouble(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToDouble(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Suma(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas double");
                    }
                    break;
                        case "2" or "-":
                    if (ArSvekiejiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToInt32(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToInt32(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Atimtis(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas int");
                    }

                    else if (ArDesimtainiaiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToDouble(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToDouble(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Atimtis(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas double");
                    }
                        break;
                        case "3" or "*":
                    if (ArSvekiejiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToInt32(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToInt32(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Daugyba(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas int");
                    }

                    else if (ArDesimtainiaiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToDouble(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToDouble(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Daugyba(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas double");
                    }
                        break;
                        case "4" or "/":
                    if (ArSvekiejiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToInt32(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToInt32(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Dalyba(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas int");
                    }

                    else if (ArDesimtainiaiSkaiciai(pirmasSkaicius1, antrasSkaicius1))
                    {
                        var konvertuotasPirmasSkaicius1 = Convert.ToDouble(pirmasSkaicius1);
                        var konvertuotasAntrasSkaicius1 = Convert.ToDouble(antrasSkaicius1);
                        Console.WriteLine($"{pirmasSkaicius1} + {antrasSkaicius1} = {Dalyba(konvertuotasPirmasSkaicius1, konvertuotasAntrasSkaicius1)}");
                        Debug.WriteLine("Panaudotas double");
                    }
                        break;
                    }
            }

            else if (menuPasirinkimas == "5" || menuPasirinkimas == "6")
            {
                Console.WriteLine("Įveskite skaičių:");
                var skaicius = int.Parse(Console.ReadLine());

                switch (menuPasirinkimas)
                {
                    case "5":
                    Console.WriteLine(KelimasKvadratu(skaicius));
                    break;
                    case "6":
                    Console.WriteLine(KelimasKubu(skaicius));
                    break;
                    default:
                    Console.WriteLine("Toks menu pasirinkimas neegzituoja");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Klaida");
            }
            
            Console.WriteLine("Įveskite taisiklingojo daugiakampio kraštinių kiekį (n):");
            var krastiniuKiekis = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite taisiklingojo daugiakampio kraštinės ilgį (b):");
            var krastiniuIlgis = int.Parse(Console.ReadLine());

            if(IsTrikampis(krastiniuKiekis))
            {
                Console.WriteLine("Įveskite aukštį (h):");
                var aukstis = int.Parse(Console.ReadLine());
                Console.WriteLine($"Plotas: {TrikampioPlotas(krastiniuIlgis, aukstis)}");
            }

            else if (IsKeturkampis(krastiniuKiekis))
            {
                Console.WriteLine($"Plotas: {KeturkampioPlotas(krastiniuKiekis, krastiniuIlgis)}");
            }

            else if (IsVisaKita(krastiniuKiekis))
            {
                Console.WriteLine("Įveskite statmenį (r):");
                var statmuo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Plotas: {VisuKituPlotas(krastiniuKiekis, krastiniuIlgis, statmuo)}");
            }

            else
            {
                Console.WriteLine("Neatpažinta figūra");
            }
                
            Console.WriteLine($"Vidinių kampų suma: {VidiniuKampuSuma(krastiniuKiekis)}");
        }

        /*
        UŽDUOTIS 1
        1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
        - Main metode paprašykite įvesti 2 skaičius
        - Kiekvienas matematinis veiksmas turi turėti savo metodą 
        metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
        - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
        - Visų gautų rezultatų sumą atspausdinti Main metode.

        2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
        - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
        - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą. 
        - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
        - parašyti testus
        - gautą rezultatą atspausdinti į ekraną Main metode.
        */

        public static int Suma(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius + antrasSkaicius;
        }

        public static int Atimtis(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius - antrasSkaicius;
        }

        public static int Daugyba(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius * antrasSkaicius;
        }

        public static double Dalyba(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius / (double)antrasSkaicius;
        }

        public static double? Skaiciuotuvas(int pirmasSkaicius1, int antrasSkaicius1, string matematinisVeiksmas)
        {
            switch(matematinisVeiksmas)
            {
                case "+":
                    return Suma(pirmasSkaicius1, antrasSkaicius1);
                case "-":
                    return Atimtis(pirmasSkaicius1, antrasSkaicius1);
                case "*":
                    return Daugyba(pirmasSkaicius1, antrasSkaicius1);
                case "/":
                    return Dalyba(pirmasSkaicius1, antrasSkaicius1);
                default:
                    return null;
            }
        }

        /*
        Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b)., 
         metodo parinkimui naudoti switch expression
        1. Kai įvestas trikampis, 
        - paprašyti įvesti aukšį h
        - A=1/2bh
        2. Kai įvestas keturkampis,
        - A=b*b
        3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
        - paprašyti įvesti statmenį r
        - A=n/2 * b * r
        4. išvesti betkokio poligono vidinių kampų sumą
        - 180 * (n - 2)
        N.B! atkreipkite dėmesį į metodų testuojamumą. 
        visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami
        */

        public static bool IsTrikampis(int krastiniuKiekis)
        {
            if (krastiniuKiekis == 3)
                return true;
            else
                return false;
        }

        public static bool IsKeturkampis(int krastiniuKiekis)
        {
            if (krastiniuKiekis == 4)
                return true;
            else
                return false;
        }

        public static bool IsVisaKita(int krastiniuKiekis)
        {
            if (krastiniuKiekis > 4)
                return true;
            else
                return false;
        }

        public static int VidiniuKampuSuma(int krastiniuKiekis)
        {
            return 180 * (krastiniuKiekis - 2);
        }

        public static double KeturkampioPlotas(int krastiniuKiekis, double krastiniuIlgis)
        {
            return krastiniuKiekis * (double)krastiniuIlgis;
        }

        public static double TrikampioPlotas(double krastiniuIlgis, double aukstis)
        {
            return 1 / (double)2 * krastiniuIlgis * aukstis;
        }

        public static double VisuKituPlotas(int krastiniuKiekis, double krastiniuIlgis, double statmuo)
        {
            return krastiniuKiekis / (double)2 * krastiniuIlgis * statmuo;
        }

        /*
        1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)

        2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)

        3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).

        4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) a^2
          6) a^3
        */

        public static double Suma(double pirmasSkaicius, double antrasSkaicius)
        {
            return pirmasSkaicius + antrasSkaicius;
        }

        public static double Atimtis(double pirmasSkaicius, double antrasSkaicius)
        {
            return pirmasSkaicius - antrasSkaicius;
        }

        public static double Daugyba(double pirmasSkaicius, double antrasSkaicius)
        {
            return pirmasSkaicius * antrasSkaicius;
        }

        public static double Dalyba(double pirmasSkaicius, double antrasSkaicius)
        {
            return pirmasSkaicius / antrasSkaicius;
        }

        public static double KelimasKvadratu(double skaicius)
        {
            return skaicius * skaicius;
        }

        public static double KelimasKubu(double skaicius)
        {
            return skaicius * skaicius * skaicius;
        }

        public static bool ArSvekiejiSkaiciai(string a, string b) => int.TryParse(a, out _) && int.TryParse(b, out _);
        public static bool ArDesimtainiaiSkaiciai(string a, string b) => double.TryParse(a, out _) && double.TryParse(b, out _);
    }
}