using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {

        public Inventory inventory;
        public Pitcher pitcher;
        public Recipe recipe;
        public Wallet wallet;

        public Player()
        {
            inventory = new Inventory();
            pitcher = new Pitcher();
            recipe = new Recipe();
            wallet = new Wallet();
        }
    }


}
