namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
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

                Console.Clear();
                Console.WriteLine(SpausdinaMenu(menuPasirinkimas));
                Console.WriteLine(SpausdinaPiesini(7));
                Console.WriteLine($"\nŽodis: {string.Join(" ", rodymas)}");
                Console.WriteLine("\nSpėkite raidę ar žodį:");

                while (zaidimasTesiasi)
                {
                    var spejimas = Console.ReadLine().ToLower();
                    var gyvybes = 7;

                    if (spejimas == atsitiktinisZodis)
                    {
                        Console.WriteLine(" !!! SVEIKINIMAI !!!");
                    }

                    else if (spejimas != atsitiktinisZodis && spejimas.Length > 1)
                    {
                        Console.WriteLine($":( PALAIMEJOTE :(\nZodis buvo: {atsitiktinisZodis}\nPakartoti zaidima T / N ? ");
                        // zaidimasTesiasi = false;
                    }

                    else if (spejimas != atsitiktinisZodis)
                    {
                        char spetosRaides;
                        gyvybes = gyvybes - 1;
                        spetosRaides = SpausdinaSpetasRaides(atsitiktinisZodis, char.Parse(spejimas));

                        Console.WriteLine($"{SpausdinaPiesini(gyvybes)}");
                        Console.WriteLine($"\nSpėtos raidės: {spetosRaides}");
                        Console.WriteLine($"\nŽodis: {string.Join(" ", rodymas)}");
                    }

                    else if (TikrinaArRaideYraZodyje(atsitiktinisZodis, char.Parse(spejimas)))
                    {
                        Console.WriteLine(SpausdinaPiesini(7));
                        // Console.WriteLine($"Žodis: {string.Join(" ", rodymas)}");
                        Console.WriteLine("Spėkite raidę ar žodį:");
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

        public static bool TikrinaArRaideYraZodyje(string zodis, char raide)
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
    }
}