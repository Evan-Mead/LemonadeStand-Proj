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

        public void SetRecipe()
        {
            pricePerCup = UI.GetUserInputDouble("How much would you like to charge for a cup of lemonade?");
            amountOfLeomons = UI.GetUserInputInt("How many lemons would you like in your recipe?");
            amountOfIceCubes = UI.GetUserInputInt("How many ice cubes would you like per cup?");
            amountOfSugarCubes = UI.GetUserInputInt("How many sugar cubes would you like in your recipe?");
        }

    }
}