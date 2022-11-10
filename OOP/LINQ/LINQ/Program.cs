namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 1: Sarase “List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }” isfiltruokite skaicius, kurie butu didesni arba lygus 35, bet mazesni arba lygus 99. Istestuokite.

            Uzduotis 2:Parasykite programa, kuri is spalvu saraso “List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", “Magenta”, “Tomato”, “Cyan” }” istrauktu spalvas, kuriu ilgis yra didesnis 4 raides, projekcijos pagalba padarykite, kad visus rezultatus grazintu didziosiomis raidemis. Istestuokite.

            Uzduotis 3:Parasykite programa, kuri is zodziu kratinio “List<string> {“dangus”, “afro”, “vanduo”, “darzelis”, “darzove”, “kremas”, “valdiklis”,”daumantas”, “mokinys”, “pazymys”,”danguole”} isvestu I ekrana zodzius, kurie prasideda raide “d” ir baigiasi raide “s”. Istestuokite.

            Uzduotis 4:     *  Naudojant CharacterInitialData užpildyti žmonių(Human) sąrašą.            - Žmonių sąrašui užpildyti implementuokite interfeisą IHumanFactory su metodu Bind()                 Metodas Bind() iškoduoja DataSeed ir grąžina reikiamą objektą            - Užpildytą sąrašą išvesti į konsolę

            1 UZDUOTIS 
            turime masyvą 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            Parašykite užklausą, kuri grąžins lyginius skaičius

            turime masyvą 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            Parašykite užklausą, kuri grąžins teigiamus skaičius

            [9:56 PM] Robertas Ūselis
            3 UZDUOTIS
            turime masyvą 3, 9, 2, 8, 6, 5
            Parašykite užklausą, kuri grąžins kiekvieno skaičiaus kvadratą

            4 UZDUOTIS
            turime masyvą 3, 9, 2, 8, 6, 5, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2
            parašykite metodą, kuris grąžins kiekvieno skaičiaus pasikartojimų kiekį

            5 UZDUOTIS 
            turime masyvą 3, 9, 2, 8, 6, 5, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2
            parašykite metodą, kuris grąžins skaičių sumą

            6 UZDUOTIS
            turime tekstą - "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ornare commodo elementum. Sed felis eros, bibendum a mattis finibus, vestibulum elementum lectus."
            parašykite metodą, kuris grąžins kiek kartų pasikartojo a 

            7 UZDUOTIS
            turime tekstą - "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ornare commodo elementum. Sed felis eros, bibendum a mattis finibus, vestibulum elementum lectus."
            parašykite metodą, kuris grąžins kiekvienos raidės pasikartojimų kiekį
            */

            List<string> colours = new List<string>() { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };

            List<int> numbers = new List<int>(){ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

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

        public static List<int> FilterEvenNumbers(List<int> list)
        {
            var evenNumbers = from e in list
                              where e % 2 == 0
                              select e;

            return evenNumbers.ToList();
        }
    }
}