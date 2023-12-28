using lab4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handler
{
    public class DisplayPlayerStats : IGameHandler
    {
        private readonly IGameAccountService gameAccountService;

        public DisplayPlayerStats(IGameAccountService gameAccountService)
        {
            this.gameAccountService = gameAccountService;
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Введите айди игрока:");
            int playerId = Convert.ToInt32(Console.ReadLine());

            gameAccountService.GetStats(playerId);
        }

        public string ShowInfo()
        {
            return "Показать статистику игрока";
        }
    }
}
