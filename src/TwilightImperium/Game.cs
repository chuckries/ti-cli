using System.Collections.Generic;

namespace TwilightImperium
{
    public class Game
    {
        public List<Unit> Units { get; } = new List<Unit>();

        public Game()
        {
            Units.Add(new SpaceDock());
        }
    }
}