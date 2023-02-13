using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_10_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book obj = new Book();
            obj.Input();
            Console.WriteLine(obj);
            List_Book obj2 = new List_Book();
            if(obj2.Find(obj, "jack") == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine(obj);
        }
    }
}
