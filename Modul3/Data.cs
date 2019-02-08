using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{

    enum TypePlayer
    {
        Player = 0,
        NotePlayer = 1,
        UberPlayer = 2,
        CheaterPlayer = 3,
        UberCheaterPlayer = 4
    }

    class Data
    {
        public string name { get ; set; }

        public TypePlayer t { get; set; }

        public IPlayer player { get; }

        public Data(string Name, TypePlayer T)
        {
            this.name = Name;
            this.t = T;
            switch (t)
            {
                case TypePlayer.Player:
                    player = new Player();
                    break;
                case TypePlayer.NotePlayer:
                    player = new NotePlayer();
                    break;
                case TypePlayer.UberPlayer:
                    player = new UberPlayer();
                    break;
                case TypePlayer.CheaterPlayer:
                    player = new CheaterPlayer();
                    break;
                case TypePlayer.UberCheaterPlayer:
                    player = new UberCheaterPlayer();
                    break;
            }


        }


        
    }
}
