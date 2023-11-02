using System.Collections.Generic;

namespace lab1
{
    class GameAccount
    {
        public string UserName { get; }
        private int currentRating;
        public int CurrentRating { get { return currentRating; } set { // в свойствах карент рейтинг прописал гетер и сетер, а валуе это значение
                if (value < 1)
                {
                    currentRating = 1;
                }
                else
                {
                    currentRating = value; 
                }
            } }     
        private int GamesCount { get { return _stats.Count; } }
        private readonly List<StatsDTO> _stats = new List<StatsDTO>();

        public GameAccount(string name)
        {
            UserName = name;
            CurrentRating = 100;
           
                    }

        public void WinGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new Exception("Рейтинг не може бути відємним");
            }
            CurrentRating += rating;
                        var changedRating = new System.Text.StringBuilder();
            changedRating.Append($"+{rating.ToString()}");
            var result = new StatsDTO(_index, opponentName, "Win", changedRating.ToString(), CurrentRating);
            _stats.Add(result);
        }

        public void LoseGame(string opponentName, int rating)
        {
        if (rating < 0)
            {
                throw new Exception("Рейтинг не може бути відємним");
            }
            CurrentRating -= rating;
            var changedRating = new System.Text.StringBuilder();
            changedRating.Append($"-{rating.ToString()}");
            var result = new StatsDTO(_index, opponentName, "Lose", changedRating.ToString(), CurrentRating);
            _stats.Add(result);
        }

        public string GetStats()
        {
            var allStats = new System.Text.StringBuilder();
            allStats.AppendLine($"Stats for {UserName}:");
            allStats.AppendLine("Index\tOpponent\tEnd of game\tEarned rating\tCurrent rating");
            foreach (var item in _stats)
            {
                allStats.AppendLine(
                    $"{item.gameID}\t{item.OpponentName}\t\t{item.EndGame}\t\t{item.ChangedRating}\t\t{item.CurrentRating}");
            }

            allStats.AppendLine($"Total games: {GamesCount}");

            return allStats.ToString();
        }
    }
}