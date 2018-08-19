using System;
using System.Collections.Generic;

namespace GraphDracula.Turn
{
    public class Turn
    {
        private List<ITurnAction> _actions;

        public Turn()
        {
            _actions = new List<ITurnAction>();
        }

        public Turn(ITurnAction action)
        {
            _actions = new List<ITurnAction> {action};
        }

        public Turn(List<ITurnAction> actions)
        {
            _actions = actions;
        }

        public void AddAction(ITurnAction action)
        {
            _actions.Add(action);
        }

        public new string ToString()
        {
            List<string> stringTurns = new List<string>();
            foreach (ITurnAction turnAction in _actions)
            {
                stringTurns.Add(turnAction.ToString());
            }

            return String.Join(";", stringTurns.ToArray());
        }
    }
}