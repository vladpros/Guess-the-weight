using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class UberCheaterPlayer : CheaterPlayer, IPlayer
    {
        int number = Const.StartVal-1;

        public new int ChooseNumber(List<int> list)
        {
            number++;

            return GetNumberOutList(list);
        }

        protected int GetNumberOutList(List<int> choosenumbers)
        {
            while (choosenumbers.Contains(number))
            {
                number++;
            }

            return number;
        }
    }
}
