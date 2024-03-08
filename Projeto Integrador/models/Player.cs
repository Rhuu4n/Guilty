using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador.models
{
    internal class Player
    {
        int coins = 0;

        public Player()
        {
        }

        public int getCoins()
        {
            return this.coins;
        }

        public void loseCoin()
        {
            if (this.coins > 0)
            {
                this.coins--;
            }
        }

        public void winCoin()
        {
            this.coins++;
        }
    }
}
