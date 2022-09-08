using Microsoft.VisualStudio.TestTools.UnitTesting;
using _08_25_NamuDarbas_3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_25_NamuDarbas_3.Domain.Interfaces;

namespace _08_25_NamuDarbas_3.Domain.Models.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void GetHobbyInformation_Void_ReturnsHobbyInformation()
        {
            IHobby movie = new Game();

            var expected = $"{movie.Name} {movie.Genre} {movie.Rating}/10";

            var actual = movie.GetHobbyInformation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyName_Void_ReturnsHobbyName()
        {
            IHobby movie = new Game();

            var expected = $"{movie.Name}";

            var actual = movie.GetHobbyName();

            Assert.AreEqual(expected, actual);
        }
    }
}