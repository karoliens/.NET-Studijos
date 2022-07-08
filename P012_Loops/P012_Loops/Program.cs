namespace P012_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoWhilePavyzdys();
            SkaiciuSumaNuoVienoIkiIvesto();
            LyginiaiSKaiciaiNuoNulioIkiIvesto();
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
            var i = 0;

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

        public static void LyginiaiSKaiciaiNuoNulioIkiIvesto()
        {
            var suma = 0;
            var i = 0;

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
        * Parašyti programa, kuri apskaičiuoja visų įvestų skaičių sumą, kurie buvo įvesti iki įvesto neigiamo skaičiaus
        * 
        * PVZ
        * 1,23,4,5,7,8,-1
        */

        public static void Suma()
        {
            Console.WriteLine("Įveskite skaičius:");
            var ivestiSkaiciai = int.Parse(Console.ReadLine());

            //var ivestiSkaiciai = 0;
            var suma = 0;
            var i = 0;

            while (ivestiSkaiciai > 0)
            {
                suma = ivestiSkaiciai++;
                Console.WriteLine($"{suma}");
            }
                
        }

        /*
        * Parasykite slaptazodzio ivedimo simuliacija. 
        * Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi.
        * Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
        * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
        * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo. 
        */
    }
}