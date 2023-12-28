using lab4.DataBase;
using lab4.GameAccounts;
using lab4.GameTypes;
using lab4.Repository;
using lab4.Service;

namespace lab4.Factory
{
    public class GameFactory
    {
        public static Game CreateGame(string type, GameAccount firtOpponent, GameAccount secondOpponent, int rating)
        {
            if (type == "Train")
            {
                return new TrainGame(firtOpponent.UserName, secondOpponent.UserName, rating);
            }
            if (type == "DoublePoints")
            {
                return new DoublePointsGame(firtOpponent.UserName, secondOpponent.UserName, rating);
            }
            if (type == "Standard")
            {
                return new StandardGame(firtOpponent.UserName, secondOpponent.UserName, rating);
            }
            else
            {
                return null;
            }
        }

    }

}
