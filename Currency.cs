using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Currency
    {



        public decimal bucksinaccount = 1000;
        public decimal bucks = 0;

        public void Acquire(decimal bucks)
        {
            bucksinaccount += bucks;

        }

        public void Spend(decimal amount, Currency currency)
        {
            bucksinaccount -= amount;
        }


    }
}
