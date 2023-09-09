using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_8_NET
{
    internal class Program
    {
        struct Fraction
        {
            private int numerator;
            private int denominator;

            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }

            public override string ToString()
            {
                return $"{numerator}/{denominator}";
            }

            public static Fraction operator +(Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                if(a.denominator == b.denominator)
                {
                    result.numerator = a.numerator + b.numerator;
                    result.denominator = a.denominator;
                }
                else
                {
                    result.denominator = a.denominator * b.denominator;
                    result.numerator = (a.numerator * b.numerator) + (b.numerator * b.denominator);
                }
                return result;
            }

            public static Fraction operator - (Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                if (a.denominator == b.denominator)
                {
                    result.numerator = a.numerator - b.numerator;
                    result.denominator = a.denominator;
                }
                else
                {
                    result.denominator = a.denominator * b.denominator;
                    result.numerator = (a.numerator * b.numerator) - (b.numerator * b.denominator);
                }
                return result;
            }

            public static Fraction operator * (Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.numerator;
                result.denominator = a.denominator * b.denominator;
                if(result.numerator % 2 == 0)
                {
                    result.numerator /= 2;
                }
                else if(result.denominator % 2 == 0)
                {
                    result.numerator /= 2;
                }
                return result;
            }

            public static Fraction operator / (Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.denominator;
                result.denominator = a.denominator * b.numerator;
                if (result.numerator % 2 == 0)
                {
                    result.numerator /= 2;
                }
                else if (result.denominator % 2 == 0)
                {
                    result.numerator /= 2;
                }
                return result;
            }
        }

        struct ComplexNumber
        {
            private int number;
            private int imaginerynumber;

            public ComplexNumber(int number, int imaginerynumber)
            {
                this.number = number;
                this.imaginerynumber = imaginerynumber;
            }

            public override string ToString()
            {
                return $"z = {number} + {imaginerynumber}i";
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber result = new ComplexNumber();
                result.number = a.number + b.number;
                result.imaginerynumber = a.imaginerynumber + b.imaginerynumber;
                return result;
            }

            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber result = new ComplexNumber();
                result.number = a.number - b.number;
                result.imaginerynumber = a.imaginerynumber - b.imaginerynumber;
                return result;
            }

            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber result = new ComplexNumber();
                int[] temp = new int[4];
                temp[0] = a.number;
                temp[1] = a.imaginerynumber;
                temp[2] = b.number;
                temp[3] = b.imaginerynumber;
                result.number = (a.number * b.number - a.imaginerynumber * b.imaginerynumber);
                result.imaginerynumber = (temp[0] * temp[3] + temp[2] * temp[1]);
                return result;
            }
            public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber result = new ComplexNumber();
                result.number = a.number / b.number;
                result.imaginerynumber = a.imaginerynumber / b.imaginerynumber;
                return result;
            }
        }

        struct Birthday
        {
            DateTime date;

            public Birthday(DateTime date)
            {
                this.date = date;
            }

            public void Init()
            {
                Console.WriteLine("Enter date your birthday");
                date = Convert.ToDateTime(Console.ReadLine());
            }

            public int Day()
            {
                DateTime now = DateTime.Now;
                DateTime birthday = new DateTime(now.Year, date.Year, date.Day);
                if(now.Month > date.Month) 
                {
                    birthday.AddYears(1);
                }
                else if(date.Month == now.Month && now.Day > date.Day)
                {
                    birthday.AddYears(1);
                }
                return (int)(birthday - now).TotalDays;
            }
        }

        static void Main(string[] args)
        {
            #region task1
            ////////////////////////////////////////TASK 1
            //Fraction obj = new Fraction(4, 6);
            //Fraction obj2 = new Fraction(8, 10);
            //Console.WriteLine(obj);
            //Console.WriteLine(obj2);
            //obj = obj + obj2;
            //Console.WriteLine(obj);
            //obj = obj - obj2;
            //Console.WriteLine(obj);
            //obj = obj * obj2;
            //Console.WriteLine(obj);
            //obj = obj / obj2;
            //Console.WriteLine(obj);
            #endregion

            #region task2
            //ComplexNumber obj = new ComplexNumber(2, 2);
            //ComplexNumber obj2 = new ComplexNumber(15, 6);
            //Console.WriteLine(obj);
            //Console.WriteLine(obj2);
            //obj = obj + obj2;
            //Console.WriteLine(obj);
            //obj = obj - obj2;
            //Console.WriteLine(obj);
            //obj = obj * obj2;
            //Console.WriteLine(obj);
            //obj = obj / obj2;
            //Console.WriteLine(obj);
            #endregion

            #region task3
            Birthday obj = new Birthday();
            obj.Init();
            Console.WriteLine(obj.Day());
            #endregion
        }
    }
}
