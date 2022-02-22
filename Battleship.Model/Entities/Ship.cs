using System.Collections.Generic;

namespace Battleship.Model.Entities
{
    public class Ship
    {
        public Position Start { get; set; }
        public Position End { get; set; }
        public bool IsSet => Start != null && End != null;

        public bool IsInGrid(int gridSize)
        {
            return false;
            // x.Start.Row < 4 && x.Start.Row >= 0
        }
    }
}