namespace P003_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            PARAŠYTI PROGRAMĄ KURIOJE SAUGOME:
            • MOKYKLOS PAVADINIMĄ
            • KURSO PAVADINIMĄ
            • STUDENTŲ SKAIČIŲ
            • ŠIANDIENOS DATĄ
            • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
            */

            string mokyklosPavadinimas = "CodeAcademy";
            string kursoPavadinimas = ".NET";
            int studentuSkaicius = 18;
            DateTime data = DateTime.Now;

            Console.WriteLine($"{mokyklosPavadinimas}\n{kursoPavadinimas}\n{studentuSkaicius}\n{data.ToShortDateString()}");

            /*
            PAPILDYTI PROGRAMĄ IR PRIDĖTI:
            • KURSO PRADŽIOS DATĄ
            • KURSO PABAIGOS DATĄ
            • Sužinoti skirtumą tarp pradžios ir dabartinės datos (dienomis)
            • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
            */

            DateTime kursoPradziosData = new DateTime(2022, 05, 30);
            DateTime kursoPabaigosData = new DateTime(2022, 12, 01);

            TimeSpan value = data - kursoPradziosData;

            Console.WriteLine($"{kursoPradziosData.ToShortDateString()}");
            Console.WriteLine($"{kursoPabaigosData.ToShortDateString()}");
            Console.WriteLine($"{value.Days}");

            /*
            Sukurkite tris kintamuosius: tekstinio, sveiko skaitmens ir loginio tipo.
            Parašykite programą, kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu
            */

            string text = "Ledai";
            int number = 2;
            bool boolean = true;

            Console.WriteLine($"{text} {number} {boolean}");

            /*
            Sukurkite tris sveikojo skaitmens tipo kintamuosius.
            Parašykite programą kuri į konsolę visus aprašytus kintamuosius atskiriant tarpu
            - panaudokite konkatinacija
            - panaudokite kompoziciją
            - panaudokite interpociacija
            */

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;

            Console.WriteLine(number1 + " " + number2 + " " + number3);
            Console.WriteLine("{0} {1} {2}", number1, number2, number3);
            Console.WriteLine($"{ number1} { number2} { number3}");
        }
    }
}