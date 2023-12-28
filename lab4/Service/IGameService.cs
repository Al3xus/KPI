using lab4.GameAccounts;
using lab4.GameTypes;
using lab4.Repository;
using lab4.Service;
using System.Collections.Generic;

namespace lab4.Service
{
    public interface IGameService
    {
        void StartGame(string typeGame, GameAccount player1, GameAccount player2, int rate);
        Game ReadGameById(int gameId);
        List<Game> ReadAllGames();
        void UpdateGame(int gameId, Game game);
        void DeleteGame(int gameId);
        void PrintAllGame();
    }
}