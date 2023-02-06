using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_5__NET
{
    internal class Program
    {
        static void Task1()
        {
            int index = 0, length = 0;
            StringBuilder str = new StringBuilder("Hello world");
            Console.WriteLine($"String -> {str}");
            Console.WriteLine("Enter index to remove");
            index = Convert.ToInt32(Console.ReadLine());
            str = str.Remove(index, 1);
            Console.WriteLine($"Result -> {str}");
        }

        static void Task2()
        {
            string symbol;
            StringBuilder str = new StringBuilder("Hello world");
            Console.WriteLine($"str -> {str}");
            Console.WriteLine("Enter symbol");
            symbol = Console.ReadLine();
            str.Replace(symbol, "");
            Console.WriteLine($"str -> {str}");

        }

        static void Task3()
        {
            int index = 0;
            string symbol;
            StringBuilder str = new StringBuilder("Hello world");
            Console.WriteLine($"str -> {str}");
            Console.WriteLine("Enter symbol to insert");
            symbol = Console.ReadLine();
            Console.WriteLine("Enter index to insert");
            index = Convert.ToInt32(Console.ReadLine());
            str.Insert(index, symbol);
            Console.WriteLine($"str -> {str}");
        }

        static void Task4()
        {
            
            string str;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();
            char[] str2 = str.ToCharArray();
            Array.Reverse(str2, 0, str2.Length);
            string str3 = new string(str2);
            if(str == str3)
            {
                Console.WriteLine("Your string palindrom");
            }
            else
            {
                Console.WriteLine("Your string not palindrom");
            }
        }

        static void Task5()
        {
            string str;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();
            string[] str2 = str.Split(' ');
            Console.WriteLine($"Words in string -> {str2.Length}");
        }

        static void Task6()
        {
            string str;
            string search_word;
            string insert_word;
            Console.WriteLine("Enter text");
            str = Console.ReadLine();
            Console.WriteLine($"text -> {str}");
            Console.WriteLine("Enter word for the search");
            search_word = Console.ReadLine();
            Console.WriteLine("Enter word");
            insert_word = Console.ReadLine();
            string[] str2 = str.Split(' ');

            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Contains(search_word))
                {
                    str2[i] = insert_word;
                }
            }
            foreach (string n in str2)
                Console.Write($"{n} ");    

        }

        static void Task7()
        {
            string str;
            Console.WriteLine("Enter text");
            str = Console.ReadLine();
            string[] str2 = str.Split(' ');
            for (int i = 0; i < str2.Length - 1; i+=2)
            {
                string temp = str2[i];
                str2[i] = str2[i + 1];
                str2[i + 1] = temp;
            }
            foreach(string n in str2)
            {
                Console.Write($"{n} ");
            }

        }

        static void Task8()
        {
            string str;
            string vowels = "АаОоУуЫыЭэЯяЁёЮюИиЕе";
            int count_vowels = 0;
            Console.WriteLine("Напишите предложение");
            str = Console.ReadLine();
            char[] str2 = str.ToCharArray();
            char[] str3_vowels = vowels.ToCharArray();
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str3_vowels.Length; j++)
                {
                    if (str2[i] == ' ')
                    {
                        if (str2[i - 1] == str3_vowels[j])
                        {
                            count_vowels++;
                        }
                    }
                }
            }
            Console.WriteLine($"Количество гласных букв -> {count_vowels}");
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
            Task8();
        }
    }
}
