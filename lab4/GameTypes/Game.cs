

namespace lab4.GameTypes
{
    public abstract class Game
    {
        public int GameId { get; set; }
        public string FirstOpponentName { get; set; }
        public string SecondOpponentName { get; set; }
        public int Rating { get; set; }
        public bool Won { get; set; }

        public static int gameIdCounter = 0;

        public Game(string firstOpponentName, string secondOpponentName, int rating)
        {
            ++gameIdCounter;
            GameId = gameIdCounter;
            FirstOpponentName = firstOpponentName;
            SecondOpponentName = secondOpponentName;
            Rating = rating;
        }

        public abstract int CalculatePoints();
    }

}
