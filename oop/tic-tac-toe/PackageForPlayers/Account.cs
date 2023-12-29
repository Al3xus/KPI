using System.Collections.Generic;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForGame;

namespace tic_tac_toe.PackageForPlayers
{
    public class Account
    {
        // Конструктор класса, принимающий данные для создания аккаунта.
        public Account(string firstName, string lastName, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Results = new List<PlayerHistory>();
            TypeAccount = TypeAccount.Класичний; // По умолчанию тип аккаунта - Классический.
        }

        // Свойства для доступа к данным аккаунта.
        public string FirstName { get; }
        public string LastName { get; }
        public string UserName { get; }
        public TypeAccount TypeAccount { get; protected set; } 
        public string Password { get; }

        // Текущий рейтинг аккаунта.
        private int _currentRating = 1;
        public int CurrentRating
        {
            get => _currentRating;
            set => _currentRating = value < 1 ? 1 : value; // Рейтинг не может быть меньше 1.
        }

        // Список с историей результатов игр.
        public List<PlayerHistory> Results { get; }

        // Метод для обработки победы в игре.
        public virtual void WinGame(TypeGame typeGame, GameHistory game, Account opponent)
        {
            var beforeRating = CurrentRating;
            CurrentRating += game.Rating; // Увеличение рейтинга игрока на величину выигрыша.
            Results.Add(new PlayerHistory(typeGame, game.Id, game.Rating, GameOutcome.WIN, opponent, beforeRating, CurrentRating));
        }

        // Метод для обработки поражения в игре.
        public virtual void LoseGame(TypeGame typeGame, GameHistory game, Account opponent)
        {
            var beforeRating = CurrentRating;
            CurrentRating -= game.Rating; // Уменьшение рейтинга игрока на величину проигрыша.
            Results.Add(new PlayerHistory(typeGame, game.Id, game.Rating, GameOutcome.LOSE, opponent, beforeRating, CurrentRating));
        }

        // Метод для обработки ничьей в игре.
        public void TieGame(TypeGame typeGame, GameHistory game, Account opponent)
        {
            Results.Add(new PlayerHistory(typeGame, game.Id, game.Rating, GameOutcome.TIE, opponent, CurrentRating, CurrentRating));
        }
    }
}
