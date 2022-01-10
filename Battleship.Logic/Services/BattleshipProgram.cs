using System;
using Battleship.Logic.Interfaces;
using Battleship.Logic.Static;

namespace Battleship.Logic.Services
{
    public class BattleshipProgram : IBattleshipProgram
    {
        private ICommunicator _communicator;
        private IPlayerPicker _playerPicker;
        public BattleshipProgram(ICommunicator communicator)
        {
            _communicator = communicator;
        }

        public void Run()
        {
            _communicator.Write(StaticStrings.WelcomeMessage);
            var players = _playPicker.ChoosePalyers();
        }
    }
}