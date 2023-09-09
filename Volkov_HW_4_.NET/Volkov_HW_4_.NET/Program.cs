using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_4_.NET
{
    internal class Program
    {
        static void Task1()
        {
            int[][] arr = new int[4][];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[4];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[i][j] = rand.Next(1, 50);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] arr2 = new int[4];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i].Sum();
            }
            int[] arr3 = arr[Array.IndexOf(arr2, arr2.Min())];
            arr[Array.IndexOf(arr2, arr2.Min())] = arr[Array.IndexOf(arr2, arr2.Max())];
            arr[Array.IndexOf(arr2, arr2.Max())] = arr3;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void Task2()
        {
            int size = 5;
            int[][] arr = new int[5][];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++, size--)
            {
                arr[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    arr[i][j] = rand.Next(1, 50);
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }
    }
}
