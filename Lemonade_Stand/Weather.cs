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

        }


        // NEEDS TO BE RANDOM BASED OFF HIGH/LOW TEMP AND WEATHER CONDITIONS %'S
        // TEMP CAN BE RANDOM BETWEEN MAX AND MIN NUMBERSGIVEN TO RANDMO RANGE random (xx, yy)
        // NEEDS TO HAVE RANDOM WEATHER CONDITION LIST<> (SUNNY, PARTLY CLOUDY, CLOUDY, RAINY, THUNDERSTROMS)
    }
}
