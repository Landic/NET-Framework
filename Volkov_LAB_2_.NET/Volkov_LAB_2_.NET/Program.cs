using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Volkov_LAB_2_.NET
{
    internal class Program
    {
        static void Task0()
        {
            int[] arr=new int [10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10); // заполнение
            }
            foreach(int n in arr)
                Console.Write("{0,3}", n); // вывод
        }

        static void Task1()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 20);
            }
            foreach (int n in arr)
                Console.Write("{0,4}", n);
            short positive = 0, negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) // поиск четных чисел
                {
                    positive++;
                }
                else // нечетные числа
                {
                    negative++;
                }
            }
            int individual = arr.Distinct().Count() - (arr.Length - arr.Distinct().Count()); // счетчик уникальных цифр
            
            
            Console.WriteLine($"\nPositive -> {positive}\nNegative -> {negative}\nIndividual -> {individual}");

        }

        static void Task2()
        {
            int[] arr = new int[15];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 30);
            }
            foreach (int n in arr)
                Console.Write("{0,4}", n);
            int digit = 0,smaller = 0;
            Console.WriteLine("\nEnter number:");
            digit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < digit) // поиск сколько цифр меньше значение которое написал пользователь
                {
                    smaller++;
                }
            }
            Console.WriteLine($"Count smaller {digit} -> {smaller}");
        }

        static void Task3()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
            foreach (int n in arr)
                Console.Write("{0,4}", n);
            int digit1 = 0, digit2 = 0, digit3 = 0, count = 0;
            Console.WriteLine("\nEnter 3 digit");
            digit1 = Convert.ToInt32(Console.ReadLine());
            digit2 = Convert.ToInt32(Console.ReadLine());
            digit3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0, j = 1, h = 2; i < arr.Length && j < arr.Length && h < arr.Length; i++, j++, h++)
            {
                if (arr[i] == digit1 && arr[j] == digit2 && arr[h] == digit3) // поиск трех цифр в ряд
                    count++;
            }
            Console.WriteLine($"Result -> {count}");
        }

        static void Task4()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(1, 10);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(1, 10);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (arr1[k] == arr1[i]) 
                            {
                                count = 1;
                                break;
                            }
                            if(count == 2) // перезаписываем в третий массив сопадение в первом и во втором массиве без повторений
                            {
                                arr3[i] = arr1[i];
                            }
                            count = 2;

                        }
                        count++;
                        
                        break;
                    }
                }
            }
            Console.Write("Arr 1 -> ");
            foreach (int n in arr1)
                Console.Write("{0,4}", n);
            Console.Write("\nArr2 -> ");
            foreach (int n in arr2)
                Console.Write("{0,4}", n);
            Console.Write("\nArr3 -> ");
            foreach (int n in arr3)
                Console.Write("{0,4}", n);
        }

        static void Task5()
        {
            int[,] arr = new int[4, 4];
            Random rand = new Random();
            int max = 0, min = 100000;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 40); // заполнение
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] < min) // ищет минимум
                    {
                        min = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > max) // ищет максимум в многомерном массиве
                    {
                        max = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i, j]); // вывод
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nmin -> {min}\nmax -> {max}");

        }

        static void Task6()
        {
            short word = 0;
            string str;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') // счетчик слов
                {
                    word++; 
                }
            }
            Console.WriteLine($"Count word in string -> {word}");
        }

        static void Task7()
        {
            string str;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();
            char[] str2 = str.ToCharArray();
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == ' ')
                {
                    Array.Reverse(str2,i,str2.Length); // переворачивает 
                }
            }
            string str3 = new string(str2);
            Console.WriteLine(str3);
        }

        static void Task8()
        {
            short vowels_count = 0;
            string vowels = "AaEeIiOoUuYy"; // строка соддержащия гласные буквы в англ
            string str;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++) 
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j]) // пробегаемся по буквом с помощью цикла и ищем совпадения
                    {
                        vowels_count++; // счетчик гласных букв
                    }
                }
            }
            Console.WriteLine($"Count vowels -> {vowels_count}");

        }

        static void Task9()
        {
            short word_count = 0;
            string str;
            string word;
            Console.WriteLine("Enter str");
            str = Console.ReadLine();
            Console.WriteLine("Enter word for search");
            word = Console.ReadLine();
            bool result;
            if (result = Regex.IsMatch(str, word)) // проверка для поиска слов
            {
                word_count++; // счетчик слов
            }
            Console.WriteLine($"Word for search -> {word}\nCount word in ths string -> {word_count}");
        }

        static void Main(string[] args)
        {
            //Task0();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            Task9();
        }
    }
}
