using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    interface IPlayer
    {

        int ChooseNumber(List<int> list);

        List<int> UsedNumberAdd(int q);

        List<int> UsedNumberAll();
    }
}
