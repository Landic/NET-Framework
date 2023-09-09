using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_7_NET
{
    internal class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        private int[] arr;

        public MyArray()
        {
            arr = new int[0];
        }

        public MyArray(int size)
        {
            arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
            }
        }

        ////////////////////////////////////// HW //////////////////////////
        public int CountDistinct()   // HW
        {
            int count = 0, count2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count2++;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count2 - count;
        }

        public int EqualToValue(int valueToCompare) // HW
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare) // HW
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Less(int valueToCompare) // HW
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public void ShowEven() // HW
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + "\t");
                }
            }
        }

        public void ShowOdd() // HW
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i] + "\t");
                }
            }
        }
         
        /////////////////////////////////////////////////////////
        
        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sum = sum / arr.Length;
            return sum;
        }


        public int Max()
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {

            return (Array.BinarySearch(arr,valueToSearch) > 0) ? true : false;
        }

        public void Show()
        {
            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            foreach (int i in arr)
                Console.WriteLine(i);
        }


        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if(isAsc == true)
            {
                Array.Sort(arr);
            }
            else
            {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
    }
}
