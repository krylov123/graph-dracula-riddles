namespace GraphDracula.Core
{
    public class GameState
    {
        public int CurrentRound { get; private set; }
        public GameSettings Settings { get; }
        public Field.Field Field { get; private set; }

        public GameState()
        {
            Settings = new GameSettings();
            Field = new Field.Field();
        }

        public void UpdateRound(int round = 0)
        {
            if (round == 0) round = CurrentRound + 1;
            CurrentRound = round;
        }

        public void UpdateRound(string round = "0")
        {
            UpdateRound(int.Parse(round));
        }
    }
}