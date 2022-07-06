namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            //PasalinaTarpus(txt);
            //KeiciaIDidziasias(txt);
            Console.WriteLine(Validacija(txt));
        }

        public static void PasalinaTarpus(string txt)
        {
            Console.WriteLine(txt.Replace(" ", ""));
        }

        public static void KeiciaIDidziasias(string txt)
        {
            Console.WriteLine(txt.ToUpper());
        }

        public static string Validacija(string txt)
        {
            PasalinaTarpus(txt);
            
            txt = txt.Replace("a", "-", StringComparison.OrdinalIgnoreCase);
            txt = txt.Replace("t", "-", StringComparison.OrdinalIgnoreCase);
            txt = txt.Replace("c", "-", StringComparison.OrdinalIgnoreCase);
            txt = txt.Replace("g", "-", StringComparison.OrdinalIgnoreCase);
            txt = txt.Replace(" ", "-");

            return txt;
        }
    }
}