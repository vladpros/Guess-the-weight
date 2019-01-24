using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul3
{
    class Game
    {
        int Win = 87;
        int K;
        int Bliz = 1000;
        List<int> Used = new List<int>();
        string BestPlayers;
        InOutConsole _inOut = new InOutConsole();
        object _locker = new object();

        public void StartGame()
        {

            List<Data> players = CreatPlayer();
            var pts1 = new ParameterizedThreadStart(Threads);

            _inOut.Players(players);

            _inOut.WinNumber(Win);


            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < K; j++)
                {
                    Thread thread = new Thread(pts1);
                    thread.Start(players[j]);
                }
            }

            for (int i = 0; i < K; i++)
            {
                if(BestPlayers == players[i].name)
                    _inOut.Win(players[i]);
            }

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

        public void Threads (object input1)
        {
            lock (_locker)
            {
                Data input = (Data)input1;

                int number = input.player.ChooseNumber(Used);
                Used.Add(number);

                if (number == Win)
                {
                    _inOut.Win(input);
                }
                if ((Win - number) < (Win - Bliz))
                {
                    Bliz = number;
                    BestPlayers = input.name;
                }
            }
            Thread.Sleep(300);
        }
    }
}
