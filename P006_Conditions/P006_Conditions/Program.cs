namespace P006_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
            - JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
            - JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
            - KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ
            */
            /*
            Console.WriteLine("Įveskite skaičių:");

            var skaicius = int.Parse(Console.ReadLine());

            if (skaicius % 2 == 0 && skaicius !=0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }    
            
            if (skaicius < 0)
            {
                Console.WriteLine("Skaičius yra neigiamas");
            }
      
            else
            {
                Console.WriteLine($"{skaicius}");
            }*/
            
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
            VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
            JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
            „TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2 --„TAI
            DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
            MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
            DAUGIAU NEI 10 ––„TAI KAMERINIS
            ANSAMBLIS“.
            */
            /*
            Console.WriteLine("Įveskite grupės narių kiekį:");
            
            var nariuKiekis = int.Parse(Console.ReadLine());

            if (nariuKiekis == 1)
            {
                Console.WriteLine("TAI SOLO ATLIKĖJAS");
            }

            else if (nariuKiekis == 2)
            {
                Console.WriteLine("TAI DUETAS");
            }

            else if (nariuKiekis > 2 && nariuKiekis < 10)
            {
                Console.WriteLine("TAI ANSAMBLIS");
            }

            else if (nariuKiekis <= 0)
            {
                Console.WriteLine("KLAIDA");
            }

            else
            {
                Console.WriteLine("TAI KAMERINIS ANSAMBLIS");
            }*/
           
            /*
            PARAŠYTI PROGRAMĄ, KURI
            PAPRAŠO VARTOTOJO ĮVESTI
            IŠDIRBTAS VALANDAS.
            JEI VALANDŲ YRA MAŽIAU NEI 160,
            PROGRAMA TURI PARODYTI, KIEK
            DAR REIKIA IŠDIRBTI, JEI LYGIAI 160,
            PARODO, KAD IŠDIRBTAS PILNAS
            ETATAS, JEI DAUGIAU PARODO
            KIEK YRA VIRŠVALANDŽIŲ.
            JEI VARTOTOJAS PADARO ĮVEDIMO
            KLAIDĄ PRANEŠTI IR UŽBAIGTI
            DARBĄ
            */
            
            Console.WriteLine("Įveskite išdirbtas valandas:");

            var valandos = int.Parse(Console.ReadLine());

            if (valandos < 160 && valandos > 0) 
            {
                Console.WriteLine($"Dar reikia išdirbti: {160 - valandos}");
            }
            else if (valandos == 160)
            {
                Console.WriteLine("Išdirbtas pilnas etatas");
            }
            else if (valandos > 160)
            {
                Console.WriteLine($"Sukaupta viršvalandžių: {valandos - 160}");
            }
            else
            {
                Console.WriteLine("Klaida");
            }
        }
    }
}