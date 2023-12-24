namespace lab3
{
    public class PremiumAccount : GameAccount
    {
        public PremiumAccount(string username, decimal currentRating, int id) : base(username, currentRating, id)
        {
        }

        public override void LoseGame(string opponentname, Game gamerating)
        {
            decimal Rating = gamerating.GetRank();

            if (Rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "Match rating can not be less then 1");
            }


            CurrentRating -= Rating / 2;

            var gamesession = new GameStats(opponentname, Username, CurrentRating);
            allGames.Add(gamesession);
        }
    }
}
