using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class NotePlayer : Player, IPlayer
    {
        private List<int> choosenumbers = new List<int>(100);


        public new int ChooseNumber(List<int> list)
        {
            int x = GetRandNumberOutList(choosenumbers);
            choosenumbers.Add(x);
            return x;
        }

    }
}
