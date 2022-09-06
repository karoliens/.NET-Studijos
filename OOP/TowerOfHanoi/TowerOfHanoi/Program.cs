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

            var selectedStack = new Stack();
            selectedStack.GetSelectedStack(1);

            var disk = new Disk();
            disk.Move(4, from, to);
        }
    }
}