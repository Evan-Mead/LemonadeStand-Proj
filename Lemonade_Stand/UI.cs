using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class UI
    {

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