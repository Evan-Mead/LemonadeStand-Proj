using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public Player player;
        public Day currentDay;
        public int totalDays;
        public int dayNUmber = 0;

        public Game()
        {
            this.totalDays = 7;
            this.player = new Player();
        }



    }
}
