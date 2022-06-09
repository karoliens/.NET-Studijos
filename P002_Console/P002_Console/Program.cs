namespace P002_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Išveskite į konsolę savo vardą
            
            Console.WriteLine("Karolis\n");

            //Nuskaitykite iš klaviatūros savo vardą ir išveskite į konsolę

            Console.WriteLine("Įveskite savo vardą:");
            Console.WriteLine($"\nJūsų vardas: {Console.ReadLine()}");

            //Nuskaitykite iš klaviatūros savo vardo pirmąją raidę ir išveskite į konsolę jos ASCII kodą

            Console.WriteLine("\nĮveskite savo vardo pirmą raidę ir bus išvestas ASCII kodas:");
            Console.WriteLine($"\nPirmosios vardo raidės ASCII kodas: {(int)Console.ReadKey().Key}");

            //Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą. Pabandykite šį skaičių išvesti įvairiais formatais

            Console.WriteLine("\nIveskite savo vardo pirmaja raide ir betkoki skaiciu:");
            Console.WriteLine($"\nRezultatas yra: {(int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar - 48}");

            //Padarykite konsolės meniu skirtingose eilutėse(1) Pirkti, (2) Parduoti, (3) Likučiai. Išveskite pasirinktą meniu punktą

            Console.WriteLine("\n(1) Pirkti\n(2) Parduoti\n(3) Likučiai");
            Console.WriteLine(Console.ReadKey());

            //Parašykite programą, kuri žodžio LABAS kiekvieną raidę išveda naujoje eilutėje

            Console.WriteLine("\nL\nA\nB\nA\nS");

            //Parašykite programą, kuri žodžio LABAS kiekvieną raidę nutolusią per vieną tab'ą

            Console.WriteLine("\nL\tA\tB\tA\tS");

            //Parašykite programą, kuri žodį LABAS išveda kabutėse.Dviem būdais - naudodami escape ir HEX simbolio kodą

            Console.WriteLine("\n\"LABAS\"");
            Console.WriteLine("\u0022LABAS\u0022");

            //Parašykite programą, kuri nuskaito jūsų vardą ir išveda antrą raidę

            Console.WriteLine("\nKoks Jusu vardas?");;
            Console.WriteLine($"Jusu vardo antra raide yra: {Console.ReadLine()[1]}");

            //Parašykite programą, kuri nuskaito jūsų vardą ir išveda raidžių kiekį

            Console.WriteLine("\nKoks Jusu vardas?");
            Console.WriteLine($"Jusu varda sudaro: {Console.ReadLine().Length} raides");

            //Parašykite programą kuri nuskaito jūsų vardą ir raidžių kiekį.

            Console.WriteLine("\nKoks Jusu vardas?");
            Console.WriteLine($"|\t{Console.ReadLine()} |\t{Console.ReadLine().Length} |");

            //Parašykite programą kuri nuskaito jūsų vardą ir jį išveda 3 eilutėm žemiau(naudoti newline)

            Console.WriteLine("\nKoks Jusu vardas?");
            Console.WriteLine($"\n\n\n{Console.ReadLine()}");

            //Nupieškiteveiduką

            Console.WriteLine(@"
           ****************
        **                  **
       **    ()       ()      **
      **          |           **
     **           |            **
      **     *    |     *     **
       **     *        *      **
        **     * * * *       **
         **                **
          ****************");

            //Veiduke visas žvaigždutes pakeiskite dvigubomis kabutėmis

            Console.WriteLine(@"
           ****************
        **                  **
       **    ()       ()      **
      **          |           **
     **           |            **
      **     *    |     *     **
       **     *        *      **
        **     * * * *       **
         **                **
          ****************".Replace("*", "\""));
        }
    }
}