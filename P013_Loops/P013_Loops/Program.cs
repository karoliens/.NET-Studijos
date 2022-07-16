using System.Text;

namespace P013_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ReadIntNumber();
            // IntegerToBinary();
            // SkaiciuTrikampis();
            // PakeltiLaipsniu();
            // SkaiciuTrikampis();
            // SkaiciuPiramide();
            // DidejanciuSkaiciuStatusTrikampis();
             DidejanciuSkaiciuPiramide();
        }

        /*
        Sukurti metodą ReadIntNumber, kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
        Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
        neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
        (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
        */

        public static void ReadIntNumber()
        {
            Console.WriteLine("Įveskite sveikąjį skaičių:");
            bool arSkaiciusTeisingas = false;
            var ivestasSkaicius = Console.ReadLine();

            while (!arSkaiciusTeisingas)
            {
                arSkaiciusTeisingas = int.TryParse(ivestasSkaicius, out _);

                if (arSkaiciusTeisingas)
                {
                    Console.WriteLine($"Įvestas skaičius: {ivestasSkaicius}");
                }

                else
                {
                    Console.WriteLine("Neteisingas skaičius.");
                    Console.WriteLine("Įveskite sveikąjį skaičių:");
                    ivestasSkaicius = Console.ReadLine();
                }
            }
        }

        /*
        Sukurti metodą IntegerToBinary, 
        kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
        2 --> 10
        7 --> 111
        45 --> 101101
        */

        public static void IntegerToBinary()
        {
            Console.WriteLine("Įveskite teigiamą skaičių:");
            var teigiamasSkaicius = int.Parse(Console.ReadLine());
            var binarySkaicius = "";

            while (teigiamasSkaicius > 0)
            {
                binarySkaicius = teigiamasSkaicius % 2 + binarySkaicius;
                teigiamasSkaicius /= 2;
            }

            Console.WriteLine($"{binarySkaicius}");
        }

        /*
        Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
        laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
        kelsime, antras laipsnis, kuriuo pakelti.
        NB! kai skaičius 0 o laipsnis > 0 gąžinama 1
        NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
        NB! kai laipsnis = 1 gąžinamas tas pats skaičius
        */

        public static void PakeltiLaipsniu()
        {
            Console.WriteLine("Įveskite skaičių:");
            var skaicius = int.Parse(Console.ReadLine()); // 2

            Console.WriteLine("Įveskite laipsnį:");
            var laipsnis = int.Parse(Console.ReadLine()); // 3

            var skaiciusPakeltas = 1;

            for (int i = 1; i <= laipsnis; i++)
            {
                skaiciusPakeltas = skaiciusPakeltas * skaicius; // 1 * 2 = 2; 2 * 2 = 4; 4 * 2 = 8
            }

            if (laipsnis == 0 && skaicius > 0)
            {
                skaiciusPakeltas = 1;
            }

            if (skaicius == 0 && laipsnis == 0)
            {
                skaiciusPakeltas = 0;
            }

            if (laipsnis == 1)
            {
                skaiciusPakeltas = skaicius;
            }

            Console.WriteLine(skaiciusPakeltas);
        }

        /*
        Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */
        
        public static void SkaiciuTrikampis()
        {
            Console.Write("Įveskite skaičių nuo 1 iki 9: ");
            var ivestasSkaicius = int.Parse(Console.ReadLine());

            var arTeisingaskaicius = false;

            while (!arTeisingaskaicius) // NOT false = true

            {
                int skaiciusEiluteje;
                int skaiciusStulpelyje;

                if (ivestasSkaicius > 1 || ivestasSkaicius <= 9)
                {
                    for (skaiciusStulpelyje = 0; skaiciusStulpelyje < ivestasSkaicius; skaiciusStulpelyje++)
                    {

                        for (skaiciusEiluteje = 0; skaiciusEiluteje < skaiciusStulpelyje + 1; skaiciusEiluteje++)
                        {
                            Console.Write(ivestasSkaicius);
                        }

                        Console.WriteLine();
                        arTeisingaskaicius = true;
                    }
                }

                if (ivestasSkaicius < 1 || ivestasSkaicius > 9)
                {
                    Console.WriteLine("Netinkamas skaičius");
                    Console.Write("Įveskite skaičių nuo 1 iki 9:");
                    ivestasSkaicius = int.Parse(Console.ReadLine());
                }
            }   
        }

        /*
        Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        jeigu įveda netinkamą skaičių
        prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
        */

        public static void SkaiciuPiramide()
        {
            Console.Write("Įveskite skaičių nuo 1 iki 9: ");
            var ivestasSkaicius = int.Parse(Console.ReadLine());

            var arTeisingaskaicius = false;

            while (!arTeisingaskaicius)
            {
                int i;
                int j;
                
                if (ivestasSkaicius > 1 || ivestasSkaicius <= 9)
                {
                    StringBuilder sb = new StringBuilder();
                    
                    for (i = 0; i < ivestasSkaicius; i++)
                    {
                        sb.Append(ivestasSkaicius);
                        Console.WriteLine(sb.ToString());
                        
                        arTeisingaskaicius = true;
                    }

                    for (i = ivestasSkaicius; i >= 1; i--)
                    {
                        sb.Remove(0, 1);
                        Console.WriteLine(sb.ToString());

                        arTeisingaskaicius = true;
                    }

                }

                if (ivestasSkaicius < 1 || ivestasSkaicius > 9)
                {
                    Console.WriteLine("Netinkamas skaičius");
                    Console.Write("Įveskite skaičių nuo 1 iki 9: ");
                    ivestasSkaicius = int.Parse(Console.ReadLine());
                }
            }
        }

        /*
        Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
        Programa turi grąžinti atitinkamą statųjį trikampį.
        1
        22
        333
        4444
        55555
        */

        public static void DidejanciuSkaiciuStatusTrikampis()
        {
            Console.Write("Įveskite skaičių nuo 1 iki 9: ");
            var ivestasSkaicius = int.Parse(Console.ReadLine());

            var arTeisingaskaicius = false;

            while (!arTeisingaskaicius)
            {
                int i;
                int j;

                if (ivestasSkaicius > 1 || ivestasSkaicius <= 9)
                {
                    StringBuilder sb = new StringBuilder();

                    /*
                    for (i = 1; i <= ivestasSkaicius; i++)
                    {

                        for (j = 1; j <= i; j++) 
                        {
                            Console.Write(i);
                        }

                        Console.Write("\n");

                        arTeisingaskaicius = true;
                    }*/

                    
                    for (i = 1; i <= ivestasSkaicius; i++)
                    {
                        sb.Append(ivestasSkaicius);

                        for (j = 1; j <= i; j++) 
                        {
                            sb.Replace(ivestasSkaicius.ToString(), (i.ToString()));
                        }

                    Console.WriteLine(sb.ToString());

                    arTeisingaskaicius = true;
                    }

                }

                if (ivestasSkaicius < 1 || ivestasSkaicius > 9)
                {
                    Console.WriteLine("Netinkamas skaičius");
                    Console.Write("Įveskite skaičių nuo 1 iki 9: ");
                    ivestasSkaicius = int.Parse(Console.ReadLine());
                }
            }
        }

        /*
        Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
        Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
        1
        22
        333
        4444
        333
        22
        1
        */

        public static void DidejanciuSkaiciuPiramide()
        {
            Console.Write("Įveskite skaičių nuo 1 iki 9: ");
            var ivestasSkaicius = int.Parse(Console.ReadLine());

            var arTeisingaskaicius = false;

            while (!arTeisingaskaicius)

            {
                int i;
                int j;

                if (ivestasSkaicius > 1 || ivestasSkaicius <= 9)
                {

                    for (i = 1; i <= ivestasSkaicius; i++)
                    {

                        for (j = 1; j <= i; j++)
                        {
                            Console.Write(i);
                        }

                        Console.Write("\n");

                        arTeisingaskaicius = true;
                    }

                }

                if (ivestasSkaicius < 1 || ivestasSkaicius > 9)
                {
                    Console.WriteLine("Netinkamas skaičius");
                    Console.Write("Įveskite skaičių nuo 1 iki 9: ");
                    ivestasSkaicius = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}