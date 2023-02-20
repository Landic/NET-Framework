using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_15_NET
{
    delegate void MyDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard obj = new CreditCard("Barak Obama", "10.25", 4235, 1000, 21000);
            int choose = 0;
            while (true)
            {
                Console.WriteLine("1. Info card\n2. Add to the balance\n3. History\n4. Start credit\n5. Reaching summ\n6. Change PIN-Code");
                choose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        Console.WriteLine(obj);
                        Console.WriteLine("1. Back");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        obj.ev += new MyDelegate(obj.AddBalance);
                        obj.Event();
                        obj.ev -= obj.AddBalance;
                        Console.Clear();
                        break;
                    case 3:
                        obj.ev += new MyDelegate(obj.History);
                        obj.Event();
                        obj.ev -= obj.AddBalance;
                        Console.WriteLine("1. Back");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 4:
                        obj.ev += new MyDelegate(obj.Credit);
                        obj.Event();
                        obj.ev -= obj.Credit;
                        Console.WriteLine("1. Back");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 5:
                        obj.ev += new MyDelegate(obj.ReachingTheSum);
                        obj.Event();
                        obj.ev -= obj.ReachingTheSum;
                        Console.WriteLine("1. Back");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 6:
                        obj.ev += new MyDelegate(obj.ChangePIN);
                        obj.Event();
                        obj.ev -= obj.ChangePIN;
                        Console.WriteLine("1. Back");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Error choose");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
