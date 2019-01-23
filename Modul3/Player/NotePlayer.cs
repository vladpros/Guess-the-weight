using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class NotePlayer : Player
    {
        private static List<int> choosenumbers = new List<int>(100);

        public static new int ChooseNumber()
        {
            int x = GetRandNumberOutList(choosenumbers);
            choosenumbers[x - 1] = 1;
            return x;
        }

    }
}
