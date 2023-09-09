using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose = 1;
            double sum = 0,number1 = 0,number2 = 0;
            string symbols;
            while (choose == 1) {
                number1 = 0;
                number2 = 0;
                Console.WriteLine("Enter your example: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                symbols = Console.ReadLine();
                number2 = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < symbols.Length; i++)
                {
                    switch (symbols[i])
                    {
                        case '+':
                            sum = number1 + number2;
                            break;
                        case '-':
                            sum = number1 - number2;
                            break;
                        case '*':
                            sum = number1 * number2;
                            break;
                        case '/':
                            sum = number1 / number2;
                            break;
                    }
                }
                    Console.WriteLine($"Summa = {sum}\nDo you want continue?\n1. Yes\n2. No");
                    choose = Convert.ToInt32(Console.ReadLine());
                    if(choose == 2)
                    {
                        break;
                    }
                }
            }
        }
    }
