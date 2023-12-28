using lab4.GameTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.GameAccounts
{
    public class WinStreakGameAccount : GameAccount
    {
        private int winStreak = 0;

        public WinStreakGameAccount(string userName, int initialRating) : base(userName, initialRating) { }

        public override void WinGame(Game game)
        {

            int ratingChange = game.CalculatePoints();
            winStreak += 1;
            if (winStreak >= 2)
            {
                ratingChange = ratingChange + (10 * winStreak - 10);
                CurrentRating += ratingChange;
                game.Rating = ratingChange;
                game.Won = true;
                gameHistory.Add(game);
            }
            else
            {
                CurrentRating += ratingChange;
                game.Rating = ratingChange;
                game.Won = true;
                gameHistory.Add(game);
            }

        }

        public override void LoseGame(Game game)
        {
            winStreak = 0;
            int ratingChange = game.CalculatePoints();
            CurrentRating -= ratingChange;
            game.Won = false;
            gameHistory.Add(game);
        }

    }
}
