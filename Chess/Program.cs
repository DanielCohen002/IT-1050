using System;

namespace New_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            IO.startGame();
            int repeatPlaceHolder = 255;
            while (repeatPlaceHolder == 255)
            {
                IO.movePiece();
            }
        }
    }
}
