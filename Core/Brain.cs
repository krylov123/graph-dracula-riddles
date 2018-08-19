using System;
using GraphDracula.Turn;

namespace GraphDracula.Core
{
    public class Brain
    {
        private GameState _gameState;
        
        public Brain(ref GameState gameState)
        {
            _gameState = gameState;
        }

        public Turn.Turn makeTurn()
        {
            //choosing random direction for next turn
            //code your own turn logic instead
            Array values = Enum.GetValues(typeof(MoveDirection));
            Random random = new Random();
            MoveDirection randomDirection = (MoveDirection)values.GetValue(random.Next(values.Length));
            
            return new Turn.Turn(new MoveAction(randomDirection));
        }

        public void ResponseToActionRequest(string actionTimer)
        {
            Turn.Turn turn = makeTurn();
            Console.WriteLine(turn.ToString());
        }
        
    }
}