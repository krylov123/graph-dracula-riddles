using GraphDracula.CommandSource;

namespace GraphDracula
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICommandSource commandSource = new ConsoleCommandSource();
            
            if ((args.Length == 1) && (args[0] == "test"))
            {
                commandSource = new FileCommandSource();
            }

            Core.Core botCore = new Core.Core(commandSource);
            botCore.Run();
        }
    }
}