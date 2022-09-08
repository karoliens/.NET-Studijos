using _08_25_NamuDarbas_3.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_25_NamuDarbas_3.Domain.Models
{
    public class Person : IPerson, IHobby
    {
        // Properties
        public string PersonName { get; set; }
        public List<IHobby> Hobbies { get; set; }
        public List<IHobby> CheckoutList { get; set; }

        // Interface implementation

        public string Name => Name;

        public string Publisher => Publisher;

        public string Genre => Genre;

        public int Rating => Rating;
        public List<string> FindMatchingGenres(Person person, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person person)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person person, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> GetEachHobbyAvgRating()
        {
            throw new NotImplementedException();
        }

        public List<IHobby> GetFavoriteFromEachHobby()
        {
            throw new NotImplementedException();
        }

        public IHobby GetFavoriteHobby()
        {
            throw new NotImplementedException();
        }

        public string GetFavoriteHobbyType()
        {
            return Name;
        }

        public string GetFavoriteMusicGenre()
        {
            throw new NotImplementedException();
        }

        public string GetHobbyInformation()
        {
            throw new NotImplementedException();
        }

        public string GetHobbyName()
        {
            throw new NotImplementedException();
        }

        public void Interact(IHobby hobby)
        {
            Console.WriteLine($"{PersonName} will now watch a {hobby.Name} which is a {hobby.Genre}");
        }

        public void ShareHobbies(Person person)
        {
            throw new NotImplementedException();
        }

        public void ShareOldMovies(Person person)
        {
            throw new NotImplementedException();
        }

        // Methods
        void AddRandomToCheckList(Person person)
        {

        }
    }
}
