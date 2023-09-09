using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_9_NET
{
    internal class Program
    {
        static void Task1()
        {
            Magazine obj = new Magazine();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj = obj + 2;
            Console.WriteLine(obj.ToString());
            obj = obj - 3;
            Console.WriteLine(obj.ToString());
            Magazine obj2 = new Magazine();
            obj2.Input();
            Console.WriteLine(obj2.ToString());
            if(obj > obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if(obj < obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if(obj == obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if(obj != obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Task2()
        {
            Shop obj = new Shop();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj = obj + 20;
            Console.WriteLine(obj.ToString());
            obj = obj - 10;
            Console.WriteLine(obj.ToString());
            Shop obj2 = new Shop();
            obj2.Input();
            Console.WriteLine(obj2.ToString());
            if (obj > obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (obj < obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (obj == obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (obj != obj2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();
            
        }
    }
}
