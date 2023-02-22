using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_17_NET
{
    internal class ATM
    {
        Card obj;

        public ATM()
        {
            obj = new Card();
        }
        public ATM(Card obj)
        {
            this.obj = obj;
        }

        public void Valut(IValut valut)
        {
            valut.TypeValut();
        }

        public void Check(ICheck check)
        {
            check.CheckType();
        }

        public void InputMoney()
        {
            Console.WriteLine("Enter how much you want to top up");
            obj.SCard += int.Parse(Console.ReadLine());
        }

        public void OutputMoney() 
        {
            Console.WriteLine("Enter how much you want to withdraw");
            obj.SCard -= int.Parse(Console.ReadLine());
        }

    }
}
