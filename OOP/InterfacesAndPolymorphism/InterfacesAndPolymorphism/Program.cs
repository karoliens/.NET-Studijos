namespace InterfacesAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Uzduotis 1: Sukurkite klasę Skaicius . Savyje turi tik readonly kintamąjį kuriame saugoma reikšmė sveikasis skaičius.
            - Sukurkite interfeisą IMatematika . 
            - Interfeise aprašykite metodus: (Pridėti, Atimti, Padauginti, Padalinti --> metodams bus paduodamas sveikasis skaičius ir bus grąžinama reikšmė),
            - PakeltiKvadratu , PakeltiKubu --> metodai grąžina reikšmes.
            - Klasė Skaicius paveldi interfeisą . 
            - Implementuokite paveldėtus metodus.
            Irodyti veikima parasant testus kiekvienam metodui.

            Uzduotis 2. - Sukurti klasę Figura , kuri saugo pavadinimą readonly propertyje
            - Sukurti interfeisą IGeometrija , kurioje aprašyti du metodai Plotas ir Perimetras. Abu grąžina double reikšmes.
            - Sukurti klases: Kvadratas, Staciakampis , Statusis Trikampis ir Apskritimas 
            (klasėse susikurti reikiamus properčius fieldus visi jie turi būti readonly ). 
            - Kiekviena klasė paveldi klasę Figura ir interfeisą IGeometrija.
            - Realizuoti klases.
            Irodyti veikima parasant testus kiekvienam metodui.

              Uzduotis 3: Sukurkite interface <IPayable>. Sis interface bus naudojamas apskaitos departamento sistemose rasant israsus. <IPayable> turetu tureti sias tris kontrakto funkcines dalis:
        1.	Isgauti dabartine alga
        2.	Padidinti esama alga
        3.	Isgauti uzmokescio adresa (Fizinis siunciamas laisku)
        Sukurkite klase <Employee> ir paveldekite ja <Person> klaseje (Snippet pasiimkit is apacios)
        internal class Person
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string LastName { get; set; }
            }
        <Employee> turetu tureti siuos properties:
        1.	Salary {private get;private set;}
        2.	Mailing address {get;private set;}
        <Employee> turetu paveldeti is <IPayable> interface. Kiekviena kontrakto dali uzpildykite logiskais sprendimais pvz: IPayable adreso isgavimo funkcionalumas turetu grazinti zmogaus esama registruota adresa.
        Irodyti veikima parasant testus kiekvienam metodui.
            */
        }
    }
}