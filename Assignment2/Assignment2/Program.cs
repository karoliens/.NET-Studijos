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
            var tempC5 = skaleMax - 5;
            var tempC10 = skaleMax - 10;
            var tempC15 = skaleMax - 15;
            var tempC20 = skaleMax - 20;
            var tempC25 = skaleMax - 25;
            var tempC30 = skaleMax - 30;
            var tempC35 = skaleMax - 35;
            var tempC40 = skaleMax - 40;
            var tempC45 = skaleMax - 45;
            var tempC50 = skaleMax - 50;
            var tempC55 = skaleMax - 55;
            var tempC60 = skaleMax - 60;
            var tempC65 = skaleMax - 65;
            var tempC70 = skaleMax - 70;
            var tempC75 = skaleMax - 75;

            Console.WriteLine("|--------------------|");
            Console.WriteLine("|   ^F     _    ^C   |");
            Console.WriteLine($"|  {skaleMax * 1.8 + 32}  - | | -  {skaleMax}  |");
            Console.WriteLine($"|   {tempC5 * 1.8 + 32}  - | | -  {tempC5}  |");
            Console.WriteLine($"|   {tempC10 * 1.8 + 32}  - | | -  {tempC10}  |");
            Console.WriteLine($"|   {tempC15 * 1.8 + 32}  - | | -  {tempC15}  |");
            Console.WriteLine($"|   {tempC20 * 1.8 + 32}  - | | -  {tempC20}  |");
            Console.WriteLine($"|   {tempC25 * 1.8 + 32}  - | | -  {tempC25}  |");
            Console.WriteLine($"|   {tempC30 * 1.8 + 32}  - | | -  {tempC30}  |");
            Console.WriteLine($"|   {tempC35 * 1.8 + 32}  - | | -   {tempC35}  |");
            Console.WriteLine($"|   {tempC40 * 1.8 + 32}  - | | -   {tempC40}  |");
            Console.WriteLine($"|   {tempC45 * 1.8 + 32}  - | | -  {tempC45}  |");
            Console.WriteLine($"|   {tempC50 * 1.8 + 32}  - | | - {tempC50}  |");
            Console.WriteLine($"|    {tempC55 * 1.8 + 32}  - | | - {tempC55}  |");
            Console.WriteLine($"|   {tempC60 * 1.8 + 32}  - | | - {tempC60}  |");
            Console.WriteLine($"|  {tempC65 * 1.8 + 32}  - | | - {tempC65}  |");
            Console.WriteLine($"|  {tempC70 * 1.8 + 32}  - | | - {tempC70}  |");
            Console.WriteLine($"|  {tempC75 * 1.8 + 32}  - | | - {tempC75}  |");
            Console.WriteLine($"|  {skaleMin * 1.8 + 32}  - | | - {skaleMin}  |");
            Console.WriteLine("|        '***`       |");
            Console.WriteLine("|       (*****)      |");
            Console.WriteLine("|        `---'       |");
            Console.WriteLine("|____________________|");
        }
    }
}