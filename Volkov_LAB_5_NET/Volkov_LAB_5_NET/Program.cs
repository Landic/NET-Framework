using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_5_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////// TASK 1 //////////////////////////////////////

            //Employee obj = new Employee();
            //obj.Input();
            //obj.Output();
            //obj = obj + 2000;
            //obj.Output();
            //Employee obj2 = new Employee();
            //obj2.Input();
            //obj = obj + obj2;
            //obj.Output();
            //obj = obj - 2000;
            //obj.Output();
            //obj = obj - obj2;
            //obj.Output();
            //if(obj > obj2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if(obj < obj2)
            //{
            //    Console.WriteLine("True");
            //}
            //else 
            //{
            //    Console.WriteLine("False"); 
            //}
            //if(obj == obj2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if(obj != obj2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            /////////////////////////////////// TASK 2 //////////////////////////////////////

            Matrix obj = new Matrix(2, 2);
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj[0, 0] = 1;
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj[0,0]);
            //obj.Arr = new int[2, 2] { { 1, 2 }, { 1, 2 } };
            //Console.Write(obj.ToString());
            //Matrix obj2 = new Matrix();
            //obj2.Arr = new int[2, 2] { { 1, 2 }, { 1, 2 } };
            //Console.Write(obj2.ToString());
            //obj = obj2 + obj2;
            //Console.Write(obj.ToString());
            //obj = obj + 2;
            //Console.Write(obj.ToString());
            ////obj = obj - obj2;
            //Console.Write(obj.ToString());
            //obj = obj - 1;
            //Console.Write(obj.ToString());
            //obj = obj * obj2;
            //Console.Write(obj.ToString());
            //obj = obj * 2;
            //Console.Write(obj.ToString());

            /////////////////////////////////// TASK 3 //////////////////////////////////////

            //City obj = new City();
            //obj.Input();
            //obj.Output();
            //obj = obj + 2000;
            //obj.Output();
            //obj = obj - 1000;
            //obj.Output();
            //City obj2 = new City();
            //obj2.Input();
            //obj2.Output();
            //if(obj2 > obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if(obj2 < obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if(obj2 == obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if(obj2 != obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            /////////////////////////////////// TASK 4 //////////////////////////////////////

            //Credit_Card obj = new Credit_Card();
            //obj.Init();
            //Console.WriteLine(obj.ToString());
            //obj = obj + 2000;
            //Console.WriteLine(obj.ToString());
            //obj = obj - 1000;
            //Console.WriteLine(obj.ToString());
            //Credit_Card obj2 = new Credit_Card();
            //obj2.Init();
            //Console.WriteLine(obj2.ToString());
            //if (obj2 > obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (obj2 < obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (obj2 == obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (obj2 != obj)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
        }
    }
}
