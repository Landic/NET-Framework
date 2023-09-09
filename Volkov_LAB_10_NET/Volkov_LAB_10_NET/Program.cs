using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_10_NET
{
    internal class Program
    {
        delegate bool MyDelegate1(int number);

        static void Task1()
        {
            MyDelegate1 del = delegate (int number)
            {
                return number % 2 == 0;
            };
            Console.WriteLine(del(10));
        }

        delegate int MyDelegate2(int number);

        static void Task2()
        {
            MyDelegate2 del = delegate (int number)
            {
                return (int)Math.Pow(number, 2);
            };
            Console.WriteLine(del(2));
        }

        static void Task3()
        {
            MyDelegate2 del = number => (int)Math.Pow(number, 3);
            Console.WriteLine(del(5));
        }


        static void Task4()
        {
            MyDelegate1 del = (int num) =>
            {
                if (num <= 0 || num >= 365)
                    return false;
                else if (num != 256)
                    return false;
                return true;
            };
            int number = 0;
            Console.WriteLine("Enter day");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(del(number));
        }

        delegate void MyDelegate4(int[] arr);
        delegate int MyDelegate5(int[] arr);

        static void Task5()
        {
            int[] arr2 = new int[10];
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1,10);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach(int i in arr)
                    Console.Write(i + " ");
                Console.WriteLine();
            };

            MyDelegate5 Min = (int[] arr) =>
            {
                int min = arr[0];
                foreach(int i in arr)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                return min;
            };

            Init(arr2);
            Out(arr2);
            Console.WriteLine("Min -> " + Min(arr2));
        }


        static void Task6()
        {
            int[] arr2 = new int[10];
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 10);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach (int i in arr)
                    Console.Write(i + " ");
                Console.WriteLine();
            };

            MyDelegate5 Max = (int[] arr) =>
            {
                int max = arr[0];
                foreach (int i in arr)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return max;
            };

            Init(arr2);
            Out(arr2);
            Console.WriteLine("Max -> " + Max(arr2));
        }

        delegate int MyDelegate6(int[] arr, int count);

        static void Task7()
        {
            int[] arr2 = new int[10];
            int count_even = 0;
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 10);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach (int i in arr)
                    Console.Write(i + " ");
                Console.WriteLine();
            };
            Init(arr2);
            Out(arr2);
            MyDelegate6 Even = (int[] arr, int count) =>
            {
                for (int i = 0; i < arr.Length ; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine("Count even -> " + Even(arr2, count_even));
            

        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
        }
    }
}
