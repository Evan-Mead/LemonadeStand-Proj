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

            // SWITCH CASE MENU THAT SHOWS INVENTORY AND THAT LINKS TO THE STORE TO BUY ITEMS
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
