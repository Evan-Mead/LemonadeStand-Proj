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

        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Partly Cloudy", "Rainy", "Thunderstorms" };
            GenerateRandomCondition();
            GenerateRandomTemperature();
        }


        private string GenerateRandomCondition()
        {
                weatherConditions = new List<string> { "Sunny", "Cloudy", "Partly Cloudy", "Rainy", "Thunderstorms" };
                condition = weatherConditions[random.Next(weatherConditions.Count)];
                return condition;
        }

        private int GenerateRandomTemperature()
        {
            // set temerature variable to a random number that represents temp
            temperature = random.Next(50, 95);
            return temperature;
        }

        // NEEDS TO BE RANDOM BASED OFF HIGH/LOW TEMP AND WEATHER CONDITIONS %'S
    }
}
