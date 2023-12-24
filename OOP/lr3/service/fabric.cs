
namespace lab3
{
    public class fabric
    {
        public Game MakeGameObject(int gametype)
        {
            Game game = null;
            if (gametype == 1)
            {
                game = new StandartGame();
            }

            if (gametype == 2)
            {
                game = new TrainingGame();
            }

            if (gametype == 3)
            {
                game = new SiglePlayerGame();

            }
            if (game == null)
            {
                throw new NotImplementedException();
            }
            return game;
        }
    }
}
