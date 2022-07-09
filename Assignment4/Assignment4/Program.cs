namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

            Console.WriteLine($"DNR grandinė {txt}");
            Console.WriteLine("Pasirinkite veiksmą:");
            PagrindinioMenuSpausdinimas();
            PagrindinioMenuNavigacija(txt);
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
            return PasalinaTarpus(KeiciaIDidziasias(txt));
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

        public static void PagrindinioMenuSpausdinimas()
        {
            Console.WriteLine("1. Atlikti DNR grandinės normalizavimą");
            Console.WriteLine("2. Atlikti DNR grandinės validavimą");
            Console.WriteLine("3. Atlikti veiksmus su DNR grandine");
        }

        public static void PagrindinioMenuNavigacija(string txt)
        {
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
                        SubMenu1Spausdinimas();
                        SubMenu1Navigacija(txt);
                    }

                    else
                    {
                        Console.WriteLine("DNR grandinė nėra validi");
                    }
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1, 2 arba 3");
                    break;
            }
        }

        public static void SubMenu1Spausdinimas()
        {
            Console.WriteLine("DNR grandinė yra validi, tačiau nenormalizuota");
            Console.WriteLine("Pasirinkite veiksmą:");
            Console.WriteLine("1. Normalizuoti DNR grandinę");
            Console.WriteLine("2. Išeiti iš programos");
        }

        public static void SubMenu1Navigacija(string txt)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Normalizuoja(txt);
                    SubMenu2Spausdinimas();
                    SubMenu2Navigacija(txt);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pasirinkite 1 arba 2");
                    break;
            }
        }

        public static void SubMenu2Spausdinimas()
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
        }

        public static void SubMenu2Navigacija(string txt)
        {
            string ivestasSegmentas;
            string pasirinktasSegmentas;
            string keitimas;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {KeiciaGCTiAGG(txt)}");
                    break;
                case "2":
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {IeskoCAT(txt)}");
                    break;
                case "3":
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {IeskoTrecioIrPenktoSegmento(txt)}");
                    break;
                case "4":
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {IsvedaRaidziuKieki(txt)}");
                    break;
                case "5":
                    Console.WriteLine("Įveskite segmentą:");
                    ivestasSegmentas = Console.ReadLine();
                    Console.WriteLine(IeskoIvestoSegmento(txt, ivestasSegmentas));
                    break;
                case "6":
                    Console.WriteLine("Įveskite segmentą:");
                    ivestasSegmentas = Console.ReadLine();
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {PridedaIGala(txt, ivestasSegmentas)}");
                    break;
                case "7":
                    Console.WriteLine("Įveskite segmentą:");
                    ivestasSegmentas = Console.ReadLine();
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {PasalinaSegmenta(txt, ivestasSegmentas)}");
                    break;
                case "8":
                    Console.WriteLine("Pasirinkite segmentą, kurį norite pakeisti:");
                    pasirinktasSegmentas = Console.ReadLine();
                    Console.WriteLine("Pasirinkite segmentą:");
                    keitimas = Console.ReadLine();
                    Console.WriteLine($"Normalizuota grandinė: {Normalizuoja(txt)}");
                    Console.WriteLine($"Pakeista DNR grandinė: {PakeiciaSegmenta(txt, pasirinktasSegmentas, keitimas)}");
                    break;
                case "9":
                    SubMenu1Spausdinimas();
                    SubMenu1Navigacija(txt);
                    break;
                default:
                    Console.WriteLine("Pasirinkite nuo 1 iki 9");
                    break;
            }
        }

        public static string KeiciaGCTiAGG(string txt)
        {
            return Normalizuoja(txt).Replace("GCT", "AGG");
        }

        public static string IeskoCAT(string txt)
        {
            if (Normalizuoja(txt).Contains("CAT"))
            {
                return "Taip";
            }

            else
            {
                return "Ne";
            }
        }

        public static string IeskoTrecioIrPenktoSegmento(string txt)
        {
            var treciasSegmentas = Normalizuoja(txt).Replace("-", "").Substring(6, 3);
            var penktasSegmentas = Normalizuoja(txt).Replace("-", "").Substring(12, 3);

            return $"{treciasSegmentas} {penktasSegmentas}";         
        }

        public static int IsvedaRaidziuKieki(string txt)
        {
            return Normalizuoja(txt).Replace("-", "").Length;
        }

        public static string IeskoIvestoSegmento(string txt, string ivestasSegmentas)
        {
            if (Normalizuoja(txt).Contains(ivestasSegmentas.ToUpper()))
            {
                return "Įvestas segmentas yra DNR grandinėje";
            }

            else
            {
                return "Įvesto segmento nėra DNR grandinėje";
            }
        }

        public static string PridedaIGala(string txt, string ivestasSegmentas)
        {
            if (Validuoja(ivestasSegmentas) && ivestasSegmentas.Length == 3)
            {
                return $"{Normalizuoja(txt)}-{ivestasSegmentas.ToUpper()}";
            }

            else
            {
                return "Segmentą turi sudaryt trys raidės ir tik ATCG";
            }
        }

        public static string PasalinaSegmenta(string txt, string ivestasSegmentas)
        {
            return Normalizuoja(txt).Replace(ivestasSegmentas, "");
        }

        public static string PakeiciaSegmenta(string txt, string pasirinktasSegmentas, string keitimas)
        {
            if ((Validuoja(pasirinktasSegmentas) && pasirinktasSegmentas.Length == 3) && (Validuoja(keitimas) && keitimas.Length == 3))
            {
                return Normalizuoja(txt).Replace(pasirinktasSegmentas, keitimas);
            }

            else
            {
                return "Segmentą turi sudaryt trys raidės ir tik ATCG";
            }
        }
    }   
}