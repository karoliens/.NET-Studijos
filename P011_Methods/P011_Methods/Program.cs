namespace P011_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius:");
            var pirmasSkaicius = int.Parse(Console.ReadLine());
            var antrasSkaicius = int.Parse(Console.ReadLine());

            Menu(pirmasSkaicius, antrasSkaicius);

            //var menuPasirinkimas = Console.ReadLine();

            //if ()





            /*
            Console.WriteLine($"Sudėtis: {Suma(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Atimtis: {Atimtis(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Daugyba: {Daugyba(pirmasSkaicius, antrasSkaicius)}");
            Console.WriteLine($"Dalyba: {Dalyba(pirmasSkaicius, antrasSkaicius)}");

            Console.WriteLine($"Visų gautų rezultatų suma: {Suma(pirmasSkaicius, antrasSkaicius) + Atimtis(pirmasSkaicius, antrasSkaicius) + Daugyba(pirmasSkaicius, antrasSkaicius) + Dalyba(pirmasSkaicius, antrasSkaicius)}");
            
            Console.WriteLine("Įveskite du skaičius ir matematninį veiksmą:");
            var pirmasSkaicius1 = int.Parse(Console.ReadLine());
            var antrasSkaicius1 = int.Parse(Console.ReadLine());
            var matematinisVeiksmas = Console.ReadLine();

            Console.WriteLine(Skaiciuotuvas(pirmasSkaicius1, antrasSkaicius1, matematinisVeiksmas));

            Console.WriteLine("Įveskite taisiklingojo daugiakampio kraštinių kiekį (n):");
            var krastiniuKiekis = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite taisiklingojo daugiakampio kraštinės ilgį (b):");
            var krastiniuIlgis = int.Parse(Console.ReadLine());

            Console.WriteLine($"Plotas: {PlotoSkaiciavimas(krastiniuKiekis, krastiniuIlgis)}");
            Console.WriteLine($"Vidinių kampų suma: {VidiniuKampuSuma(krastiniuKiekis)}");*/
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

        public static double PlotoSkaiciavimas(int krastiniuKiekis, int krastiniuIlgis)
        {
            if (IsTrikampis(krastiniuKiekis))
                Console.WriteLine("Įveskite aukštį (h):");
                var aukstis = Console.ReadLine();
                    return (1 / (double)2) * krastiniuIlgis * krastiniuKiekis;

            if (IsKeturkampis(krastiniuKiekis))
                    return krastiniuIlgis * krastiniuIlgis;

            if (IsVisaKita(krastiniuKiekis))
                Console.WriteLine("Įveskite statmenį (r):");
                var statmuo = int.Parse(Console.ReadLine());
                    return (krastiniuKiekis / (double)2) * krastiniuIlgis * statmuo;
   
                return 0;
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

        public static double KelimasKvadratu(double pirmasSkaicius)
        {
            return pirmasSkaicius * pirmasSkaicius;
        }

        public static double KelimasKubu(double pirmasSkaicius)
        {
            return pirmasSkaicius * pirmasSkaicius * pirmasSkaicius;
        }

        public static bool YraKablelis(string pirmasSkaicius, string antrasSkaicius)
        {
            if (pirmasSkaicius.Contains(",") && antrasSkaicius.Contains(","));
                return true;
            
            return
                    false;
        }

        public static void Menu(int pirmasSkaicius, int antrasSkaicius)
        {
            Console.WriteLine("Pasirinkite matematinį veiksmą:");
            var pasirinkimas = Console.ReadLine();

            var menuPasirinkimas = pasirinkimas switch
            {
                "1)" or "+" => Suma(pirmasSkaicius, antrasSkaicius),
                "2)" or "-" => Atimtis(pirmasSkaicius, antrasSkaicius),
                "3)" or "*" => Daugyba(pirmasSkaicius, antrasSkaicius),
                "4)" or "/" => Dalyba(pirmasSkaicius, antrasSkaicius),
                "5)" or "a^2" => KelimasKvadratu(pirmasSkaicius),
                "6)" or "a^3" => KelimasKubu(pirmasSkaicius),
            };

            //return menuPasirinkimas;
        }

        /*
        Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
        Galimos bazės: Adenine, Thymine, Cytosine, Guanine
         Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
         1. Atlikti DNR grandinės normalizavimo veiksmus:
            - pašalina tarpus.
            - visas raides keičia didžiosiomis. 
         2. Atlikti grandinės validaciją
            - patikrina ar nėra kitų nei ATCG raidžių
         3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
             - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
             1) normalizuoti grandinę
             2) išeiti iš programos
             - jei grandinė normalizuota arba kai buvo atlikta normalizacija
             1) GCT pakeis į AGG
             2) Išvesti ar yra tekste CAT 
             3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
             4) Išvesti raidžių kiekį tekste (naudoti string composition)
             5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
             6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
             7) Iš grandinės pašalinti pasirinką elementą  
             8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
             9) Gryžti į ankstesnį meniu
       Visoms operacijoms reikalingi testai.
         
         
         */
    }
}