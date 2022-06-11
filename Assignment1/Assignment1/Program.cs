namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.
            Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi
            Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
            Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
            Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi
            Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
            Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi
            į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi
            pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi
            paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute
            */

            //Nupiestas Tower of Hanoi

            string pirmaEil =    "      |";
            string antraEil =    "     #|#";
            string treciaEil =   "    ##|##";
            string ketvirtaEil = "   ###|###";
            string penktaEil =   "  ####|####";
            Console.WriteLine($"1eil.{pirmaEil}\n2eil.{antraEil}\n3eil.{treciaEil}\n4eil.{ketvirtaEil}\n5eil.{penktaEil}");
            Console.WriteLine("\t----1stulp-------2stulp-------3stulp----");
            Console.WriteLine("\n\n----testi------");
            Console.ReadLine();

            //Nupiestas apverstas Tower of Hanoi

            Console.WriteLine($"\n{penktaEil}\n{ketvirtaEil}\n{treciaEil}\n{antraEil}\n{pirmaEil}");

            /*

            Console.Write($"\n------------------------------------------------------------------------");

            Console.Write($"\n{penktaEil}");
            Console.Write($"\n{ketvirtaEil}");
            Console.Write($"\n{treciaEil}");
            Console.Write($"\n{antraEil}");
            Console.Write($"\n{pirmaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            penktaEil = "\t####|####\t\t    ####|####\t\t    ####|####";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{penktaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            penktaEil = "\t####|####\t\t     ###|###\t\t      ##|##   ";
            ketvirtaEil = "\t    |    \t\t        |   \t\t       #|#   ";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{ketvirtaEil}");
            Console.Write($"\n{penktaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            penktaEil = "\t####|####\t\t     ###|###\t\t      ##|##   ";
            ketvirtaEil = "\t   #|#   \t\t        |   \t\t       #|#   ";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{ketvirtaEil}");
            Console.Write($"\n{penktaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            penktaEil = "\t####|####\t\t      ##|## \t\t      ##|##   ";
            ketvirtaEil = "\t   #|#   \t\t      ##|## \t\t       #|#   ";
            pirmaEil = "\t    |    \t\t      ##|## \t\t        |    ";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{ketvirtaEil}");
            Console.Write($"\n{penktaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            pirmaEil = "\t    |\t\t\t        |\t\t\t|";
            antraEil = "\t    |\t\t\t        |\t\t       #|#";
            treciaEil = "\t    |\t\t\t        |\t\t      ##|##";
            ketvirtaEil = "\t    |\t\t\t        |\t\t     ###|###";
            penktaEil = "\t    |\t\t\t        |\t\t    ####|####";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{antraEil}");
            Console.Write($"\n{treciaEil}");
            Console.Write($"\n{ketvirtaEil}");
            Console.Write($"\n{penktaEil}");

            Console.Write($"\n------------------------------------------------------------------------");

            pirmaEil = "\t    |\t\t\t        |\t\t\t|";
            antraEil = "\t    |\t\t\t        |\t\t       #|#";
            treciaEil = "\t    |\t\t\t        |\t\t      ##|##";
            ketvirtaEil = "\t    |\t\t\t        |\t\t     ###|###";
            penktaEil = "\t    |\t\t\t        |\t\t    ####|####";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{antraEil}".Replace("#", "\""));
            Console.Write($"\n{treciaEil}".Replace("#", "\""));
            Console.Write($"\n{ketvirtaEil}".Replace("#", "\""));
            Console.Write($"\n{penktaEil}".Replace("#", "\""));

            Console.Write($"\n------------------------------------------------------------------------");
            //paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę.Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("\nĮveskite nuo vieno iki keturių #:");
            string ivedimas = Console.ReadLine();
            //Console.WriteLine(ivedimas);

            pirmaEil = $"\t    {ivedimas}|{ivedimas}\t\t\t        |\t\t\t|";
            antraEil = "\t    |\t\t\t        |\t\t       #|#";
            treciaEil = "\t    |\t\t\t        |\t\t      ##|##";
            ketvirtaEil = "\t    |\t\t\t        |\t\t     ###|###";
            penktaEil = "\t    |\t\t\t        |\t\t    ####|####";
            Console.Write($"\n{pirmaEil}");
            Console.Write($"\n{antraEil}".Replace("#", "\""));
            Console.Write($"\n{treciaEil}".Replace("#", "\""));
            Console.Write($"\n{ketvirtaEil}".Replace("#", "\""));
            Console.Write($"\n{penktaEil}".Replace("#", "\""));
            */
        }
    }
}