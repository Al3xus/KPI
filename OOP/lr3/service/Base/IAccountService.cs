using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IAccountService
    {
        public GameAccount CreateAccount(int ind, string name, decimal pts, int id);
        public void ReadAccounts();
        public Player ReadAccountById(int id);
        public GameAccount ReadAccount(int id);
        public void ReadPlayedGamesByPlayer(int id);
    }
}
   
