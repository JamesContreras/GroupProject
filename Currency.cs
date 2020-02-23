using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Currency
    {



        public decimal bucksinaccount = 500;
        public decimal bucks = 0;

        public void Acquire(decimal bucks)
        {
            bucksinaccount += bucks;

        }

        public void Spend(decimal amount)
        {
            bucksinaccount -= amount;
        }


    }
}
