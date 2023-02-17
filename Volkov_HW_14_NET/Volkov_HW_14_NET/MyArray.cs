using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_14_NET
{
    internal class MyArray
    {
        private int[] arr;

        public MyArray()
        {
            arr = new int[0];
        }

        public MyArray(int size)
        {
            arr = new int[size];
            Random rand= new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,50);
            }
        }

        void Output()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public void Even()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public void NoEven()
        {
            int[] noteven = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public void JustANumber()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int h = 2; h < arr[i]; h++)
                {
                    if (arr[i] % h == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        public void Fibonachi()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int y = 1, z = 1, b = 1;
                bool q = false;
                for (int j = 0; j < arr[i]; j++)
                {
                    z = y;
                    y = b;
                    b = z + y;
                    if(b == arr[i])
                    {
                        q = true;
                    }
                }
                if (q)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
