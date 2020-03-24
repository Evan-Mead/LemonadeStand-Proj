﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Wallet
    {

        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public void PayMoneyForItems(double transactionPrice)
        {
            money -= transactionPrice;
        }

        public void MoneyFromSales(double pricePerCup)
        {
            money += pricePerCup;
        }
    }
}
