
namespace lab4.GameTypes
{
    public class StandardGame : Game
    {
        public StandardGame(string firstOpponentName, string secondOpponentName, int rating) : base(firstOpponentName, secondOpponentName, rating) { }

        public override int CalculatePoints()
        {
            return Rating;
        }
    }
}
