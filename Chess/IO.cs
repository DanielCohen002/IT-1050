using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess
{
    class IO
    {
        static public string[,] allRows = new string[8, 8];
        static public void startGame()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    IO.allRows[i, j] = "~";
                }

            }
            for (int i = 0; i < 8; i++)
            {
                IO.allRows[1, i] = "P";
            }
            IO.allRows[0, 0] = "R";
            IO.allRows[0, 1] = "H";
            IO.allRows[0, 2] = "B";
            IO.allRows[0, 3] = "Q";
            IO.allRows[0, 4] = "K";
            IO.allRows[0, 5] = "B";
            IO.allRows[0, 6] = "H";
            IO.allRows[0, 7] = "R";

            for (int i = 0; i < 8; i++)
            {
                IO.allRows[6, i] = "p";
            }
            IO.allRows[7, 0] = "r";
            IO.allRows[7, 1] = "h";
            IO.allRows[7, 2] = "b";
            IO.allRows[7, 3] = "q";
            IO.allRows[7, 4] = "k";
            IO.allRows[7, 5] = "b";
            IO.allRows[7, 6] = "h";
            IO.allRows[7, 7] = "r";

            printBoard();
        }
        static public void movePiece()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a piece");
            int x = (int.Parse(Console.ReadLine()) - 1);
            int y = (int.Parse(Console.ReadLine()) - 1);

            Console.WriteLine("Where would you like to move it?");
            int x2 = (int.Parse(Console.ReadLine()) - 1);
            int y2 = (int.Parse(Console.ReadLine()) - 1);
            //if (x == 255)
            //{
            //    startGame();
            // }
            // else
            // {
            allRows[x2, y2] = allRows[x, y];
            allRows[x, y] = "~";
            Console.WriteLine();
            printBoard();
            // }
        }
        public static void printBoard()
        {
            Console.WriteLine("  " + 1 + " " + 2 + " " + 3 + " " + 4 + " " + 5 + " " + 6 + " " + 7 + " " + 8);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        Console.Write((i + 1) + "|");
                    }
                    Console.Write(IO.allRows[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
