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

            ///*
            //PARAŠYTI PROGRAMĄ KURI
            //PRAŠO ĮVESTI 2 SKAIČIUS.
            //JEI ABU LYGINIAI,
            //PROGRAMA TURI IŠVESTI
            //TRUE , JEI NE FALSE
            //*/

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

            //var kanalasA = "__---___---___---___---___";
            //var kanalasB = "____---___---___---___---_";

            //// A AND B

            //Console.Write((kanalasA[0] == '-' && kanalasB[0] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[1] == '-' && kanalasB[1] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[2] == '-' && kanalasB[2] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[3] == '-' && kanalasB[3] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[4] == '-' && kanalasB[4] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[5] == '-' && kanalasB[5] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[6] == '-' && kanalasB[6] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[7] == '-' && kanalasB[7] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[8] == '-' && kanalasB[8] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[9] == '-' && kanalasB[9] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[10] == '-' && kanalasB[10] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[11] == '-' && kanalasB[11] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[12] == '-' && kanalasB[12] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[13] == '-' && kanalasB[13] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[14] == '-' && kanalasB[14] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[15] == '-' && kanalasB[15] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[16] == '-' && kanalasB[16] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[17] == '-' && kanalasB[17] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[18] == '-' && kanalasB[18] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[19] == '-' && kanalasB[19] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[20] == '-' && kanalasB[20] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[21] == '-' && kanalasB[21] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[22] == '-' && kanalasB[22] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[23] == '-' && kanalasB[23] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[24] == '-' && kanalasB[24] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[25] == '-' && kanalasB[25] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// A OR B

            //Console.Write((kanalasA[0] == '-' || kanalasB[0] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[1] == '-' || kanalasB[1] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[2] == '-' || kanalasB[2] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[3] == '-' || kanalasB[3] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[4] == '-' || kanalasB[4] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[5] == '-' || kanalasB[5] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[6] == '-' || kanalasB[6] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[7] == '-' || kanalasB[7] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[8] == '-' || kanalasB[8] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[9] == '-' || kanalasB[9] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[10] == '-' || kanalasB[10] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[11] == '-' || kanalasB[11] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[12] == '-' || kanalasB[12] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[13] == '-' || kanalasB[13] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[14] == '-' || kanalasB[14] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[15] == '-' || kanalasB[15] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[16] == '-' || kanalasB[16] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[17] == '-' || kanalasB[17] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[18] == '-' || kanalasB[18] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[19] == '-' || kanalasB[19] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[20] == '-' || kanalasB[20] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[21] == '-' || kanalasB[21] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[22] == '-' || kanalasB[22] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[23] == '-' || kanalasB[23] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[24] == '-' || kanalasB[24] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[25] == '-' || kanalasB[25] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// A XOR B

            //Console.Write((kanalasA[0] == '-' ^ kanalasB[0] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[1] == '-' ^ kanalasB[1] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[2] == '-' ^ kanalasB[2] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[3] == '-' ^ kanalasB[3] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[4] == '-' ^ kanalasB[4] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[5] == '-' ^ kanalasB[5] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[6] == '-' ^ kanalasB[6] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[7] == '-' ^ kanalasB[7] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[8] == '-' ^ kanalasB[8] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[9] == '-' ^ kanalasB[9] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[10] == '-' ^ kanalasB[10] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[11] == '-' ^ kanalasB[11] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[12] == '-' ^ kanalasB[12] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[13] == '-' ^ kanalasB[13] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[14] == '-' ^ kanalasB[14] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[15] == '-' ^ kanalasB[15] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[16] == '-' ^ kanalasB[16] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[17] == '-' ^ kanalasB[17] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[18] == '-' ^ kanalasB[18] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[19] == '-' ^ kanalasB[19] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[20] == '-' ^ kanalasB[20] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[21] == '-' ^ kanalasB[21] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[22] == '-' ^ kanalasB[22] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[23] == '-' ^ kanalasB[23] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[24] == '-' ^ kanalasB[24] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((kanalasA[25] == '-' ^ kanalasB[25] == '-').ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// A NAND B

            //Console.Write((!(kanalasA[0] == '-' && kanalasB[0] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[1] == '-' && kanalasB[1] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[2] == '-' && kanalasB[2] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[3] == '-' && kanalasB[3] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[4] == '-' && kanalasB[4] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[5] == '-' && kanalasB[5] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[6] == '-' && kanalasB[6] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[7] == '-' && kanalasB[7] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[8] == '-' && kanalasB[8] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[9] == '-' && kanalasB[9] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[10] == '-' && kanalasB[10] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[11] == '-' && kanalasB[11] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[12] == '-' && kanalasB[12] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[13] == '-' && kanalasB[13] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[14] == '-' && kanalasB[14] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[15] == '-' && kanalasB[15] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[16] == '-' && kanalasB[16] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[17] == '-' && kanalasB[17] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[18] == '-' && kanalasB[18] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[19] == '-' && kanalasB[19] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[20] == '-' && kanalasB[20] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[21] == '-' && kanalasB[21] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[22] == '-' && kanalasB[22] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[23] == '-' && kanalasB[23] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[24] == '-' && kanalasB[24] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[25] == '-' && kanalasB[25] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// A NOR B

            //Console.Write((!(kanalasA[0] == '-' || kanalasB[0] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[1] == '-' || kanalasB[1] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[2] == '-' || kanalasB[2] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[3] == '-' || kanalasB[3] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[4] == '-' || kanalasB[4] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[5] == '-' || kanalasB[5] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[6] == '-' || kanalasB[6] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[7] == '-' || kanalasB[7] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[8] == '-' || kanalasB[8] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[9] == '-' || kanalasB[9] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[10] == '-' || kanalasB[10] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[11] == '-' || kanalasB[11] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[12] == '-' || kanalasB[12] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[13] == '-' || kanalasB[13] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[14] == '-' || kanalasB[14] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[15] == '-' || kanalasB[15] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[16] == '-' || kanalasB[16] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[17] == '-' || kanalasB[17] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[18] == '-' || kanalasB[18] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[19] == '-' || kanalasB[19] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[20] == '-' || kanalasB[20] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[21] == '-' || kanalasB[21] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[22] == '-' || kanalasB[22] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[23] == '-' || kanalasB[23] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[24] == '-' || kanalasB[24] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[25] == '-' || kanalasB[25] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// NOT A

            //Console.Write((!(kanalasA[0] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[1] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[2] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[3] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[4] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[5] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[6] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[7] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[8] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[9] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[10] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[11] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[12] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[13] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[14] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[15] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[16] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[17] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[18] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[19] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[20] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[21] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[22] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[23] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[24] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[25] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// NOT A OR B

            //Console.Write((!(kanalasA[0] == '-') || (kanalasB[0] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[1] == '-') || (kanalasB[1] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[2] == '-') || (kanalasB[2] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[3] == '-') || (kanalasB[3] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[4] == '-') || (kanalasB[4] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[5] == '-') || (kanalasB[5] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[6] == '-') || (kanalasB[6] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[7] == '-') || (kanalasB[7] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[8] == '-') || (kanalasB[8] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[9] == '-' ) || (kanalasB[9] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[10] == '-' ) || (kanalasB[10] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[11] == '-' ) || (kanalasB[11] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[12] == '-' ) || (kanalasB[12] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[13] == '-' ) || (kanalasB[13] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[14] == '-' ) || (kanalasB[14] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[15] == '-' ) || (kanalasB[15] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[16] == '-' ) || (kanalasB[16] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[17] == '-' ) || (kanalasB[17] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[18] == '-' ) || (kanalasB[18] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[19] == '-' ) || (kanalasB[19] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[20] == '-' ) || (kanalasB[20] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[21] == '-' ) || (kanalasB[21] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[22] == '-' ) || (kanalasB[22] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[23] == '-' ) || (kanalasB[23] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[24] == '-' ) || (kanalasB[24] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write((!(kanalasA[25] == '-' ) || (kanalasB[25] == '-')).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            //// (A OR B) NAND A

            //Console.Write(((kanalasA[0] == '-' || kanalasB[0] == '-') && (!(kanalasA[0] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[1] == '-' || kanalasB[1] == '-') && (!(kanalasA[1] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[2] == '-' || kanalasB[2] == '-') && (!(kanalasA[2] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[3] == '-' || kanalasB[3] == '-') && (!(kanalasA[3] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[4] == '-' || kanalasB[4] == '-') && (!(kanalasA[4] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[5] == '-' || kanalasB[5] == '-') && (!(kanalasA[5] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[6] == '-' || kanalasB[6] == '-') && (!(kanalasA[6] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[7] == '-' || kanalasB[7] == '-') && (!(kanalasA[7] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[8] == '-' || kanalasB[8] == '-') && (!(kanalasA[8] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[9] == '-' || kanalasB[9] == '-') && (!(kanalasA[9] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[10] == '-' || kanalasB[10] == '-') && (!(kanalasA[10] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[11] == '-' || kanalasB[11] == '-') && (!(kanalasA[11] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[12] == '-' || kanalasB[12] == '-') && (!(kanalasA[12] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[13] == '-' || kanalasB[13] == '-') && (!(kanalasA[13] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[14] == '-' || kanalasB[14] == '-') && (!(kanalasA[14] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[15] == '-' || kanalasB[15] == '-') && (!(kanalasA[15] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[16] == '-' || kanalasB[16] == '-') && (!(kanalasA[16] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[17] == '-' || kanalasB[17] == '-') && (!(kanalasA[17] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[18] == '-' || kanalasB[18] == '-') && (!(kanalasA[18] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[19] == '-' || kanalasB[19] == '-') && (!(kanalasA[19] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[20] == '-' || kanalasB[20] == '-') && (!(kanalasA[20] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[21] == '-' || kanalasB[21] == '-') && (!(kanalasA[21] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[22] == '-' || kanalasB[22] == '-') && (!(kanalasA[22] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[23] == '-' || kanalasB[23] == '-') && (!(kanalasA[23] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[24] == '-' || kanalasB[24] == '-') && (!(kanalasA[24] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.Write(((kanalasA[25] == '-' || kanalasB[25] == '-') && (!(kanalasA[25] == '-'))).ToString().Replace("True", "-").Replace("False", "_"));
            //Console.WriteLine();

            ///*Prašykite programą, kuri pritaikius loginę funkciją grąžina tokius rezultatus
            //A  B F(A, B)
            //0  0     0
            //0  1     1
            //1  0     1
            //1  1     1
            //*/

            //Console.WriteLine("A:");

            //var a = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            //Console.WriteLine("B:");

            //var b = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            //Console.WriteLine($"F: {(a || b).ToString().Replace("True", "1").Replace("False", "0")}");

            ///*
            //A  B   F(A,B)
            //0  0     1
            //0  1     1
            //1  0     0
            //1  1     1
            //*/

            //Console.WriteLine("A:");

            //var a1 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            //Console.WriteLine("B:");

            //var b1 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            //Console.WriteLine($"F: {(!a1 || b1).ToString().Replace("True", "1").Replace("False", "0")}");

            /*
            A  B   F(A,B)
            0  0     1
            0  1     0
            1  0     1
            1  1     0
            */

            Console.WriteLine("A:");

            var a2 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            Console.WriteLine("B:");

            var b2 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            Console.WriteLine($"F: {(!((a2 || b2) && b2)).ToString().Replace("True", "1").Replace("False", "0")}");

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

            Console.WriteLine("A:");

            var a3 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            Console.WriteLine("B:");

            var b3 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            Console.WriteLine("C:");

            var c3 = bool.Parse(Console.ReadLine().Replace("0", "false").Replace("1", "true"));

            Console.WriteLine($"F: {(!((a3 || b3) && b3)).ToString().Replace("True", "1").Replace("False", "0")}");
        }
    }
}