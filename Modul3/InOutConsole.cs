using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class InOutConsole
    {
        public int Amount()
        {
            int k = 0;
            Console.WriteLine("Enter amount of player: ");
            while (!Int32.TryParse(Console.ReadLine(), out k) || IfCorrectInputDataNumber(k))
            {
                Console.WriteLine("Wrong data!!!");
                Console.WriteLine("Please try another: ");
            }
            Console.Clear();

            return k;
        }

        public string String()
        {
            Console.Clear();
            string str = "";
            Console.WriteLine("Enter name of player: ");
            str = Console.ReadLine();
            Console.Clear();

            return str;
        }

        public TypePlayer TypePlayers()
        {
            TypePlayer t;
            int x = 0;
            Console.Clear();
            Console.WriteLine("Please choose type of player: \n1.Player\n2.Note Player\n3.Uber Player\n4.Cheater\n5.Uber Cheater");

            while (!Int32.TryParse(Console.ReadLine(), out x) || IfCorrectInputDataType(x))
            {
                Console.WriteLine("Wrong data!!!");
                Console.WriteLine("Please try another: ");
            }

            t = (TypePlayer)(x-1);

            return t;
        }

        public void WinMassege(string win)
        {
            Console.WriteLine($"Congruutilations {win} you win!!!!!");
            Console.WriteLine($"Please press any button...");
            Console.ReadLine();
            Environment.Exit(0);

        }

        public void OutWinNumber(int k)
        {
            Console.WriteLine($"Win number: {k}");
            Console.WriteLine($"Please press any button...");
            Console.ReadLine();
            Console.WriteLine($"Somthing wait please...");
        }

        public void Players(List<Data> list)
        {
            Console.Clear();
            Console.WriteLine($"Player list:\n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i].name} hi`s {list[i].t};");
            }

            Console.WriteLine($"Please press any button...");
            Console.ReadLine();
        }

        public void PlayerNumber(List<Data> list)
        {

            Console.WriteLine("Used number:");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i].name} choos:");
                ShowList(list[i].player.UsedNumberAll());
                Console.Write(";\n");
            }
            Console.WriteLine();
        }

        public void ShowList(List<int> list)
        {
            foreach(var number in list)
            {
                Console.Write($" {number}");
            }
        }

        private bool IfCorrectInputDataType(int x)
        {
            bool k = x < 1 || x > 5;
            return true;
        }

        private bool IfCorrectInputDataNumber(int x)
        {
            bool k = x < Const.MinPlayers || x > Const.MaxPlayers;
            return true;
        }
    }
}
