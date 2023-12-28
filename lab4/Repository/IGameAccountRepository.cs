using lab4.GameAccounts;
using System.Collections.Generic;

namespace lab4.Repository
{
    public interface IGameAccountRepository
    {
        void CreateGameAccount(GameAccount gameAccount);
        GameAccount ReadGameAccountById(int accountId);
        List<GameAccount> ReadAllGameAccounts();
        void UpdateGameAccount(int accountId, GameAccount gameAccount);
        void DeleteGameAccount(int accountId);
    }
}