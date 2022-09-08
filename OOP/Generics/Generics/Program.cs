using Generics.Domain.Interfaces;
using Generics.Domain.Models;
using Generics.DomainTests.Models;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzduotis 1Sukurkite generic klase <Cordinate>, kuri gali buti bet kokio tipo (int, string, double, datetime) kordinate x ir y asyse. Jusu klase turetu tureti generic konstruktoriu, kuris gali priimti, bet kokio tipo x ir y kordinates. X ir y pozicijas galima keisti ir kituose projektuose kreipiantis i objekta. Paveldekite is <ICordinate> interface, kuris savyje turi: string GetCordinate() // grazina x ir y kordinates viename stringe//, void ResetCordinate() // grazina default reiksmes// metodus. Irodykite veikima sukurdami 3 atskirus objektus. Pirmas objektas su string, antras su int, trecias su dateTime. Testai turetu patikrinti abu metodus ir bent 3 skirtingais duomenu tipais inicializuotas reiksmes (Siem testam pasitelkite GetCordinate metoda)

            Uzduotis 3Pries uzduotis susikurti 3 klases: PrivateClient, Administrator, BusinessClient. Visos jos paveldeja is interface IUser (int Id get set, string Name get set, )Sukurti generic <EntityRepository> klase, kuri priimtu klases su tusciu konstruktoriumi duomenu tipa ir turetu metodus: Add, Remove, Print(), Fetch(). Repository savyje turi tureti generic sarasa, kuris priimtu sias 3 klases: PrivateClient, Administrator, BusinessClient. Tam, kad igyvendintumete salyga naudokite interface kaip duomenu tipa savo repository objektui. Veikima irodykite testu pagalba(Isskyrus print) ir Main() metode idekite naujai sukurtus 3 objektus (Kiekvienai klasei po viena) 
            */

            Cordinate<string> cordinateString = new Cordinate<string>("2", "5"); 
            Cordinate<int> cordinateInt = new Cordinate<int>(10, 20);
            Cordinate<DateTime> cordinateDateTime = new Cordinate<DateTime>(new DateTime(1987, 06, 05), new DateTime(2000, 06, 05));

            var administrator = new EntityRepository<IUser>();
            var businessClient = new EntityRepository<IUser>();
            var privateClient = new EntityRepository<IUser>();
        }
    }
}