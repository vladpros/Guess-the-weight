using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Game
    {
        int Win = 87;
        int K;
        InOutConsole _inOut = new InOutConsole();

        public void StartGame()
        {

            List<int> list = new List<int>();
            List<Data> players = CreatPlayer();
            int bliz = 1000;
            int bestPlayers = 0;

            _inOut.Players(players);

            _inOut.WinNumber(Win);


            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < K; j++)
                {
                    int number = players[j].player.ChooseNumber(list);
                    list.Add(number);

                    if(number == Win)
                    {
                        _inOut.Win(players[j]);
                        return;
                    }
                    if ((Win - number) < (Win - bliz))
                    {
                        bliz = number;
                        bestPlayers = j;
                    }
                }
            }

            _inOut.Win(players[bestPlayers]);

        }

        public List<Data> CreatPlayer()
        {
            List<Data> list = new List<Data>();

            K = _inOut.Amount();

            for (int i = 0; i < K; i++)
            {
                string name = _inOut.String();
                TypePlayer t = _inOut.TypePlayers();
                list.Add(new Data(name, t));
            }

            return list;
        }
    }
}
