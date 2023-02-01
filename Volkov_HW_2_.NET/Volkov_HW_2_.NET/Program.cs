using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_2_.NET
{
    internal class Program
    {
        static void Task1() 
        {
            int number = 0;
            Console.WriteLine("Enter a number between 1 and 100");
            number = Convert.ToInt32(Console.ReadLine());
            if(number < 1 || number > 100){
                Console.WriteLine("Error!");
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz and Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void Task2()
        {
            int number = 0, procent = 0,res =0;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter procent");
            procent = Convert.ToInt32(Console.ReadLine());
            res = (number * procent) / 100;
            Console.WriteLine($"Result -> {res}");
        }

        static void Task3()
        {
            int number1 = 0, number2 = 0, number3 = 0, number4 = 0,res =0;
            Console.WriteLine("Enter 4 digit");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            number4 = Convert.ToInt32(Console.ReadLine());
            res = number4 + number3 * 10 + number2 * 100 + number1 * 1000;
            Console.WriteLine($"Result -> {res}");
        }

        static void Task4()
        {
            string number;
            int indexA = 0, indexB = 0;
            Console.WriteLine("enter a six-digit number");
            number = Console.ReadLine();
            Console.WriteLine("Enter index 1");
            indexA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter index 2");
            indexB = Convert.ToInt32(Console.ReadLine());
            char number1 = number[indexA - 1];
            number = number.Remove(indexA - 1, 1).Insert(indexA - 1, number[indexB - 1].ToString());
            number = number.Remove(indexB - 1, 1).Insert(indexB - 1, indexA.ToString());
            Console.WriteLine(number);
        }

        static void Task5()
        {
            string date;
            Console.WriteLine("Enter date");
            date = Console.ReadLine();
            DateTime date1 = DateTime.Parse(date);
            string month = "";
            if(date1.Month == 12 || date1.Month == 1 || date1.Month == 2)
            {
                month = "Winter";
            }
            else if(date1.Month == 3 || date1.Month == 4 || date1.Month == 5)
            {
                month = "Spring";
            }
            else if (date1.Month == 6 || date1.Month == 7 || date1.Month == 8)
            {
                month = "Summer";
            }
            else if (date1.Month == 9 || date1.Month == 10 || date1.Month == 11)
            {
                month = "Autumn";
            }
            Console.WriteLine(month + " " + date1.DayOfWeek);
        }

        static void Task6()
        {
            int choose = 0; 
            double temperature = 0,res = 0;
            Console.WriteLine("Choose convert to:\n1.Fahrenheit\n2.Celsius");
            choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter temperature for convert");
            temperature = Convert.ToDouble(Console.ReadLine());
            if(choose == 1)
            {
                res = temperature * 9 / 5 + 32;
            }
            else if(choose == 2)
            {
                res = (temperature - 32) * 5 / 9;
            }
            Console.WriteLine($"Result convert: {res}");
        }

        static void Task7()
        {
            int rangeA = 0, rangeB = 0;
            Console.WriteLine("Enter range A");
            rangeA= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter range B");
            rangeB= Convert.ToInt32(Console.ReadLine());
            if(rangeA > rangeB)
            {
                int temp = 0;
                temp = rangeA;
                rangeA = rangeB;
                rangeB = temp;
            }
            Console.WriteLine("Result: ");
            for (int i = 0; i <= rangeB; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
            //Task6();
            //Task7();
        }
    }
}
