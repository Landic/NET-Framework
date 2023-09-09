using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_21_NET
{
    internal class Program
    {
        static void Task1()
        {
            Piece[] obj = new Piece[20];
            for (int i = 0; i < 20; i++)
            {
                obj[i] = new Piece();
            }
        }

        static void Task2()
        {
            Shop[] obj = new Shop[20];
            for (int i = 0; i < 20; i++)
                using (obj[i] = new Shop())
                {

                }
        }

        static void Task3()
        {
            Shop[] obj1 = new Shop[20];
            for (int i = 0; i < 20; i++)
                obj1[i] = new Shop();
            Piece[] obj2 = new Piece[20];
            for (int i = 0; i < 20; i++)
                using (obj2[i] = new Piece())
                {

                }
        }


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }
    }
}
