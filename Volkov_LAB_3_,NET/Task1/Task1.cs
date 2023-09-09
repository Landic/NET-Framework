using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_3__NET
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.Input();
            city.Output();
            city[0] = "Ukkk";
            city.Output();
        }
    }
}
