using System.Collections.Generic;
using Battleship.Logic.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Battleship.Logic.Tests.Services
{
    [TestClass]
    public class BattleSetupTester
    {
        private BattleSetup _battleSetup = new BattleSetup();

        [TestMethod]
        public void PlaceBoats_WithEmptyRequiredShipsList_ThenEmptyBoatList()
        {
            Assert.AreEqual(0, _battleSetup.PlaceBoats(null,0, new List<int>()).Count);
        }
    }
}