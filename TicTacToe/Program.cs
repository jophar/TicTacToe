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
            TicTacToe t = new TicTacToe();

            do
            {
                TicTacToe.PrintBoard(t);
                TicTacToe.InsertPlay(t, t.activePlayer);
                Console.Clear();
            }
            while (!TicTacToe.ValidateWin(t));

            TicTacToe.PrintBoard(t);
            t.ValidateWinner();

        }
    }
}
