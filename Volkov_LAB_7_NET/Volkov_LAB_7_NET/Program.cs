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

        static void HWTask1()
        {
            ICalc obj = new MyArray(10);
            Console.WriteLine(obj.Less(10));
            Console.WriteLine(obj.Greater(10));
        }

        static void HWTask2()
        {
            IOutput2 obj = new MyArray(10);
            obj.ShowEven();
            Console.WriteLine();
            obj.ShowOdd();
        }

        static void HWTask3()
        {
            ICalc2 obj = new MyArray(10);
            Console.WriteLine(obj.CountDistinct());
            Console.WriteLine(obj.EqualToValut(5));
        }

        static void Main(string[] args)
        {
            ////////////////// LAB //////////////
            //Task1();
            //Task2();
            //Task3();

            //////////////// HW ////////////////


            //HWTask1();
            //HWTask2();
            HWTask3();
        }
    }
}
