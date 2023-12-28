using lab4.GameTypes;
using System.Collections.Generic;

namespace lab4.Repository
{
    public interface IGameRepository
    {
        void CreateGame(Game game);
        Game ReadGameById(int gameId);
        List<Game> ReadAllGames();

        void UpdateGame(int gameId, Game game);
        void DeleteGame(int gameId);
        void PrintAllGame();
    }
}