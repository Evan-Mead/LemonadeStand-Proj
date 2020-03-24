using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public string condition;
        public int temperature;
        Random random = new Random();
        private List<string> weatherConditions;

        public Weather(string condition, int temperature, List<string> weatherConditions)
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Partly Cloudy", "Rainy", "Thunderstorms" };
            GenerateRandomCondition();
            GenerateRandomTemperature();
        }

        private string GenerateRandomCondition()
        {
            condition = weatherConditions[random.Next(weatherConditions.Count)];
            return condition;
        }

        private void GenerateRandomTemperature()
        {
            if(condition == "Sunny")
            {
                temperature = random.Next(85, 95);
            }
            else if(condition == "Partly Cloudy")
            {
                temperature = random.Next(76, 84);
            }
            else if (condition == "Cloudy")
            {
                temperature = random.Next(70, 75);
            }
            else if (condition == "Rainy")
            {
                temperature = random.Next(60, 69);
            }
            else if (condition == "Thunderstorms")
            {
                temperature = random.Next(50, 59);
            }
        }
    }
}
