using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3 
{

    public class Player : IPlayer
    {
        static Random random = new Random();

        public int ChooseNumber(List<int> list)
        {

           return GetRandNumber();
        }

        public static int GetRandNumber()
        {

            int x = random.Next(Const.StartVal, Const.EndVal+1);
            return x;
        }

        protected int GetRandNumberOutList(List<int> choosenumbers)
        {
            int x = GetRandNumber();

            while (choosenumbers.Contains(x))
            {
                x = GetRandNumber();
            }

            return x;
        }

    }
}
