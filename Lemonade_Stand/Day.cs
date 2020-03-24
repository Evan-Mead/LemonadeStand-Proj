using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        public Weather weather;
        public List<string> customers;
        Random random = new Random();

        public Day()
        {
            weather.condition = Weather.GenerateRandomCondition();
            weather.temperature = Weather.GenerateRandomTemp();
            customers = new List<string>();
            GenerateRandomCustomers();
            AddCustomers();
        }

        private string GenerateRandomCustomers()
        {
            customers = weather.temperature[random.Next(weatherConditions.Count)];
            return GenerateRandomCustomers();
        }

        private void AddCustomers()
        {
            if(weather.temperature <= 95)
            {
                customers = random.Next(50, 60);
            }
            else if(weather.temperature <= 85)
            {
                customers = random.Next(40, 50);
            }
            else if(weather.temperature <= 75)
            {
                customers = random.Next(30, 40);
            }
            else if(weather.temperature <= 65)
            {
                customers = random.Next(20, 30);
            }
            else if(weather.temperature <= 55)
            {
                customers = random.Next(10, 20);
            }
        }
    }
}
