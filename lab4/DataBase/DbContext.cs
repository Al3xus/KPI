using lab4.GameAccounts;
using lab4.GameTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.DataBase
{
    public class DbContext
    {
        public List<GameAccount> GameAccounts { get; set; } = new List<GameAccount>();
        public List<Game> Games { get; set; } = new List<Game>();
    }
}
