using _08_25_NamuDarbas_3.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_25_NamuDarbas_3.Domain.Models
{
    public class Movie : IHobby
    {
        // Constructors
        public Movie() { }
        public Movie(int id, int creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        // Properties
        public int Id { get; set; }
        public int CreationDate { get; set; }

        // Interface implementation
        public string Name => "Day Shift";
        public string Publisher => "J. J. Perry";
        public string Genre => "Action";
        public int Rating => 6;

        // Methods
        public string GetHobbyInformation()
        {
            return Name + " " + Genre + " " + Rating;
        }

        public string GetHobbyName()
        {
            return Name;
        }
    }
}
