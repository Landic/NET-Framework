using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine obj = new Magazine();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj.DescriptionOfMagazine = "kakoy to zurnal";
            obj.Email = "kakoy-to-email@gmail.com";
            obj.NameMagazine = "obama";
            obj.Phone = "+3805234325";
            obj.YearOfFoundation = 2023;
            Console.WriteLine(obj.ToString());
        }
    }
}
