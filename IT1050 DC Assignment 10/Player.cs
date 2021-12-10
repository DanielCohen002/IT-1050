using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Assignment_10
{
    class Player
    {
        public int number { get; set; }
        public int rank { get; set; }
        public string name { get; set; }
        public Player(int number, string name, int rank)
        {
            this.number = number;
            this.name = name;
            this.rank = rank;
        }
    }
}
