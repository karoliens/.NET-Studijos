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

            Console.WriteLine("Įveskite gimimo datą YYYY-MM-DD:");
            var gimimoDataIvesta = Console.ReadLine();


            var pirmasAkSkaicius = int.Parse(asmensKodas.ToString()[..1]);

            var gimimoDataIsAk18 = asmensKodas.ToString()[..1].Replace("1", "18").Replace("2", "18");
            var gimimoDataIsAk19 = asmensKodas.ToString()[..1].Replace("3", "19").Replace("4", "19");
            var gimimoDataIsAk20 = asmensKodas.ToString()[..1].Replace("5", "20").Replace("6", "21");

            var gimimoDataIsAk18Pilna = int.Parse(gimimoDataIsAk18 + asmensKodas.Substring(1, 6));
            var gimimoDataIsAk19Pilna = int.Parse(gimimoDataIsAk19 + asmensKodas.Substring(1, 6));
            var gimimoDataIsAk20Pilna = int.Parse(gimimoDataIsAk20 + asmensKodas.Substring(1, 6));

            Console.WriteLine(gimimoDataIsAk19Pilna);

            var data = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            var amziusIsAk19 = (data - gimimoDataIsAk19Pilna) / 10000;

            Console.WriteLine(amziusIsAk19);


            //Spausdinimas
            /*
            Console.WriteLine($"ATASKAITA APIE ASMENĮ\n{data:d}");
            Console.WriteLine($"Vardas, pavardė {vardasIrPavarde}");

            //Lyties nustatymas
            /*
            if (pirmasAkSkaicius == 1 || pirmasAkSkaicius == 3 || pirmasAkSkaicius == 5)
            {
                var lytis = "Vyras";
                Console.WriteLine($"Lytis {lytis}");
            }

            else
            {
                var lytis = "Moteris";
                Console.WriteLine($"Lytis {lytis}");
            }*/
           
            //Asmens kodo simbolių apribojimas
            /*
            if (asmensKodas.ToString().Length < 11 || asmensKodas.ToString().Length < 11)
            {
                Console.WriteLine("Klaida");
            }

            else
            {
                Console.WriteLine($"Asmens kodas {asmensKodas}");
            }
            */

            //Console.WriteLine("Amžiaus patikimumas");

            if (!string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta)) //Šitas blokas tikrina kas įvesta
            {
                Console.WriteLine("Įvestas ir amžius ir gimimo data");
                if (pirmasAkSkaicius == 1 || pirmasAkSkaicius == 3 || pirmasAkSkaicius == 5) //Šitas blokas nustato lytį
                {
                    Console.WriteLine($"Lytis: Vyras");

                    if (pirmasAkSkaicius == 1) //Šitas blokas nustato gimimo datą
                    {
                        Console.WriteLine("18");
                    }

                    else if (pirmasAkSkaicius == 3)
                    {
                        Console.WriteLine("19");
                    }

                    else
                    {
                        Console.WriteLine("20");
                    }

                }
                else
                {
                    Console.WriteLine($"Lytis Moteris");

                    if (pirmasAkSkaicius == 2)
                    {
                        Console.WriteLine("18");
                    }

                    else if (pirmasAkSkaicius == 4)
                    {
                        Console.WriteLine("19");
                    }

                    else
                    {
                        Console.WriteLine("20");
                    }
                }
            }

            else if (!string.IsNullOrEmpty(amziusIvestas) || !string.IsNullOrEmpty(gimimoDataIvesta)) //Tikrina kas įvesta
            {
                Console.WriteLine("Įvestas arba amžius arba gimimo data");
            }

            else
            {
                Console.WriteLine("Patikimumui trūksta duomenų"); //Jei niekas neįvesta
            }

            
            //Console.WriteLine($"Amžius {amzius}");
            
            //Console.WriteLine($"Gimimo data {gimimoData}");*/
        }
    }
}