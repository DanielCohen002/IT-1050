using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Assignment_10
{
    class Team
    {
        public string name { get; set; }
        private Player[] players = new Player[3];
        public Team(string name, Player[] players)
        {
            this.name = name;
            this.players = players;
        }
        public void print()
        {
            Console.WriteLine("Numbers, names, and ranks of " + this.name + " members:");
            foreach (Player p in players)
            {
                Console.WriteLine(p.name + ", #" + p.number + " is rank " + p.rank);
            }
        }
    }
}
