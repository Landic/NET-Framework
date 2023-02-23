using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_17_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(1000);
            ATM atm = new ATM(card, 100000);
            ICheck check;
            IValut valut;
            int choose = 0;
            Console.WriteLine("Enter type valut 1 - USD 2 - UAH");
            choose = int.Parse(Console.ReadLine());
            if(choose == 1)
            {
                atm.Valut(valut = new USD(), atm, card);
            }
            else if(choose == 2)
            {
                atm.Valut(valut = new UAH(), atm, card);
            }
            while (true) {
                Console.WriteLine("1. Input money\n2. Output money\n3. Balance Card\n4. Balance ATM");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        atm.InputMoney();
                        break;
                    case 2:
                        atm.OutputMoney();
                        break;
                    case 3:
                        card.Balance();
                        Console.WriteLine("1. Exit");
                        choose =int.Parse(Console.ReadLine());
                        continue;
                    case 4:
                        atm.BalanceATM();
                        Console.WriteLine("1. Exit");
                        choose = int.Parse(Console.ReadLine());
                        continue;
                }
                Console.WriteLine("Do you wont check\n1. Print check\n2. Don't print check\n3. Electronic check");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        atm.Check(check = new PrintCheck());
                        break;
                    case 2:
                        atm.Check(check = new NotPrint());
                        break;
                    case 3:
                        atm.Check(check = new ElectronicCheck());
                        break;
                }
            }
        }
    }
}
