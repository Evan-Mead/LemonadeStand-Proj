using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class UI
    {

        public static void StoreMenu(Store store)
        {
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine($"Prices:\nCup: {store.pricePerLemon}\n");
            Console.WriteLine($"Prices:\nLemon: {store.pricePerLemon}\n");
            Console.WriteLine($"Prices:\nIce Cube: {store.pricePerLemon}\n");
            Console.WriteLine($"Prices:\nSugar Cube: {store.pricePerLemon}\n");
            Console.WriteLine("\n1 Buy Cups, \n2) Buy Lemons, \n3) Buy Ice Cubes, \n4) Buy Sugar Cubes");
            string choice = Console.ReadLine();
        }

        public static void ShowPlayerInventory(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Your current inventory: ");
            Console.WriteLine($"Lemons: {inventory.lemons.Count}");
            Console.WriteLine($"Ice Cubes: {inventory.iceCubes.Count}");
            Console.WriteLine($"Sugar Cubes: {inventory.sugarCubes.Count}");
            Console.WriteLine($"Cups: {inventory.cups.Count}");
            Console.WriteLine($"Current Money: {wallet.Money}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        public static string GetUserInputString(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public static int GetUserInputInt(string prompt)
        {
            try
            {
                int input = Convert.ToInt32(GetUserInputString(prompt));
                return input;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
                return GetUserInputInt(prompt);
            }
        }

        public static double GetUserInputDouble(string prompt)
        {
            try
            {
                Console.WriteLine(prompt);
                double input = Convert.ToDouble(Console.ReadLine());
                return input;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a double value.");
                return GetUserInputDouble(prompt);
            }
        }
        public static int BuyNumberOfItems(string itemsToBuy)
        {
            bool userInput = false;
            int itemQuantity = -1;

            while (!userInput || itemQuantity < 0)
            {
                Console.WriteLine("How many " + itemsToBuy + " would you like to buy?");
                Console.WriteLine("Enter amount: ");

                userInput = Int32.TryParse(Console.ReadLine(), out itemQuantity);
            }

            return itemQuantity;
        }
    }
}