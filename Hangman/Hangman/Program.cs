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

            string[] vardai = { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };
            string[] lietuvosMiestai = { "Šiauliai", "Vilnius", "Klaipėda", "Kaunas", "Mažeikiai", "Marijampolė", "Utena", "Joniškis", "Kelmė", "Pakruojis" };
            string[] valstybes = { "Lietuva", "Vokietija", "Danija", "Latvija", "Norvegija", "Švedija", "Estija", "Lenkija", "Italija", "Portugalija" };
            string[] kita = { "Šuo", "Katė", "Televizorius", "Langas", "Durys", "Šaldytuvas", "Automobilis", "Laikrodis", "Namas", "Garažas" };
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(" \nTEMA: VARDAI");

                    var randomZodis = ParenkaAtsitiktiniElementa(vardai).ToLower();
                    var randomZodisArr = randomZodis.ToCharArray();
                    var rodymas = PakeiciaIBruksnelius(randomZodis);

                    Console.WriteLine($"Žodis: {string.Join(" ", rodymas)}");

                    bool zaidimasTesiasi = true;

                    while (zaidimasTesiasi == true)
                    {

                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(" TEMA: LIETUVOS MIESTAI");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(" TEMA: VALSTYBĖS");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(" TEMA: KITA");
                    break;
                default:
                    while (TikrinaArPasirinktasMenu(Console.ReadLine()))
                    {
                        Console.WriteLine("temos nėra, bandykite iš naujo");
                    }
                    break;
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

        public static bool TikrinaArPasirinktasMenu(string ivedimas)
        {
            if (ivedimas != "1" || ivedimas != "2" || ivedimas != "3" || ivedimas != "4")
            {
                return false;
            }
            return true;
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
    }
}