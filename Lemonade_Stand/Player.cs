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

        public Player()
        {
            inventory = new Inventory();
            pitcher = new Pitcher();
            recipe = new Recipe();
            wallet = new Wallet();
        }

        public void ShowInventory()
        {
            Console.WriteLine("You have ");
            // NEEDS A MENU THAT SHOWS INVENTORY AND THAT LINKS TO THE STORE TO BUY ITEMS
            // SWITCH/CASE 
        }

        public void CupsInPitcher()
        {
            // NEEDS TO SHOW CUPS REMANING PER INGREDIENTS IN PITCHER
        }

        public void MakeRecipe()
        {
            // NEEDS A MENU THAT CAN +/- ITEMS TO THE RECIPE
        }

        public void MoneyInWallet()
        {
            // NEEDS TO SHOW +/- MONEY IN WALLET
        }
    }
}
