using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class PlayersRepository : IPlayersRepository
    {
        private DbContext db;
        public PlayersRepository()
        {
            db = new DbContext();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return db.AllPlayers;
        }
        public Player GetById(int id)
        {
            return db.AllPlayers.FirstOrDefault(player => player.PlayerId == id);
        }
        public GameAccount GetAccountById(int id)
        {
            return db.AllAccounts.FirstOrDefault(account => account.AccountId == id);

        }
        public Player GetByName(string name)
        {
            return db.AllPlayers.FirstOrDefault(player => player.Name == name);
        }

        public void Create(Player player)
        {
            db.AllPlayers.Add(player);
        }
        public void CreateAccount(GameAccount player)
        {
            db.AllAccounts.Add(player);
        }
        public void Delete(int id)
        {
            Player player = db.AllPlayers.FirstOrDefault(player => player.PlayerId == id);
            if (player != null)
            {
                db.AllPlayers.Remove(player);
            }
        }

        public void UpdateId(Player player, int newId)
        {
            player.PlayerId = newId;
        }

        public void UpdatePts(Player player, decimal newPts)
        {
            player.Points = newPts;
        }

        public void UpdateName(Player player, string newname)
        {
            player.Name = newname;
        }

    }
}
