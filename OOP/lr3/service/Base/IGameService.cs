using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IGameService
    {
        public void ReadGames();
        public void CreateGame(GameAccount p1, GameAccount p2, Game game);


    }
}
