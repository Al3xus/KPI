using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class GameService : IGameService
    {
        public IGamesRepository gr = new GamesRepository();
        public int gameid = 1;
        public void CreateGame(GameAccount p1, GameAccount p2, Game game)
        {
            Program.play(p1, p2, game);
            FinishedGame fgame = new FinishedGame(gameid);

            //Player player1 = pr.GetById(p1.AccountId);
            //Player player2 = pr.GetById(p2.AccountId);

            gr.Create(fgame);

            p1.PlayedGamesId.Add(gameid);
            p2.PlayedGamesId.Add(gameid);

            //player1.PlayedGamesId.Add(gameid);
            //player2.PlayedGamesId.Add(gameid);

            gameid++;
        }

        public void ReadGames()
        {
            Console.WriteLine();
            Console.WriteLine($"Finished Games:");
            foreach (FinishedGame fgame in gr.GetAllGames())
            {
                Console.WriteLine($"Game ID: {fgame.GameId}");
            }
            Console.WriteLine();
        }


    }
}
