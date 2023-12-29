using tic_tac_toe.Enums;
using tic_tac_toe.PackageForGame;

namespace tic_tac_toe.PackageForPlayers
{
    public class PremiumAccount : Account
    {
        // Конструктор класса PremiumAccount, вызывает конструктор базового класса
        public PremiumAccount(string firstName, string lastName, string userName, string password) : base(firstName,
            lastName, userName, password)
        {
            // Устанавливаем тип аккаунта как Преміум
            TypeAccount = TypeAccount.Преміум; 
        }

        // Переопределенный метод для обработки выигрыша в игре
        public override void WinGame(TypeGame typeGame, GameHistory game, Account opponent)
        {
            var beforeRating = CurrentRating;
            // Увеличиваем текущий рейтинг игрока при выигрыше
            CurrentRating += game.Rating * 2;
            // Добавляем историю в результаты игрока
            Results.Add(new PlayerHistory(typeGame, game.Id, game.Rating, GameOutcome.WIN, opponent, beforeRating,
                CurrentRating));
        }

        // Переопределенный метод для обработки проигрыша в игре
        public override void LoseGame(TypeGame typeGame, GameHistory game, Account opponent)
        {
            var beforeRating = CurrentRating;
            // Уменьшаем текущий рейтинг игрока при проигрыше
            CurrentRating -= game.Rating / 2;
            // Добавляем историю в результаты игрока
            Results.Add(new PlayerHistory(typeGame, game.Id, game.Rating, GameOutcome.LOSE, opponent, beforeRating,
                CurrentRating));
        }
    }
}