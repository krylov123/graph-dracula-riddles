using System;
using GraphDracula.CommandSource;
using GraphDracula.Exceptions;
using GraphDracula.Parser;

namespace GraphDracula.Core
{
    public class Core
    {
        private ICommandSource _commandSource;
        private CommandParser _commandParser;
        private GameState _gameState;
        private Brain _botBrain;
        
        public Core(ICommandSource iCommandSource)
        {
            _commandSource = iCommandSource;
            _gameState = new GameState();
            _commandParser = new CommandParser();
            _botBrain = new Brain(ref _gameState);
            
            //Events Listeners
            _commandParser.settingChanged += _gameState.Settings.Update;
            _commandParser.settingChanged += _gameState.Field.UpdateSettings;
            _commandParser.newRoundBegin += _gameState.UpdateRound;
            _commandParser.fieldUpdated += _gameState.Field.UpdateFromString;
            _commandParser.actionRequested += _botBrain.ResponseToActionRequest;
        }

        public void Run()
        {
            string line;
            while ((line = _commandSource.ReadLine()) != null)
            {
                try
                {
                    _commandParser.Parse(line);
                }
                catch (ParserException e)
                {
                    Console.Error.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }
}