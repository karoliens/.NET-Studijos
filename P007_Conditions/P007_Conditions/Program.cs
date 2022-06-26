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
            
            var betKoksSkaicius = 5;

            Console.WriteLine("Įveskite skaičių nuo 1 iki 20:");

            var spetasSkaicius = int.Parse(Console.ReadLine());

            if (betKoksSkaicius == spetasSkaicius)
            {
                Console.WriteLine("TESINGAI");
            }

            else if (betKoksSkaicius > spetasSkaicius && spetasSkaicius > 0)
            {
                Console.WriteLine("SKAIČIUS YRA DIDESNIS");
            }

            else if (spetasSkaicius <= 0)
            {
                Console.WriteLine("SKAIČIUS NEPATENKA Į INTERVALĄ");
            }
            else
            {
                Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
            }

            /*
            * SKAIČIUOTUVAS *
            Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
            - Parašykite programą kuri į ekraną išves skaičių rezultatą
            - naudokite if
            - naudokite switch
            */
            
            Console.WriteLine("Įveskite du skaičius:");

            var pirmasSkaicius = int.Parse(Console.ReadLine());
            var antrasSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Pasirinkti skaičiai: {pirmasSkaicius} ir {antrasSkaicius}");

            Console.WriteLine("Įveskite matematinę operaciją: +, -, *, /");

            var matematineOperacija = Console.ReadLine();

            if (matematineOperacija == "+")
            {
                Console.WriteLine($"Skaičių {pirmasSkaicius} ir {antrasSkaicius } sudėties rezultatas: {pirmasSkaicius + antrasSkaicius}");
            }

            if (matematineOperacija == "-")
            {
                Console.WriteLine($"Skaičių {pirmasSkaicius} ir {antrasSkaicius} atimties rezultatas: {pirmasSkaicius - antrasSkaicius}");
            }

            if (matematineOperacija == "*")
            {
                Console.WriteLine($"Skaičių {pirmasSkaicius} ir {antrasSkaicius} daugybos rezultatas: {pirmasSkaicius * antrasSkaicius}");
            }

            if (matematineOperacija == "/")
            {
                Console.WriteLine($"Skaičių {pirmasSkaicius} ir {antrasSkaicius} dalybos rezultatas: {pirmasSkaicius / antrasSkaicius}");
            }

            /*
            * Trys draugai *
            - Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
            - Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
            - Atspausdinti draugų amžiaus vidurkį
            - Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
            - Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
            <Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
            konstrukcijas kurias iki šiol išėjome.
            */
            
            Console.WriteLine("Įveskite draugo vardą:");

            var draugoVardas1 = Console.ReadLine();

            Console.WriteLine("Įveskite draugo amžių:");

            var draugoAmzius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite draugo vardą:");

            var draugoVardas2 = Console.ReadLine();

            Console.WriteLine("Įveskite draugo amžių:");

            var draugoAmzius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite draugo vardą:");

            var draugoVardas3 = Console.ReadLine();

            Console.WriteLine("Įveskite draugo amžių:");

            var draugoAmzius3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Pirmo draugo vardas yra {draugoVardas1} ir jam yra {draugoAmzius1} metai");
            Console.WriteLine($"Antro draugo vardas yra {draugoVardas2} ir jam yra {draugoAmzius2} metai");
            Console.WriteLine($"Trečio draugo vardas yra {draugoVardas3} ir jam yra {draugoAmzius3} metai");
            Console.WriteLine($"Amžiaus vidurkis {(float)(draugoAmzius1 + draugoAmzius2 + draugoAmzius3) / 3}");

            if (draugoAmzius1 < draugoAmzius2 && draugoAmzius1 < draugoAmzius3)
            {
                Console.WriteLine($"Jauniausias draugas yra: {draugoVardas1} ir jam yra {draugoAmzius1}");
            }

            else if (draugoAmzius2 < draugoAmzius1 && draugoAmzius2 < draugoAmzius3)
            {
                Console.WriteLine($"Jauniausias draugas yra: {draugoVardas2} ir jam yra {draugoAmzius2}");
            }

            else if (draugoAmzius3 < draugoAmzius1 && draugoAmzius3 < draugoAmzius2)
            {
                Console.WriteLine($"Jauniausias draugas yra: {draugoVardas3} ir jam yra {draugoAmzius3}");
            }


            if (draugoAmzius1 > draugoAmzius2 && draugoAmzius1 > draugoAmzius3)
            {
                Console.WriteLine($"Vyriausias draugas yra: {draugoVardas1} ir jam yra {draugoAmzius1}");
            }

            else if (draugoAmzius2 > draugoAmzius1 && draugoAmzius2 > draugoAmzius3)
            {
                Console.WriteLine($"Vyriausias draugas yra: {draugoVardas2} ir jam yra {draugoAmzius2}");
            }

            else if (draugoAmzius3 > draugoAmzius1 && draugoAmzius3 > draugoAmzius2)
            {
                Console.WriteLine($"Vyriausias draugas yra: {draugoVardas3} ir jam yra {draugoAmzius3}");
            }

            /*
            ** Kalėdų sausainiai **
            - Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
            - Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
            - Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
            - Jei nėra išveda - "Palaukite kalėdų"
            Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
            <Hint> metodai data.Month ir data.Day
            */

            Console.WriteLine("Įveskite 4 datas formatu yyyy-MM-dd, po kiekvieno įvedimo spauskite Enter:");

            var data1 = DateTime.Parse(Console.ReadLine());
            var data2 = DateTime.Parse(Console.ReadLine());
            var data3 = DateTime.Parse(Console.ReadLine());
            var data4 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Įvesta {data1.ToString("yyyy-MM-dd")} {data2.ToString("yyyy-MM-dd")} {data3.ToString("yyyy-MM-dd")} {data4.ToString("yyyy-MM-dd")}");


            if (data1.Month == 12 && data1.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdų sausainiai");

            else if (data2.Month == 12 && data2.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdų sausainiai");

            else if (data3.Month == 12 && data3.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdų sausainiai");
            
            else if (data4.Month == 12 && data4.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdų sausainiai");

            else
                Console.WriteLine("Palaukite kalėdų");
        }
    }
}