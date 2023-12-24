using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IPlayersRepository
    {
        IEnumerable<Player> GetAllPlayers();
        Player GetById(int id);
        GameAccount GetAccountById(int id);
        Player GetByName(string name);
        void Create(Player player);
        void CreateAccount(GameAccount player);
        void Delete(int id);
        void UpdateId(Player player, int newId);
        void UpdatePts(Player player, decimal newPts);
        void UpdateName(Player player, string newname);

    }
}
