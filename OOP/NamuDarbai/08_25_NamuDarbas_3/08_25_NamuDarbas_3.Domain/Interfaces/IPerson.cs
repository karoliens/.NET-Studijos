using _08_25_NamuDarbas_3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_25_NamuDarbas_3.Domain.Interfaces
{
    public interface IPerson
    {
        void Interact(IHobby hobby);
        string GetFavoriteHobbyType();
        string GetFavoriteHobby();
        List<IHobby> GetFavoriteFromEachHobby();
        String GetFavoriteMusicGenre();
        Dictionary<string, int> GetEachHobbyAvgRating();
        void ShareHobbies(Person person );
        void ShareOldMovies(Person person);
        List<IHobby> FindSimilarHobbies(Person person);
        List<IHobby> FindSimilarHobbies(Person person, string hobbyType);
        List<string> FindMatchingGenres(Person person, string hobbyType);
    }
}
