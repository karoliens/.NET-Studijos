namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Nupiestas Tower of Hanoi

            string pirmaEil = "       |     ";
            string antraEil = "      #|#    ";
            string treciaEil = "     ##|##   ";
            string ketvirtaEil = "    ###|###  ";
            string penktaEil = "   ####|#### ";
            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{antraEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{treciaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{ketvirtaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"5eil.{penktaEil}{pirmaEil}{pirmaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Nupiestas apverstas Tower of Hanoi

            Console.WriteLine($"1eil.{penktaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{ketvirtaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{treciaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{antraEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"5eil.{pirmaEil}{pirmaEil}{pirmaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Isvalytas Tower of Hanoi

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"5eil.{pirmaEil}{pirmaEil}{pirmaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į kiekvieno stulpelio 5 eilute idetas 4 dalių elementas

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"5eil.{penktaEil}{penktaEil}{penktaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            /*
            Į 1 stulpelio 5 eilute įdėtas 4 dalių elementas
            I 2 sutulpelio 5 eilute idetas 3 dalių elementas
            I 3 stulpelio 4 eilute idetas 1 dalies elementas
            I 3 stulpelio 5 eilute idetas 2 dalių elementas
            */

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{antraEil}");
            Console.WriteLine($"5eil.{penktaEil}{ketvirtaEil}{treciaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į 1 stulpelio 4 eilute įdėtas toks pat elementas kaip yra 3 stulpelyje 4 eiluteje

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"4eil.{antraEil}{pirmaEil}{antraEil}");
            Console.WriteLine($"5eil.{penktaEil}{ketvirtaEil}{treciaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Į visas 2 stulpelio eilutes įdėtas toks pat elementas kaip yra 3 stulpelio 5 eiluteje

            Console.WriteLine($"1eil.{pirmaEil}{antraEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{antraEil}{pirmaEil}");
            Console.WriteLine($"3eil.{pirmaEil}{antraEil}{pirmaEil}");
            Console.WriteLine($"4eil.{antraEil}{antraEil}{antraEil}");
            Console.WriteLine($"5eil.{penktaEil}{antraEil}{treciaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            /*
            I 3 stulpeli sudėta teisinga piramide
            1 stulpelis ir 2 stulpelis turi likti tušti
            */

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{antraEil}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{treciaEil}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{ketvirtaEil}");
            Console.WriteLine($"5eil.{pirmaEil}{pirmaEil}{penktaEil}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //pakeiskitas visų elementų dizainas iš # į "

            Console.WriteLine($"1eil.{pirmaEil}{pirmaEil}{pirmaEil.Replace("#","\"")}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{antraEil.Replace("#", "\"")}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{treciaEil.Replace("#", "\"")}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{ketvirtaEil.Replace("#", "\"")}");
            Console.WriteLine($"5eil.{pirmaEil}{pirmaEil}{penktaEil.Replace("#", "\"")}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("Nupieskite 1 stulpelio 1 eilute");

            string ivedimas = Console.ReadLine();

            Console.WriteLine($"1eil.{ivedimas}{pirmaEil}{pirmaEil.Replace("#", "\"")}");
            Console.WriteLine($"2eil.{pirmaEil}{pirmaEil}{antraEil.Replace("#", "\"")}");
            Console.WriteLine($"3eil.{pirmaEil}{pirmaEil}{treciaEil.Replace("#", "\"")}");
            Console.WriteLine($"4eil.{pirmaEil}{pirmaEil}{ketvirtaEil.Replace("#", "\"")}");
            Console.WriteLine($"5eil.{pirmaEil}{pirmaEil}{penktaEil.Replace("#", "\"")}");

            Console.WriteLine("      ----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();
        }
    }
}