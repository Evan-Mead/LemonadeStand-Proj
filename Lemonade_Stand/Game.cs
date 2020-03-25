using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Store store;
        Random random = new Random();
        public int userInput;


        public Game()
        {
            player = new Player();
            days = new List<Day>();
            store = new Store();
            CreateDays();
            PlayerMenu();
        }

        private void CreateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }
        }

        public void PlayerMenu()
        {
            Console.WriteLine("Select an option: ");
            Console.WriteLine($"Check inventory\n1, Set recipe\n2, Go to store\n3, Start current day\n4");
            switch (userInput)
            {
                case 1:
                    UI.ShowPlayerInventory(player.inventory, player.wallet);
                    break;
                case 2:
                    player.recipe.SetRecipe();
                    break;
                case 3:
                    store.Menu(player);
                    break;
                case 4:
                    CreateDays();
                    break;
                default:
                    break;
            }
        }
            
        

        public void RunGame()
        {
            Console.WriteLine("Welcome to your lemonade stand.");

            List<string> gameObject = new List<string>();
            gameObject.Add("You will start with $20.00 to buy what you need from the store");
            gameObject.Add("Everyday you will have one chance to buy from the store, change your recipe, and set a price for a single cup of lemonade.");
            gameObject.Add("Sales will be based on the weather and how expensive your price is.");
            gameObject.Add("You will have one week (seven days) to collect as much money as you can.");
            gameObject.Add("The game will continue until you have completed a full week of sales or you run out of money and can not continue sales.");
            gameObject.Add("Happy sales!");

            foreach (string game in gameObject)
            {
                Console.WriteLine(game);
            }

            PlayerMenu();

            //need a do while loop for game to run

            do
            {
                CreateDays();
                foreach(Player)
                {

                }
            }

            /*as long as case 4 is selected in game menu the day should start
             * game needs to loop for for six more days
             * or unitl player runs out of money
             * if game runs for seven days then end game and display total cash*/
        }
    }
}
