using lab4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handler
{
    public class Exit : IGameHandler
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("Закрыть программу");

        }

        public string ShowInfo()
        {
            return "Выйти в окно";
        }
    }
}
