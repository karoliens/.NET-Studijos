using System.Text;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            Console.WriteLine("Pasirinkite temą:");
            Console.WriteLine("1. VARDAI");
            Console.WriteLine("2. LIETUVOS MIESTAI");
            Console.WriteLine("3. VALSTYBĖS");
            Console.WriteLine("4. KITA");

            bool zaidimasTesiasi = true;
            
            while(zaidimasTesiasi)
            {
                var menuPasirinkimas = Console.ReadLine();
                var atsitiktinisZodis = ParenkaAtsitiktiniElementa(ParenkaSarasa(menuPasirinkimas));
                var rodymas = PakeiciaIBruksnelius(atsitiktinisZodis);
                List<char> neatspetosRaides = new List<char>();
                var gyvybes = 7;

                Console.Clear();
                Console.WriteLine(SpausdinaMenu(menuPasirinkimas));
                Console.WriteLine(SpausdinaPiesini(gyvybes));
                Console.WriteLine($"\nŽodis: {string.Join(" ", rodymas)}");
                Console.WriteLine("\nSpėkite raidę ar žodį:");

                while (zaidimasTesiasi)
                {
                    var spejimas = Console.ReadLine().ToLower();

                    if (ArChar(spejimas))
                    {
                        if (ArRaideYraZodyje(atsitiktinisZodis, char.Parse(spejimas)))
                        {
                            Console.Clear();
                            Console.WriteLine(SpausdinaMenu(menuPasirinkimas));
                            Console.WriteLine(SpausdinaPiesini(gyvybes));
                            Console.WriteLine($"\nŽodis: {string.Join(" ", rodymas)}");
                            Console.WriteLine("\nSpėkite raidę ar žodį:");
                        }

                        else if (spejimas != atsitiktinisZodis && spejimas.Length > 1)
                        {
                            Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {atsitiktinisZodis}\nPakartoti žaidimą T / N ? ");
                        }

                        else if (!atsitiktinisZodis.Contains(spejimas))
                        {
                            Console.Clear();
                            Console.WriteLine(SpausdinaMenu(menuPasirinkimas));

                            gyvybes--;
                            neatspetosRaides.Add(char.Parse(spejimas));

                            if (gyvybes == 0)
                            {
                                Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {atsitiktinisZodis}\nPakartoti žaidimą T / N ? ");
                            }

                            Console.WriteLine($"{SpausdinaPiesini(gyvybes)}");
                            Console.WriteLine($"\nSpėtos raidės: {string.Join(", ", neatspetosRaides)}");
                            Console.WriteLine($"\nŽodis: {string.Join(" ", rodymas)}");
                        }
                    }

                    else if (ArChar(spejimas) == false)
                    {
                        if (spejimas == atsitiktinisZodis)
                        {
                            Console.WriteLine(" !!! SVEIKINIMAI !!!");
                        }

                        else if (spejimas != atsitiktinisZodis)
                        {
                            Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {atsitiktinisZodis}\nPakartoti žaidimą T / N ? ");
                        }
                    }
                }
            }
        }

        public static string ParenkaAtsitiktiniElementa(string[] sarasas)
        {
            Random random = new Random();

            int atsitiktinisElementas = random.Next(sarasas.Length);

            return sarasas[atsitiktinisElementas];
        }

        public static char[] PakeiciaIBruksnelius(string zodis)
        {
            char[] pakeistasZodis =  new char [zodis.Length];

            for (int i = 0; i < zodis.Length; i++)
            {
                pakeistasZodis[i] = ('_');
            }

            return pakeistasZodis;
        }

        public static string SpausdinaPiesini(int gyvybiuSkaicius)
        {
            string[] piesiniai = { @"   - - - - - - |   
|              o 
|             \|/  
|              0  
|             / \ 
|                  
|                  
|                  
_ _ _ _", @"   - - - - - - |   
|              o
|             \|/
|              0
|             /  
|
|
|
_ _ _ _", @"   - - - - - - |   
|              o
|             \|/
|              0
|               
|
|
|
_ _ _ _", @"   - - - - - - |   
|              o
|             \|/
|              
|               
|
|
|
_ _ _ _", @"   - - - - - - |   
|              o
|             \|
|              
|               
|
|
|
_ _ _ _", @"   - - - - - - |   
|              o
|              |
|              
|               
|
|
|
_ _ _ _", @"   - - - - - - |   
|              o
|              
|              
|               
|
|
|
_ _ _ _", @"   - - - - - - |   
|              
|              
|              
|               
|
|
|
_ _ _ _" };

            for (int i = 0; i < piesiniai.Length; i++)
            {
                if (i == gyvybiuSkaicius)
                {
                    return piesiniai[i];
                }
            }

            return null;
        }

        public static string[] PanaikinaZodiIsSaraso(string zodis, string[] sarasas)
        {
            var zodzioIndeksas = Array.IndexOf(sarasas, zodis);

            List<string> laikinas = new List<string>(sarasas);
            laikinas.RemoveAt(zodzioIndeksas);
            sarasas = laikinas.ToArray();

            return sarasas;
        }

        public static char SpausdinaSpetasRaides(string zodis, char raide)
        {
            char spetaRaide = ' ';

            if (zodis.Contains(raide))
            {
                spetaRaide = ' ';
            }

            else
            {
                spetaRaide = raide;
            }
            return spetaRaide;
        }

        public static bool ArRaideYraZodyje(string zodis, char raide)
        {
            if (zodis.Contains(raide))
            {
                return true;
            }

            return false;
        }

        public static string SpausdinaMenu(string pasirinkimas)
        {
            if (pasirinkimas == "1")
            {
                return " TEMA: VARDAI";
            }

            else if (pasirinkimas == "2")
            {
                return " TEMA: LIETUVOS MIESTAI";
            }

            else if (pasirinkimas == "3")
            {
                return " TEMA: VALSTYBĖS";
            }

            else if (pasirinkimas == "4")
            {
                return " TEMA: KITA";
            }

            else
            {
                return $"{pasirinkimas} temos nėra, bandykite iš naujo";
            }

            return null;
        }

        public static string[] ParenkaSarasa(string pasirinkimas)
        {
            string[] vardai = { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };
            string[] lietuvosMiestai = { "Šiauliai", "Vilnius", "Klaipėda", "Kaunas", "Mažeikiai", "Marijampolė", "Utena", "Joniškis", "Kelmė", "Pakruojis" };
            string[] valstybes = { "Lietuva", "Vokietija", "Danija", "Latvija", "Norvegija", "Švedija", "Estija", "Lenkija", "Italija", "Portugalija" };
            string[] kita = { "Šuo", "Katė", "Televizorius", "Langas", "Durys", "Šaldytuvas", "Automobilis", "Laikrodis", "Namas", "Garažas" };

            if (pasirinkimas == "1")
            {
                return vardai;
            }

            else if (pasirinkimas == "2")
            {
                return lietuvosMiestai;
            }

            else if (pasirinkimas == "3")
            {
                return valstybes;
            }

            else if (pasirinkimas == "4")
            {
                return kita;
            }

            return null;
        }

        public static bool ArChar(string ivedimas)
        {
            if (ivedimas.Length == 1)
            {
                return true;
            }

            else if (ivedimas.Length > 1)
            {
                return false;
            }

            else
            {
                return ivedimas == null;
            }
        }
        
        public static bool ArSkaicius(string ivedimas)
        {
            if (int.TryParse(ivedimas, out _))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}