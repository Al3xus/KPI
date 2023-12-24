
namespace lab3
{
    internal class WinStreakAccount : GameAccount
    {
        public int WinStreak = 0;

        public WinStreakAccount(string username, decimal currentRating, int id) : base(username, currentRating, id)
        {
        }

        public override void WinGame(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRank();

            WinStreak++;

            if (WinStreak > 1)
            {
                CurrentRating += Rating + 5;
            }
            else
                CurrentRating += Rating;

            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }

        public override void LoseGame(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRank();

            WinStreak = 0;
            if (Rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "Match rating can not be less then 1");
            }

            CurrentRating -= Rating;

            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }
    }
}
