using System;
using System.IO;

namespace GraphDracula.CommandSource
{
    public class FileCommandSource : ICommandSource
    {
        private string line;
        private string fileName;
        private StreamReader stream;

        public FileCommandSource(string dumpFilePath = @".\..\..\dump.txt")
        {
            fileName = dumpFilePath;
            stream = new StreamReader(fileName);
        }

        public string ReadLine()
        {
            return stream.ReadLine();
        }
    }
}