namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
            - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
            - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
            - Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
            - Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
            - Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
            - Nupieškite termometrą pagal Celsijų 
            a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
            (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
            b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
            <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
            if naudoti negalima, ternary operator (?) naudoti negalima.
            rezultatas gali atrodyti taip:
                            |--------------------|
                            |   ^F     _    ^C   |
                            |  104  - | | -  40  |
                            |   95  - | | -  35  |
                            |   86  - | | -  30  |
                            |   77  - | | -  25  |
                            |   68  - | | -  20  |
                            |   59  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   41  - |#| -   5  |
                            |   32  - |#| -   0  |
                            |   23  - |#| -  -5  |
                            |   14  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |   -4  - |#| - -20  |
                            |  -10  - |#| - -25  |
                            |  -20  - |#| - -30  |
                            |  -30  - |#| - -35  |
                            |  -40  - |#| - -40  |
                            |        '***`       |
                            |       (*****)      |
                            |        `---'       |
                            |____________________|
            */

            Console.WriteLine("Įveskite temperatūrą pagal Celsijų:");
            var tempC = double.Parse(Console.ReadLine());
            var tempF = tempC * 1.8 + 32;
            var tempK = tempC + 273.15;

            Console.WriteLine($"Temperatūra pagal Farenheitą: {tempF}");

            Console.WriteLine($"Temperatūra pagal Kelviną: {tempK}");

            var tempCPerskaiciuotaIsF = (tempF - 32) / 1.8;
            //Console.WriteLine(tempFPerskaiciuota);
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Farenheitą sutampa su įvestu skaičiu? {tempCPerskaiciuotaIsF == tempC}");

            var tempCPerskaiciuotaIsK = tempK - 273.15;
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Celcijų sutampa su įvestu skaičiu? {tempCPerskaiciuotaIsK == tempC}");

            var tempKPerskaiciuotaIsF = (tempF - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Kelviną sutampa su ankstesniu skaičiavimu? {tempKPerskaiciuotaIsF == tempK}");

            var skaleMax = tempC + 40;
            var skaleMin = tempC - 40;

            Console.WriteLine("|--------------------|");
            Console.WriteLine("|   ^F     _    ^C   |");

            for (var i = skaleMax; i > tempC; i = i - 5)
            {
                Console.WriteLine(String.Format("| {0, 4}  - | | - {1, 3}  |", i * 1.8 + 32, i));
            }

            for (var i = tempC; i >= skaleMin; i = i - 5)
            {
                Console.WriteLine(String.Format("| {0, 4}  - |#| - {1, 3}  |", i * 1.8 + 32, i));
            }

            Console.WriteLine("|        '***`       |");
            Console.WriteLine("|       (*****)      |");
            Console.WriteLine("|        `---'       |");
            Console.WriteLine("|____________________|");
        }
    }
}