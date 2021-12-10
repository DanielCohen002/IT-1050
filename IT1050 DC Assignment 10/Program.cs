using System;

namespace IT1050_DC_Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Team Team1 = new Team ("Team 1", new Player[3] { new Player(1, "Alpha", 1), new Player(2, "Bravo", 2), new Player(3, "Charely", 3) } );
            Team Team2 = new Team ("Team 2", new Player[3] { new Player(4, "Delta", 4), new Player(5, "Echo", 5), new Player(6, "Foxtrot", 6) } );
            Team1.print();
            Console.WriteLine();
            Team2.print();
        }
    }
}
