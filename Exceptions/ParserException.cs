using System;

namespace GraphDracula.Exceptions
{
    public class ParserException : Exception
    {
        public ParserException(string message) : base(message)
        {
        }

        public static ParserException UnknownCommand(string message = "Unknown command")
        {
            return new ParserException(message);
        }

        public static ParserException UnknownSettingCommand(string message = "Unknown setting command")
        {
            return new ParserException(message);
        }

        public static ParserException UnknownUpdateCommand(string message = "Unknown update command")
        {
            return new ParserException(message);
        }
        
        public static ParserException UnknownActionCommand(string message = "Unknown action command")
        {
            return new ParserException(message);
        }
    }
}