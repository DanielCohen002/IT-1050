using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Final
{
    class Passenger
    {
        #region Variables
        private string Name;
        private double Weight;
        #endregion
        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
