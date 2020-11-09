using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ_Game
{
    class Bank
    {
        private decimal cash;

        public Bank()
        {
            this.cash = 100;
        }

        public decimal Cash { get => cash; set => cash = value; }

        public void addCash(int chip)
        {
           this.cash += chip * 2;
        }

        public void addCashEven(int chip)
        {
           this.cash += chip * 1.5M;
        }
        public void takeCash(int chip)
        {
           cash -= chip;
        }
    }
}
