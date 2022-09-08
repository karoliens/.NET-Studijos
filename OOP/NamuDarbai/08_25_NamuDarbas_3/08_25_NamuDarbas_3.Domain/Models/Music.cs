using _08_25_NamuDarbas_3.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_25_NamuDarbas_3.Domain.Models
{
    public class Music : IHobby
    {
        // Constructors
        public Music() { }
        public Music(int id, int length, string artistName)
        {
            Id = id;
            Length = length;
            ArtistName = artistName;
        }

        // Properties
        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }

        // Interface implementation
        public string Name => "Own It";
        public string Publisher => "Merky";
        public string Genre => "Grime";
        public int Rating => 9;

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
