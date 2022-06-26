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

            var gimimoDataIsAk18 = asmensKodas.ToString()[..1].Replace("1", "18").Replace("2", "18");
            var gimimoDataIsAk19 = asmensKodas.ToString()[..1].Replace("3", "19").Replace("4", "19");
            var gimimoDataIsAk20 = asmensKodas.ToString()[..1].Replace("5", "20").Replace("6", "21");

            var gimimoDataIsAk18Pilna = int.Parse(gimimoDataIsAk18 + asmensKodas.Substring(1, 6));
            var gimimoDataIsAk19Pilna = int.Parse(gimimoDataIsAk19 + asmensKodas.Substring(1, 6));
            var gimimoDataIsAk20Pilna = int.Parse(gimimoDataIsAk20 + asmensKodas.Substring(1, 6));

            var data = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            var amziusIsAk18 = (data - gimimoDataIsAk18Pilna) / 10000;
            var amziusIsAk19 = (data - gimimoDataIsAk19Pilna) / 10000;
            var amziusIsAk20 = (data - gimimoDataIsAk20Pilna) / 10000;


            //Spausdinimas


            Console.WriteLine("ATASKAITA APIE ASMENĮ");
            Console.WriteLine(data);
            Console.WriteLine(vardasIrPavarde);

            //Tikrina kas įvesta - tik amžius, tik gimimoa data, abu, nieko


            //Įvesta ir amžius, ir gimimo data
            if (!string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta))
            {
                //Console.WriteLine("Įvestas ir amžius ir gimimo data");
                //Tikrina lytį
                if (pirmasAkSkaicius == 1 || pirmasAkSkaicius == 3 || pirmasAkSkaicius == 5)
                {
                    Console.WriteLine($"Lytis: Vyras");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas vyro amžius ir gimimo data patikimi
                    if (amziusIvestas.Equals(amziusIsAk18.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk18.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }

                }
                else
                {
                    Console.WriteLine($"Lytis Moteris");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas  moters amžius ir gimimo data patikimi
                    if (amziusIvestas.Equals(amziusIsAk18.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()) && gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius tikras");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk18.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()) || gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius nepatikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }
                }
            }

            //Įvestas tik amžius
            else if (!string.IsNullOrEmpty(amziusIvestas) && string.IsNullOrEmpty(gimimoDataIvesta))
            {
                //Console.WriteLine("Įvestas tik amžius");
                //Tikrina lytį
                if (pirmasAkSkaicius == 1 || pirmasAkSkaicius == 3 || pirmasAkSkaicius == 5)
                {
                    Console.WriteLine($"Lytis: Vyras");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas vyro amžius patikimas. Lygina amžių.
                    if (amziusIvestas.Equals(amziusIsAk18.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }

                }
                else
                {
                    Console.WriteLine($"Lytis Moteris");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas moters amžius patikimas. Lygina amžių.
                    if (amziusIvestas.Equals(amziusIsAk18.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk19.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (amziusIvestas.Equals(amziusIsAk20.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }
                }
            }

            //Įvesta tik gimimo data
            else if (string.IsNullOrEmpty(amziusIvestas) && !string.IsNullOrEmpty(gimimoDataIvesta))
            {
                //Console.WriteLine("Įvesta tik gimimo data");
                //Tikrina lytį

                if (pirmasAkSkaicius == 1 || pirmasAkSkaicius == 3 || pirmasAkSkaicius == 5)
                {
                    Console.WriteLine($"Lytis: Vyras");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas vyro amžius patikimas. lygina gimimo datą.
                    if (gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }

                }
                else
                {
                    Console.WriteLine($"Lytis Moteris");
                    Console.WriteLine($"Asmens kodas {asmensKodas}");
                    Console.WriteLine($"Amžius {amziusIvestas}");
                    Console.WriteLine($"Gimimo data {gimimoDataIvesta}");

                    //Tikrina ar įvestas moters amžius patikimas. Lygina gimimo datą.
                    if (gimimoDataIvesta.Equals(gimimoDataIsAk18Pilna.ToString()))
                    {
                        Console.WriteLine("Amžiaus patikimumas amžius patikimas");
                    }

                    else if (gimimoDataIvesta.Equals(gimimoDataIsAk19Pilna.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else if (gimimoDataIvesta.Equals(gimimoDataIsAk20Pilna.ToString()))
                    {
                        Console.WriteLine("amžius patikimas");
                    }

                    else
                    {
                        Console.WriteLine("amžius pameluotas");
                    }
                }
            }

            else
            {
                //Neįvestas nei amžius, nei gimimo data
                Console.WriteLine("Patikimumui trūksta duomenų");
            }
        }
    }
}