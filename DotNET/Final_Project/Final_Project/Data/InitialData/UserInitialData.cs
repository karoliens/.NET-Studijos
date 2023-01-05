using Final_Project.Models;

namespace Final_Project.Data.InitialData
{
    public class UserInitialData
    {
        public static readonly User[] DataSeed = new User[] {
            new User
            {
                Id = 1,
                UserName = "karoliens",
                Name = "Karolis"
            },
             new User
            {
                Id = 2,
                UserName = "ievuzis",
                Name = "Ieva"
            },
              new User
            {
                Id = 3,
                UserName = "tomukas",
                Name = "Tomas"
            },
               new User
            {
                Id = 4,
                UserName = "sauliens",
                Name = "Saulius"
            }
        };
    }
}
