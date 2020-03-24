using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        public string name;
        private List<string> names;

        public Customer()
        {
            names = new List<string>();
        }


        // NEEDS TO BE BASED OFF PRICE PER CUP AND WEATHER
        // public 

        public bool MakeChoice(Weather weather, Recipe recipe)
        {
            // if else bool

            // numbers 1-7 <= 5 is true for chance to buy
            // number 1-10 <= 5 is false for chance to not buy
        }
    }
}