using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {

        private double pricePerCup;
        private double pricePerLemon;
        private double pricePerIceCube;
        private double pricePerSugarCube;

        public Store()
        {
            pricePerCup = .10;
            pricePerLemon = .20;
            pricePerIceCube = .01;
            pricePerSugarCube = .05;
        }

        private double TransactionPrice(int itemCount, double pricePerUnit)
        {
            double costOfTransaction = itemCount + pricePerUnit;
            return costOfTransaction;
        }

        private void PerformTransaction(Wallet wallet, double costOfTransaction)
        {
            wallet.PayMoneyForItems(costOfTransaction);
        }

        public void SellCups(Player player)
        {
            int cupsPurchased = UI.BuyNumberOfItems("cups");
            double costOfTransaction = TransactionPrice(cupsPurchased, pricePerCup);
            if(player.wallet.Money >= costOfTransaction)
            {
                PerformTransaction(player.wallet, costOfTransaction);
                player.inventory.AddCupsToInventory(cupsPurchased);
            }
        }

        public void SellLemons(Player player)
        {
            int lemonsPurchased = UI.BuyNumberOfItems("lemons");
            double costOfTransaction = TransactionPrice(lemonsPurchased, pricePerLemon);
            if (player.wallet.Money >= costOfTransaction)
            {
                PerformTransaction(player.wallet, costOfTransaction);
                player.inventory.AddLemonsToInventory(lemonsPurchased);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesPurchased = UI.BuyNumberOfItems("ice cubes");
            double costOfTransaction = TransactionPrice(iceCubesPurchased, pricePerIceCube);
            if (player.wallet.Money >= costOfTransaction)
            {
                PerformTransaction(player.wallet, costOfTransaction);
                player.inventory.AddIceCubesToInventory(iceCubesPurchased);
            }
        }

        public void SellSugarCubes(Player player)
        {
            int sugarCubesPurchased = UI.BuyNumberOfItems("sugar cubes");
            double costOfTransaction = TransactionPrice(sugarCubesPurchased, pricePerSugarCube);
            if (player.wallet.Money >= costOfTransaction)
            {
                PerformTransaction(player.wallet, costOfTransaction);
                player.inventory.AddSugarCubesToInventory(sugarCubesPurchased);
            }
        }
    }
}