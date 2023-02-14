using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_7_NET
{
    internal class Program
    {
        static void Task1()
        {
            IOutput obj = new MyArray(4);
            obj.Show();
            obj.Show("Prosto informaciya");
        }

        static void Task2()
        {
            MyArray obj2 = new MyArray(5);
            obj2.Show();
            Console.WriteLine(obj2.Min());
            Console.WriteLine(obj2.Max());
            Console.WriteLine(obj2.Avg());
            if (obj2.Search(15))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Task3()
        {
            MyArray obj2 = new MyArray(5);
            obj2.Show();
            obj2.SortAsc();
            obj2.Show();
            obj2.SortDesc();
            obj2.Show();
            obj2.SortByParam(true);
            obj2.Show();
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }
    }
}
