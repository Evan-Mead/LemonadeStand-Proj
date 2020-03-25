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
        public List<Customer> customers;
        Random random = new Random();

        public Day()
        {
            customers = new List<Customer>();
            AddCustomers();
        }

        private int GenerateAmountOfCustomers()
        {
            int amountOfCustomers = 0;
            if (weather.temperature <= 95)
            {
                amountOfCustomers = random.Next(50, 60);
            }
            else if (weather.temperature <= 85)
            {
                amountOfCustomers = random.Next(40, 50);
            }
            else if (weather.temperature <= 75)
            {
                amountOfCustomers = random.Next(30, 40);
            }
            else if (weather.temperature <= 65)
            {
                amountOfCustomers = random.Next(20, 30);
            }
            else if (weather.temperature <= 55)
            {
                amountOfCustomers = random.Next(10, 20);
            }
            return amountOfCustomers;
        }

        private void AddCustomers()
        {
            //int amountOfCustomers = GenerateAmountOfCustomers();

            //for(int i = 0; i < amountOfCustomers; i++)
            //{
            //    customers.Add(new Customer());
            //}
        }
    }
}