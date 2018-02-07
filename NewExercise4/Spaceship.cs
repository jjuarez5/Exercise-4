using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class Spaceship
    {
        public string currentShip;
        public string spaceshipName;
        public int supplies = 0;
        public int shipInventory = 1000;

        public Spaceship(string spaceshipName)
        {
            this.spaceshipName = spaceshipName;
        }

        //Method to receive purchase order "boughtSupplies" and
        //increase shipInventory = then return shipInventory.
        public int IncreaseShipInventory(int boughtSupplies)
        {
             this.shipInventory += boughtSupplies;
             return shipInventory;
        }


        // code structure by argiopetech
        public int DecreaseShipInventory(int offLoadedSupplies)
        {
            int suppliesSold;

            if (offLoadedSupplies > this.supplies)
            {
                suppliesSold = this.supplies;
                this.supplies = 0;
            }
            else
            {
                suppliesSold = offLoadedSupplies;
                this.supplies -= offLoadedSupplies;
            }
            return suppliesSold;
        }
    }
}
