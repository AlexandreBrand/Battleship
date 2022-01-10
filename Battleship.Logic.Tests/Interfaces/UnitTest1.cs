using Battleship.Logic.Interfaces;
using Battleship.Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Battleship.Logic.Tests
{
    [TestClass]
    public class BattleshipProgramTester
    {
        private BattleshipProgram _program;
        private Mock<ICommunicator> _commMock;


        public BattleshipProgramTester()
        {
            _commMock = new Mock<ICommunicator>();
            _program = new BattleshipProgram(_commMock.Object);
        }

        [TestMethod]
        public void Runs_ThenCommunicatorisCalled()
        {
            _program.Run();

        }
    }
}
