using System.Linq;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.PackageForGame
{
    public class ClassicGame : Game
    {
        public ClassicGame()
        {
            TypeGame = TypeGame.ClassicGame;
        }

        // Реализация метода абстрактного класса Game для реальной игры
        public override void RealPlayingGame(Account player1, Account player2, int rating, int result)
        {
            switch (result)
            {
                case 0:
                    // Ничья
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                    player1.TieGame(TypeGame, Results.Last(), player2);
                    player2.TieGame(TypeGame, Results.Last(), player1);
                    break;
                case 1:
                    // Победа первого игрока
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.WIN));
                    player1.WinGame(TypeGame, Results.Last(), player2);
                    player2.LoseGame(TypeGame, Results.Last(), player1);
                    break;
                default:
                    // Победа второго игрока
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.LOSE));
                    player1.LoseGame(TypeGame, Results.Last(), player2);
                    player2.WinGame(TypeGame, Results.Last(), player1);
                    break;
            }
        }

        // Реализация метода абстрактного класса Game для игры (симуляция случайных результатов)
        public override void PlayingGame(Account player1, Account player2, int rating)
        {
            var random = Random.Next(1, 101);

            if (random % 10 == 0)
            {
                // Ничья
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                player1.TieGame(TypeGame, Results.Last(), player2);
                player2.TieGame(TypeGame, Results.Last(), player1);
            }
            else if (random % 2 == 0)
            {
                // Победа первого игрока
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.WIN));
                player1.WinGame(TypeGame, Results.Last(), player2);
                player2.LoseGame(TypeGame, Results.Last(), player1);
            }
            else
            {
                // Победа второго игрока
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.LOSE));
                player1.LoseGame(TypeGame, Results.Last(), player2);
                player2.WinGame(TypeGame, Results.Last(), player1);
            }
        }
    }
}
