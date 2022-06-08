namespace P002_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Išveskite į konsolę savo vardą

            //Console.WriteLine("Karolis");

            //Nuskaitykite iš klaviatūros savo vardą ir išveskite į konsolę

            //Console.WriteLine("Įveskite savo vardą:");
            //Console.WriteLine($"Jūsų vardas: {Console.ReadLine()}");

            //Nuskaitykite iš klaviatūros savo vardo pirmąją raidę ir išveskite į konsolę jos ASCII kodą

            //Console.WriteLine("Įveskite savo vardo pirmą raidę ir bus išvestas ASCII kodas:");
            //Console.WriteLine($"\tPirmosios vardo raidės ASCII kodas:{(int)Console.ReadKey().Key}");

            //Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą. Pabandykite šį skaičių išvesti įvairiais formatais

            Console.WriteLine("Įveskite savo vardo pirmą raidę:");
            var firstLetter = Console.ReadKey().Key;
            Console.WriteLine($"\tPirmosios vardo raidės ASCII kodas:{(int)firstLetter}");

            Console.WriteLine("Įveskite skaičių:");
            var anyNumber = Console.ReadLine();
            Convert.ToInt32(anyNumber);
            Console.WriteLine($"\tĮvestas skaičius:{anyNumber}");




            //Console.WriteLine("(1) Pirkti\n(2) Parduoti\n(3) Likučiai", );


            //Console.WriteLine("\"LABAS\"");
            //Console.WriteLine("\u0022LABAS\u0022");


            //Console.WriteLine("Karolis");



            //Console.WriteLine("     " + Console.ReadLine().Length);
            //Console.WriteLine("Karolis" + Console.ReadLine().Length);

            //Console.WriteLine("\t*********************");
            //Console.WriteLine("\t**\t\t**");

            Console.Read(););
        }
    }
}