using lab4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handler
{
    public class DisplayPlayers : IGameHandler
    {
        private readonly IGameAccountService gameAccountService;

        public DisplayPlayers(IGameAccountService gameAccountService)
        {
            this.gameAccountService = gameAccountService;
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Все игроки:");
            foreach (var player in gameAccountService.ReadAllGameAccounts())
            {
                Console.WriteLine($"{player.UserName} - {player.CurrentRating}");
            }
        }

        public string ShowInfo()
        {
            return "Показать всех игроков";
        }
    }
}
