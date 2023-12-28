using lab4.GameAccounts;
using lab4.GameTypes;
using lab4.Repository;
using lab4.Service;
using System.Collections.Generic;

namespace lab4.Service
{
    public interface IGameAccountService
    {
        void CreateGameAccount(string userName, int initialRating, string type);
        GameAccount ReadGameAccountById(int accountId);
        List<GameAccount> ReadAllGameAccounts();
        void UpdateGameAccount(int accountId, GameAccount gameAccount);
        void DeleteGameAccount(int accountId);
        void WinGame(int accountId, Game game);
        void LoseGame(int accountId, Game game);
        void GetStats(int accountId);
    }
}