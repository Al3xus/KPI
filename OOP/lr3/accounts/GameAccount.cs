namespace lab3
{
    public class GameAccount
    {
        public List<GameStats> allGames = new List<GameStats>();

        //public Player player = new Player();

        public GameAccount(string username, decimal currentRating, int id)
        {
            Username = username;
            CurrentRating = currentRating;
            AccountId = id;
            PlayedGamesId = new List<int> { };
        }
        public List<int> PlayedGamesId { get; set; }

        public int AccountId { get; set; }
        public string Username { get; }
        private decimal currentrating;
        public decimal CurrentRating
        {
            get
            {
                return currentrating;
            }
            set
            {
                if (value < 1)
                {
                    currentrating = 1;
                }
                else
                    currentrating = value;
            }
        }
        public decimal GamesCount { get { return allGames.Count; } }


        public virtual void WinGame(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRank();

            CurrentRating += Rating;

            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }

        public virtual void WinGame_noRating(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRankZero();

            CurrentRating += Rating;

            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }

        public virtual void LoseGame(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRank();

            if (Rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "Match rating can not be less then 0");
            }


            CurrentRating -= Rating;


            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }

        public virtual void LoseGame_noRating(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRankZero();

            if (Rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "Match rating can not be less then 0");
            }


            CurrentRating -= Rating;


            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }

        public string GetStats()
        {
            var reportstats = new System.Text.StringBuilder();

            decimal rating = 0;
            reportstats.AppendLine("User Name\t\tOpponent\tRating\tGame Id");
            foreach (var game in allGames)
            {
                rating = game.Rating;
                reportstats.AppendLine($"{game.UserName}\t\t\t {game.OpponentName}\t {rating}\t {game.gameId}");
            }
            return reportstats.ToString();
        }

    }
}
