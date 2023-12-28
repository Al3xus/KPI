
namespace lab4.GameTypes
{
    public class DoublePointsGame : Game
    {
        public DoublePointsGame(string firstOpponentName, string secondOpponentName, int rating) : base(firstOpponentName, secondOpponentName, rating) { }

        public override int CalculatePoints()
        {
            Rating = Rating * 2;
            return Rating;
        }
    }
}
