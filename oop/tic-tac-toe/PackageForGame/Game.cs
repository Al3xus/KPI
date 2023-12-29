using System;
using System.Collections.Generic;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.PackageForGame
{
    public abstract class Game
    {
        // Список для хранения истории результатов игр
        protected List<GameHistory> Results { get; }

        // Тип игры
        protected TypeGame TypeGame { get; set; }

        // Генератор случайных чисел
        protected readonly Random Random;

        // Конструктор класса
        protected Game()
        {
            Results = new List<GameHistory>();
            Random = new Random();
        }

        // Абстрактный метод для симуляции игры
        public abstract void PlayingGame(Account player1, Account player2, int rating);

        // Абстрактный метод для реальной игры с указанием результата
        public abstract void RealPlayingGame(Account player1, Account player2, int rating, int result);
    }
}