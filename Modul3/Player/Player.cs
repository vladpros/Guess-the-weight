using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3 
{
    class Player 
    {
      public static int ChooseNumber()
        {
           return GetRandNumber();
        }

        protected static int GetRandNumber()
        {

            Random random = new Random();

            return (int)random.Next(1, 101);
        }

        protected static int GetRandNumberOutList(List<int> choosenumbers)
        {
            int x = GetRandNumber();

            while (choosenumbers[x - 1] == 1)
            {
                x = GetRandNumber();
                return x;
            }
            return x;
        }

        protected static int GetNumberOutList(List<int> choosenumbers, int x)
        {

            while (choosenumbers[x - 1] == 1)
            {
                x ++;
                return x;
            }
            return x;
        }
    }
}
