using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_16_NET
{
    internal class Program
    {
        delegate void MyDelegate1(int number1, int number2, int number3);
        delegate void MyDelegate3();
        static void Task1()
        {
            MyDelegate1 del = (int number1, int number2, int number3) =>
            {
                Console.WriteLine("RGB -> " + number1 + " " + number2 + " " + number3);
            };
            del(10, 20, 30);

        }

        static void Task2()
        {
            Backpack obj = new Backpack();
            obj.Input();
            Console.WriteLine(obj);
            MyDelegate3 del = delegate ()
            {
                obj.ev += obj.AddItem;
                obj.Event();
            };
            del();
            Console.WriteLine(obj);
        }


        delegate void MyDelegate4(int[] arr);
        delegate int MyDelegate5(int[] arr, int count_number);
        static void Task3()
        {
            int[] arr2 = new int[10];
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1,20);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            };

            Init(arr2);
            Out(arr2);

            MyDelegate5 countnumber = (int[] arr, int count_number) =>
            {
                count_number = arr.Length;
                return count_number;
            };

            int count = 0;

            Console.WriteLine(countnumber(arr2, count));
        }


        static void Task4()
        {
            int[] arr2 = new int[10];
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-20, 20);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            };

            Init(arr2);
            Out(arr2);

            MyDelegate5 countnumber = (int[] arr, int count_number) =>
            {
                foreach(int i in arr)
                    if(i >= 0)
                    {
                        count_number++;
                    }
                return count_number;
            };

            int count = 0;

            Console.WriteLine(countnumber(arr2, count));
        }


        static void Task5()
        {
            int[] arr2 = new int[10];
            MyDelegate4 Init = (int[] arr) =>
            {
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-20, 20);
                }
            };

            MyDelegate4 Out = (int[] arr) =>
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            };

            Init(arr2);
            Out(arr2);

            MyDelegate5 countnumber = (int[] arr, int count_number) =>
            {
                foreach (int i in arr)
                    if (i < 0)
                    {
                        count_number++;
                    }
                return count_number;
            };

            int count = 0;

            Console.WriteLine(countnumber(arr2, count));
        }


        delegate bool MyDelegate6(string str1, string word1);

        static void Task6()
        {
            string str;
            string[] str2;
            string word;
            Console.WriteLine("Enter text");
            str = Console.ReadLine();
            str2 = str.Split(' ');
            Console.WriteLine("Enter word for the search");
            word = Console.ReadLine();
            MyDelegate6 search = (string str1, string word1) => str2.Contains(word1);
            Console.WriteLine(search(str, word));
        }


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }
    }
}
