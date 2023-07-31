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
        public void OpenTheStand()
        {
            DisplayNameBalance();
            recipe.DisplayRecipe();
            DisplayInvetory();
        }
        public void DisplayNameBalance()
        {
            Console.WriteLine($"===================================================");
            Console.WriteLine($"==========  Name: {name} | Balance: ${Math.Round(wallet.Money, 2)}");
            Console.WriteLine($"===================================================");
        }
        public void DisplayInvetory()
        {
            Console.WriteLine($"\nIventory: {inventory.lemons.Count} lemons");
            Console.WriteLine($"Iventory: {inventory.sugarCubes.Count} sugar cubes");
            Console.WriteLine($"Iventory: {inventory.iceCubes.Count} ice cubes");
            Console.WriteLine($"Iventory: {inventory.cups.Count} cups\n");
        }
    }
}
