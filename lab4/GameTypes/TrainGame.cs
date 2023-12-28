

namespace lab4.GameTypes
{
    public class TrainGame : Game
    {
        public TrainGame(string firstOpponentName, string secondOpponentName, int rating) : base(firstOpponentName, secondOpponentName, rating) { }

        public override int CalculatePoints()
        {
            Rating = 0;
            return 0;
        }
    }
}
