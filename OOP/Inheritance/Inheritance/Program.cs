using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1- Sukurkite klases Hobby su properčiais
                   - Id 
                   - Text
                   - TextLt
                2- Sukurkite konstruktorių be parametrų (pasiekiama visur)
                3- Sukurkite konstruktorių su id, text, textLt parametrais (pasiekiama visur)
                4- Skirtingais būdais inicializuokite  klases. Įrašykite po 3 hobius.
                5- Hobby klasėje sukurkite metodą kuris iškoduos HobbyInitialData.DataSeedCsv vieną įrašą (string)
                   ir užpildys properčius duomenimis. unit-test

            1 Sukurkite klases Profession su properčiais
           - Id  (readonly)
           - Text (galima irasyti tik is vidaus)
           - TextLt (paprastas)

            sukurite klasę UniversityPerson paveldėtą iš Person klasės. Pridėkite properčius.
            - Profession (Profession)
            - Hobbies (List of Hobby)
            1- Padarykite metodą kuris atsitiktinai asmeniui pariks nuo 0 iki 4 hobių iš HobbyInitialData.DataSeedCsv. 
            Užtikrinkite,kad tas pat hobis nepasikartotu 2 kartus
            2- Naudodami method overload padarykite metodus kurie atsitiktinai asmeniui pariks 1 profesiją iš  
                ProfessionInitialData.DataSeed arba 
                ProfessionInitialData.DataSeedCsvComma arba
                ProfessionInitialData.DataSeedCsvSemicolon.
            3- Padarykite metodą GetCsv() kuris grąžina string t.y.
               Iš užpildytos klasės UniversityPerson duomenų sukurs CSV formato DataSeed. Taip, kad galėtume naudoti jį vėliau. (unit-test)

            Sukurkite klasę Student
            - paveldėtą iš UniversityPerson, apribokite, kad ši klasė galėtu turėti profesijas išskyrus Lecturer, Teacher ir Scientist
            - pridėkite property Courses (list of Profession)
            - padarykite metodą, kuris atsitiktinai užpildys nuo 1 iki 3 kursų iš ProfessionInitialData (išfiltravus Lecturer, Teacher ir Scientist).
            Užtikrinkite,kad tas pat kursas nepasikartotu 2 kartus (unit-test)
            - perrašykite metodą kuris GetCsv(), kad būtu grąžinami visi klasės duomenys
            - sukurkite metodą kuris GetCoursesDataSeedIndexes() grąžintu atsitiktinai parinktų kursų indeksus (List of int) iš ProfessionInitialData (unit-test)
            - parašykite metodą GetBiography() kuris parašys asmens biografiją naturalia kalba
            "studentas/studentė (parinkti pagal lytį) Vardenis Pavardenis kurio profesija yra ... turi hobius ..., .... ir .... bei lanko .... ir .... kursus"
            jei studentas neturi hobių, šios sakinio dalies rašyti nereikia.
            */

            var hobis = new Hobby();
            hobis.Id = 1;
            hobis.Text = "Football";
            hobis.TextLt = "Futvolas";

            var hobis1 = new Hobby(2, "Tenis", "Tenisas");

            var hobis2 = new Hobby()
            {
                Id = 3,
                Text = "Basketball",
                TextLt = "Krepšinis"
            };
        }
    }
}