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
    public class MusicTests
    {
        [TestMethod()]
        public void GetHobbyInformation_Void_ReturnsHobbyInformation()
        {
            IHobby music = new Game();

            var expected = $"{music.Name} {music.Genre} {music.Rating}/10";

            var actual = music.GetHobbyInformation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyName_Void_ReturnsHobbyName()
        {
            IHobby music = new Game();

            var expected = $"{music.Name}";

            var actual = music.GetHobbyName();

            Assert.AreEqual(expected, actual);
        }
    }
}