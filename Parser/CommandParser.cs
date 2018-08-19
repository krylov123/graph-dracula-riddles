using System;
using System.CodeDom;
using System.Collections;
using GraphDracula.Exceptions;

namespace GraphDracula.Parser
{
    public class CommandParser
    {
        public delegate void TwoArgumentEventContainer(string type, string value);

        public delegate void OneArgumentEventContainer(string value);

        public event TwoArgumentEventContainer settingChanged;
        public event OneArgumentEventContainer fieldUpdated;
        public event OneArgumentEventContainer newRoundBegin;
        public event OneArgumentEventContainer actionRequested;

        public void Parse(string line)
        {
            var parts = line.Split(' ');
            switch (parts[0])
            {
                case "settings":
                    settingChanged(parts[1], parts[2]);
                    break;
                case "update":
                    if (parts[2] == "field") fieldUpdated(parts[3]);
                    if (parts[2] == "round") newRoundBegin(parts[3]);
                    break;
                case "action":
                    if (parts[1] == "character") Console.WriteLine("bixie");
                    if (parts[1] == "move") actionRequested(parts[2]);
                    break;
                default:
                    throw ParserException.UnknownCommand();
                    break;
            }
        }
    }
}