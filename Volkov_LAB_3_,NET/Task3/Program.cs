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
            Plane obj = new Plane();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj.YearOfIssue = 2012;
            obj.TypePlane = "Shipping";
            obj.ModelPlane = "737";
            obj.Company = "Boeing";
            Console.WriteLine(obj.ToString());
        }
    }
}
