namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Nupieštas Tower of Hanoi

            string tuscias = "        |    ";
            string vienas = "       #|#   ";
            string du = "      ##|##  ";
            string trys = "     ###|### ";
            string keturi = "    ####|####";
            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{vienas}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{du}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{trys}{tuscias}{tuscias}");
            Console.WriteLine($"5eil.{keturi}{tuscias}{tuscias}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Nupieštas apverstas Tower of Hanoi

            Console.WriteLine($"1eil.{keturi}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{trys}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{du}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{vienas}{tuscias}{tuscias}");
            Console.WriteLine($"5eil.{tuscias}{tuscias}{tuscias}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Išvalytas Tower of Hanoi

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"5eil.{tuscias}{tuscias}{tuscias}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į kiekvieno stulpelio 5 eilutę įdėtas 4 dalių elementas

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"5eil.{keturi}{keturi}{keturi}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            /*
            Į 1 stulpelio 5 eilutę įdėtas 4 dalių elementas
            Į 2 sutulpelio 5 eilutę įdėtas 3 dalių elementas
            Į 3 stulpelio 4 eilutę įdėtas 1 dalies elementas
            Į 3 stulpelio 5 eilutę įdėtas 2 dalių elementas
            */

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{vienas}");
            Console.WriteLine($"5eil.{keturi}{trys}{du}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į 1 stulpelio 4 eilutę įdėtas toks pat elementas koks yra 3 stulpelyje 4 eilutėje

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"4eil.{vienas}{tuscias}{vienas}");
            Console.WriteLine($"5eil.{keturi}{trys}{du}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į visas 2 stulpelio eilutes įdėtas toks pat elementas koks yra 3 stulpelio 5 eilutėje

            Console.WriteLine($"1eil.{tuscias}{vienas}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{vienas}{tuscias}");
            Console.WriteLine($"3eil.{tuscias}{vienas}{tuscias}");
            Console.WriteLine($"4eil.{vienas}{vienas}{vienas}");
            Console.WriteLine($"5eil.{keturi}{vienas}{du}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            /*
            Į 3 stulpelį sudėta teisinga piramidė
            1 stulpelis ir 2 stulpelis turi likti tušti
            */

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{vienas}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{du}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{trys}");
            Console.WriteLine($"5eil.{tuscias}{tuscias}{keturi}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Pakeistas visų elementų dizainas iš # į "

            Console.WriteLine($"1eil.{tuscias}{tuscias}{tuscias.Replace("#","\"")}");
            Console.WriteLine($"2eil.{tuscias}{tuscias}{vienas.Replace("#", "\"")}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{du.Replace("#", "\"")}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{trys.Replace("#", "\"")}");
            Console.WriteLine($"5eil.{tuscias}{tuscias}{keturi.Replace("#", "\"")}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            /*
            Paprašyta naudotojo nupiešti 1 sulpelio 1 eilutę
            Išvestas visas Tower of Hanoi su perpiešta pirma eilute
            */

            Console.WriteLine("Nupieskite 1 stulpelio 1 eilute");

            string ivedimas = Console.ReadLine();

            Console.WriteLine($"1eil.     {ivedimas} {tuscias}{tuscias.Replace("#", "\"")}"); //gerai išlygiuoja tik su ###|###
            Console.WriteLine($"2eil.{tuscias}{tuscias}{vienas.Replace("#", "\"")}");
            Console.WriteLine($"3eil.{tuscias}{tuscias}{du.Replace("#", "\"")}");
            Console.WriteLine($"4eil.{tuscias}{tuscias}{trys.Replace("#", "\"")}");
            Console.WriteLine($"5eil.{tuscias}{tuscias}{keturi.Replace("#", "\"")}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();
        }
    }
}