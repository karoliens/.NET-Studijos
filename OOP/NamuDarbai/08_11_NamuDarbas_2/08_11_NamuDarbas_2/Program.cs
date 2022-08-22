namespace _08_11_NamuDarbas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2.    Parasykite klase „Skaiciuoklis“, kuris turetu 1 private property pavadinimu Skaicius ir 3 metodus: Didinti (Padidina Skaicius 1), Mazinti(Sumazina Skaicius 1), Atspausdinti()
            a.   Padarykite, kad Mazinti() metodas negaletu sumazinti <Skaicius> maziau 0
            b.    Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti <Skaicius> i pradine busena (Perkrauti metodas turetu nepriimti jokiu parametru)

            3. Sukurkite „Produktas“ klase, kuri turetu 3 properties su pasleptais seteriais – Kaina, kiekis, pavadinimas. Sukurkite
            „Produktas“ metoda void SpausdintiProdukta(), kuris atspausdintu informacija apie produkta tokiu formatu „Kivis kaina 1,50$: 3 vnt“

            4. Pasirašyti klasę <SkaiciuKrepselis>, kuris turėtų <private List<int>> skaiciu sarasa. Skaiciu sąrašui užpildyti sukurkite naują metodą <void PridėtiSkaiciu(int skaicius)>. Taip pat sukurkite
            naują metodą <double ApskaiciuotiVidurki()>, kuris apskaiciuoja visu sarase esanciu skaiciu vidurki.

            5. Parašyti po 1 metoda kiekvienai iš jūsų <Kambarys> namų darbo klasei (~12 klasių). Stenkitės pasipraktuokuoti skirtingus gražinimo duomenų tipus ir gal net vienam ar kitam metodui pridėkite po kokį nors parametrą.Papildomai galite ~6 klasėms sukurti po konstruktorių, kuris kelis jūsų pasirinktus <private set> properties(Siuo metu visi yra public) inicijuotų per kontruktoriu paduotas reiksmes.
            */

            var skaicius = new Skaiciuoklis(5);

            //skaicius.Mazinti();
            //skaicius.Didinti();
            //skaicius.Didinti();
            //skaicius.Didinti();
            /*skaicius.Atspausdinti();
            skaicius.Didinti();
            skaicius.Didinti();
            skaicius.Atspausdinti();
            skaicius.Perkrauti();
            skaicius.Atspausdinti();
            skaicius.Atspausdinti();

            */
            var produktas = new Produktas();




            Console.WriteLine(produktas.Kaina);
        }
    }
}