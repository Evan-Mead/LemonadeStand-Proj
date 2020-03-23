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
        public List<Lemon> numberOfLemons;
        public List<IceCube> numberOfIceCubes;
        public List<SugarCube>numberOfSugarCubes;

        public Recipe()
        {
            pricePerCup = new double();
            numberOfLemons = new List<Lemon>();
            numberOfIceCubes = new List<IceCube>();
            numberOfSugarCubes = new List<SugarCube>();
        }

        public double SetCupPrice(Recipe pricePerCup)
        {
            Console.WriteLine("Set price per cup.");
            double amount = Convert.ToDouble(Console.ReadLine());
            return pricePerCup.SetCupPrice(amount); //HOW DO I GET THIS TO WORK?
        }

        public void AddLemons(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                numberOfLemons.Equals(numberOfLemons);
            }
        }

        public void AddIce(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                numberOfIceCubes.Equals(numberOfIceCubes);
            }
        }

        public void AddSugar(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                numberOfSugarCubes.Equals(numberOfSugarCubes);
            }
        }
    }
}
