using Battleship.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Battleship.Logic.Tests.Models
{
    [TestClass]
    public class ShipTester
    {
        [TestMethod]
        public void IsInGrid_WithGridSize_ThenFalse()
        {
            Assert.IsFalse(new Ship().IsInGrid(0));
        }
    }
}