using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Game
    {
        public void StartGame()
        {
            List<int> list = new List<int>();
            List<IPlayer> players = new List<IPlayer>();

            players.Add(new Player());
            players.Add(new CheaterPlayer());

            Console.WriteLine(players[1].ChooseNumber(list)); 

        }

    }
}
