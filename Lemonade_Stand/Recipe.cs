using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public double pricePerCup;
        public int amountOfLeomons;
        public int amountOfIceCubes;
        public int amountOfSugarCubes;

        public Recipe()
        {
            pricePerCup = .00;
            amountOfLeomons = 0;
            amountOfIceCubes = 0;
            amountOfSugarCubes = 0;
        }
    }
}
