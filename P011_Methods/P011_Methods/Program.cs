namespace P011_Methods
{
    internal class Program
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

            Console.WriteLine("Įveskite du skaičius ir matematninį veiksmą:");
            var pirmasSkaicius1 = int.Parse(Console.ReadLine());
            var antrasSkaicius1 = int.Parse(Console.ReadLine());
            var matematinisVeiksmas = Console.ReadLine();

            Console.WriteLine(Skaiciuotuvas(pirmasSkaicius1, antrasSkaicius1, matematinisVeiksmas));
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


    }
}