namespace P005_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            PARAŠYTI PROGRAMĄ KURI
            PRAŠO ĮVESTI 2 SKAIČIUS.
            JEI ABU LYGŪS,
            PROGRAMA TURI IŠVESTI
            TRUE , JEI NE FALSE
            */

            //Console.WriteLine("Įveskite pirmą skaičių:");
            //var pirmasSkaicius = int.Parse(Console.ReadLine());

            //Console.WriteLine("Įveskite antrą skaičių:");
            //var antrasSkaicius = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Ar lygūs? {pirmasSkaicius == antrasSkaicius}");

            /*
            PARAŠYTI PROGRAMĄ KURI
            PRAŠO ĮVESTI 2 SKAIČIUS.
            JEI ABU LYGINIAI,
            PROGRAMA TURI IŠVESTI
            TRUE , JEI NE FALSE
            */

            //bool lyginisPirmas = pirmasSkaicius % 2 == 0;
            //bool lyginisAntras = antrasSkaicius % 2 == 0;
            //Console.WriteLine($"Ar abu lyginiai? {lyginisPirmas && lyginisAntras}");

            /*
            Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
            išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
            kanalas A __---___---___---___---___
            kanalas B ____---___---___---___---_
            Apatinis brūkšnys (_) reiškia false, o paprastas (-) true.
            Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
            a) A AND B
            b) A OR B
            c) A XOR B
            d) A NAND B
            e) A NOR B
            f) NOT A
            g) NOT A OR B
            e) (A OR B) NAND A
            */

            //Kanalo A atskirų elementų priskyrimas kintamiesiems
            /*
            var kanalasA = "__---___---___---___---___";
            var kanalasB = "____---___---___---___---_";

            var kanalasABinary = kanalasA.Replace("_", "0").Replace("-", "1");
            var kanalasBBinary = kanalasB.Replace("_", "0").Replace("-", "1");

            int kanalasAInt = Convert.ToInt32(kanalasABinary, 2);
            int kanalasBInt = Convert.ToInt32(kanalasBBinary, 2);

            var kanalasAANDB = kanalasAInt & kanalasBInt;

            //Console.WriteLine("____-_____-_____-_____-___");
            Console.WriteLine(Convert.ToString(kanalasAANDB, 2).PadLeft(26, '0').Replace("0", "_").Replace("1", "-"));

            /*
            string kanalasA0 = "_";
            string kanalasA1 = "_";
            string kanalasA2 = "-";
            string kanalasA3 = "-";
            string kanalasA4 = "-";
            string kanalasA5 = "_";
            string kanalasA6 = "_";
            string kanalasA7 = "_";
            string kanalasA8 = "-";
            string kanalasA9 = "-";
            string kanalasA10 = "-";
            string kanalasA11 = "_";
            string kanalasA12 = "_";
            string kanalasA13 = "_";
            string kanalasA14 = "-";
            string kanalasA15 = "-";
            string kanalasA16 = "-";
            string kanalasA17 = "_";
            string kanalasA18 = "_";
            string kanalasA19 = "_";
            string kanalasA20 = "-";
            string kanalasA21 = "-";
            string kanalasA22 = "-";
            string kanalasA23 = "_";
            string kanalasA24 = "_";
            string kanalasA25 = "_";

            //Kanalo B atskirų elementų priskyrimas kintamiesiems

            string kanalasB0 = "_";
            string kanalasB1 = "_";
            string kanalasB2 = "_";
            string kanalasB3 = "_";
            string kanalasB4 = "-";
            string kanalasB5 = "-";
            string kanalasB6 = "-";
            string kanalasB7 = "_";
            string kanalasB8 = "_";
            string kanalasB9 = "_";
            string kanalasB10 = "-";
            string kanalasB11 = "-";
            string kanalasB12 = "-";
            string kanalasB13 = "_";
            string kanalasB14 = "_";
            string kanalasB15 = "_";
            string kanalasB16 = "-";
            string kanalasB17 = "-";
            string kanalasB18 = "-";
            string kanalasB19 = "_";
            string kanalasB20 = "_";
            string kanalasB21 = "_";
            string kanalasB22 = "-";
            string kanalasB23 = "-";
            string kanalasB24 = "-";
            string kanalasB25 = "_";

            //Kanalo A pradinis išvedimas

            Console.WriteLine($"Kanalas A\n{kanalasA0}{kanalasA1}{kanalasA2}{kanalasA3}{kanalasA4}" +
            $"{kanalasA5}{kanalasA6}{kanalasA7}{kanalasA8}" +
            $"{kanalasA9}{kanalasA10}{kanalasA11}{kanalasA12}" +
            $"{kanalasA13}{kanalasA14}{kanalasA15}{kanalasA16}" +
            $"{kanalasA17}{kanalasA18}{kanalasA19}{kanalasA20}" +
            $"{kanalasA21}{kanalasA22}{kanalasA23}{kanalasA24}" +
            $"{kanalasA25}");

            //Kanalo B pradinis išvedimas

            Console.WriteLine($"Kanalas B\n{kanalasB0}{kanalasB1}{kanalasB2}{kanalasB3}{kanalasB4}" +
                $"{kanalasB5}{kanalasB6}{kanalasB7}{kanalasB8}" +
                $"{kanalasB9}{kanalasB10}{kanalasB11}{kanalasB12}" +
                $"{kanalasB13}{kanalasB14}{kanalasB15}{kanalasB16}" +
                $"{kanalasB17}{kanalasB18}{kanalasB19}{kanalasB20}" +
                $"{kanalasB21}{kanalasB22}{kanalasB23}{kanalasB24}" +
                $"{kanalasB25}");

            //Kanalo A elementų keitimas į eilutę True ir False

            kanalasA0 = kanalasA0.Replace("_", "False").Replace("-", "True");
            kanalasA1 = kanalasA1.Replace("_", "False").Replace("-", "True");
            kanalasA2 = kanalasA2.Replace("_", "False").Replace("-", "True");
            kanalasA3 = kanalasA3.Replace("_", "False").Replace("-", "True");
            kanalasA4 = kanalasA4.Replace("_", "False").Replace("-", "True");
            kanalasA5 = kanalasA5.Replace("_", "False").Replace("-", "True");
            kanalasA6 = kanalasA6.Replace("_", "False").Replace("-", "True");
            kanalasA7 = kanalasA7.Replace("_", "False").Replace("-", "True");
            kanalasA8 = kanalasA8.Replace("_", "False").Replace("-", "True");
            kanalasA9 = kanalasA9.Replace("_", "False").Replace("-", "True");
            kanalasA10 = kanalasA10.Replace("_", "False").Replace("-", "True");
            kanalasA11 = kanalasA11.Replace("_", "False").Replace("-", "True");
            kanalasA12 = kanalasA12.Replace("_", "False").Replace("-", "True");
            kanalasA13 = kanalasA13.Replace("_", "False").Replace("-", "True");
            kanalasA14 = kanalasA14.Replace("_", "False").Replace("-", "True");
            kanalasA15 = kanalasA15.Replace("_", "False").Replace("-", "True");
            kanalasA16 = kanalasA16.Replace("_", "False").Replace("-", "True");
            kanalasA17 = kanalasA17.Replace("_", "False").Replace("-", "True");
            kanalasA18 = kanalasA18.Replace("_", "False").Replace("-", "True");
            kanalasA19 = kanalasA19.Replace("_", "False").Replace("-", "True");
            kanalasA20 = kanalasA20.Replace("_", "False").Replace("-", "True");
            kanalasA21 = kanalasA21.Replace("_", "False").Replace("-", "True");
            kanalasA22 = kanalasA22.Replace("_", "False").Replace("-", "True");
            kanalasA23 = kanalasA23.Replace("_", "False").Replace("-", "True");
            kanalasA24 = kanalasA24.Replace("_", "False").Replace("-", "True");
            kanalasA25 = kanalasA25.Replace("_", "False").Replace("-", "True");

            //Kanalo A eilutės elementų keitimas į loginius kintamuosius

            bool kanalasA0Bool = bool.Parse(kanalasA0);
            bool kanalasA1Bool = bool.Parse(kanalasA1);
            bool kanalasA2Bool = bool.Parse(kanalasA2);
            bool kanalasA3Bool = bool.Parse(kanalasA3);
            bool kanalasA4Bool = bool.Parse(kanalasA4);
            bool kanalasA5Bool = bool.Parse(kanalasA5);
            bool kanalasA6Bool = bool.Parse(kanalasA6);
            bool kanalasA7Bool = bool.Parse(kanalasA7);
            bool kanalasA8Bool = bool.Parse(kanalasA8);
            bool kanalasA9Bool = bool.Parse(kanalasA9);
            bool kanalasA10Bool = bool.Parse(kanalasA10);
            bool kanalasA11Bool = bool.Parse(kanalasA11);
            bool kanalasA12Bool = bool.Parse(kanalasA12);
            bool kanalasA13Bool = bool.Parse(kanalasA13);
            bool kanalasA14Bool = bool.Parse(kanalasA14);
            bool kanalasA15Bool = bool.Parse(kanalasA15);
            bool kanalasA16Bool = bool.Parse(kanalasA16);
            bool kanalasA17Bool = bool.Parse(kanalasA17);
            bool kanalasA18Bool = bool.Parse(kanalasA18);
            bool kanalasA19Bool = bool.Parse(kanalasA19);
            bool kanalasA20Bool = bool.Parse(kanalasA20);
            bool kanalasA21Bool = bool.Parse(kanalasA21);
            bool kanalasA22Bool = bool.Parse(kanalasA22);
            bool kanalasA23Bool = bool.Parse(kanalasA23);
            bool kanalasA24Bool = bool.Parse(kanalasA24);
            bool kanalasA25Bool = bool.Parse(kanalasA25);

            

            //Kanalo B elementų keitimas į eilutę True ir False

            kanalasB0 = kanalasB0.Replace("_", "False").Replace("-", "True");
            kanalasB1 = kanalasB1.Replace("_", "False").Replace("-", "True");
            kanalasB2 = kanalasB2.Replace("_", "False").Replace("-", "True");
            kanalasB3 = kanalasB3.Replace("_", "False").Replace("-", "True");
            kanalasB4 = kanalasB4.Replace("_", "False").Replace("-", "True");
            kanalasB5 = kanalasB5.Replace("_", "False").Replace("-", "True");
            kanalasB6 = kanalasB6.Replace("_", "False").Replace("-", "True");
            kanalasB7 = kanalasB7.Replace("_", "False").Replace("-", "True");
            kanalasB8 = kanalasB8.Replace("_", "False").Replace("-", "True");
            kanalasB9 = kanalasB9.Replace("_", "False").Replace("-", "True");
            kanalasB10 = kanalasB10.Replace("_", "False").Replace("-", "True");
            kanalasB11 = kanalasB11.Replace("_", "False").Replace("-", "True");
            kanalasB12 = kanalasB12.Replace("_", "False").Replace("-", "True");
            kanalasB13 = kanalasB13.Replace("_", "False").Replace("-", "True");
            kanalasB14 = kanalasB14.Replace("_", "False").Replace("-", "True");
            kanalasB15 = kanalasB15.Replace("_", "False").Replace("-", "True");
            kanalasB16 = kanalasB16.Replace("_", "False").Replace("-", "True");
            kanalasB17 = kanalasB17.Replace("_", "False").Replace("-", "True");
            kanalasB18 = kanalasB18.Replace("_", "False").Replace("-", "True");
            kanalasB19 = kanalasB19.Replace("_", "False").Replace("-", "True");
            kanalasB20 = kanalasB20.Replace("_", "False").Replace("-", "True");
            kanalasB21 = kanalasB21.Replace("_", "False").Replace("-", "True");
            kanalasB22 = kanalasB22.Replace("_", "False").Replace("-", "True");
            kanalasB23 = kanalasB23.Replace("_", "False").Replace("-", "True");
            kanalasB24 = kanalasB24.Replace("_", "False").Replace("-", "True");
            kanalasB25 = kanalasB25.Replace("_", "False").Replace("-", "True");

            //Kanalo B eilutės elementų keitimas į loginius kintamuosius

            bool kanalasB0Bool = bool.Parse(kanalasB0);
            bool kanalasB1Bool = bool.Parse(kanalasB1);
            bool kanalasB2Bool = bool.Parse(kanalasB2);
            bool kanalasB3Bool = bool.Parse(kanalasB3);
            bool kanalasB4Bool = bool.Parse(kanalasB4);
            bool kanalasB5Bool = bool.Parse(kanalasB5);
            bool kanalasB6Bool = bool.Parse(kanalasB6);
            bool kanalasB7Bool = bool.Parse(kanalasB7);
            bool kanalasB8Bool = bool.Parse(kanalasB8);
            bool kanalasB9Bool = bool.Parse(kanalasB9);
            bool kanalasB10Bool = bool.Parse(kanalasB10);
            bool kanalasB11Bool = bool.Parse(kanalasB11);
            bool kanalasB12Bool = bool.Parse(kanalasB12);
            bool kanalasB13Bool = bool.Parse(kanalasB13);
            bool kanalasB14Bool = bool.Parse(kanalasB14);
            bool kanalasB15Bool = bool.Parse(kanalasB15);
            bool kanalasB16Bool = bool.Parse(kanalasB16);
            bool kanalasB17Bool = bool.Parse(kanalasB17);
            bool kanalasB18Bool = bool.Parse(kanalasB18);
            bool kanalasB19Bool = bool.Parse(kanalasB19);
            bool kanalasB20Bool = bool.Parse(kanalasB20);
            bool kanalasB21Bool = bool.Parse(kanalasB21);
            bool kanalasB22Bool = bool.Parse(kanalasB22);
            bool kanalasB23Bool = bool.Parse(kanalasB23);
            bool kanalasB24Bool = bool.Parse(kanalasB24);
            bool kanalasB25Bool = bool.Parse(kanalasB25);

            //Kanalo A ir B AND loginis lyginimas

            bool a0B0 = bool.Parse(kanalasA0) && bool.Parse(kanalasB0);
            bool a1B1 = bool.Parse(kanalasA1) && bool.Parse(kanalasB1);
            bool a2B2 = bool.Parse(kanalasA2) && bool.Parse(kanalasB2);
            bool a3B3 = bool.Parse(kanalasA3) && bool.Parse(kanalasB3);
            bool a4B4 = bool.Parse(kanalasA4) && bool.Parse(kanalasB4);
            bool a5B5 = bool.Parse(kanalasA5) && bool.Parse(kanalasB5);
            bool a6B6 = bool.Parse(kanalasA6) && bool.Parse(kanalasB6);
            bool a7B7 = bool.Parse(kanalasA7) && bool.Parse(kanalasB7);
            bool a8B8 = bool.Parse(kanalasA8) && bool.Parse(kanalasB8);
            bool a9B9 = bool.Parse(kanalasA9) && bool.Parse(kanalasB9);
            bool a10B10 = bool.Parse(kanalasA10) && bool.Parse(kanalasB10);
            bool a11B11 = bool.Parse(kanalasA11) && bool.Parse(kanalasB11);
            bool a12B12 = bool.Parse(kanalasA12) && bool.Parse(kanalasB12);
            bool a13B13 = bool.Parse(kanalasA13) && bool.Parse(kanalasB13);
            bool a14B14 = bool.Parse(kanalasA14) && bool.Parse(kanalasB14);
            bool a15B15 = bool.Parse(kanalasA15) && bool.Parse(kanalasB15);
            bool a16B16 = bool.Parse(kanalasA16) && bool.Parse(kanalasB16);
            bool a17B17 = bool.Parse(kanalasA17) && bool.Parse(kanalasB17);
            bool a18B18 = bool.Parse(kanalasA18) && bool.Parse(kanalasB18);
            bool a19B19 = bool.Parse(kanalasA19) && bool.Parse(kanalasB19);
            bool a20B20 = bool.Parse(kanalasA20) && bool.Parse(kanalasB20);
            bool a21B21 = bool.Parse(kanalasA21) && bool.Parse(kanalasB21);
            bool a22B22 = bool.Parse(kanalasA22) && bool.Parse(kanalasB22);
            bool a23B23 = bool.Parse(kanalasA23) && bool.Parse(kanalasB23);
            bool a24B24 = bool.Parse(kanalasA24) && bool.Parse(kanalasB24);
            bool a25B25 = bool.Parse(kanalasA25) && bool.Parse(kanalasB25);

            //Kanalų A ir B loginio lyginimo AND išvedimas į konsolę

            Console.WriteLine($"AND\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B OR loginis lyginimas

            a0B0 = bool.Parse(kanalasA0) || bool.Parse(kanalasB0);
            a1B1 = bool.Parse(kanalasA1) || bool.Parse(kanalasB1);
            a2B2 = bool.Parse(kanalasA2) || bool.Parse(kanalasB2);
            a3B3 = bool.Parse(kanalasA3) || bool.Parse(kanalasB3);
            a4B4 = bool.Parse(kanalasA4) || bool.Parse(kanalasB4);
            a5B5 = bool.Parse(kanalasA5) || bool.Parse(kanalasB5);
            a6B6 = bool.Parse(kanalasA6) || bool.Parse(kanalasB6);
            a7B7 = bool.Parse(kanalasA7) || bool.Parse(kanalasB7);
            a8B8 = bool.Parse(kanalasA8) || bool.Parse(kanalasB8);
            a9B9 = bool.Parse(kanalasA9) || bool.Parse(kanalasB9);
            a10B10 = bool.Parse(kanalasA10) || bool.Parse(kanalasB10);
            a11B11 = bool.Parse(kanalasA11) || bool.Parse(kanalasB11);
            a12B12 = bool.Parse(kanalasA12) || bool.Parse(kanalasB12);
            a13B13 = bool.Parse(kanalasA13) || bool.Parse(kanalasB13);
            a14B14 = bool.Parse(kanalasA14) || bool.Parse(kanalasB14);
            a15B15 = bool.Parse(kanalasA15) || bool.Parse(kanalasB15);
            a16B16 = bool.Parse(kanalasA16) || bool.Parse(kanalasB16);
            a17B17 = bool.Parse(kanalasA17) || bool.Parse(kanalasB17);
            a18B18 = bool.Parse(kanalasA18) || bool.Parse(kanalasB18);
            a19B19 = bool.Parse(kanalasA19) || bool.Parse(kanalasB19);
            a20B20 = bool.Parse(kanalasA20) || bool.Parse(kanalasB20);
            a21B21 = bool.Parse(kanalasA21) || bool.Parse(kanalasB21);
            a22B22 = bool.Parse(kanalasA22) || bool.Parse(kanalasB22);
            a23B23 = bool.Parse(kanalasA23) || bool.Parse(kanalasB23);
            a24B24 = bool.Parse(kanalasA24) || bool.Parse(kanalasB24);
            a25B25 = bool.Parse(kanalasA25) || bool.Parse(kanalasB25);

            //Kanalų A ir B loginio lyginimo OR išvedimas į konsolę

            Console.WriteLine($"OR\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B XOR loginis lyginimas

            a0B0 = bool.Parse(kanalasA0) ^ bool.Parse(kanalasB0);
            a1B1 = bool.Parse(kanalasA1) ^ bool.Parse(kanalasB1);
            a2B2 = bool.Parse(kanalasA2) ^ bool.Parse(kanalasB2);
            a3B3 = bool.Parse(kanalasA3) ^ bool.Parse(kanalasB3);
            a4B4 = bool.Parse(kanalasA4) ^ bool.Parse(kanalasB4);
            a5B5 = bool.Parse(kanalasA5) ^ bool.Parse(kanalasB5);
            a6B6 = bool.Parse(kanalasA6) ^ bool.Parse(kanalasB6);
            a7B7 = bool.Parse(kanalasA7) ^ bool.Parse(kanalasB7);
            a8B8 = bool.Parse(kanalasA8) ^ bool.Parse(kanalasB8);
            a9B9 = bool.Parse(kanalasA9) ^ bool.Parse(kanalasB9);
            a10B10 = bool.Parse(kanalasA10) ^ bool.Parse(kanalasB10);
            a11B11 = bool.Parse(kanalasA11) ^ bool.Parse(kanalasB11);
            a12B12 = bool.Parse(kanalasA12) ^ bool.Parse(kanalasB12);
            a13B13 = bool.Parse(kanalasA13) ^ bool.Parse(kanalasB13);
            a14B14 = bool.Parse(kanalasA14) ^ bool.Parse(kanalasB14);
            a15B15 = bool.Parse(kanalasA15) ^ bool.Parse(kanalasB15);
            a16B16 = bool.Parse(kanalasA16) ^ bool.Parse(kanalasB16);
            a17B17 = bool.Parse(kanalasA17) ^ bool.Parse(kanalasB17);
            a18B18 = bool.Parse(kanalasA18) ^ bool.Parse(kanalasB18);
            a19B19 = bool.Parse(kanalasA19) ^ bool.Parse(kanalasB19);
            a20B20 = bool.Parse(kanalasA20) ^ bool.Parse(kanalasB20);
            a21B21 = bool.Parse(kanalasA21) ^ bool.Parse(kanalasB21);
            a22B22 = bool.Parse(kanalasA22) ^ bool.Parse(kanalasB22);
            a23B23 = bool.Parse(kanalasA23) ^ bool.Parse(kanalasB23);
            a24B24 = bool.Parse(kanalasA24) ^ bool.Parse(kanalasB24);
            a25B25 = bool.Parse(kanalasA25) ^ bool.Parse(kanalasB25);

            //Kanalų A ir B loginio lyginimo XOR išvedimas į konsolę

            Console.WriteLine($"XOR\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B NAND loginis lyginimas

            a0B0 = !(bool.Parse(kanalasA0)) && !(bool.Parse(kanalasB0));
            a1B1 = !(bool.Parse(kanalasA1)) && !(bool.Parse(kanalasB1));
            a2B2 = !(bool.Parse(kanalasA2)) && !(bool.Parse(kanalasB2));
            a3B3 = !(bool.Parse(kanalasA3)) && !(bool.Parse(kanalasB3));
            a4B4 = !(bool.Parse(kanalasA4)) && !(bool.Parse(kanalasB4));
            a5B5 = !(bool.Parse(kanalasA5)) && !(bool.Parse(kanalasB5));
            a6B6 = !(bool.Parse(kanalasA6)) && !(bool.Parse(kanalasB6));
            a7B7 = !(bool.Parse(kanalasA7)) && !(bool.Parse(kanalasB7));
            a8B8 = !(bool.Parse(kanalasA8)) && !(bool.Parse(kanalasB8));
            a9B9 = !(bool.Parse(kanalasA9)) && !(bool.Parse(kanalasB9));
            a10B10 = !(bool.Parse(kanalasA10)) && !(bool.Parse(kanalasB10));
            a11B11 = !(bool.Parse(kanalasA11)) && !(bool.Parse(kanalasB11));
            a12B12 = !(bool.Parse(kanalasA12)) && !(bool.Parse(kanalasB12));
            a13B13 = !(bool.Parse(kanalasA13)) && !(bool.Parse(kanalasB13));
            a14B14 = !(bool.Parse(kanalasA14)) && !(bool.Parse(kanalasB14));
            a15B15 = !(bool.Parse(kanalasA15)) && !(bool.Parse(kanalasB15));
            a16B16 = !(bool.Parse(kanalasA16)) && !(bool.Parse(kanalasB16));
            a17B17 = !(bool.Parse(kanalasA17)) && !(bool.Parse(kanalasB17));
            a18B18 = !(bool.Parse(kanalasA18)) && !(bool.Parse(kanalasB18));
            a19B19 = !(bool.Parse(kanalasA19)) && !(bool.Parse(kanalasB19));
            a20B20 = !(bool.Parse(kanalasA20)) && !(bool.Parse(kanalasB20));
            a21B21 = !(bool.Parse(kanalasA21)) && !(bool.Parse(kanalasB21));
            a22B22 = !(bool.Parse(kanalasA22)) && !(bool.Parse(kanalasB22));
            a23B23 = !(bool.Parse(kanalasA23)) && !(bool.Parse(kanalasB23));
            a24B24 = !(bool.Parse(kanalasA24)) && !(bool.Parse(kanalasB24));
            a25B25 = !(bool.Parse(kanalasA25)) && !(bool.Parse(kanalasB25));

            //Kanalų A ir B loginio lyginimo NAND išvedimas į konsolę

            Console.WriteLine($"NAND\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B NOR loginis lyginimas

            a0B0 = !(bool.Parse(kanalasA0)) || !(bool.Parse(kanalasB0));
            a1B1 = !(bool.Parse(kanalasA1)) || !(bool.Parse(kanalasB1));
            a2B2 = !(bool.Parse(kanalasA2)) || !(bool.Parse(kanalasB2));
            a3B3 = !(bool.Parse(kanalasA3)) || !(bool.Parse(kanalasB3));
            a4B4 = !(bool.Parse(kanalasA4)) || !(bool.Parse(kanalasB4));
            a5B5 = !(bool.Parse(kanalasA5)) || !(bool.Parse(kanalasB5));
            a6B6 = !(bool.Parse(kanalasA6)) || !(bool.Parse(kanalasB6));
            a7B7 = !(bool.Parse(kanalasA7)) || !(bool.Parse(kanalasB7));
            a8B8 = !(bool.Parse(kanalasA8)) || !(bool.Parse(kanalasB8));
            a9B9 = !(bool.Parse(kanalasA9)) || !(bool.Parse(kanalasB9));
            a10B10 = !(bool.Parse(kanalasA10)) || !(bool.Parse(kanalasB10));
            a11B11 = !(bool.Parse(kanalasA11)) || !(bool.Parse(kanalasB11));
            a12B12 = !(bool.Parse(kanalasA12)) || !(bool.Parse(kanalasB12));
            a13B13 = !(bool.Parse(kanalasA13)) || !(bool.Parse(kanalasB13));
            a14B14 = !(bool.Parse(kanalasA14)) || !(bool.Parse(kanalasB14));
            a15B15 = !(bool.Parse(kanalasA15)) || !(bool.Parse(kanalasB15));
            a16B16 = !(bool.Parse(kanalasA16)) || !(bool.Parse(kanalasB16));
            a17B17 = !(bool.Parse(kanalasA17)) || !(bool.Parse(kanalasB17));
            a18B18 = !(bool.Parse(kanalasA18)) || !(bool.Parse(kanalasB18));
            a19B19 = !(bool.Parse(kanalasA19)) || !(bool.Parse(kanalasB19));
            a20B20 = !(bool.Parse(kanalasA20)) || !(bool.Parse(kanalasB20));
            a21B21 = !(bool.Parse(kanalasA21)) || !(bool.Parse(kanalasB21));
            a22B22 = !(bool.Parse(kanalasA22)) || !(bool.Parse(kanalasB22));
            a23B23 = !(bool.Parse(kanalasA23)) || !(bool.Parse(kanalasB23));
            a24B24 = !(bool.Parse(kanalasA24)) || !(bool.Parse(kanalasB24));
            a25B25 = !(bool.Parse(kanalasA25)) || !(bool.Parse(kanalasB25));

            //Kanalų A ir B loginio lyginimo NOR išvedimas į konsolę

            Console.WriteLine($"NOR\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B NOT A loginis lyginimas

            bool a0 = bool.Parse(kanalasA0);
            bool a1 = bool.Parse(kanalasA1);
            bool a2 = bool.Parse(kanalasA2);
            bool a3 = bool.Parse(kanalasA3);
            bool a4 = bool.Parse(kanalasA4);
            bool a5 = bool.Parse(kanalasA5);
            bool a6 = bool.Parse(kanalasA6);
            bool a7 = bool.Parse(kanalasA7);
            bool a8 = bool.Parse(kanalasA8);
            bool a9 = bool.Parse(kanalasA9);
            bool a10 = bool.Parse(kanalasA10);
            bool a11 = bool.Parse(kanalasA11);
            bool a12 = bool.Parse(kanalasA12);
            bool a13 = bool.Parse(kanalasA13);
            bool a14 = bool.Parse(kanalasA14);
            bool a15 = bool.Parse(kanalasA15);
            bool a16 = bool.Parse(kanalasA16);
            bool a17 = bool.Parse(kanalasA17);
            bool a18 = bool.Parse(kanalasA18);
            bool a19 = bool.Parse(kanalasA19);
            bool a20 = bool.Parse(kanalasA20);
            bool a21 = bool.Parse(kanalasA21);
            bool a22 = bool.Parse(kanalasA22);
            bool a23 = bool.Parse(kanalasA23);
            bool a24 = bool.Parse(kanalasA24);
            bool a25 = bool.Parse(kanalasA25);

            //Kanalų A ir B loginio lyginimo NOT A išvedimas į konsolę

            Console.WriteLine($"NOT A\n{Convert.ToString(!a0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(!a25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B NOT A OR B loginis lyginimas

            a0B0 = !(bool.Parse(kanalasA0) || bool.Parse(kanalasB0));
            a1B1 = !(bool.Parse(kanalasA1) || bool.Parse(kanalasB1));
            a2B2 = !(bool.Parse(kanalasA2) || bool.Parse(kanalasB2));
            a3B3 = !(bool.Parse(kanalasA3) || bool.Parse(kanalasB3));
            a4B4 = !(bool.Parse(kanalasA4) || bool.Parse(kanalasB4));
            a5B5 = !(bool.Parse(kanalasA5) || bool.Parse(kanalasB5));
            a6B6 = !(bool.Parse(kanalasA6) || bool.Parse(kanalasB6));
            a7B7 = !(bool.Parse(kanalasA7) || bool.Parse(kanalasB7));
            a8B8 = !(bool.Parse(kanalasA8) || bool.Parse(kanalasB8));
            a9B9 = !(bool.Parse(kanalasA9) || bool.Parse(kanalasB9));
            a10B10 = !(bool.Parse(kanalasA10) || bool.Parse(kanalasB10));
            a11B11 = !(bool.Parse(kanalasA11) || bool.Parse(kanalasB11));
            a12B12 = !(bool.Parse(kanalasA12) || bool.Parse(kanalasB12));
            a13B13 = !(bool.Parse(kanalasA13) || bool.Parse(kanalasB13));
            a14B14 = !(bool.Parse(kanalasA14) || bool.Parse(kanalasB14));
            a15B15 = !(bool.Parse(kanalasA15) || bool.Parse(kanalasB15));
            a16B16 = !(bool.Parse(kanalasA16) || bool.Parse(kanalasB16));
            a17B17 = !(bool.Parse(kanalasA17) || bool.Parse(kanalasB17));
            a18B18 = !(bool.Parse(kanalasA18) || bool.Parse(kanalasB18));
            a19B19 = !(bool.Parse(kanalasA19) || bool.Parse(kanalasB19));
            a20B20 = !(bool.Parse(kanalasA20) || bool.Parse(kanalasB20));
            a21B21 = !(bool.Parse(kanalasA21) || bool.Parse(kanalasB21));
            a22B22 = !(bool.Parse(kanalasA22) || bool.Parse(kanalasB22));
            a23B23 = !(bool.Parse(kanalasA23) || bool.Parse(kanalasB23));
            a24B24 = !(bool.Parse(kanalasA24) || bool.Parse(kanalasB24));
            a25B25 = !(bool.Parse(kanalasA25) || bool.Parse(kanalasB25));

            //Kanalų A ir B loginio lyginimo NOT A OR B išvedimas į konsolę

            Console.WriteLine($"NOT A OR B\n{Convert.ToString(a0B0).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25).Replace("False", "_").Replace("True", "-")}");

            //Kanalo A ir B (A OR B) NAND A loginis lyginimas

            a0B0 = bool.Parse(kanalasA0) || bool.Parse(kanalasB0);
            a1B1 = bool.Parse(kanalasA1) || bool.Parse(kanalasB1);
            a2B2 = bool.Parse(kanalasA2) || bool.Parse(kanalasB2);
            a3B3 = bool.Parse(kanalasA3) || bool.Parse(kanalasB3);
            a4B4 = bool.Parse(kanalasA4) || bool.Parse(kanalasB4);
            a5B5 = bool.Parse(kanalasA5) || bool.Parse(kanalasB5);
            a6B6 = bool.Parse(kanalasA6) || bool.Parse(kanalasB6);
            a7B7 = bool.Parse(kanalasA7) || bool.Parse(kanalasB7);
            a8B8 = bool.Parse(kanalasA8) || bool.Parse(kanalasB8);
            a9B9 = bool.Parse(kanalasA9) || bool.Parse(kanalasB9);
            a10B10 = bool.Parse(kanalasA10) || bool.Parse(kanalasB10);
            a11B11 = bool.Parse(kanalasA11) || bool.Parse(kanalasB11);
            a12B12 = bool.Parse(kanalasA12) || bool.Parse(kanalasB12);
            a13B13 = bool.Parse(kanalasA13) || bool.Parse(kanalasB13);
            a14B14 = bool.Parse(kanalasA14) || bool.Parse(kanalasB14);
            a15B15 = bool.Parse(kanalasA15) || bool.Parse(kanalasB15);
            a16B16 = bool.Parse(kanalasA16) || bool.Parse(kanalasB16);
            a17B17 = bool.Parse(kanalasA17) || bool.Parse(kanalasB17);
            a18B18 = bool.Parse(kanalasA18) || bool.Parse(kanalasB18);
            a19B19 = bool.Parse(kanalasA19) || bool.Parse(kanalasB19);
            a20B20 = bool.Parse(kanalasA20) || bool.Parse(kanalasB20);
            a21B21 = bool.Parse(kanalasA21) || bool.Parse(kanalasB21);
            a22B22 = bool.Parse(kanalasA22) || bool.Parse(kanalasB22);
            a23B23 = bool.Parse(kanalasA23) || bool.Parse(kanalasB23);
            a24B24 = bool.Parse(kanalasA24) || bool.Parse(kanalasB24);
            a25B25 = bool.Parse(kanalasA25) || bool.Parse(kanalasB25);

            //Kanalų A ir B loginio lyginimo (A OR B) NAND A išvedimas į konsolę

            Console.WriteLine($"(A OR B) NAND A\n{Convert.ToString(a0B0 !&& !kanalasA0Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a1B1 && !!kanalasA1Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a2B2 && !kanalasA2Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a3B3 && !kanalasA3Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a4B4 && !kanalasA4Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a5B5 && !kanalasA5Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a6B6 && !kanalasA6Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a7B7 && !kanalasA7Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a8B8 && !kanalasA8Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a9B9 && !kanalasA9Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a10B10 && !kanalasA10Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a11B11 && !kanalasA11Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a12B12 && !kanalasA12Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a13B13 && !kanalasA13Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a14B14 && !kanalasA14Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a15B15 && !kanalasA15Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a16B16 && !kanalasA16Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a17B17 && !kanalasA17Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a18B18 && !kanalasA18Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a19B19 && !kanalasA19Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a20B20 && !kanalasA20Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a21B21 && !kanalasA21Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a22B22 && !kanalasA22Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a23B23 && !kanalasA23Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a24B24 && !kanalasA24Bool).Replace("False", "_").Replace("True", "-")}" +
                $"{Convert.ToString(a25B25 && !kanalasA25Bool).Replace("False", "_").Replace("True", "-")}");

            /*Prašykite programą, kuri pritaikius loginę funkciją grąžina tokius rezultatus
            A  B F(A, B)
            0  0     0
            0  1     1
            1  0     1
            1  1     1
            */

            Console.WriteLine("A:");

            bool a = bool.Parse(Console.ReadLine());

            Console.WriteLine("B:");

            bool b = bool.Parse(Console.ReadLine());

            Console.WriteLine(a || b);

            /*
            A  B   F(A,B)
            0  0     1
            0  1     1
            1  0     0
            1  1     1
            */

            /*
            A  B   F(A,B)
            0  0     1
            0  1     0
            1  0     1
            1  1     0
            */

            /*
            A B  C F(A, B, C)
            0  0  0      1
            0  0  1      0
            0  1  0      0
            0  1  1      0
            1  0  0      1
            1  0  1      0
            1  1  0      0
            1  1  1      1
            */
        }
    }
}