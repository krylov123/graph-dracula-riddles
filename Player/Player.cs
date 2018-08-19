using System.Collections.Generic;

namespace GraphDracula.Player
{
    public class Player
    {
        public string Name { get; private set; }
        public int Bombs { get; set; }
        public int Snippets { get; set; }
        private List<int[]> TurnHistory;

        public Player(string playerName)
        {
            Name = playerName;
        }
    }
}