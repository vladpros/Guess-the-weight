using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{

    class CheaterPlayer : Player, IPlayer
    {
        public new int ChooseNumber(List<int> list)
        {

            return GetRandNumberOutList(list);
        }

    }
}
