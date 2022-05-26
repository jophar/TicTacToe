using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rounds = 0;
            TicTacToe t = new TicTacToe();

            while(rounds != 8)
            {
                TicTacToe.PrintBoard(t);
                TicTacToe.InsertPlay(t, t.activePlayer);
                Console.Clear();

                rounds++;
            }

        }
    }
}
