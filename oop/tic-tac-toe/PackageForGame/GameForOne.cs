using System.Linq;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.PackageForGame
{
    public class GameForOne : Game
    {
        // Конструктор класса
        public GameForOne()
        {
            // Устанавливаем тип игры как GameForOne
            TypeGame = TypeGame.GameForOne;
        }
        // Метод реальной игры для одного игрока
        public override void RealPlayingGame(Account player1, Account player2, int rating, int result)
        {
            switch (result)
            {
                // Если результат игры - ничья (0), добавляем запись в историю игр с соответствующими результатами.
                case 0:
                    Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                    // Обновляем статистику для обоих игроков по ничьей.
                    player1.TieGame(TypeGame, Results.Last(), player2);
                    player2.TieGame(TypeGame, Results.Last(), player1);
                    break;
                case 1:
                {
                    // Если результат игры - победа (1), обрабатываем результаты победы и обновляем статистику для игроков
                    var game = new GameHistory(player1, player2, 0, GameOutcome.WIN);
                    player2.LoseGame(TypeGame, game, player1);
                    game.Rating = rating;
                    player1.WinGame(TypeGame, game, player2);
                    Results.Add(game);
                    break;
                }
                default:
                {
                    // Если результат игры - поражение (не 0 и не 1), обрабатываем результаты поражения и обновляем статистику
                    var game = new GameHistory(player1, player2, 0, GameOutcome.LOSE);
                    player2.WinGame(TypeGame, game, player1);
                    game.Rating = rating;
                    player1.LoseGame(TypeGame, game, player2);
                    Results.Add(game);
                    break;
                }
            }
        }

        // Метод случайной игры для одного игрока
        public override void PlayingGame(Account player1, Account player2, int rating)
        {
            // Генерируем случайное число от 1 до 100
            var random = Random.Next(1, 101);

            if (random % 10 == 0)
            {
                // Если случайное число делится на 10 без остатка, игра заканчивается в ничью
                Results.Add(new GameHistory(player1, player2, rating, GameOutcome.TIE));
                player1.TieGame(TypeGame, Results.Last(), player2);
                player2.TieGame(TypeGame, Results.Last(), player1);
            }
            else if (random % 2 == 0)
            {
                // Если случайное число четное, игрок побеждает
                var game = new GameHistory(player1, player2, 0, GameOutcome.WIN);
                player2.LoseGame(TypeGame, game, player1);
                game.Rating = rating;
                player1.WinGame(TypeGame, game, player2);
                Results.Add(game);
            }
            else
            {
                // Если случайное число нечетное, игрок проигрывает
                var game = new GameHistory(player1, player2, 0, GameOutcome.LOSE);
                player2.WinGame(TypeGame, game, player1);
                game.Rating = rating;
                player1.LoseGame(TypeGame, game, player2);
                Results.Add(game);
            }
        }
    }
}