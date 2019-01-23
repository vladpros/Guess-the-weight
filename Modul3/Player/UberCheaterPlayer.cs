using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class UberCheaterPlayer : CheaterPlayer
    {
        static int number = 0;
        public new int ChooseNumber(List<int> list)
        {
            number++;
            return GetNumberOutList(list, number);
        }

        protected int GetNumberOutList(List<int> choosenumbers, int x)
        {

            while (choosenumbers.Contains(x))
            {
                x++;
                return x;
            }
            return x;
        }
    }
}
