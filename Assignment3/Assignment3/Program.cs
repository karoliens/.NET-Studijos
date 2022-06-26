namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
          Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
          Vartotojas įveda:
           - vardą ir pavardę 
           - asmens kodą (11simb.)
           - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
         Programa į ekraną išveda ataskatą:
          - šiandienos datą
          - Vardas, pavardė
          - Lytis
             <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį 
             (1 – XIX a. gimęs vyras, 
              2 – XIX a. gimusi moteris, 
              3 – XX a. gimęs vyras,
              4 – XX a. gimusi moteris, 
              5 – XXI a. gimęs vyras,
              6 – XXI a. gimusi moteris
              tolesni šeši: 
                   metai (du skaitmenys), 
                   mėnuo (du skaitmenys), 
                   diena (du skaitmenys))     
          - Asmens kodas 
             <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                Paskaičiuojamas Kontrolinis skaičius 
                a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                b) jei neteisingas išvedamas tekstas "kodas neteisingas", 
                   o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų" 
                   <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
          - Amžius
          - Amžiaus patikimumas - pagal tokias sąlygas:
          -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu. 
             a) jei sutampa išvesti "amžius patikimas"
             b) jei nesutampa išvesti "amžius pameluotas"
          - jei įvesta gimimo data sulyginti su įvestu asmens kodu. 
             a) jei sutampa išvesti "amžius patikimas" 
             b) jei nesutampa išvesti "amžius pameluotas"
          - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu. 
             a) jei viskas sutampa išvesti "amžius tikras" 
             b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas" 
             c) jei nesutampa išvesti "amžius pameluotas"
          - jei neįvesta nei amžius nei gimimo data išvesti
             a) "patikimumui trūksta duomenų"
Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
          */


            Console.WriteLine("Įveskite vardą ir pavardę:");
            var vardasIrPavarde = Console.ReadLine();

            Console.WriteLine("Įveskite asmens kodą:");
            var asmensKodas = (Console.ReadLine());

            Console.WriteLine("Įveskite amžių:");
            var amziusIvestas = Console.ReadLine();

            Console.WriteLine("Įveskite gimimo datą yyyyMMdd:");
            var gimimoDataIvesta = Console.ReadLine();


            var pirmasAkSkaicius = int.Parse(asmensKodas.ToString()[..1]);
            var paskutinisAkSkaicius = int.Parse(asmensKodas.Substring(10));


            var data = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            var lytis = pirmasAkSkaicius switch
            {
                1 or 3 or 5 => "Vyras",
                2 or 4 or 6 => "Moteris",
                _ => "Nežinoma"
            };

            var gimimoData = pirmasAkSkaicius switch
            {
                1 or 2 => "18" + asmensKodas.Substring(1, 6),
                3 or 4 => "19" + asmensKodas.Substring(1, 6),
                5 or 6 => "20" + asmensKodas.Substring(1, 6),
            };

            var amzius = (data - int.Parse(gimimoData)) / 10000;

            //Kintamieji, reikalingi asmenens kodo validavimui
            var index0 = int.Parse(asmensKodas.Substring(0, 1));
            var index1 = int.Parse(asmensKodas.Substring(1, 1));
            var index2 = int.Parse(asmensKodas.Substring(2, 1));
            var index3 = int.Parse(asmensKodas.Substring(3, 1));
            var index4 = int.Parse(asmensKodas.Substring(4, 1));
            var index5 = int.Parse(asmensKodas.Substring(5, 1));
            var index6 = int.Parse(asmensKodas.Substring(6, 1));
            var index7 = int.Parse(asmensKodas.Substring(7, 1));
            var index8 = int.Parse(asmensKodas.Substring(8, 1));
            var index9 = int.Parse(asmensKodas.Substring(9, 1));

            var suma1 = index0 * 1 + index1 * 2 + index2 * 3 + index3 * 4 + index4 * 5 + index5 * 6 + index6 * 7 + index7 * 8 + index8 * 9 + index9 * 1;
            var suma2 = index0 * 3 + index1 * 4 + index2 * 5 + index3 * 6 + index4 * 7 + index5 * 8 + index6 * 9 + index7 * 1 + index8 * 2 + index9 * 3;

            var liekana1 = suma1 % 11;
            var liekana2 = suma2 % 11;

            var kontrolinisSkaicius = 0;


            /*
            Kontrolinis skaičius
            Jei asmens kodas užrašomas ABCDEFGHIJK, tai:

            S = A*1 + B*2 + C*3 + D*4 + E*5 + F*6 + G*7 + H*8 + I*9 + J*1

            Suma S dalinama iš 11, ir jei liekana nelygi 10, ji yra asmens kodo kontrolinis skaičius K. Jei liekana lygi 10, tuomet skaičiuojama nauja suma su tokiais svertiniais koeficientais:

            S = A*3 + B*4 + C*5 + D*6 + E*7 + F*8 + G*9 + H*1 + I*2 + J*3

            Ši suma S vėl dalinama iš 11, ir jei liekana nelygi 10, ji yra asmens kodo kontrolinis skaičius K. Jei vėl liekana yra 10, kontrolinis skaičius K yra 0.
            */


            //Spausdinimas

            Console.WriteLine("ATASKAITA APIE ASMENĮ");
            Console.WriteLine(data);
            Console.WriteLine($"Vardas, pavardė:    \t{vardasIrPavarde}");
            Console.WriteLine($"Lytis:              \t{lytis}");

            //Asmens kodo validavimas

            if (liekana1 != 10)
            {
                kontrolinisSkaicius = liekana1;
                //Console.WriteLine(kontrolinisSkaicius);
            }

            else
            {

                if (liekana2 != 10)
                {
                    kontrolinisSkaicius = liekana2;
                    //Console.WriteLine(kontrolinisSkaicius);
                }

                else
                {
                    kontrolinisSkaicius = 0;
                    //Console.WriteLine(kontrolinisSkaicius);
                }
            }

            if (paskutinisAkSkaicius == kontrolinisSkaicius)
            {
                Console.WriteLine($"Asmens kodas:   \t{asmensKodas}");
            }

            else
            {
                Console.WriteLine("Asmens kodas:    \tkodas neteisingas");
            }

            Console.WriteLine($"Amžius:             \t{amziusIvestas}");
            Console.WriteLine($"Gimimo data:        \t{gimimoDataIvesta}");
            Console.Write("Amžiaus patikimumas:    ");

            //Tikrina kas įvesta - tik amžius, tik gimimo data, abu, nieko
            //Įvesta ir amžius, ir gimimo data

            if (paskutinisAkSkaicius != kontrolinisSkaicius)
            {
                Console.WriteLine("patikimumui trūksta duomenų");
            }

            else if (!string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta))
            {

                //Įvesto amžiaus ir gimimo datos tikrinimas pagal asmens kodą

                if (int.Parse(amziusIvestas) == amzius && gimimoDataIvesta == gimimoData)
                {
                    Console.WriteLine("amžius tikras");
                }

                else if (int.Parse(amziusIvestas) == amzius || gimimoDataIvesta == gimimoData)
                {
                    Console.WriteLine("amžius nepatikimas");
                }

                else
                {
                    Console.WriteLine("amžius pameluotas");
                }
            }

            //Įvestas tik amžius

            else if (!string.IsNullOrEmpty(amziusIvestas) && string.IsNullOrEmpty(gimimoDataIvesta))
            {

                //Įvesto amžiaus tikrinimas pagal asmens kodą

                if (int.Parse(amziusIvestas) == amzius)
                {
                    Console.WriteLine("amžius patikimas");
                }

                else
                {
                    Console.WriteLine("amžius pameluotas");
                }
            }

            //Įvesta tik gimimo data

            else if (string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta))
            {

                //Įvestos gimimo datos tikrinimas pagal asmens kodą

                if (gimimoDataIvesta == gimimoData)
                {
                    Console.WriteLine("amžius patikimas");
                }

                else
                {
                    Console.WriteLine("amžius pameluotas");
                }
            }

            //Neįvestas nei amžius, nei gimimo data

            else
            {
                Console.WriteLine("Patikimumui trūksta duomenų");
            }
            }
        }
    }