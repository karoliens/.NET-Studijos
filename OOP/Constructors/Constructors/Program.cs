namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje (P030) po 3 konstruktorius
            */

            var namas = new Namas();
            namas.plotas = 200;
            Console.WriteLine($"{namas.plotas}\n{namas.vieta}");

            var namas1 = new Namas()
            {
                plotas = 300,
                kambariuSkaicius = 2,
            };

            var stogas = new Stogas();
            stogas.Medziaga = "Metalas";

            namas1.Stogas = stogas;

            Console.WriteLine($"{namas1.Stogas.Medziaga}");

            Console.WriteLine($"{namas1.plotas}");

            var namas3 = new Namas(100, "Vilnius");
        }
    }
}