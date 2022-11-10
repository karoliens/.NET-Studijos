using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            SUKURTI ŽAIDIMĄ TOWER OF HANOI
            Tower Of Hanoi
             Ėjimas 0

               Diskas rankoje: 

              1eil.       |            |            |      
              2eil.      #|#           |            |      
              3eil.     ##|##          |            |      
              4eil.    ###|###         |            |      
              5eil.   ####|####        |            |      
                    -----[1]----------[2]----------[3]------

              Norėdami išeiti paspauskite 'Esc' 
              Pagalbai paspauskite 'H' 
              Pasirinkite stulpelį iš kurio paimti
            */
            /*
            Console.WriteLine("Pasirinkite stulpelį iš kurio paimti");

            var from = Console.ReadLine();

            if(int.TryParse(from, out int _))
            {

            }

            else
            {
                Console.WriteLine("Klaida! Neteisinga įvestis");
            }

            Console.WriteLine("Pasirinkite stulpelį į kurį padėti");

            var to = Console.ReadLine();

            if (int.TryParse(to, out int _))
            {
                
            }

            else
            {
                Console.WriteLine("Klaida! Neteisinga įvestis");
            }
            */
            /*
            Console.WriteLine("Tower Of Hanoi");

            Console.WriteLine("Ėjimas");

            Console.WriteLine("Diskas rankoje:");

            Console.WriteLine("Pasirinkite stulpelį iš kurio paimti");
            */

            Game newGame = new Game();
            // Stack firstStack = newGame.FirstStack;
            Stack secondStack = newGame.SecondStack;
            Stack thirdStack = newGame.ThirdStack;

            Stack firstStack = new Stack();

            Disk disk1 = new Disk(2);
            Disk disk2 = new Disk(4);
            Disk disk3 = new Disk(6);
            Disk disk4 = new Disk(8);

            firstStack.AddDisk(disk1);
            firstStack.AddDisk(disk2);
            firstStack.AddDisk(disk3);
            firstStack.AddDisk(disk4);


            var selectedDisk1 = firstStack.RemoveDisk();
            var selectedDisk2 = firstStack.RemoveDisk();

            secondStack.AddDisk(selectedDisk1);
            thirdStack.AddDisk(selectedDisk2);
            
            for (int i = 3; i >= 0; i--) // einam per keturias Stack eilutes
            {
                var firstStackDisk = firstStack.GetDisk(i);
                var secondStackDisk = secondStack.GetDisk(i);
                var thirdStackDisk = thirdStack.GetDisk(i);

                Console.Write($"{firstStackDisk}");
                Console.Write($"{secondStackDisk}");
                Console.WriteLine($"{thirdStackDisk}");
            }
            
            /*
            foreach (Disk disk in firstStack.Disks)
            {
                Console.WriteLine($"{disk.DiskSize.ToString()}");
            }

            Console.WriteLine("_____________________");

            foreach (Disk disk in secondStack.Disks)
            {
                Console.WriteLine($"{disk.DiskSize}");
            }

            Console.WriteLine("_____________________");

            foreach (Disk disk in thirdStack.Disks)
            {
                Console.WriteLine($"{disk.DiskSize}");
            }
            */
            // secondStack.AddDisk(disk4);

            // var input = Console.ReadLine();
            /*
            switch (input)
            {
                case "1":
                // firstStack
                    Console.WriteLine($"{disk1.DiskSize.ToString()}");
                    Console.WriteLine($"{disk2.DiskSize.ToString()}");
                    Console.WriteLine($"{disk3.DiskSize.ToString()}");
                    Console.WriteLine($"{disk4.DiskSize.ToString()}");
                    break;
                case "2":
                    // secondStack
                case "3":
                    // thirdStack
                default:
                    Console.WriteLine("Klaida! Neteisinga įvestis");
                break;
            }
            */

            // Console.WriteLine(firstStack.Disks.Count().ToString());
            // Console.WriteLine(secondStack.Disks.ToString());
            // Console.WriteLine(thirdStack.Disks);

            // Console.WriteLine($"Diskas rankoje: {selectedDisk.DiskSize}");

            /*
            if (firstStack.CountDisks() == null)
            {
                Console.WriteLine("Stulpelyje nėra disko");
            }
            */
        }
    }
}