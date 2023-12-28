using lab4.DataBase;
using lab4.GameAccounts;
using lab4.GameTypes;
using System.Collections.Generic;
using System.Linq;

namespace lab4.Repository
{
    public class GameAccountRepository : IGameAccountRepository
    {
        private DbContext dbContext;

        public GameAccountRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateGameAccount(GameAccount gameAccount)
        {
            dbContext.GameAccounts.Add(gameAccount);
        }

        public GameAccount ReadGameAccountById(int accountId)
        {
            return dbContext.GameAccounts.FirstOrDefault(ga => ga.Id == accountId);
        }

        public List<GameAccount> ReadAllGameAccounts()
        {
            return dbContext.GameAccounts.ToList();
        }

        public void UpdateGameAccount(int accountId, GameAccount gameAccount)
        {
            var updateGameAccount = dbContext.GameAccounts.FirstOrDefault(g => g.Id == accountId);
            if (updateGameAccount != null)
            {
                dbContext.GameAccounts.Remove(updateGameAccount);
                gameAccount.Id = updateGameAccount.Id;
                updateGameAccount = gameAccount;
                dbContext.GameAccounts.Add(updateGameAccount);
            }
        }

        public void DeleteGameAccount(int accountId)
        {
            var updateGameAccount = dbContext.GameAccounts.FirstOrDefault(g => g.Id == accountId);
            if (updateGameAccount != null)
            {
                dbContext.GameAccounts.Remove(updateGameAccount);
            }
        }
    }
}