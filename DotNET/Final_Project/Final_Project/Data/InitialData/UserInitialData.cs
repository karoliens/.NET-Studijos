using Final_Project.Models;

namespace Final_Project.Data.InitialData
{
    public class UserInitialData
    {
        public static readonly User[] DataSeed = new User[] {
            new User
            {
                UserId = 1,
                UserName = "karoliens",
                Name = "Karolis"
            },
             new User
            {
                UserId = 2,
                UserName = "ievuzis",
                Name = "Ieva"
            },
              new User
            {
                UserId = 3,
                UserName = "tomukas",
                Name = "Tomas"
            },
               new User
            {
                UserId = 4,
                UserName = "sauliens",
                Name = "Saulius"
            }
        };
    }
}
