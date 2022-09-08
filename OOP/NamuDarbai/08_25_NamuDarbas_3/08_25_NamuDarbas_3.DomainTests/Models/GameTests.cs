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
    public class GameTests
    {
        [TestMethod()]
        public void GetHobbyInformation_Void_ReturnsHobbyInformation()
        {
            IHobby game = new Game();

            var expected = $"{game.Name} {game.Genre} {game.Rating}/10";

            var actual = game.GetHobbyInformation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyName_Void_ReturnsHobbyName()
        {
            IHobby game = new Game();

            var expected = $"{game.Name}";

            var actual = game.GetHobbyName();

            Assert.AreEqual(expected, actual);
        }
    }
}