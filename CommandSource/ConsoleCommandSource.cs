using System;

namespace GraphDracula.CommandSource
{
    public class ConsoleCommandSource : ICommandSource
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}