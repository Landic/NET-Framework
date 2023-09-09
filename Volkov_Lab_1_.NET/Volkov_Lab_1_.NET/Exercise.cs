using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Lab_1_.NET
{
    internal class Exercise
    {
        static void Task1()
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup\n");
        }

        static void Task2()
        {
            // через массив было бы удобней :(

            int number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0, sum = 0, multiplication_sum = 0;
            int max = 0, min = 0;
            Console.WriteLine("Enter number 1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 4:");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 5:");
            number5 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2 + number3 + number4 + number5; // сумма всех чисел
            multiplication_sum = number1 * number2 * number3 * number4 * number5; // произведение чисел
            // поиск минимального числа
            if (number1 < number2 && number1 < number3 && number1 < number4 && number1 < number5)
            {
                min = number1;
            }
            else if (number2 < number1 && number2 < number3 && number2 < number4 && number2 < number5)
            {
                min = number2;
            }
            else if (number3 < number1 && number3 < number2 && number3 < number4 && number3 < number5)
            {
                min = number3;
            }
            else if (number4 < number1 && number4 < number2 && number4 < number3 && number4 < number5)
            {
                min = number4;
            }
            else if (number5 < number1 && number5 < number2 && number5 < number3 && number5 < number4)
            {
                min = number5;
            }
            // поиск максимального числа
            if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
            {
                max = number1;
            }
            else if(number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
            {
                max = number2;
            }
            else if(number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
            {
                max = number3;
            }
            else if(number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
            {
                max = number4;
            }
            else if(number5 > number1 && number5 > number2 && number5 > number3 && number5 > number4)
            {
                max = number5;
            }
            Console.WriteLine($"{number1} {number2} {number3} {number4} {number5}\nSumma = {sum}\nMultiplication = {multiplication_sum}\nMin = {min}\nMax = {max}");
        }

        static void Task3()
        {
            int number = 0, result = 0, number2 = 0;
            Console.WriteLine("Enter 6 digit number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            number2 = number % 10;
            number = number / 10;
            result += number2 * 10000;
            number2 = number % 10;
            number = number / 10;
            result += number2 * 1000;
            number2 = number % 10;
            number = number / 10;
            result += number2 * 100;
            number2 = number % 10;
            number = number / 10;
            result += number2 * 10;
            number2 = number % 10;
            number = number / 10;
            number2 = number % 10;
            number = number / 10;
            result += number2 * 10;
            number2 = number % 10;
            number = number / 10;
            result += number2;
            Console.WriteLine($"Result: {result}");
        }

        static void Task4()
        {
            int rangeA = 0, rangeB = 0, first = 0, second = 1, sum = 1;
            Console.WriteLine("Enter range A:");
            rangeA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter range B:");
            rangeB = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < rangeB; i++)
            {
                if (i >= rangeA)
                {
                    Console.Write(first + " ");
                }
                first = second;
                second = sum;
                sum = first + second;
            }
        }

        static void Task5() 
        {
            int A = 0, B = 0;
            Console.WriteLine("Enter A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            B= Convert.ToInt32(Console.ReadLine());
            for (int i = A; i < B + 1; i++)
            {
                for (int j = 0;j < i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }

        static void Task6()
        {
            int length = 0, choose = 0;
            string symbols;
            Console.WriteLine("Enter length:");
            length= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol:");
            symbols= Console.ReadLine();
            Console.WriteLine("Choose:\n1. Horizontally\n2.Vertically\n");
            choose= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                if (choose == 1) // Если выбрали горизонтально
                {
                    Console.Write(symbols);
                }
                else if (choose == 2) // Если выбрали вертикально
                {
                    Console.WriteLine(symbols);
                }
            }
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
