using System;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.PackageForGame
{
    // Класс GameHistory представляет запись об истории игры между двумя игроками.
    public class GameHistory
    {
        // Уникальный идентификатор записи об истории.
        public string Id { get; }

        // Игрок 1.
        public Account Player1 { get; }

        // Игрок 2.
        public Account Player2 { get; }

        // Рейтинг игры.
        public int Rating { get; set; }

        // Результат игры (победа, поражение, ничья).
        public GameOutcome Outcome { get; }

        // Конструктор класса GameHistory.
        public GameHistory(Account player1, Account player2, int rating, GameOutcome outcome)
        {
            // Генерация уникального идентификатора.
            Id = GetId();
            
            // Инициализация игроков и результатов игры.
            Player1 = player1;
            Player2 = player2;
            Rating = rating;
            Outcome = outcome;
        }

        // Метод для генерации уникального идентификатора.
        private static string GetId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}