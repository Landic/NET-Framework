using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_17_NET
{
    internal class USD : IValut
    {
        public void TypeValut(ATM obj, Card obj2)
        {
            Console.WriteLine("You choose USD -> UAH");
            obj2.SCard = obj2.SCard / 39.60;
            obj2.SCard = Math.Round(obj2.SCard, 2);
            obj.SummATM = obj.SummATM / 39.60;
            obj.SummATM = Math.Round(obj.SummATM, 2);
        }
    }
}
