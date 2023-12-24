using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Player
    {
        public Player(int id, decimal pts, string name)
        {
            PlayerId = id;
            Points = pts;
            Name = name;
            //PlayedGamesId = new List<int> { };
        }
        public int PlayerId { get; set; }
        public decimal Points { get; set; }
        public string? Name { get; set; }
        //public List<int> PlayedGamesId { get; set; }
    }

    public class FinishedGame
    {
        public FinishedGame(int gameId)
        {
            GameId = gameId;
        }

        public int GameId { get; set; }
    }


    public class DbContext
    {
        public List<Player> AllPlayers { get; set; }
        public List<FinishedGame> FGames { get; set; }
        public List<GameAccount> AllAccounts { get; set; }

        public DbContext()
        {
            AllPlayers = new List<Player> { };

            AllAccounts = new List<GameAccount> { };

            FGames = new List<FinishedGame> { };
        }
    }
}
