using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix obj = new Matrix();
            obj.Input();
            Console.Write(obj.ToString());
            Console.WriteLine($"Min element -> {obj.Minimum()}");
            Console.WriteLine($"Min element -> {obj.Maximum()}");
            obj.Arr = new int[2, 2] { { 1, 2 }, { 1,2 } };
            Console.WriteLine(obj.ToString());
        }
    }
}
