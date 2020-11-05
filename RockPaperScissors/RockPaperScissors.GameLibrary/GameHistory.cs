namespace RockPaperScissors.Library
{
    public struct GameHistory
    {
        private static readonly string[] s_GameActionStrings = new string[] { "Rock", "Paper", "Scissors" };

        GameAction PlayerAction { get; }
        GameAction AIAction { get; }
        bool PlayerWins { get; }

        public GameHistory(GameAction playerAction, GameAction aIAction, bool playerWins)
        {
            PlayerAction = playerAction;
            AIAction = aIAction;
            PlayerWins = playerWins;
        }

        public override string ToString() => $"Player Action: {s_GameActionStrings[(int)PlayerAction]}, AI Action: {s_GameActionStrings[(int)PlayerAction]}, Result: {(PlayerWins ? "Player won" : "AI won")}";
    }
}
