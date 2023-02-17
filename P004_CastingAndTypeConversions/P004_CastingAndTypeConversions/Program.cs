namespace P004_CastingAndTypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*
            //PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS. PROGRAMA TURI IŠVESTI:
            //• SKAIČIŲ SUMĄ
            //• SKAIČIŲ SKIRTUMĄ
            //• SANDAUGĄ
            //• DALYBĄ
            //*/

            //Console.WriteLine("Įveskite pirmą skaičių:");
            //string skaicius1 = Console.ReadLine();

            //Console.WriteLine("Įveskite antrą skaičių:");
            //string skaicius2 = Console.ReadLine();

            //Console.WriteLine($"Skaičių suma: {Convert.ToInt32(skaicius1) + Convert.ToInt32(skaicius2)}");
            //Console.WriteLine($"Skaičių skirtumas: {Convert.ToInt32(skaicius1) - Convert.ToInt32(skaicius2)}");
            //Console.WriteLine($"Skaičių sandauga: {Convert.ToInt32(skaicius1) * Convert.ToInt32(skaicius2)}");
            //Console.WriteLine($"Skaičių dalyba: {(double)Convert.ToInt32(skaicius1) / Convert.ToInt32(skaicius2)}");

            ////PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ.

            //Console.WriteLine("Įveskite pirmą skaičių:");
            //int s1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Įveskite antrą skaičių:");
            //int s2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Įveskite trečią skaičių:");
            //int s3 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Vidurkis: {((double)s1 + s2 + s3) / 3}");

            ///*
            //sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
            //sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
            //- padalinkite didesnį skaičių iš mažesnio
            //- iš rezultato atimkite maksimalų long skaičių
            //- ir pridėkite maksimalų int skaičių
            //*/

            //long ilgas = long.MaxValue;
            //short trumpas = short.MaxValue;

            //Console.WriteLine($"Dalyba: {(double)ilgas / trumpas}");
            //Console.WriteLine($"Atimtis: {(double)ilgas / trumpas - ilgas}");
            //Console.WriteLine($"Sudėtis: {(double)ilgas / trumpas + int.MaxValue}");

            ///*
            //PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
            //INT , SHORT , BYTE
            //STEBĖTI REZULTATĄ.
            //*/

            //double didelisSkaicius = 1000000000;

            //Console.WriteLine($"INT: {Convert.ToInt32(didelisSkaicius)}");
            //// Console.WriteLine($"SHORT: {Convert.ToInt16(didelisSkaicius)}"); // netelpa
            //// Console.WriteLine($"BYTE: {Convert.ToByte(didelisSkaicius)}"); // netelpa

            ///*
            //PARAŠYTI PROGRAMĄ KURI
            //PRAŠO ĮVESTI RUTULIO DIAMETRĄ,
            //O IŠVEDA PLOTĄ IR TŪRĮ
            //*/

            //Console.WriteLine("Įveskite rutulio diametrą:");
            //var d = double.Parse(Console.ReadLine());
            //var r = d / 2;

            //Console.WriteLine($"Plotas: {4 * 3.14 * r * r}");
            //Console.WriteLine($"Tūris: {4 / 3 * 3.14 * r * r * r}");

            ///*
            //PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (METRAIS) IR LAIKĄ (SEKUNDĖMIS),
            //- IŠVEDA GREITĮ km/h.
            //- IŠVEDA GREITĮ km/s.
            //*/

            //Console.WriteLine("Įveskite atstumą metrais:");
            //var atstumas = double.Parse(Console.ReadLine());

            //Console.WriteLine("Įveskite laiką sekundėmis");
            //var laikas = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Greitis km/h: {((atstumas) / 1000) / ((laikas) * 3600)}");
            //Console.WriteLine($"Greitis km/s: {((atstumas) / 1000) / (laikas)}");

            ///*
            //Nuskaitykite iš klaviatūros 2 skaičius (x ir y).
            //Išveskite į ekraną funkciją y+2y+x+1 ir apskaičiuokite šios funkcijos rezultatą.
            //Išveskite į ekraną funkciją y²+x/2 apskaičiuokite šios funkcijos rezultatą.
            //*/

            //var x = int.Parse(Console.ReadLine());
            //var y = int.Parse(Console.ReadLine());
            //var rezultatas1 = y + 2 * y + x + 1;
            //var rezultatas2 = y * y + x / 2;

            //Console.WriteLine($"{rezultatas1}");
            //Console.WriteLine($"{rezultatas2}");

            ///*
            //PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            //VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            //PVZ BUVO ĮVESTA 12345
            //REZULTATAS 2345/2=1172,5
            //<HINT> naudokite replace
            //*/

            //Console.WriteLine("Įveskite penkiaženklį sveiką skaičių:");

            //int penkiazenklisSkaicius = int.Parse(Console.ReadLine().Replace("1", "0"));
            //Console.WriteLine($"Rezultatas: {penkiazenklisSkaicius}/2={(double)penkiazenklisSkaicius / 2}");

            ///*
            //PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            //VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            //PVZ BUVO ĮVESTA 12345
            //REZULTATAS 10000/2=5000
            //<HINT> naudokite replace
            //*/

            //Console.WriteLine("Įveskite penkiaženklį sveiką skaičių:");

            //int penkiazenklisSkaicius1 = int.Parse(Console.ReadLine()
            //    .Replace("2", "0")
            //    .Replace("3", "0")
            //    .Replace("4", "0")
            //    .Replace("5", "0")
            //    .Replace("6", "0")
            //    .Replace("7", "0")
            //    .Replace("8", "0")
            //    .Replace("9", "0"));

            //Console.WriteLine($"Rezultatas: {penkiazenklisSkaicius1}/2={(double)penkiazenklisSkaicius1 / 2}");

            /*
            PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
            VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
            PVZ BUVO ĮVESTA 5
            REZULTATAS 6 7 8 9 10
            */

            Console.WriteLine("Įveskite sveiką skaičių:");
            var skaicius = int.Parse(Console.ReadLine());

            Console.WriteLine($"{++skaicius} {++skaicius} {++skaicius} {++skaicius} {++skaicius}");
        }
    }
}