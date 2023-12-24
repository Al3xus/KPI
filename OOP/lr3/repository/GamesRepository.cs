using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class GamesRepository : IGamesRepository
    {
        private DbContext db;
        public GamesRepository()
        {
            db = new DbContext();
        }

        public IEnumerable<FinishedGame> GetAllGames()
        {
            return db.FGames;
        }

        public void Create(FinishedGame game)
        {
            db.FGames.Add(game);
        }

        public void Delete(int id)
        {
            FinishedGame fgame = db.FGames.FirstOrDefault(game => game.GameId == id);
            if (fgame != null)
            {
                db.FGames.Remove(fgame);
            }
        }

        public FinishedGame GetById(int id)
        {
            return db.FGames.FirstOrDefault(game => game.GameId == id);
        }

        public void Update(FinishedGame game, int id)
        {
            game.GameId = id;
        }
    }
}
