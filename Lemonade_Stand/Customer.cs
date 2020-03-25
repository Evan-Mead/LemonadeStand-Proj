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
        public int customers;
        private List<string> names;
        Random random = new Random();


        public Customer(int customers, List<string> names)
        {

        }

        public bool MakeChoice(Weather weather, Recipe recipe)
        {
            int chanceNumber = 0;
            if(weather.condition == "Sunny" && recipe.pricePerCup <= 0.38)
            {
                chanceNumber = random.Next(4, 10);
            }
            else if(weather.condition == "Partly Cloudy" && recipe.pricePerCup <= 0.32)
            {
                chanceNumber = random.Next(4, 10);
            }
            else if(weather.condition == "Cloudy" && recipe.pricePerCup <= 0.28)
            {
                chanceNumber = random.Next(4, 10);
            }
            else if(weather.condition == "Rainy" && recipe.pricePerCup >= 0.23)
            {
                chanceNumber = random.Next(2, 10);
            }
            else if(weather.condition == "Thunderstorms" && recipe.pricePerCup >= 0.20)
            {
                chanceNumber = random.Next(0, 10);
            }


            if(chanceNumber > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}