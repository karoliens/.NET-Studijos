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
            var tempF = tempC * 1.8 + 32; //Įvestos temperatūros pagal Celcijų konvertavimas į temperatūrą pagal Farenheitą
            var tempK = tempC + 273.15; //Įvestos temperatūros pagal Celcijų konvertavimas į temperatūrą pagal Kelviną

            Console.WriteLine($"Temperatūra pagal Farenheitą: {tempF}");

            Console.WriteLine($"Temperatūra pagal Kelviną: {tempK}");

            var tempCPerskaiciuotaIsF = (tempF - 32) / 1.8;

            //Perskaičiuotos temperatūros pagal Farenheitą tikrinimas su anksčiau apskaičiuota temperatūra 
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Farenheitą sutampa su įvestu skaičiu? {tempCPerskaiciuotaIsF == tempC}");

            var tempCPerskaiciuotaIsK = tempK - 273.15;
            //Perskaičiuotos temperatūros pagal Celcijų tikrinimas su anksčiau apskaičiuota temperatūra
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Celcijų sutampa su įvestu skaičiu? {tempCPerskaiciuotaIsK == tempC}");

            var tempKPerskaiciuotaIsF = (tempF - 32) * 5 / 9 + 273.15;

            //Perskaičiuotos temperatūros pagal Kelviną tikrinimas su anksčiau apskaičiuota temperatūra
            Console.WriteLine($"Ar perskaičiuota temperatūra pagal Kelviną sutampa su ankstesniu skaičiavimu? {tempKPerskaiciuotaIsF == tempK}");

            var skaleMax = tempC + 40; //Prie įvestos temperatūros pridedama 40
            var skaleMin = tempC - 40; //Prie įvestos temperatūros atimama 40

            Console.WriteLine("|--------------------|");
            Console.WriteLine("|   ^F     _    ^C   |");


            //Loopinama pradedant maksimalia termometro reikšme ir baigiant įvesta, kas 5
            for (var i = skaleMax; i > tempC; i = i - 5)
            {
                Console.WriteLine(String.Format("| {0, 4}  - | | - {1, 3}  |", (int)(i * 1.8 + 32), i)); //Formatuojama, kad neiškraipytų piešinio
            }

            //Loopinama pradedant įvesta termometro reikšme ir baigiant minimalia, kas 5
            for (var i = tempC; i >= skaleMin; i = i - 5)
            {
                Console.WriteLine(String.Format("| {0, 4}  - |#| - {1, 3}  |", (int)(i * 1.8 + 32), i)); //Formatuojama, kad neiškraipytų piešinio
            }

            Console.WriteLine("|        '***`       |");
            Console.WriteLine("|       (*****)      |");
            Console.WriteLine("|        `---'       |");
            Console.WriteLine("|____________________|");

            Console.WriteLine("Įveskite atstumą tarp taškų A ir B kilometrais:");
            var atstumas = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite pirmos transporto priemonės greitį km/h:");
            var greitis1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite antros transporto priemonės greitį km/h:");
            var greitis2 = int.Parse(Console.ReadLine());

            //Skaičiuojamas laikas po kurio pirma ir antra transporto priemonės susitiks valandomis
            // t = S / (v1 + v2)

            var laikasPoKurioSusitiks = (atstumas / (greitis1 + greitis2));

            //Skaičiuojamas atstumas nuo taško A iki vietos, kurioje susitiks pirma ir antra transporto priemonės kilometrais

            var atstumasNuoAIkiSusitikimo = greitis1 * laikasPoKurioSusitiks;

            //Skaičiuojamas laikas kada pirma ir antra transporto priemonės pasieks galutinius taškus valandomis
            // t = S / v

            var laikasIkiTasko1 = (atstumas / greitis1);
            var laikasIkiTasko2 = (atstumas / greitis2);

           /*
           Skaičiuojama kiek gramų CO2 išskyrė abi transporto priemonės kartu sudėjus įveikdamos visą atstumą:
           A -> B ir B -> A
           Vienos transporto priemonės CO2 norma yra 95g/km
           */

            var transportPriemCo2Visas = atstumas * 2 * 95;

            /*
            Skaičiuojama kiek gramų CO2 išskyrė abi transporto priemonės kartu sudėjus įveikdamos atstumą iki susitikimo:
            A -> susitikimo ir B -> susitikimo
            Vienos transporto priemonės CO2 norma yra 95g/km
            */

            var transportPriemCo2IkiTasko = (atstumasNuoAIkiSusitikimo * 95) + (atstumas - atstumasNuoAIkiSusitikimo) * 95;

            Console.WriteLine($"Transporto priemonės susitiks po {atstumasNuoAIkiSusitikimo} metrų.");
            Console.WriteLine($"Transporto priemonės susitiks po {laikasPoKurioSusitiks * 3600} sekundžių.");
            Console.WriteLine($"Pirma transporto priemonė pasieks galutinį tašką po {laikasIkiTasko1 * 60} minučių.");
            Console.WriteLine($"Antra transporto priemonė pasieks galutinį tašką po {laikasIkiTasko2 * 60} minučių.");
            Console.WriteLine($"Abi kartu transporto priemonės įveikdamos visą atstumą išskyrė {transportPriemCo2Visas} gramus CO2.");
            Console.WriteLine($"Abi kartu transporto priemonės įveikdamos atstumą iki susitikimo išskyrė {transportPriemCo2IkiTasko} gramus CO2.");

            /*
            | 5km  | 5km  | 5km  | 5km   | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  |
            |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
            A______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B
            |-----------22km---------|        
            |----------------------------------------------------------------100km-----------------------------------------------------------------------|        
            >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 90min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< 30min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            */

            /*
            Nesugalvojau kaip nupiešti be loop, todėl naudojau loop, tačiau vistiek neveikia gerai.
            Taip pat susidūriau su sunkumaisskaičiuojant po kokio atstumo susitko transporto priemonės.
            */

            //20 segmentų

            var segmentai = atstumas / 20;

            //skaičiuojamas eilutės ilgis

            var eilute = "|----------------------------------------------------------------100km-----------------------------------------------------------------------|";
            var eilutesIlgis = eilute.Length;

            Console.WriteLine(eilutesIlgis);

            for (var i = 0; i < 20; i++) //piešiami segmentai
            {
                Console.Write($"| {segmentai}km  ");
            }
            
            Console.WriteLine("|");
            
            for (var i = 0; i <= 20; i++)
            {
                Console.Write("|      ");
            }
            
            Console.Write("\nA");
            
            for (var i = 0; i < atstumasNuoAIkiSusitikimo; i++) //piešiama A -> V
            {
                Console.Write("-");
            }

            Console.Write("V");
           
            for (var i = atstumasNuoAIkiSusitikimo; i < eilutesIlgis; i++) //piešiama V -> B
            {
                Console.Write("-");
            }

            Console.Write("B");

            Console.Write("\n|");

            for (var i = 0; i < atstumasNuoAIkiSusitikimo; i++) //piešiama A -> V
            {
                Console.Write("-");
            }

            Console.Write("|");
            Console.WriteLine($"\n|----------------------------------------------------------------{atstumas}km-----------------------------------------------------------------------|");
            Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> {laikasIkiTasko1}min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine($"<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< {laikasIkiTasko2}min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }
    }
}