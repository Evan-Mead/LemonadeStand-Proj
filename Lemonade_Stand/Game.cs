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
        private Store store;
        Random random = new Random();
        private int currentDay;
        public int userInput;


        public Game()
        {
            player = new Player();
            days = new List<Day>();
            store = new Store();
            CreateDays();
        }

        public void CreateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }
        }

        public void PlayerMenu()
        {
            Console.WriteLine("Select an option: ");
            Console.WriteLine($"\n1 Check inventory \n2 Set recipe \n3 Go to store \n4 Start current day");
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
            Console.WriteLine("Welcome to your lemonade stand!");

            Console.ReadLine();

            List<string> gameObject = new List<string>();
            gameObject.Add("You will start with $20.00 to buy what you need from the store");
            gameObject.Add("Everyday you will have one chance to buy from the store, change your recipe, and set a price for a cup.");
            gameObject.Add("Sales will be based on the weather and how expensive your price is.");
            gameObject.Add("You will have one week (seven days) to collect as much money as you can.");
            gameObject.Add("The game will continue until you have completed a full week of sales or you run out of money and can not continue sales.");
            gameObject.Add("Happy sales!");

            foreach (string game in gameObject)
            {
                Console.WriteLine(game);
            }

            Console.ReadLine();

            do
            {
                PlayerMenu();
                CreateDays();

                //{
                //    if (player.wallet.Money <= 0.00)
                //    {
                //        Console.WriteLine("You have ran out of money. Game over!");
                //    }
                //    else
                //    {
                //        days.Add(new Day());
                //    }
                //    PlayerMenu();
            }
            while (player.wallet.Money > 0.00);
        }
    }
}
