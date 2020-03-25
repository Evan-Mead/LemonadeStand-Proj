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

        public Game()
        {
            player = new Player();
            days = new List<Day>();
            CreateDays();
        }

        private void CreateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }
        }

        public int PlayerMenu()
        {
            int userInput;

            for (userInput)
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
                }
            }
        }
    // NEEDS MENU FOR BUYING INVENTORY--> ALREADY BUILT IN UI...JUST FIND A WAY TO CALL THAT HERE
    // NEEDS DAY COUNT AND HOW MANY DAYS YOU WANT TO PLAY
    // NEEDS TO SHOW CURRENT DAY

    public void RunGame()
        {

        }
    }
}
