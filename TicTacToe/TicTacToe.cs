using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToe
    {
        /* Tabuleiro
         *   |  1   2   3 (X)
         * --|---------------    
         * 1 |  a | b | c
         *   | -----------
         * 2 |  d | e | f
         *   | -----------
         * 3 |  g | h | i
         *(Y)  
         */

        internal string activePlayer = "O";

        private string CoordOne { get; set; }
        private string CoordTwo { get; set; }
        private string CoordThree { get; set; }
        private string CoordFour { get; set; }
        private string CoordFive { get; set; }
        private string CoordSix { get; set; }
        private string CoordSeven { get; set; }
        private string CoordEight { get; set; }
        private string CoordNine { get; set; }


        internal TicTacToe()
        {
            CoordOne = " ";
            CoordTwo = " ";
            CoordThree = " ";
            CoordFour = " ";
            CoordFive = " ";
            CoordSix = " ";
            CoordSeven = " ";
            CoordEight = " ";
            CoordNine = " ";
        }

        internal Dictionary<(int, int), string> coordConvert = new Dictionary<(int, int), string>()
            {
                {(1,1), "a" },
                {(2,1), "b" },
                {(3,1), "c" },
                {(1,2), "d" },
                {(2,2), "e" },
                {(3,2), "f" },
                {(1,3), "g" },
                {(2,3), "h" },
                {(3,3), "i" }
            };
        internal static void PrintBoard(TicTacToe t)
        {
            Console.WriteLine( "   |  1   2   3 ");
            Console.WriteLine( "---|-------------");
            Console.WriteLine($" 1 |  {t.CoordOne} | {t.CoordTwo} | {t.CoordThree}");
            Console.WriteLine($"   |-------------");
            Console.WriteLine($" 2 |  {t.CoordFour} | {t.CoordFive} | {t.CoordSix}");
            Console.WriteLine($"   |-------------");
            Console.WriteLine($" 3 |  {t.CoordSeven} | {t.CoordEight} | {t.CoordNine}");
            Console.WriteLine("\n\n");
        }

        private static void InvalidPlay()
        {
            Console.WriteLine("Invalid play, please select another field");
            Console.WriteLine("Press key to continue...");
            Console.ReadKey();
        }
        internal static TicTacToe InsertPlay(TicTacToe t, string player)
        {
            string coord = string.Empty;
            Console.Write($"{t.activePlayer} insert coordinate to play (x y): ");
            coord = Console.ReadLine();

            var textSplit = coord.Split(' ');
            bool one = int.TryParse(textSplit[0], out int a);
            bool two = int.TryParse(textSplit[1], out int b); //  o segundo try parse nao funciona se for dado um valor sem espaços

            if (one && two && a <= 3 && b <= 3)
            {
                t = ValidatePlay(a, b, t, t.activePlayer);
                return t;
            }
            else
            {
                Console.WriteLine("Incorret coordinate inserted, try again;");
                Console.ReadKey();
                return t;
            }
        }

        // TODO: Refaturar o metodo
        internal static TicTacToe ValidatePlay(int a, int b, TicTacToe t, string p)
        {
            switch (t.coordConvert[(a, b)])
            {
                case "a":
                    {
                        if (t.CoordOne != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            { 
                                t.CoordOne = t.activePlayer;
                                t.activePlayer = "X";

                            }
                            else
                            {
                                t.CoordOne = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "b":
                    {
                        if (t.CoordTwo != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordTwo = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordTwo = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "c":
                    {
                        if (t.CoordThree != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordThree = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordThree = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "d":
                    {
                        if (t.CoordFour != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordFour = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordFour = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "e":
                    {
                        if (t.CoordFive != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordFive = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordFive = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "f":
                    {
                        if (t.CoordSix != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordSix = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordSix = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "g":
                    {
                        if (t.CoordSeven != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordSeven = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordSeven = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "h":
                    {
                        if (t.CoordEight != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordEight = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordEight = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;

                case "i":
                    {
                        if (t.CoordNine != " ")
                        {
                            InvalidPlay();
                            break;
                        }

                        else
                        {
                            if (t.activePlayer == "O")
                            {
                                t.CoordNine = t.activePlayer;
                                t.activePlayer = "X";
                            }
                            else
                            {
                                t.CoordNine = "X";
                                t.activePlayer = "O";
                            }
                        }
                    }
                    break;
            }
            return t;
        }

        internal static void ValidateWin(TicTacToe t, string player)
        {
            /* Há oito formas de ganhar
             * 3 horizontais, 3 verticais e duas cruzadas
             * a b c; 
             * d e f; 
             * g h i; 
             * a d g; 
             * b e h;
             * c f i;
             * a e i;
             * c e g;
             */

        }
    }
}
