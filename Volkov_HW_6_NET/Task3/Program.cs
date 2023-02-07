using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop obj = new Shop();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj.Phone = "+3806352342";
            obj.NameShop = "kakoy to magazin";
            obj.Email = "shop@gmail.com";
            obj.Adress = "kakaya ta ylica 25";
            obj.DescriptionOfTheShop = "Prosto magazin";
            Console.WriteLine(obj.ToString());
        }
    }
}
