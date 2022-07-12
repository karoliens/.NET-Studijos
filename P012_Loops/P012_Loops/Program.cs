namespace P012_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DoWhilePavyzdys();
            //SkaiciuSumaNuoVienoIkiIvesto();
            //LyginiaiSkaiciaiNuoNulioIkiIvesto();
            //LyginiaiSkaiciaiNuoNulioIkiIvestoFor();
            //SkaiciuSumaIkiNeigiamoSkaiciaus();
            //SlaptazodzioSimuliacija();
            SkaiciusArHerbas();
        }

        public static void DoWhilePavyzdys()
        {
            var zaidejuSkaicius = 0;
            do
            {
                Console.WriteLine("Kiek žaidėjų žais žaidimą?");
                zaidejuSkaicius = int.Parse(Console.ReadLine());

            } while (zaidejuSkaicius < 1 || zaidejuSkaicius > 10);
        }

        /*         
        * Paprašyti vartotojo įvesti bet kokį skaičių. Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.
        */

        public static void SkaiciuSumaNuoVienoIkiIvesto()
        {
            var suma = 0;
            int i;

            Console.WriteLine("Įveskite betkokį skaičių:");
            i = int.Parse(Console.ReadLine());

            while (i > 0)
            {
                suma += i;
                i--;
            }
            Console.WriteLine($"Suma: {suma}");
        }

        /*
        * Paprašyti vartotojo įvesti bet kokį skaičių. 
        * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
        */

        public static void LyginiaiSkaiciaiNuoNulioIkiIvesto()
        {
            Console.WriteLine("Įveskite betkokį skaičių:");

            var ivestasSkaicius = int.Parse(Console.ReadLine());

            while (ivestasSkaicius >= 0)
            {

                if (ivestasSkaicius % 2 == 0)
                {
                    Console.Write($"{ivestasSkaicius}, ");
                    
                }

                ivestasSkaicius--;
            }  
        }

        public static void LyginiaiSkaiciaiNuoNulioIkiIvestoFor()
        {
            Console.WriteLine("Įveskite betkokį skaičių:");

            var ivestasSkaicius = int.Parse(Console.ReadLine());

            for (int i = 0; i < ivestasSkaicius; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
        }

        /*
        * Parašyti programą, kuri apskaičiuoja visų įvestų skaičių sumą, kurie buvo įvesti iki įvesto neigiamo skaičiaus
        * 
        * PVZ
        * 1,23,4,5,7,8,-1
        */

        public static void SkaiciuSumaIkiNeigiamoSkaiciaus()
        {
            var ivestiSkaiciai = 0;
            int suma = 0;

            while (ivestiSkaiciai >= 0)
            {
                Console.WriteLine("Įveskite skaičius:");
                ivestiSkaiciai = int.Parse(Console.ReadLine());
                if (ivestiSkaiciai >= 0)
                {
                    suma = suma + ivestiSkaiciai;
                } 
            }
            Console.WriteLine($"{suma}");
        }

        /*
        * Parasykite slaptazodzio ivedimo simuliacija. 
        * Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi.
        * Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
        * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
        * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo. 
        */

        public static void SlaptazodzioSimuliacija()
        {
            Console.WriteLine("Nustatykite slaptažodį:");
            var ivestasSlaptazodis = Console.ReadLine();

            Console.WriteLine("Pakartokite slaptažodį:");
            var pakartotasSlaptazodis = Console.ReadLine();

            while (ivestasSlaptazodis != pakartotasSlaptazodis)
            {
                Console.WriteLine("Slaptažodis neteisingas. Bandykite dar kartą.");

                Console.WriteLine("Pakartokite slaptažodį:");
                pakartotasSlaptazodis = Console.ReadLine();

                break;
            }
        }

        //Parasykite programa, kuri paklaustu naudotojo “skaicius ar herbas” ir naudotojas galetu zaisti iki kol pasieke arba 10 pergaliu arba 10 pralaimejimu

        public static void SkaiciusArHerbas()
        {
            var randomObjektas = new Random();
            var ismestaMoneta = randomObjektas.Next(1, 2);
            int monetosMetimas = 0;

            while (monetosMetimas < 10)
            {
                monetosMetimas++;
            }
        }
    }
}