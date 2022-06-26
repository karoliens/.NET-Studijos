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

            var data = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            var lytis = pirmasAkSkaicius switch
            {
                1 or 3 or 5 => "Vyras",
                2 or 4 or 6 => "Moteris"
            };

            var gimimoData = pirmasAkSkaicius switch
            {
                1 or 2 => "18" + asmensKodas.Substring(1, 6),
                3 or 4 => "19" + asmensKodas.Substring(1, 6),
                5 or 6 => "20" + asmensKodas.Substring(1, 6),
            };

            var amzius = (data - int.Parse(gimimoData)) / 10000;


            //Spausdinimas

            Console.WriteLine("ATASKAITA APIE ASMENĮ");
            Console.WriteLine(data);
            Console.WriteLine($"Vardas, pavardė {vardasIrPavarde}");
            Console.WriteLine($"Lytis: {lytis}");
            Console.WriteLine($"Asmens kodas {asmensKodas}");
            Console.WriteLine($"Amžius {amziusIvestas}");
            Console.WriteLine($"Gimimo data {gimimoDataIvesta}");
            Console.Write("Amžiaus patikimumas ");

            //Tikrina kas įvesta - tik amžius, tik gimimo data, abu, nieko
            //Įvesta ir amžius, ir gimimo data
            if (!string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta))
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