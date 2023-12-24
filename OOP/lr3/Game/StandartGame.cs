namespace lab3
{
    public class StandartGame : Game
    {

        public StandartGame()
        {
            GameTypeNumber = 1;
        }

        public override decimal GetRank()
        {
            Random random = new Random();
            decimal randomNumber = random.Next(1, 15);
            return randomNumber;
        }

        public override decimal GetRankZero()
        {
            throw new NotImplementedException();
        }
    }
}

