using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_5_NET
{
    internal class Matrix
    {
        private int[,] arr;

        public Matrix()
        {
            arr = null;
        }

        public Matrix(int[,] arr)
        {
            this.arr = arr;
        }

        public void Input()
        {
            int size1 = 0;
            int size2 = 0;
            Console.WriteLine("Enter size matrix");
            size1 = Convert.ToInt32(Console.ReadLine());
            size2 = Convert.ToInt32(Console.ReadLine());
            arr = new int[size1, size2];
            Console.WriteLine("Enter element to the matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public int Maximum()
        {
            int max = arr[0, 0];
            foreach(int n in arr)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }

        public int Minimum()
        {
            int min = arr[0, 0];
            foreach (int n in arr)
            {
                if (n < min)
                    min = n;
            }
            return min;
        }

        public override string ToString()
        {
            string temp = null;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp += arr[i, j].ToString() + ' ';
                }
                temp += "\n";
            }
            return temp;
        }

        public int[,] Arr
        {
            get
            {
                return arr;
            }
            set 
            {
                arr = value; 
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] += b.arr[i, j];
                }
            }
            return a;
        }

        public static Matrix operator +(Matrix a, int b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] += b;
                }
            }
            return a;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] -= b.arr[i, j];
                }
            }
            return a;
        }

        public static Matrix operator -(Matrix a, int b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] -= b;
                }
            }
            return a;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if(a.arr.GetLength(0) != b.arr.GetLength(0) && a.arr.GetLength(1) != b.arr.GetLength(1))
            {
                throw new Exception("multiplication is not possible");
            }
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] *= b.arr[i, j];
                }
            }
            return a;
        }

        public static Matrix operator *(Matrix a, int b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] *= b;
                }
            }
            return a;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    if (a.arr[i,j] == b.arr[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    if (a.arr[i, j] != b.arr[i, j])
                    {
                        return true; 
                    }
                }
            }
            return false;
        }
    }
}
