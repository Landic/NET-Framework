using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Volkov_HW_3_.NET
{
    internal class Program
    {
        static void Task1()
        {
            int[] arr1 = new int[5];
            double[,] arr2 = new double[3, 5];
            Random rand = new Random();
            Console.WriteLine("Enter elements in array 1");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rand.NextDouble() * 10;
                }
            }
            Console.WriteLine();
            Console.Write("Array 1 -> ");
            foreach (int n in arr1)
                Console.Write("{0,4}", n);
            Console.WriteLine();
            Console.WriteLine("Array 2 -> ");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("{0:F3}\t", arr2[i,j]); // вывод
                }
                Console.WriteLine();
            }
            int max = 0, max_2 = 0,result_max = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    for (int k = 0; k < arr2.GetLength(1); k++)
                    {
                        if (arr1[i] > max && arr2[j, k] > max_2)
                        {
                            max = arr1[i];
                            max_2 = Convert.ToInt32(arr2[j, k]);
                            if (max == max_2)
                            {
                                result_max = max;
                            }
                        }
                    }
                }
            }
            int min = 100000, min_2 = 100000, result_min = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    for (int k = 0; k < arr2.GetLength(1); k++)
                    {
                        if (arr1[i] < min)
                        {
                            min = arr1[i];
                            if (min == min_2)
                            {
                                result_min = min;
                            }
                        }
                        if(arr2[j, k] < min_2)
                        {
                            min_2 = Convert.ToInt32(arr2[j, k]);
                            if (min == min_2)
                            {
                                result_min = min;
                            }
                        }
                    }
                }
            }
            
            double summa = 0,summa_2 = 0, general_summa = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                summa += Convert.ToDouble(arr1[i]);
            }
            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                        summa_2 += arr2[j, k];
                }
            }
            general_summa = summa + summa_2;
            double multi = 1, multi_2 = 1, general_multi = 1;
            for (int i = 0; i < arr1.Length; i++)
            {
                multi *= Convert.ToDouble(arr1[i]);
            }
            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                    multi_2 *= arr2[j, k];
                }
            }
            general_multi = multi * multi_2;
            int even = 0, odd = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    even+= arr1[i];
                }
            }
            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                    if (Convert.ToInt32(arr2[j, k]) % 2 == 1)
                    {
                        odd += Convert.ToInt32(arr2[j, k]);
                    }
                }
            }
            Console.WriteLine($"General maximum in array -> {result_max}\nGeneral minimum elements in array -> {result_min}\nSumma all elements -> {general_summa}\nMulti all element -> {general_multi}" +
                $"\nArray 1 even summ -> {even}\nArray 2 odd summ -> {odd}");
            
        }

        static void Task2()
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);   
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}",arr[i,j]);
                }
                Console.WriteLine();
            }
            int min = 1000000, max = 0, index_min_i = 0, index_min_j = 0, index_max_i = 0, index_max_j = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i,j];
                        index_min_i = i;
                        index_min_j = j;
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        index_max_i = i;
                        index_max_j = j;
                    }
                }
            }
            int summa = 0, index_i_1 = 0, index_j_1 = 0, index_i_2 = 0, index_j_2 = 0, count = 0, full = 0, digit1 = 0, digit2 = 0;
            if (index_min_i == index_max_i)
            {
                index_i_1 = index_i_2 = index_min_i;
                if (index_min_j < index_max_j)
                {
                    index_j_1 = index_min_j;
                    index_j_2 = index_max_j;
                }
                else
                {
                    index_j_1 = index_max_j;
                    index_j_2 = index_min_j;
                }
            }
            else
            {
                if (index_min_i < index_max_i)
                {
                    index_i_1 = index_min_i;
                    index_j_1 = index_min_j;
                    index_i_2 = index_max_i;
                    index_j_2 = index_max_j;
                }
                else
                {
                    index_i_1 = index_max_i;
                    index_j_1 = index_max_j;
                    index_i_2 = index_min_i;
                    index_j_2 = index_min_j;
                }
            }
            if(index_i_1 == index_i_2)
            {
                count = index_j_2 - index_j_1 - 1;
            }
            else
            {
                full = index_i_2 - index_i_1 - 1;
                digit1 = 5 - index_j_1 - 1;
                digit2 = index_j_2;
                count = full * 5 + digit1 + digit2;
            }
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == index_i_1 && arr[i,j] ==  index_i_2 && arr[i,j] ==  index_j_1 && arr[i,j] == index_j_2)
                    {
                        summa += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Min -> {min}\nMax -> {max}\nSumma -> {summa}");
        }

        static void Task4()
        {
            int[,] arr = new int[4, 4];
            int[,] arr2 = new int[4, 4];
            int[,] arr_result = new int[4, 4];
            int number = 0, choose = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 50);
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rand.Next(1, 50);
                }
            }

            Console.WriteLine("\nArray 1:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}",arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nArray 2:");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Choose:\n1. Multiplication by number\n2. Matrix addition\n3. Product of matrices\n");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter number");
                    number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] *= number;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0, q = 0; i < arr.GetLength(0) && q < arr2.GetLength(0); i++, q++)
                    {
                        for (int j = 0, w = 0; j < arr.GetLength(1) && w < arr2.GetLength(1); j++, w++)
                        {
                            arr[i, j] += arr2[q, w];
                        }
                    }
                    break;
                case 3:
                    for (int i = 0, q = 0; i < arr.GetLength(0) && q < arr2.GetLength(0); i++, q++)
                    {
                        for (int j = 0, w = 0; j < arr.GetLength(1) && w < arr2.GetLength(1); j++, w++)
                        {
                            arr[i, j] *= arr2[q, w];
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Result: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}",arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Task5()
        {
            string example;
            int digit1 = 0, digit2 = 0, res = 0;
            Console.WriteLine("Enter example: ");
            example= Console.ReadLine();
            int i = 0;
            while (i < example.Length)
            {
                if (example[i] >= '0' || example[i] <= '9')
                {
                    digit1 = Convert.ToInt32(example[i]);
                }
                i++;
            }
            while (i <= example.Length)
            {
                if (example[i] >= '0' || example[i] <= '9')
                {
                    digit2 = Convert.ToInt32(example[i]);
                }
                i++;
            }
            i = 0;
            while (i <= example.Length)
            {
                if (example[i] == '+')
                {
                    res = digit1 + digit2;
                    break;
                }
                else if (example[i] == '-')
                {
                    res = digit1 - digit2;
                    break;
                }
                i++;
            }
            Console.WriteLine("Result -> ",res);
        }

        static void Task6()
        {
            string str;
            Console.WriteLine("Enter text");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[0] >= 'a' || str[0] <= 'z')
                {
                    str = str[0].ToString().ToUpper() + str.Substring(1); ;
                }
                if (str[i] == '.')
                {
                    if(i < str.Length)
                    {
                        while (str[i] != ' ')
                        {
                            i++;
                        }
                        i++;
                        if (str[i] >= 'a' || str[i] <= 'z')
                        {
                            i++;
                            str = str[i].ToString().ToUpper() + str.Substring(i);
                        }
                    }
                }
            }
            Console.WriteLine(str);
        }

        static void Task7()
        {
            string str;
            string bad_word = "die";
            Console.WriteLine("Enter text");
            str = Console.ReadLine();
            str = str.Replace(bad_word, "**e");
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }
    }
}
