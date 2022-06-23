namespace P007_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
            EGZAMINO PAŽYMĮ. IŠVESTI:
            0 - 4: NEPATEKINAMAI
            5: SILPNAI
            6: PATENKINAMAI
            7: VIDUTINIŠKAI
            8: GERAI
            9: LABAI GERAI
            10: PUIKIAI
            */
            /*
            Console.WriteLine("Įveskite egzamino pažymį:");
            var pazymys = int.Parse(Console.ReadLine());

            if (pazymys < 0)
            {
                Console.WriteLine("KLAIDA");
            }

            else if (pazymys == 5)
            {
                Console.WriteLine("SILPNAI");
            }

            else if (pazymys == 6)
            {
                Console.WriteLine("PATENKINAMAI");
            }

            else if (pazymys == 7)
            {
                Console.WriteLine("VIDUTINIŠKAI");
            }

            else if (pazymys == 8)
            {
                Console.WriteLine("GERAI");
            }

            else if (pazymys == 9)
            {
                Console.WriteLine("LABAI GERAI");
            }

            else if (pazymys == 10)
            {
                Console.WriteLine("PUIKIAI");
            }

            else
            {
                Console.WriteLine("NEPATENKINAMAI");
            }

            /*
            ** Nemokama kava **
            Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
            Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
            - Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
            - Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"
            */
            /*
            var puodeliuKiekis = -2;
            var nemokamiPuodeliai = puodeliuKiekis / 3;

            if (nemokamiPuodeliai == 1)
            {
                Console.WriteLine($"Pirkėjui priklauso {nemokamiPuodeliai} nemokamas puodelis");
            }

            else if (nemokamiPuodeliai > 1)
            {
                Console.WriteLine($"Pirkėjui priklauso {nemokamiPuodeliai} nemokami puodeliai");
            }

            else if (nemokamiPuodeliai <= 0)
            {
                Console.WriteLine("KLAIDA");
            }

            else
            {
                Console.WriteLine("Pirkėjui nepriklauso nemokami puodeliai");
            }

            /*
            ** Piešingi skaičiai **
            Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
            - Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
            - Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;
            */

            Console.WriteLine("Įveskite betkokius 4 sveikus skaičius:");
            var skaicius1 = int.Parse(Console.ReadLine());
            var skaicius2 = int.Parse(Console.ReadLine());
            var skaicius3 = int.Parse(Console.ReadLine());
            var skaicius4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{skaicius1}; {skaicius2}; {skaicius3}; {skaicius4}");

            if (skaicius1 > 0)
            {
                Console.WriteLine($"{0 - skaicius1}");
            }

            else if (skaicius1 == 0)
            {
                Console.WriteLine("N/A");
            }

            else 
            {
                Console.WriteLine($"{skaicius1 * -1}");
            }

            if (skaicius2 > 0)
            {
                Console.WriteLine($"{0 - skaicius2}");
            }

            else if (skaicius2 == 0)
            {
                Console.WriteLine("N/A");
            }

            else
            {
                Console.WriteLine($"{skaicius2 * -1}");
            }

            if (skaicius3 > 0)
            {
                Console.WriteLine($"{0 - skaicius3}");
            }

            else if (skaicius3 == 0)
            {
                Console.WriteLine("N/A");
            }

            else
            {
                Console.WriteLine($"{skaicius3 * -1}");
            }

            if (skaicius4 > 0)
            {
                Console.WriteLine($"{0 - skaicius4}");
            }

            else if (skaicius4 == 0)
            {
                Console.WriteLine("N/A");
            }

            else
            {
                Console.WriteLine($"{skaicius4 * -1}");
            }

            /*
            ŽAIDIMAS ATSPĖK SKAIČIŲ
            - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
            - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
            - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
            - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
            - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
            nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
            */

            /*
            * SKAIČIUOTUVAS *
            Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
            - Parašykite programą kuri į ekraną išves skaičių rezultatą
            - naudokite if
            - naudokite switch
            */
        }
    }
}