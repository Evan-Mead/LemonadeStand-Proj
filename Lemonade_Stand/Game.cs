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
            currentDay = 0;
            CreateDays();
        }

        private void CreateDays()
        {
            int dayNumber = currentDay;

            for (int i = 0; i < dayNumber; i++)
            {
                days.Add(new Day());
            }

            switch (currentDay)
            {
                case 1:
                    Console.WriteLine("Day 1");
                    break;
                case 2:
                    Console.WriteLine("Day 2");
                    break;
                case 3:
                    Console.WriteLine("Day 3");
                    break;
                case 4:
                    Console.WriteLine("Day 4");
                    break;
                case 5:
                    Console.WriteLine("Day 5");
                    break;
                case 6:
                    Console.WriteLine("Day 6");
                    break;
                case 7:
                    Console.WriteLine("Day 7");
                    break;
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
