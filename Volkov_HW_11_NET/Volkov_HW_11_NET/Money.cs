using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Money
    {
        private int bills;
        private int copeck;

        public Money()
        {
            bills = 0;
            copeck = 0;
        }

        public Money(int bills, int copeck)
        {
            this.bills = bills;
            this.copeck = copeck;
        }

        public void Input()
        {
            Console.WriteLine("Enter bills");
            bills = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter copeck");
            copeck = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Bills -> {bills}\nCopeck -> {copeck}\n";
        }

        public static Money operator +(Money a, Money b)
        {
            Money result = new Money();
            result.copeck = a.copeck + b.copeck;
            result.bills = a.bills + b.bills;
            return result;
        }

        public int Bills 
        { 
            get 
            { 
                return bills;
            }
            set
            {
                bills = value;
            }
        }

        public int Copeck
        {
            get
            {
                return copeck;
            }
            set
            {
                copeck = value;
            }
        }
    }
}
