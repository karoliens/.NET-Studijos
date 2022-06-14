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
                            |  100  - | | -  40  |
                            |   95  - | | -  35  |
                            |   90  - | | -  30  |
                            |   80  - | | -  25  |
                            |   70  - | | -  20  |
                            |   60  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   40  - |#| -   5  |
                            |   30  - |#| -   0  |
                            |   20  - |#| -  -5  |
                            |   10  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |    0  - |#| - -20  |
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

            Console.WriteLine(skaleMin);
            Console.WriteLine(skaleMax);

            Console.WriteLine("|--------------------|");
            Console.WriteLine("|   ^F     _    ^C   |");
            Console.WriteLine($" {skaleMax}");
            Console.WriteLine($" {skaleMax - 5}");
            Console.WriteLine($" {skaleMax - 10}");
            Console.WriteLine($" {skaleMax - 15}");
            Console.WriteLine($" {skaleMax - 20}");
            Console.WriteLine($" {skaleMax - 25}");
            Console.WriteLine($" {skaleMax - 30}");
            Console.WriteLine($" {skaleMax - 35}");
            Console.WriteLine($" {skaleMax - 40}");
            Console.WriteLine($" {skaleMax - 45}");
            Console.WriteLine($" {skaleMax - 50}");
            Console.WriteLine($" {skaleMax - 55}");
            Console.WriteLine($" {skaleMax - 60}");
            Console.WriteLine($" {skaleMax - 65}");
            Console.WriteLine($" {skaleMax - 70}");
            Console.WriteLine($" {skaleMax - 75}");
            Console.WriteLine($" {skaleMax - 80}");
            Console.WriteLine($" {skaleMin}");

        }
    }
}