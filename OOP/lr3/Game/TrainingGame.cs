namespace lab3
{
    public class TrainingGame : Game
    {
        public TrainingGame()
        {
            GameTypeNumber = 2;
        }

        public override decimal GetRank()
        {
            throw new NotImplementedException();
        }

        public override decimal GetRankZero()
        {
            return 0;
        }
    }
}
