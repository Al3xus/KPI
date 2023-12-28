using lab4.Factory;
using lab4.GameAccounts;
using lab4.GameTypes;
using lab4.Repository;
using lab4.Service;
using System.Collections.Generic;

namespace lab4.Service
{
    public class GameService : IGameService
    {
        private IGameRepository gameRepository;
        private IGameAccountService gameAccountService;

        public GameService(IGameRepository gameRepository, IGameAccountService gameAccountService)
        {
            this.gameRepository = gameRepository;
            this.gameAccountService = gameAccountService;
        }
        public void StartGame(string typeGame, GameAccount player1, GameAccount player2, int rate)
        {
            Game gameWin = GameFactory.CreateGame(typeGame, player1, player2, rate);
            gameRepository.CreateGame(gameWin);
            gameAccountService.WinGame(player1.Id, gameWin);
            Game.gameIdCounter--;
            Game gameLose = GameFactory.CreateGame(typeGame, player2, player1, rate);
            gameAccountService.LoseGame(player2.Id, gameLose);
        }
        public Game ReadGameById(int gameId)
        {
            return gameRepository.ReadGameById(gameId);
        }

        public List<Game> ReadAllGames()
        {
            return gameRepository.ReadAllGames();
        }

        public void UpdateGame(int gameId, Game game)
        {
            gameRepository.UpdateGame(gameId, game);
        }

        public void DeleteGame(int gameId)
        {
            gameRepository.DeleteGame(gameId);
        }

        public void PrintAllGame()
        {
            gameRepository.PrintAllGame();
        }
    }
}