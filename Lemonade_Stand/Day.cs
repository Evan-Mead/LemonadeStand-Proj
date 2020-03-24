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

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>()
        }

        // NEEDS TO SHOW PROJECTED WEATHER
        // NEEDS TO BE BASED OF RANDOM % OF WEATHER AND CUSTOMERS
    }
}
