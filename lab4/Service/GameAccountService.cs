
using lab4.GameAccounts;
using lab4.GameTypes;
using lab4.Repository;
using lab4.Service;
using System;
using System.Collections.Generic;

namespace lab4.Service
{
    public class GameAccountService : IGameAccountService
    {
        private IGameAccountRepository gameAccountRepository;

        public GameAccountService(IGameAccountRepository gameAccountRepository)
        {
            this.gameAccountRepository = gameAccountRepository;
        }

        public void CreateGameAccount(string userName, int initialRating, string type)
        {
            GameAccount gameAccount;

            switch (type.ToLower())
            {
                case "premium":
                    gameAccount = new PremiumGameAccount(userName, initialRating);
                    break;

                case "standard":
                    gameAccount = new StandardGameAccount(userName, initialRating);
                    break;

                case "winstreak":
                    gameAccount = new WinStreakGameAccount(userName, initialRating);
                    break;

                default:
                    throw new ArgumentException("Invalid account type", nameof(type));
            }

            gameAccountRepository.CreateGameAccount(gameAccount);
        }

        public GameAccount ReadGameAccountById(int accountId)
        {
            return gameAccountRepository.ReadGameAccountById(accountId);
        }

        public List<GameAccount> ReadAllGameAccounts()
        {
            return gameAccountRepository.ReadAllGameAccounts();
        }

        public void UpdateGameAccount(int accountId, GameAccount gameAccount)
        {
            gameAccountRepository.UpdateGameAccount(accountId, gameAccount);
        }

        public void DeleteGameAccount(int accountId)
        {
            gameAccountRepository.DeleteGameAccount(accountId);
        }

        public void WinGame(int accountId, Game game)
        {
            GameAccount gameAccount = gameAccountRepository.ReadGameAccountById(accountId);
            gameAccount.WinGame(game);
            gameAccountRepository.UpdateGameAccount(accountId, gameAccount);
        }

        public void LoseGame(int accountId, Game game)
        {
            GameAccount gameAccount = gameAccountRepository.ReadGameAccountById(accountId);
            gameAccount.LoseGame(game);
            gameAccountRepository.UpdateGameAccount(accountId, gameAccount);
        }

        public void GetStats(int accountId)
        {
            GameAccount gameAccount = gameAccountRepository.ReadGameAccountById(accountId);
            gameAccount.GetStats();
        }
    }
}