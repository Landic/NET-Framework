using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_6_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web_Site obj = new Web_Site();
            obj.Input();
            Console.WriteLine(obj.ToString());
            obj.IP = "192.0.0.1";
            obj.NameSite = "Kakoy-to site";
            obj.PathToSite = "www.kakot-to-site.com";
            obj.DescriptionOfTheSite = "Prosto kakoy-to site";
            Console.WriteLine(obj.ToString());
        }
    }
}
