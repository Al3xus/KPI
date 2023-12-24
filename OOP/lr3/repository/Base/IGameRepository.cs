using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IGamesRepository
    {
        IEnumerable<FinishedGame> GetAllGames();
        FinishedGame GetById(int id);
        void Create(FinishedGame game);
        void Update(FinishedGame game, int id);
        void Delete(int id);
    }
}

