using RockPaperScissors.GameLibrary;
using RockPaperScissors.Library.AI;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Library
{
    public class Game
    {
        private static readonly bool[][] s_PossibleMoves = new bool[3][]
        {
            new []{ false, false, true },
            new []{ true,  false, false },
            new []{ false, true,  false }
        };

        private readonly bool _serialize;
        private readonly IAI _ai;
        private readonly JsonGameHistoryPersistence _jsonPersistence = new JsonGameHistoryPersistence("../../../game_histories.json");
        // History of past games: { player move, ai move, outcome }
        private List<GameHistory> _gameHistories = new List<GameHistory>();

        public Game(AIStrategy aiStrategy, bool serialize)
        {
            _serialize = serialize;

            if (_serialize)
                _gameHistories = _jsonPersistence.Read();

            switch (aiStrategy)
            {
                case AIStrategy.Random:
                    _ai = new RandomAI();
                    break;

                case AIStrategy.AlwaysWins:
                    _ai = new AlwaysWinsAI();
                    break;

                case AIStrategy.AlwaysLoses:
                    _ai = new AlwaysLosesAI();
                    break;
            }
        }

        public static bool IsWin(GameAction userAction, GameAction aiAction) => s_PossibleMoves[(int)userAction][(int)aiAction];

        public void Run()
        {
            bool quit = false;

            while (!quit)
            {
                // Get Player turn
                GameAction userAction = Player.PromptAction("Your Move: 0 = Rock, 1 = Paper, 2 = Scissors, -1 = quit: ");

                if (userAction == GameAction.Quit)
                    return;
                // Get Computer Turn
                GameAction aiAction = _ai.Play(userAction);
                bool isWin = IsWin(userAction, aiAction);
                Console.WriteLine(isWin ? "You won" : "AI won");
                // Record the history
                _gameHistories.Add(new GameHistory(userAction, aiAction, isWin));
                // Prompt to play again
                quit = ConsoleIO.ConsoleIO.PromptForBool("Do you wish to play again? Enter 'yes' or 'no': ", "no", "yes");
            }

            if (_serialize)
                _jsonPersistence.Write(_gameHistories);
        }

        public List<GameHistory> GetHistories() => _gameHistories;
    }
}