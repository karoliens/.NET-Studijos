namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace Zaidimas
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string pirmaEil = "\t    |\t\t\t        |\t\t\t|";
                string antraEil = "\t   #|#\t\t\t        |\t\t\t|";
                string treciaEil = "\t  ##|##\t\t\t        |\t\t\t|";
                string ketvirtaEil = "\t ###|###\t\t\t|\t\t\t|";
                string penktaEil = "\t####|####\t\t\t|\t\t\t|";
                Console.Write($"{pirmaEil}");
                Console.Write($"\n{antraEil}");
                Console.Write($"\n{treciaEil}");
                Console.Write($"\n{ketvirtaEil}");
                Console.Write($"\n{penktaEil}");

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


            }
        }
    }
}
    }
}