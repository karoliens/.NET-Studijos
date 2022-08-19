namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirbtiSuPirmaUzduotimi();
        }

        public static void DirbtiSuPirmaUzduotimi()
        {
            Zmogus zmogus = new Zmogus();
            zmogus.akiuSpalva = "Mėlyna";
            zmogus.vardas = "Ričardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Kelionės";

            Console.WriteLine($"zmogus.akiuSpalva:{zmogus.akiuSpalva}\nzmogus.vardas:{zmogus.vardas}\nzmogus.pavarde:{zmogus.pavarde}\nzmogus.pareigos:{zmogus.pareigos}\nzmogus.megstamiausiasHobis:{zmogus.megstamiausiasHobis}");

            var masina = new Masina()
            {
                Modelis = "Corolla",
                Gamintojas = "Toyota",
                ArDrausta = true,
                DidziausiasGreitis = 100,
                EmisijuKiekis = 0,
                // KedziuKiekis = 4,
                // Spalva = "Raudona",
                VariklioTipas = "Elektrinis"
            };

            Console.WriteLine($"Modelis:{masina.Modelis}\n{masina.Gamintojas}");

            var ismaniejiTelefonai = new Dictionary<int, string>();
            var samsung = new IsmanusisTelefonas();
            var iPhone = new IsmanusisTelefonas();
            // ismaniejiTelefonai.Add(1)

            Namas namas = new Namas();
            namas.kambariuSkaicius = 4;
            namas.vieta = "Vilnius";
            namas.plotas = 100;
            namas.stogas = new Stogas()
            {
                Spalva = "Raudona",
                Kaina = 100
            };

            Console.WriteLine($"namas.vieta:{namas.vieta}namas.stogas.Spalva:{namas.stogas.Spalva}namas.stogas.Kaina:{namas.stogas.Kaina}");

            var salis = new Salis()
            {
                Plotas = 100,
                GyventojuSkaicius = 1000,
                Kalba = "lietuvių"
            };

            salis.miestas = new Miestas()
            {
                Koordinates = 100,
                Dydis = 200,
            };

            Console.WriteLine($"salis.miestas.Koordinates:{salis.miestas.Koordinates}salis.miestas.Dydis:{salis.miestas.Dydis}");

            var knyga = new Dictionary<int, Knyga>();

            var trysParsiukai = new Knyga();
            var liutasKaralius = new Knyga();
            knyga.Add(1, trysParsiukai);
            knyga.Add(2, liutasKaralius);

            knyga[1].bukle = new Bukle()
            {

            };
        }
    }
}