using SQLDB.Infrastructure.Database;
using SQLDB.Infrastructure.Interfaces;

namespace SQLDB
{
    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                Console.WriteLine($"\n1.Add new user\n2.Display all users\nq.Quit");

                char selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                    Console.WriteLine($"Name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine($"Last name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine($"\nAge: (Example: 2000/01/01)");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());
                    _bloggingRepository.AddPerson(firstName, lastName, birthDate);

                    break;
                    case '2':
                    _bloggingRepository.PrintAllPersons();
                    break;
                    case 'q':
                    return;
                    default:
                    Console.WriteLine("Input incorrect. Please try again.");
                    break;
                }
            }
        }
    }
}