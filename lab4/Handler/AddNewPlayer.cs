using lab4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handler
{
    public class AddNewPlayer : IGameHandler
    {
        private readonly IGameAccountService gameAccountService;

        public AddNewPlayer(IGameAccountService gameAccountService)
        {
            this.gameAccountService = gameAccountService;
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Введите имя игрока:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Введите рейтинг игрока:");
            int initialRating = Convert.ToInt32(Console.ReadLine());
            string accountType;
            do
            {
                Console.WriteLine("Тип входного аккаунта: Standard,WinStreak,Premium:");
                accountType = Console.ReadLine();
            } while (accountType != "Premium" && accountType != "Standard" && accountType != "WinStreak");

            gameAccountService.CreateGameAccount(playerName, initialRating, accountType);
        }

        public string ShowInfo()
        {
            return "Добавить нового игрока";
        }
    }
}
