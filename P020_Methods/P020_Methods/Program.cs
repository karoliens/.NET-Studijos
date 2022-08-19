namespace P020_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hobis = new Hobis();
            {
                hobis.Tekstas = "Futbolas";
            }

            hobis.Tekstas = "Krepšinis";

            var profesija = new Profesija();
            {
                profesija.Tekstas = "Mokytojas";
            }

            profesija.Tekstas = "Statybininkas";
        }
    }
}