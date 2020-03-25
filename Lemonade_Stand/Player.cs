using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Pitcher pitcher;
        public Recipe recipe;
        public Wallet wallet;
        public string cupsRemaining { get; private set; }

        public Player()
        {
            inventory = new Inventory();
            pitcher = new Pitcher();
            recipe = new Recipe();
            wallet = new Wallet();
        }


        public void ShowInventory()
        {
            Console.WriteLine($"You have {inventory.cups.Count} remaining.");
            Console.WriteLine($"You have {inventory.lemons.Count} remaining.");
            Console.WriteLine($"You have {inventory.iceCubes.Count} remaining.");
            Console.WriteLine($"You have {inventory.sugarCubes.Count} remaining.");

            {
                inventory = Inventory.BuyNumberOfItems("How many cups would you like to purchase?");
                inventory = Inventory.BuyNumberOfItems("How many lemons would yo like to purchase?");
                inventory = Inventory.GetUserInputInt("How many ice cubes would you like to purchase?");
                inventory = Inventory.GetUserInputInt("How many sugar cubes would you like to purchase?");
            }

            //int  userInput;

            //for (userInput)
            //{
            //    Console.WriteLine("Would you like to buy more items?");
            //    Console.WriteLine($"Cups\n1, Lemons\n2, Ice Cubes\n3, Sugar Cubes\n4");
            //    switch (userInput)
            //    {
            //        case 1:
            //            Console.WriteLine("How many cups would you like to purchase?");
            //            Console.WriteLine($"\n" );
            //    }
            //}
        }

        public void CupsInPitcher()
        {
            Console.WriteLine($"There are {cupsRemaining} in your pitcher.");
        }

        public void MakeRecipe()
        {
            recipe.SetRecipe();
        }

        public void MoneyInWallet()
        {
            wallet.
            // NEEDS TO SHOW +/- MONEY IN WALLET
            //Console.WriteLine("You have " + PayMoneyForItems + MoneyFromSales + " in your wallet.");
        }
    }
}
