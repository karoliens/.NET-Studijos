using System.Text;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            while (true)
            {
                var menuPasirinkimas = GautiMenuPasirinkima();
                var parinktasSarasas = ParenkaSarasa(menuPasirinkimas);
                var atsitiktinisZodis = ParenkaAtsitiktiniElementa(parinktasSarasas);

                PanaikinaZodiIsSaraso(atsitiktinisZodis, parinktasSarasas);
                Zaisti(atsitiktinisZodis, menuPasirinkimas);

                // Galimas naujo žaidimo pradžios scenarijus.

                Console.WriteLine("Pakartoti žaidimą T / N ? ");
                var ivestis = Console.ReadLine().ToLower();

                if (ivestis != "t")
                {
                    break;
                }
            }
        }

        public static string ParenkaAtsitiktiniElementa(string[] sarasas)
        {
            Random random = new Random();

            if (sarasas == null)
            {
                return "Neiteisinga";
            }

            else
            {
                return sarasas[random.Next(sarasas.Length)];
            }
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

        public static bool ArRaideYraZodyje(string zodis, char raide) => zodis.Contains(raide);

        public static void SpausdinaPasirinktaTema(string pasirinkimas)
        {
            if (pasirinkimas == "1")
            {
                Console.WriteLine(" TEMA: VARDAI");
            }

            else if (pasirinkimas == "2")
            {
                Console.WriteLine(" TEMA: LIETUVOS MIESTAI");
            }

            else if (pasirinkimas == "3")
            {
                Console.WriteLine(" TEMA: VALSTYBĖS");
            }

            else if (pasirinkimas == "4")
            {
                Console.WriteLine(" TEMA: KITA");
            }
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

        public static List<char> AtverciaRaides(string zodis, List<char> raides )
        {
            var zodisBruksneliai = new List<char>();

            foreach (char raide in zodis)
            {
                if (raides.Contains(raide))
                {
                    zodisBruksneliai.Add(raide);
                }

                else
                {
                    zodisBruksneliai.Add('_');
                }
            }

            return zodisBruksneliai;
        }

        public static bool ArTeisingasMenuPasirinkimas(string pasirinkimas)
        {
            if (int.TryParse(pasirinkimas, out _) && (int.Parse(pasirinkimas) > 0 && (int.Parse(pasirinkimas) < 5)))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static string GautiMenuPasirinkima()
        {
            Console.Clear();
            Console.WriteLine("Pasirinkite temą:");
            Console.WriteLine("1. VARDAI");
            Console.WriteLine("2. LIETUVOS MIESTAI");
            Console.WriteLine("3. VALSTYBĖS");
            Console.WriteLine("4. KITA");

            var menuPasirinkimas = Console.ReadLine();

            while (true)
            {
                if (ArTeisingasMenuPasirinkimas(menuPasirinkimas))
                {
                    break;
                }

                else
                {
                    Console.WriteLine($"{menuPasirinkimas} temos nėra, bandykite iš naujo");
                    menuPasirinkimas = Console.ReadLine();
                }
            }

            return menuPasirinkimas;
        }

        public static string GautiSpejima()
        {
            Console.WriteLine("Spėkite raidę ar žodį:");

            var spejimas = Console.ReadLine();

            while (true)
            {
                if (ArSpejimasValidus(spejimas))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Įveskite raidę ar žodį:");
                    spejimas = Console.ReadLine();
                }
            }

            return spejimas;
        }

        // Tikrina įvestą spėjamą raidę. Negalimas ne raidžių bei nieko įvedimas.

        public static bool ArSpejimasValidus(string spejimas)
        {
            if (spejimas.Length == 0)
            {
                return false;
            }

            else if (spejimas.Length == 1)
            {
                return Char.IsLetter(spejimas, 0);
            }

            return true;
        }

        public static bool ArChar(string? ivedimas)
        {
            if (ivedimas != null && ivedimas.Length == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void Zaisti(string atsitiktinisZodis, string menuPasirinkimas)
        {
            List<char> neatspetosRaides = new List<char>();
            List<char> atspetosRaides = new List<char>();
            var gyvybes = 7;
            var zaidimasTesiasi = true;

            while (true)
            {
                var rodymas = AtverciaRaides(atsitiktinisZodis.ToLower(), atspetosRaides);

                Console.Clear();
                SpausdinaPasirinktaTema(menuPasirinkimas);
                Console.WriteLine($"{SpausdinaPiesini(gyvybes)}\n");
                Console.WriteLine($"Spėtos raidės: {string.Join(", ", neatspetosRaides)}");
                Console.WriteLine($"Žodis: {string.Join(" ", rodymas)}\n");

                // Žaidimo pabaigos scenarijus.

                if (!zaidimasTesiasi)
                {
                    if (gyvybes == 0)
                    {
                        Console.WriteLine("PRALAIMĖJOTE");
                        Console.WriteLine($"Žodis buvo: {atsitiktinisZodis}\n");
                    }

                    else
                    {
                        Console.WriteLine("!!! LIMĖJOTE !!!");
                    }

                    return;
                }

                var spejimas = GautiSpejima().ToLower();
               
                if (ArChar(spejimas))
                {
                    // Jei geras raidės spėjimas, ją įdeda į atspetosRaides List.

                    if (ArRaideYraZodyje(atsitiktinisZodis.ToLower(), char.Parse(spejimas)))
                    {
                        atspetosRaides.Add(char.Parse(spejimas));

                        if (atspetosRaides.ToString().ToLower() == atsitiktinisZodis)
                        {
                            Console.WriteLine("!!! LIMĖJOTE !!!");
                        }
                    }

                    // Jei blogas raidės spėjimas, sumažinamas gyvybių skaičius ir raidė įdedama į neatspetosRaides List.

                    else
                    {
                        if (!neatspetosRaides.Contains(char.Parse(spejimas)))
                        {
                            gyvybes--;
                            neatspetosRaides.Add(char.Parse(spejimas));
                        }

                        if (gyvybes == 0)
                        {
                            zaidimasTesiasi = false;
                        }
                    }
                }

                // Jei spėjimas nėra validus t.y. daugiau negu vienas char tikrinama ar įvestas string sutampa su atsitiktiniu žodžiu.

                else
                {
                    if (spejimas == atsitiktinisZodis.ToLower())
                    {
                        zaidimasTesiasi = false;
                    }

                    else
                    {
                        zaidimasTesiasi = false;
                        gyvybes = 0;
                    }
                }
            }
        }
    }
}