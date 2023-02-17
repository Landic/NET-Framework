using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_9_NET
{
    internal class Program
    {
        public struct Text
        {
            public void Print(string text)      //task1
            {
                Console.WriteLine(text);
            }
        }

        private delegate void GetText(string text);

        public struct ArithmeticOperations
        {
            private int a, b;

            public ArithmeticOperations(int a, int b)
            {
                this.a = a; 
                this.b = b;
            }

            public int Sum()
            {
                return a + b;
            }

            public int Min()
            {
                return a - b;
            }

            public int Mult()
            {
                return a * b;
            }
        }

        private delegate int Arithmetic();

        private delegate bool Arithmetic2(int a);


        static void Func(int a, Arithmetic2 ptr)
        {
            if(ptr(a) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public struct ArithmeticOperations2
        {
            public bool Even(int a)
            {
                if(a % 2 == 0)
                {
                    return true;
                }
                return false;
            }

            public bool NotEven(int a)
            {
                if (a % 2 == 1)
                {
                    return true;
                }
                return false;
            }

            public bool JustANumber(int a)
            {
                for (int i = 2; i < a; i++)
                {
                    if(a % i == 0)
                        return false;
                }
                return true;
            }

            public bool FibonacciNumber(int a)
            {
                int x, y, z, q = 0;
                y = z = x = 1;
                for (int i = 1; i < a; i++)
                {
                    z = y;
                    y = x;
                    x = z + y;
                    if(x == a)
                    {
                        q = 1;
                    }
                }
                if(q == 1)
                {
                    return true;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            #region task1
            //Text obj = new Text();
            //GetText del = new GetText(obj.Print);
            //del.Invoke("Chto-to");
            #endregion

            #region task2
            //ArithmeticOperations obj = new ArithmeticOperations(2, 5);
            //Arithmetic del = new Arithmetic(obj.Sum);
            //del += obj.Min;
            //del += obj.Mult;
            //foreach(Arithmetic i in del.GetInvocationList())
            //{
            //    Console.WriteLine(i.Invoke());
            //}
            #endregion

            #region task3
            ArithmeticOperations2 obj = new ArithmeticOperations2();
            Func(2, obj.Even);
            Func(2, obj.NotEven);
            Func(2, obj.FibonacciNumber);
            Func(2, obj.JustANumber);
            #endregion
        }
    }
}
