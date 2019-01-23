using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class UberCheaterPlayer : CheaterPlayer
    {
        static int number = 1;
        public static new int ChooseNumber(List<int> list)
        {
            
            return GetNumberOutList(list, number);
        }
    }
}
