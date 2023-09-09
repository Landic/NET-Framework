using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_8_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1

            //try
            //{
            //    International_Passport obj = new International_Passport();
            //    obj.Input();
            //    Console.WriteLine(obj.ToString());
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // TASK 2

            Boolean_Expression obj = new Boolean_Expression();
            obj.Input();
            Console.WriteLine(obj.ToString());
            if(obj.Solution() == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
