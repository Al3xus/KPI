using tic_tac_toe.Enums;

namespace tic_tac_toe.PackageForPlayers
{
    // Класс, представляющий историю игрока в различных играх
    public class PlayerHistory
    {
        // Конструктор класса, инициализирующий историю игрока
        public PlayerHistory(TypeGame typeGame, string id, int rating, GameOutcome outcome, Account oponent,
            int beforeRating, int afterRating)
        {
            TypeGame = typeGame;
            Id = id;
            Rating = rating;
            Outcome = outcome;
            Oponent = oponent;
            BeforeRating = beforeRating;
            AfterRating = afterRating;
        }

        public TypeGame TypeGame { get; }

        public string Id { get; }

        public int Rating { get; }

        public GameOutcome Outcome { get; }

        public Account Oponent { get; }

        public int BeforeRating { get; }

        public int AfterRating { get; }
    }
}