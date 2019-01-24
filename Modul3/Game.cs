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
        int WinNumber = Player.GetRandNumber();
        int PlayerCount;
        int BestRazn = 1000;
        List<int> Used = new List<int>();
        string BestPlayers;
        InOutConsole inOut = new InOutConsole();
        object _locker = new object();

        public void StartGame()
        {

            List<Data> players = CreatPlayer();
            var pts1 = new ParameterizedThreadStart(Threads);

            inOut.Players(players);

            inOut.OutWinNumber(WinNumber);


            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < PlayerCount; j++)
                {
                    Thread thread = new Thread(pts1);
                    thread.Start(players[j]);
                }
            }

            for (int i = 0; i < PlayerCount; i++)
            {
                if(BestPlayers == players[i].name)
                    inOut.WinMassege(players[i]);
            }

        }

        public List<Data> CreatPlayer()
        {
            List<Data> list = new List<Data>();

            PlayerCount = inOut.Amount();

            for (int i = 0; i < PlayerCount; i++)
            {
                string name = inOut.String();
                TypePlayer t = inOut.TypePlayers();
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

                if (number == WinNumber)
                {
                    inOut.WinMassege(input);
                }
                if ((WinNumber - number) < (WinNumber - BestRazn))
                {
                    BestRazn = number;
                    BestPlayers = input.name;
                }
            }
            Thread.Sleep(300);
            
        }
    }
}
