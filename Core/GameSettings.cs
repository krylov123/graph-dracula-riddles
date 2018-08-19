using System.Security.Cryptography.X509Certificates;
using GraphDracula.Exceptions;

namespace GraphDracula.Core
{
    public class GameSettings
    {
        public int TimePerMove { get; private set; }
        public int MaxRounds { get; private set; }
        public int Timebank { get; private set; }
        public string MyBotName { get; private set; }
        public int MyBotId { get; private set; }
        public string[] PlayerNames { get; private set; }
        public int FieldWidth { get; private set; }
        public int FieldHeight { get; private set; }


        public void Update(string type, string value)
        {
            switch (type)
            {
                case "timebank":
                    Timebank = int.Parse(value);
                    break;
                case "time_per_move":
                    TimePerMove = int.Parse(value);
                    break;
                case "player_names":
                    PlayerNames = value.Split(',');
                    break;
                case "your_bot":
                    MyBotName = value;
                    break;
                case "your_botid":
                    MyBotId = int.Parse(value);
                    break;
                case "field_width":
                    FieldWidth = int.Parse(value);
                    break;
                case "field_height":
                    FieldHeight = int.Parse(value);
                    break;
                case "max_rounds":
                    MaxRounds = int.Parse(value);
                    break;
                default:
                    throw ParserException.UnknownSettingCommand("Uknown setting command " + type);
                    break;
            }
        }

        public new string ToString()
        {
            string result = "";
            result += "TimePerMove: " + TimePerMove + "\n";
            result += "MaxRounds: " + MaxRounds + "\n";
            result += "Timebank: " + Timebank + "\n";
            result += "MyBotName: " + MyBotName + "\n";
            result += "MyBotId: " + MyBotId + "\n";
            result += "TimePerMove: " + TimePerMove + "\n";
            result += "TimePerMove: " + TimePerMove + "\n";
            result += "PlayerNames: " + string.Join(",", PlayerNames) + "\n";
            result += "FieldWidth: " + FieldWidth + "\n";
            result += "FieldHeight: " + FieldHeight + "\n";
            return result;
        }
    }
}