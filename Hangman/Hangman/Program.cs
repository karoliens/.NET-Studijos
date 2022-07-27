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

            List<string> vardai = new List<string> { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };
            List<string> lietuvosMiestai = new List<string> { "Šiauliai", "Vilnius", "Klaipėda", "Kaunas", "Mažeikiai", "Marijampolė", "Utena", "Joniškis", "Kelmė", "Pakruojis" };
            List<string> valstybes = new List<string> { "Lietuva", "Vokietija", "Danija", "Latvija", "Norvegija", "Švedija", "Estija", "Lenkija", "Italija", "Portugalija" };
            List<string> kita = new List<string> { "Šuo", "Katė", "Televizorius", "Langas", "Durys", "Šaldytuvas", "Automobilis", "Laikrodis", "Namas", "Garažas" };
            /*
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

                    var gyvybes = 7;
                    // var ivestaRaideArZodis = Ivedimas();
                    /*
                    for (int i = 0; i < randomZodisArr.Length; i++)
                    {
                        
                        if (randomZodisArr[i] == char.Parse(ivestaRaideArZodis))
                            {
                                rodymas[i] = char.Parse(ivestaRaideArZodis);
                            }

                        if (randomZodisArr[i] != char.Parse(ivestaRaideArZodis))
                            {
                                Console.WriteLine("Tokios raidės nėra");
                                gyvybes -= 1;
                            }

                        zaidimasTesiasi = false;
                    }
                        // Console.WriteLine(piesiniai[gyvybes]);
                        Console.WriteLine(string.Join(" ", rodymas));
                    }
                    break;




                case "2":
                    Console.Clear();
                    Console.WriteLine(" TEMA: LIETUVOS MIESTAI");
                    Console.WriteLine(ParenkaAtsitiktiniElementa(lietuvosMiestai));
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
                    Console.WriteLine("temos nėra, bandykite iš naujo");
                    break;
            }*/
        }

        public static string ParenkaAtsitiktiniElementa(List<string> sarasas)
        {
            Random random = new Random();

            int atsitiktinisElementas = random.Next(sarasas.Count);

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

        public static string TikrinaMenuPasirinkima(string ivedimas)
        {
            if (ivedimas != "1" || ivedimas != "2" || ivedimas != "3" || ivedimas != "4")
            {
                return $"{ivedimas} temos nėra, bandykite iš naujo";
            }
            return null;
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

        public static List<string> PanaikinaZodiIsSaraso(string zodis, List<string> sarasas)
        {
            foreach (string elementas in sarasas)
            {
                if (elementas == zodis)
                {
                    sarasas.Remove(elementas);
                }
            }

            return sarasas;
        }
    }
}