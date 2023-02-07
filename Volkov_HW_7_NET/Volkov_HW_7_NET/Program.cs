using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_7_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector obj = new Vector();
            obj.Input();
            Console.WriteLine(obj.ToString());
            Console.WriteLine($"Length vector = {obj.LengthVector()}");
            obj.IncreaseByScalar(2);
            Console.WriteLine(obj.ToString());
            obj.ReductionByScalar(2);
            Console.WriteLine(obj.ToString());
            Vector obj2 = new Vector();
            obj2.Input();
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj.AddVector(obj2));
            Console.WriteLine(obj.SubtractionVector(obj2));
            Console.WriteLine(obj.MultiplicationVector(obj2));
            Console.WriteLine(obj.ScalarProduct(obj2));
            Console.WriteLine(obj.AngleDetection(obj2));
            if(obj.Equality(obj2) == true)
            {
                Console.WriteLine("The vectors are equal");
            }
            else
            {
                Console.WriteLine("The vectors are not equal");
            }
        }
    }
}
