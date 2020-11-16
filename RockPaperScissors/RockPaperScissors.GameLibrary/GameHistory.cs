using System.Text.Json.Serialization;

namespace RockPaperScissors.Library
{
    public class GameHistory
    {
        private static readonly string[] s_GameActionStrings = new string[] { "Rock", "Paper", "Scissors" };

        [JsonPropertyName("player_action")]
        public GameAction PlayerAction { get; set; } = 0;
        [JsonPropertyName("ai_action")]
        public GameAction AIAction { get; set; } = 0;
        [JsonPropertyName("players_wins")]
        public bool PlayerWins { get; set; } = false;

        public GameHistory(GameAction playerAction, GameAction aIAction, bool playerWins)
        {
            PlayerAction = playerAction;
            AIAction = aIAction;
            PlayerWins = playerWins;
        }

        public override string ToString() => $"Player Action: {s_GameActionStrings[(int)PlayerAction]}, AI Action: {s_GameActionStrings[(int)PlayerAction]}, Result: {(PlayerWins ? "Player won" : "AI won")}";
    }
}
