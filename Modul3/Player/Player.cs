using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3 
{

    public class Player : IPlayer
    {
        Random random = new Random(1);

        public int ChooseNumber(List<int> list)
        {
           return GetRandNumber();
        }

        protected int GetRandNumber()
        {

            int x = random.Next(1, 101);
            return x;
        }

        protected int GetRandNumberOutList(List<int> choosenumbers)
        {
            int x = GetRandNumber();

            while (choosenumbers.Contains(x))
            {
                x = GetRandNumber();
                return x;
            }
            return x;
        }

    }
}
