namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {

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

        public static bool TikrinaArIvestasSkaicius(string skaicius1, string skaicius2)
        {
            if (int.TryParse(skaicius1, out _) && int.TryParse(skaicius2, out _))
            {
                return true;
            }
            else
                return false;
        }
        /*
        public static double PakeliaSkaiciuLaipsniu(int skaicius, int laipsnis)
        {

        }

        public static double IstraukiaSkaiciausSakni(int skaicius, int laipsnis)
        {

        }*/
    }
}