namespace lab3
{
    public class SiglePlayerGame : Game
    {
        public SiglePlayerGame()
        {
            GameTypeNumber = 3;
        }
        public override decimal GetRank()
        {
            Random random = new Random();
            decimal randomNumber = random.Next(1, 15);
            return randomNumber;
        }

        public override decimal GetRankZero()
        {
            return 0;
        }
    }
}
