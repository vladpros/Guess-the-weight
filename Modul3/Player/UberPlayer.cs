﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class UberPlayer : Player
    {
        static int number = 0;

        public static new int ChooseNumber()
        {

            return number++;
        }
    }
}