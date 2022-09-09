namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 1: Sarase “List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }” isfiltruokite skaicius, kurie butu didesni arba lygus 35, bet mazesni arba lygus 99. Istestuokite.

            Uzduotis 2:Parasykite programa, kuri is spalvu saraso “List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", “Magenta”, “Tomato”, “Cyan” }” istrauktu spalvas, kuriu ilgis yra didesnis 4 raides, projekcijos pagalba padarykite, kad visus rezultatus grazintu didziosiomis raidemis. Istestuokite.

            Uzduotis 3:Parasykite programa, kuri is zodziu kratinio “List<string> {“dangus”, “afro”, “vanduo”, “darzelis”, “darzove”, “kremas”, “valdiklis”,”daumantas”, “mokinys”, “pazymys”,”danguole”} isvestu I ekrana zodzius, kurie prasideda raide “d” ir baigiasi raide “s”. Istestuokite.

            Uzduotis 4:     *  Naudojant CharacterInitialData užpildyti žmonių(Human) sąrašą.            - Žmonių sąrašui užpildyti implementuokite interfeisą IHumanFactory su metodu Bind()                 Metodas Bind() iškoduoja DataSeed ir grąžina reikiamą objektą            - Užpildytą sąrašą išvesti į konsolę
            */

            List<string> colours = new List<string>() { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };

            List<int> numbers = new List<int>(){ 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 };

            List<string> randomWords = new List<string>() { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };

        }

        public static List<int> FilterNumbers(List<int> list)
        {
            list = list

                .Where(x => x >= 35 && x <= 99).ToList();

            return list;
        }

        public static List<string> FilterColours(List<string> list)
        {
            list = list
                .Where(x => x.Length > 4)
                .Select(x => x.ToUpper())
                .ToList();

            return list.ToList();
        }

        public static List<string> FilterStrings(List<string> list)
        {
            list = list
                .Where((x) => x.StartsWith("d"))
                .Where((x) => x.EndsWith("s"))
                .ToList();

            return list.ToList();
        }
    }
}