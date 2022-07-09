namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var normalizuotasTxt = Normalizuoja(txt);

            Console.WriteLine($"DNR grandinė {txt}");
            Console.WriteLine("Pasirinkite veiksmą:");
            Console.WriteLine("1. Atlikti DNR grandinės normalizavimą");
            Console.WriteLine("2. Atlikti DNR grandinės validavimą");
            Console.WriteLine("3. Atlikti veiksmus su DNR grandine");

            //Console.WriteLine(normalizuotasTxt);
            //KeiciaGCTiAGG(normalizuotasTxt);

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(Normalizuoja(txt));
                    break;
                case "2":
                    if (Validuoja(txt))
                    {
                        Console.WriteLine("DNR grandinė yra validi");
                    }

                    else
                    {
                        Console.WriteLine("DNR grandinė yra nevalidi");
                    }
                    break;
                case "3":
                    if (Validuoja(txt) && !(Normalizuoja(txt) == txt))
                    {
                        IskvieciaSubMenu1(txt);
                    }
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1, 2 arba 3");
                    break;
            }
        }

        public static string PasalinaTarpus(string txt)
        {
            return txt.Replace(" ", "");
        }

        public static string KeiciaIDidziasias(string txt)
        {
            return txt.ToUpper();
        }

        public static string Normalizuoja(string txt)
        {
            string normalizuotasTxt = PasalinaTarpus(KeiciaIDidziasias(txt));

            return normalizuotasTxt;
        }

        public static bool Validuoja(string txt)
        {
            var txtTuscias = Normalizuoja(txt).Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Replace("-", "");
            if (txtTuscias.Length == 0)
            {
                return true;

            }

            else
            {
                return false;
            }
        }

        public static void IskvieciaSubMenu1(string txt)
        {
            Console.WriteLine("DNR grandinė yra validi, tačiau nenormalizuota");
            Console.WriteLine("Pasirinkite veiksmą:");
            Console.WriteLine("1. Normalizuoti DNR grandinę");
            Console.WriteLine("2. Išeiti iš programos");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(Normalizuoja(txt));
                    IskvieciaSubMenu2(txt);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1 arba 2");
                    break;
            }
        }

        public static void IskvieciaSubMenu2(string normalizuotasTxt)
        {
            Console.WriteLine("DNR grandinė yra normalizuota arba buvo atlikta normalizacija");
            Console.WriteLine("Pasirinkite veiksmą:");
            Console.WriteLine("1. Pakeisti GCT į AGG");
            Console.WriteLine("2. Išvesti ar yra tekste CAT");
            Console.WriteLine("3. Išvesti trečią ir penktą grandinės segmentus");
            Console.WriteLine("4. Išvesti raidžių kiekį tekste");
            Console.WriteLine("5. Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas");
            Console.WriteLine("6. Prie grandinės galo pridėti iš klaviatūros įvestą segmentą");
            Console.WriteLine("7. Iš grandinės pašalinti pasirinką elementą");
            Console.WriteLine("8. Pakeisti pasirinktą segmentą įvestu iš klaviatūros");
            Console.WriteLine("9. Grįžti į ankstesnį meniu");

            
            switch (Console.ReadLine())
            {
                case "1":
                    KeiciaGCTiAGG(normalizuotasTxt);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1 arba 2");
                    break;
            }
        }

        public static void KeiciaGCTiAGG(string normalizuotasTxt)
        {
            Console.WriteLine(normalizuotasTxt.Replace("GCT", "AGG"));
        }
    }
}