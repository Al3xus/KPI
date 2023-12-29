using System.Linq;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.PackageForGame
{
    public class TrainingGame : Game
    {
        // Конструктор класса TrainingGame.
        public TrainingGame()
        {
            // Установка типа игры.
            TypeGame = TypeGame.TrainingGame;
        }

        // Реализация метода для обработки результатов реальной игры.
        public override void RealPlayingGame(Account player1, Account player2, int rating, int result)
        {
            // Обнуление рейтинга (тренировочные игры не влияют на рейтинг).
            rating = 0;

            // Обработка результата игры в зависимости от значения result.
            switch (result)
            {
                case 0:
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                    player1.TieGame(TypeGame, Results.Last(), player2);
                    player2.TieGame(TypeGame, Results.Last(), player1);
                    break;
                case 1:
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.WIN));
                    player1.WinGame(TypeGame, Results.Last(), player2);
                    player2.LoseGame(TypeGame, Results.Last(), player1);
                    break;
                default:
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.LOSE));
                    player1.LoseGame(TypeGame, Results.Last(), player2);
                    player2.WinGame(TypeGame, Results.Last(), player1);
                    break;
            }
        }

        // Реализация метода для обработки результатов игры для тренировки.
        public override void PlayingGame(Account player1, Account player2, int rating = 0)
        {
            // Обнуление рейтинга (тренировочные игры не влияют на рейтинг).
            rating = 0;

            // Генерация случайного числа для определения результата игры.
            var random = Random.Next(1, 101);

            // Логика определения результата игры на основе случайного числа.
            if (random % 10 == 0)
            {
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                player1.TieGame(TypeGame, Results.Last(), player2);
                player2.TieGame(TypeGame, Results.Last(), player1);
            }
            else if (random % 2 == 0)
            {
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.WIN));
                player1.WinGame(TypeGame, Results.Last(), player2);
                player2.LoseGame(TypeGame, Results.Last(), player1);
            }
            else
            {
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.LOSE));
                player1.LoseGame(TypeGame, Results.Last(), player2);
                player2.WinGame(TypeGame, Results.Last(), player1);
            }
        }
    }
}
