namespace lab1
{

    public class StatsDTO 
    {
        public string OpponentName { get; }
        public string EndGame { get; }
        public int CurrentRating { get; }
        public string ChangedRating { get; }
        public static int Index = 10;
        public int gameID;
        public StatsDTO(int index, string opponentName, string endGame, string changedRating, int currentRating)
        {
            gameID = Index++;
            this.OpponentName = opponentName;
            this.EndGame = endGame;
            this.ChangedRating = changedRating;
            this.CurrentRating = currentRating;
        }
    }
}