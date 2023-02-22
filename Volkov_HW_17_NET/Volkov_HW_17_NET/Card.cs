using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_17_NET
{
    internal class Card
    {
        public int SCard
        {
            get; set;
        }

        public Card()
        {
            SCard = 0;
        }

        public Card(int card)
        {
            SCard = card;
        }

        public void Balance()
        {
            Console.WriteLine("Balance -> " + SCard);
        }
    }
}
