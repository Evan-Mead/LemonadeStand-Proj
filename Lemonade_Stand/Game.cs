﻿using System;
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

        public string 

        private void CreateDays()
        {
            int dayNumber = currentDay;

            for (int i = 0; i < dayNumber; i++)
            {
                days.Add(new Day());
            }
        }
        // NEEDS MENU FOR BUYING INVENTORY--> ALREADY BUILT IN UI...JUST FIND A WAY TO CALL THAT HERE
        // NEEDS DAY COUNT AND HOW MANY DAYS YOU WANT TO PLAY
        // NEEDS TO SHOW CURRENT DAY

    }
}
