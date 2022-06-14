namespace P004_CastingAndTypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS. PROGRAMA TURI IŠVESTI:
            • SKAIČIŲ SUMĄ
            • SKAIČIŲ SKIRTUMĄ
            • SANDAUGĄ
            • DALYBĄ
            */

            Console.WriteLine("Įveskite pirmą skaičių:");
            string skaicius1 = Console.ReadLine();

            Console.WriteLine("Įveskite antrą skaičių:");
            string skaicius2 = Console.ReadLine();

            Console.WriteLine($"Skaičių suma: {Convert.ToInt32(skaicius1) + Convert.ToInt32(skaicius2)}");
            Console.WriteLine($"Skaičių skirtumas: {Convert.ToInt32(skaicius1) - Convert.ToInt32(skaicius2)}");
            Console.WriteLine($"Skaičių sandauga: {Convert.ToInt32(skaicius1) * Convert.ToInt32(skaicius2)}");
            Console.WriteLine($"Skaičių dalyba: {Convert.ToInt32(skaicius1) / Convert.ToInt32(skaicius2)}");

            
            //PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ.
            

            Console.WriteLine("Įveskite pirmą skaičių:");
            int s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int s2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Įveskite trečią skaičių:");
            int s3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vidurkis: {((double)s1 + s2 + s3) / 3}");

            /*
            sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
            sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
            - padalinkite didesnį skaičių iš mažesnio
            - iš rezultato atimkite maksimalų long skaičių
            - ir pridėkite maksimalų int skaičių
            */
        }
    }
}