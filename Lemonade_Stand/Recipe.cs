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
        // sets all of the variables on this class equal to user input

        public string RecipeInputString(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public double SetCupPriceForRecipe(string prompt)
        {
            try
            {
                double pricePerCup = Convert.ToDouble(SetCupPriceForRecipe(prompt));
                return pricePerCup;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
                return SetCupPriceForRecipe(prompt);
            }
        }

        public int LemonsInRecipe(string prompt)
        {
            try
            {
                int amountOfLemons = Convert.ToInt32(LemonsInRecipe(prompt));
                return amountOfLemons;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
                return LemonsInRecipe(prompt);
            }
        }

        public int IceCubesInInRecipe(string prompt)
        {
            try
            {
                int amountOfIceCubes = Convert.ToInt32(IceCubesInInRecipe(prompt));
                return amountOfIceCubes;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
                return IceCubesInInRecipe(prompt);
            }
        }

        public int SugarCubesInRecipe(string prompt)
        {
            try
            {
                int amountOfSugarCubes = Convert.ToInt32(SugarCubesInRecipe(prompt));
                return amountOfSugarCubes;
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
                return SugarCubesInRecipe(prompt);
            }
        }
    }
}