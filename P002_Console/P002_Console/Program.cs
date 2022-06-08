namespace P002_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karolis"); //išveda į konsolę Karolis

            Console.WriteLine("Įveskite savo vardą:");
            Console.WriteLine($"Jūsų vardas: {Console.ReadLine()}");

            Console.WriteLine("Įveskite savo vardą:");
            Console.WriteLine();
            var firstLetter = Console.ReadKey();
            Console.WriteLine($"Pirmosios vardo raidės ASCII kodas: {(int)Console.ReadKey().KeyChar}");

            Console.WriteLine("Įveskite savo vardą:");
            var name = Console.ReadKey().Key;
            Console.WriteLine($"Pirmoji vardo raidė: {name}");

            Console.WriteLine("Įveskite skaičių:");
            var anyNumber = Console.ReadLine();
            Console.WriteLine($"Raidės ir skaičiaus suma: {name}{anyNumber}");
        }
    }
}