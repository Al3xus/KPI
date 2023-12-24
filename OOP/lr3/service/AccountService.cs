using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    public class AccountService : IAccountService
    {
        public IPlayersRepository pr = new PlayersRepository();
        //public IGamesRepository gr = new GamesRepository();

       

        public GameAccount CreateAccount(int ind, string name, decimal pts, int id)
        {
            GameAccount account = null;

            Player player = new Player(id, pts, name);

            if (ind == 1)
            {
                account = new GameAccount(name, pts, id);
                pr.Create(player);
                pr.CreateAccount(account);
            }

            if (ind == 2)
            {
                account = new PremiumAccount(name, pts, id);
                pr.Create(player);
                pr.CreateAccount(account);
            }

            if (ind == 3)
            {
                account = new WinStreakAccount(name, pts, id);
                pr.Create(player);
                pr.CreateAccount(account);
            }

            if (account == null)
            {
                throw new NotImplementedException();
            }

            return account;
        }

        

        public Player ReadAccountById(int id)
        {
            Player player = pr.GetById(id);

            if (player == null)
            {
                Console.WriteLine("ERROR: Invalid ID");
                throw new NotImplementedException();
            }
            else
            {
                return player;
            }
        }

        public GameAccount ReadAccount(int id)
        {
            GameAccount account = pr.GetAccountById(id);

            if (account == null)
            {
                Console.WriteLine("ERROR: Invalid ID");
                throw new NotImplementedException();
            }
            else
            {
                return account;
            }
        }

        public void ReadAccounts()
        {
            Console.WriteLine($"All active accounts:");
            foreach (Player player in pr.GetAllPlayers())
            {
                Console.WriteLine(player.Name);
            }
            Console.WriteLine();
        }

        

        public void ReadPlayedGamesByPlayer(int id)
        {
            //Player player = pr.GetById(id);
            GameAccount gameAccount = pr.GetAccountById(id);

            Console.WriteLine();
            Console.WriteLine($"Finished Games by player {gameAccount.Username}:");
            foreach (int gameId in gameAccount.PlayedGamesId)
            {
                Console.WriteLine($"Game ID: {gameId}");
            }
            Console.WriteLine();
        }
    }
}
