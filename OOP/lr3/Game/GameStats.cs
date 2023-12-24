namespace lab3
{
    public class GameStats
    {
        public static int GlobalId;
        public int gameId { get; }

        public string OpponentName;
        public string UserName { get; }
        public decimal Rating { get; }


        public GameStats(string opponentName, string userName, decimal rating)
        {
            OpponentName = opponentName;
            UserName = userName;
            Rating = rating;
            gameId = GlobalId;
            GlobalId++;
        }

    }
}
