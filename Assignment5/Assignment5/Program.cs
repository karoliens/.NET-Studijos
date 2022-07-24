namespace Assignment5
{
    public class Program
    {
        static double? rezultatas = null;

        static void Main(string[] args)
        {
            PagrindinioMenuIskvietimas();
        }
        
        public static void PagrindinioMenuIskvietimas()
        {
            Console.WriteLine(@"
1. Nauja operacija 
2. Išeiti");

            switch (Console.ReadLine())
            {
                case "1":
                    SubMenu1Iskvietimas();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1 arba 2");
                    break;
            }
        }

        public static void SubMenu1Iskvietimas()
        {
            Console.WriteLine(@"
1. Sudėtis
2. Atimtis
3. Daugyba
4. Dalyba");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Įveskite pirmą skaičių");
                    var ivestasSkaicius1 = Console.ReadLine();

                    while (TikrinaArIvestasSkaicius(ivestasSkaicius1) == false)
                    {
                        Console.WriteLine("Ne skaičius");
                    }


                    Console.WriteLine("Įveskite antrą skaičių");
                    var ivestasSkaicius2 = Console.ReadLine();
                    // else if ()
                    Console.WriteLine("Įveskite antrą skaičių");
                    // var ivestasSkaicius2 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius2);
                    Console.WriteLine($"Rezultatas: {SudedaSkaicius(int.Parse(ivestasSkaicius1), int.Parse(ivestasSkaicius2))}");
                    SubMenu2Iskvietimas();
                    break;
                case "2":
                    Console.WriteLine("Įveskite pirmą skaičių");
                    ivestasSkaicius1 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius1);
                    Console.WriteLine("Įveskite antrą skaičių");
                    ivestasSkaicius2 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius2);
                    Console.WriteLine($"Rezultatas: {AtimaSkaicius(int.Parse(ivestasSkaicius1), int.Parse(ivestasSkaicius2))}");
                    SubMenu2Iskvietimas();
                    break;
                case "3":
                    Console.WriteLine("Įveskite pirmą skaičių");
                    ivestasSkaicius1 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius1);
                    Console.WriteLine("Įveskite antrą skaičių");
                    ivestasSkaicius2 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius2);
                    Console.WriteLine($"Rezultatas: {DauginaSkaicius(int.Parse(ivestasSkaicius1), int.Parse(ivestasSkaicius2))}");
                    SubMenu2Iskvietimas();
                    break;
                case "4":
                    Console.WriteLine("Įveskite pirmą skaičių");
                    ivestasSkaicius1 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius1);
                    Console.WriteLine("Įveskite antrą skaičių");
                    ivestasSkaicius2 = Console.ReadLine();
                    TikrinaArIvestasSkaicius(ivestasSkaicius2);
                    Console.WriteLine($"Rezultatas: {DalinaSkaicius(int.Parse(ivestasSkaicius1), int.Parse(ivestasSkaicius2))}");
                    SubMenu2Iskvietimas();
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1, 2, 3 arba 4");
                    break;
            }
        }

        public static void SubMenu2Iskvietimas()
        {
            Console.WriteLine(@"1. Nauja operacija 2. Tęsti su rezultatu 3. Išeiti");

            switch (Console.ReadLine())
            {
                case "1":
                SubMenu1Iskvietimas();
                break;
                case "2":
                SubMenu1Iskvietimas();
                break;
                case "3":
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Neteisingai pasirinkta");
                break;
            }
        }

        public static double SudedaSkaicius(int skaicius1, int skaicius2)
        {
            int suma = skaicius1 + skaicius2;

            return suma;
        }

        public static double AtimaSkaicius(int skaicius1, int skaicius2)
        {
            int atimtis = skaicius1 - skaicius2;

            return atimtis;
        }

        public static double DauginaSkaicius(int skaicius1, int skaicius2)
        {
            int daugyba = skaicius1 * skaicius2;

            return daugyba;
        }

        public static double DalinaSkaicius(int skaicius1, int skaicius2)
        {
            double dalyba = (double)skaicius1 / skaicius2;

            return dalyba;
        }

        public static string TikrinaArDalinamaIsNulio(int skaicius)
        {
            if (skaicius == 0)
            {
                return "Dalyba iš 0 negalima";
            }

            else
            {
                return null;
            } 
        }

        public static bool TikrinaArIvestasSkaicius(string skaicius)
        {
            if (int.TryParse(skaicius, out _))
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        
        public static double PakeliaSkaiciuLaipsniu(int skaicius, int laipsnis)
        {
            int rezultatas = 0;

            if (skaicius == 0 && laipsnis > 0)
            {
                rezultatas = 0;
            }
            
            else if ((skaicius < 0 || skaicius > 0) && laipsnis == 1)
            {
                rezultatas = skaicius;
            }

            else if ((skaicius < 0 || skaicius > 0) && laipsnis == 0)
            {
                rezultatas = 1;
            }

            else
            {
                rezultatas = 1;
                for (int i = 0; i < laipsnis; i++)
                {
                    rezultatas = rezultatas * skaicius;
                }
            }
            return rezultatas;
        }

        /*
        public static double IstraukiaSkaiciausSakni(int skaicius, int laipsnis)
        {

        }
        */

        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            //todo
        }

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            //todo
            rezultatas = null;
        }
    }
}