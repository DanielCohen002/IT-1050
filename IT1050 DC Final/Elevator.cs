using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Final
{
    class Elevator
    {
        #region Variables
        private double MaxWeight;
        private Passenger[] Occupants;
        #endregion
        public Passenger[] GetOccupants()
        {
            return this.Occupants;
        }
        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double currentWeight = 0;
            foreach (Passenger p in Occupants)
            {
                currentWeight = p.GetWeight() + currentWeight ;
            }
            return currentWeight;
        }
        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
