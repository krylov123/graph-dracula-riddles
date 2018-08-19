using System;

namespace GraphDracula.Turn
{
    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right,
        Pass
    }

    public class MoveAction: ITurnAction
    {
        private MoveDirection _moveDirection;
        
        public MoveAction(MoveDirection moveDirection)
        {
            _moveDirection = moveDirection;
        }

        public new string ToString()
        {
            return Enum.GetName(typeof(MoveDirection), _moveDirection);
        }

    }
}