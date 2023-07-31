using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public string name;
        internal int drinksAvailable;
        internal int drinksSold;
        internal double balanceBeforeday;
        internal double balanceaAtertheday;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            name = "Player";
            drinksAvailable = 0;
            drinksSold = 0;
            balanceBeforeday = wallet.Money;
        }

        // member methods (CAN DO)

    }
}
