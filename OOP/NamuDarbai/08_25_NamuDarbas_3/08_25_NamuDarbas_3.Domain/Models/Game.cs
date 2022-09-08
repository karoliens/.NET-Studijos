using _08_25_NamuDarbas_3.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_25_NamuDarbas_3.Domain.Models
{
    public class Game : IHobby
    {
        // Constructors
        public Game() { }
        public Game(int id, string platform, bool isMultiplayer)
        {
            Id = id;
            Platform = platform;
            IsMultiplayer = isMultiplayer;
        }

        // Properties
        public int Id { get; set; }
        public string Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        // Interface implementation
        public string Name => "Red Dead Redemption 2";
        public string Publisher => "Rockstar Games";
        public string Genre => "Action-adventure";
        public int Rating => 9;

        // Methods
        public string GetHobbyInformation()
        {
            return Name + " " + Genre + " " + Rating + "/10";
        }

        public string GetHobbyName()
        {
            return Name;
        }
    }
}
