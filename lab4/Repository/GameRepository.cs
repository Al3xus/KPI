using lab4.DataBase;
using lab4.GameTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4.Repository
{
    public class GameRepository : IGameRepository
    {
        private DbContext dbContext;

        public GameRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateGame(Game game)
        {
            dbContext.Games.Add(game);
        }

        public Game ReadGameById(int gameId)
        {
            return dbContext.Games.FirstOrDefault(g => g.GameId == gameId);
        }

        public List<Game> ReadAllGames()
        {
            return dbContext.Games.ToList();
        }

        public void UpdateGame(int gameId, Game game)
        {
            var updateGame = dbContext.Games.FirstOrDefault(g => g.GameId == gameId);
            if (updateGame != null)
            {
                dbContext.Games.Remove(updateGame);
                game.GameId = updateGame.GameId;
                updateGame = game;
                dbContext.Games.Add(updateGame);
            }
        }

        public void DeleteGame(int gameId)
        {
            var deleteGame = dbContext.Games.FirstOrDefault(g => g.GameId == gameId);
            if (deleteGame != null)
            {
                dbContext.Games.Remove(deleteGame);
            }
        }

        public void PrintAllGame()
        {
            var allGames = ReadAllGames();

            Console.WriteLine("┌────────────┬────────────┬────────────┐");
            Console.WriteLine("│ Winner     │ Loser      │ Game Index │");
            Console.WriteLine("├────────────┼────────────┼────────────┤");

            foreach (var game in allGames)
            {
                Console.WriteLine($"│ {game.FirstOpponentName,-11}│ {game.SecondOpponentName,-11}│ {game.GameId,11}│");
            }

            Console.WriteLine("└────────────┴────────────┴────────────┘");
        }



    }
}